// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> The state of the last provisioning operation performed on the search service. Provisioning is an intermediate state that occurs while service capacity is being established. After capacity is set up, provisioningState changes to either &apos;succeeded&apos; or &apos;failed&apos;. Client applications can poll provisioning status (the recommended polling interval is from 30 seconds to one minute) by using the Get Search Service operation to see when an operation is completed. If you are using the free service, this value tends to come back as &apos;succeeded&apos; directly in the call to Create search service. This is because the free service uses capacity that is already set up. </summary>
    public enum ProvisioningState
    {
        /// <summary> succeeded. </summary>
        Succeeded,
        /// <summary> provisioning. </summary>
        Provisioning,
        /// <summary> failed. </summary>
        Failed
    }
}
