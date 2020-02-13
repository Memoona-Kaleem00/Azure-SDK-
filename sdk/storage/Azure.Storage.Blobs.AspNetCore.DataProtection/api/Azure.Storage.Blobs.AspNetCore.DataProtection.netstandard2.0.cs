namespace Azure.Storage.Blobs.AspNetCore.DataProtection
{
    public sealed partial class AzureBlobXmlRepository : Microsoft.AspNetCore.DataProtection.Repositories.IXmlRepository
    {
        public AzureBlobXmlRepository(Azure.Storage.Blobs.BlobClient blobClient) { }
        public System.Collections.Generic.IReadOnlyCollection<System.Xml.Linq.XElement> GetAllElements() { throw null; }
        public void StoreElement(System.Xml.Linq.XElement element, string friendlyName) { }
    }
}
namespace Microsoft.AspNetCore.DataProtection
{
    public static partial class AzureStorageBlobDataProtectionBuilderExtensions
    {
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder PersistKeysToAzureBlobStorage(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, Azure.Storage.Blobs.BlobClient blobClient) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder PersistKeysToAzureBlobStorage(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, System.Uri blobUri) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder PersistKeysToAzureBlobStorage(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, System.Uri blobUri, Azure.Core.TokenCredential tokenCredential) { throw null; }
    }
}
