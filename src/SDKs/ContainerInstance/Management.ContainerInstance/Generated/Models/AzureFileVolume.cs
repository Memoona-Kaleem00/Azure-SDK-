// Code generated by Microsoft (R) AutoRest Code Generator 1.2.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ContainerInstance;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Azure file volume.
    /// </summary>
    public partial class AzureFileVolume
    {
        /// <summary>
        /// Initializes a new instance of the AzureFileVolume class.
        /// </summary>
        public AzureFileVolume()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFileVolume class.
        /// </summary>
        /// <param name="shareName">The Azure file share name.</param>
        /// <param name="storageAccountName">The storage account name to access
        /// to the Azure file.</param>
        /// <param name="readOnlyProperty">The flag indicating whether the
        /// Azure file volume is read only.</param>
        /// <param name="storageAccountKey">The storage account key to access
        /// to the Azure file.</param>
        public AzureFileVolume(string shareName, string storageAccountName, bool? readOnlyProperty = default(bool?), string storageAccountKey = default(string))
        {
            ShareName = shareName;
            ReadOnlyProperty = readOnlyProperty;
            StorageAccountName = storageAccountName;
            StorageAccountKey = storageAccountKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure file share name.
        /// </summary>
        [JsonProperty(PropertyName = "shareName")]
        public string ShareName { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether the Azure file volume is
        /// read only.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets the storage account name to access to the Azure file.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountName")]
        public string StorageAccountName { get; set; }

        /// <summary>
        /// Gets or sets the storage account key to access to the Azure file.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountKey")]
        public string StorageAccountKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShareName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ShareName");
            }
            if (StorageAccountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountName");
            }
        }
    }
}
