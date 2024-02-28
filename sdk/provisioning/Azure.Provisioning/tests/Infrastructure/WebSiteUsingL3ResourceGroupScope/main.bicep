targetScope = 'resourceGroup'

@secure()
@description('SQL Server administrator password')
param sqlAdminPassword string

@secure()
@description('Application user password')
param appUserPassword string


resource appServicePlan_PxkuWnuWL 'Microsoft.Web/serverfarms@2021-02-01' = {
  name: 'appServicePlan-TEST'
  location: resourceGroup().location
  sku: {
    name: 'B1'
  }
  properties: {
    reserved: true
  }
}

resource keyVault_zomsD2kWf 'Microsoft.KeyVault/vaults@2023-02-01' = {
  name: 'kv-TEST'
  location: resourceGroup().location
  tags: {
    'key': 'value'
  }
  properties: {
    tenantId: tenant()
    sku: {
      name: 'standard'
      family: 'A'
    }
    enableRbacAuthorization: true
  }
}

resource keyVaultAddAccessPolicy_gnJ6YLPh4 'Microsoft.KeyVault/vaults/accessPolicies@2023-02-01' = {
  parent: keyVault_zomsD2kWf
  name: 'add'
  location: resourceGroup().location
  properties: {
    accessPolicies: [
      {
        tenantId: '00000000-0000-0000-0000-000000000000'
        objectId: webSite_IGuzwfciS.identity.principalId
        permissions: {
          secrets: [
            'get'
            'list'
          ]
        }
      }
    ]
  }
}

resource keyVaultSecret_CBLh3EPfm 'Microsoft.KeyVault/vaults/secrets@2023-02-01' = {
  parent: keyVault_zomsD2kWf
  name: 'sqlAdminPassword-TEST'
  location: resourceGroup().location
  properties: {
    value: sqlAdminPassword
  }
}

resource keyVaultSecret_QtRTwwecs 'Microsoft.KeyVault/vaults/secrets@2023-02-01' = {
  parent: keyVault_zomsD2kWf
  name: 'appUserPassword-TEST'
  location: resourceGroup().location
  properties: {
    value: appUserPassword
  }
}

resource keyVaultSecret_YNErVycWe 'Microsoft.KeyVault/vaults/secrets@2023-02-01' = {
  parent: keyVault_zomsD2kWf
  name: 'connectionString-TEST'
  location: resourceGroup().location
  properties: {
    value: 'Server=${sqlServer_2CRay8gJr.properties.fullyQualifiedDomainName}; Database=${sqlDatabase_P8xenywiS.name}; User=appUser; Password=${appUserPassword}'
  }
}

resource webSite_IGuzwfciS 'Microsoft.Web/sites@2021-02-01' = {
  name: 'frontEnd-TEST'
  location: resourceGroup().location
  kind: 'app,linux'
  properties: {
    serverFarmId: '/subscriptions/subscription()/resourceGroups/resourceGroup()/providers/Microsoft.Web/serverfarms/appServicePlan-TEST'
    siteConfig: {
      linuxFxVersion: 'node|18-lts'
      alwaysOn: true
      appCommandLine: './entrypoint.sh -o ./env-config.js && pm2 serve /home/site/wwwroot --no-daemon --spa'
      cors: {
        allowedOrigins: [
          'https://portal.azure.com'
          'https://ms.portal.azure.com'
        ]
      }
      minTlsVersion: '1.2'
      ftpsState: 'FtpsOnly'
    }
    httpsOnly: true
  }
}

resource applicationSettingsResource_jW0EB5uhd 'Microsoft.Web/sites/config@2021-02-01' = {
  parent: webSite_IGuzwfciS
  name: 'appsettings'
}

resource webSiteConfigLogs_GwVSHGFxS 'Microsoft.Web/sites/config@2021-02-01' = {
  parent: webSite_IGuzwfciS
  name: 'logs'
  properties: {
    applicationLogs: {
      fileSystem: {
        level: 'Verbose'
      }
    }
    httpLogs: {
      fileSystem: {
        retentionInMb: 35
        retentionInDays: 1
        enabled: true
      }
    }
    failedRequestsTracing: {
      enabled: true
    }
    detailedErrorMessages: {
      enabled: true
    }
  }
}

resource sqlServer_2CRay8gJr 'Microsoft.Sql/servers@2022-08-01-preview' = {
  name: 'sqlserver-TEST'
  location: resourceGroup().location
  properties: {
    administratorLogin: 'sqladmin'
    administratorLoginPassword: sqlAdminPassword
    version: '12.0'
    minimalTlsVersion: '1.2'
    publicNetworkAccess: 'Enabled'
  }
}

resource sqlDatabase_P8xenywiS 'Microsoft.Sql/servers/databases@2022-08-01-preview' = {
  parent: sqlServer_2CRay8gJr
  name: 'db-TEST'
  location: resourceGroup().location
  properties: {
  }
}

resource sqlFirewallRule_MTg5B9jZr 'Microsoft.Sql/servers/firewallRules@2020-11-01-preview' = {
  parent: sqlServer_2CRay8gJr
  name: 'firewallRule-TEST'
  properties: {
    startIpAddress: '0.0.0.1'
    endIpAddress: '255.255.255.254'
  }
}

resource deploymentScript_qloqQ8wU0 'Microsoft.Resources/deploymentScripts@2020-10-01' = {
  name: 'cliScript-TEST'
  location: resourceGroup().location
  kind: 'AzureCLI'
  properties: {
    cleanupPreference: 'OnSuccess'
    scriptContent: '''
wget https://github.com/microsoft/go-sqlcmd/releases/download/v0.8.1/sqlcmd-v0.8.1-linux-x64.tar.bz2
tar x -f sqlcmd-v0.8.1-linux-x64.tar.bz2 -C .
cat <<SCRIPT_END > ./initDb.sql
drop user ${APPUSERNAME}
go
create user ${APPUSERNAME} with password = '${APPUSERPASSWORD}'
go
alter role db_owner add member ${APPUSERNAME}
go
SCRIPT_END
./sqlcmd -S ${DBSERVER} -d ${DBNAME} -U ${SQLADMIN} -i ./initDb.sql'''
    environmentVariables: [
      {
        name: 'APPUSERPASSWORD'
        secureValue: appUserPassword
      }
      {
        name: 'SQLCMDPASSWORD'
        secureValue: sqlAdminPassword
      }
      {
        name: 'DBSERVER'
        value: sqlServer_2CRay8gJr.properties.fullyQualifiedDomainName
      }
      {
        name: 'DBNAME'
        value: 'db-TEST'
      }
      {
        name: 'APPUSERNAME'
        value: 'appUser'
      }
      {
        name: 'SQLADMIN'
        value: 'sqlAdmin'
      }
    ]
    retentionInterval: 'PT1H'
    timeout: 'PT5M'
    azCliVersion: '2.37.0'
  }
}

resource webSite_TR8bo87ZZ 'Microsoft.Web/sites@2021-02-01' = {
  name: 'backEnd-TEST'
  location: resourceGroup().location
  kind: 'app,linux'
  properties: {
    serverFarmId: '/subscriptions/subscription()/resourceGroups/resourceGroup()/providers/Microsoft.Web/serverfarms/appServicePlan-TEST'
    siteConfig: {
      linuxFxVersion: 'dotnetcore|6.0'
      alwaysOn: true
      appCommandLine: ''
      cors: {
        allowedOrigins: [
          'https://portal.azure.com'
          'https://ms.portal.azure.com'
        ]
      }
      minTlsVersion: '1.2'
      ftpsState: 'FtpsOnly'
    }
    httpsOnly: true
  }
}

resource applicationSettingsResource_FmsJom6FN 'Microsoft.Web/sites/config@2021-02-01' = {
  parent: webSite_TR8bo87ZZ
  name: 'appsettings'
  properties: {
    'SCM_DO_BUILD_DURING_DEPLOYMENT': 'False'
    'ENABLE_ORYX_BUILD': 'True'
  }
}

output vaultUri string = keyVault_zomsD2kWf.properties.vaultUri
output SERVICE_API_IDENTITY_PRINCIPAL_ID string = webSite_IGuzwfciS.identity.principalId
output sqlServerName string = sqlServer_2CRay8gJr.properties.fullyQualifiedDomainName
