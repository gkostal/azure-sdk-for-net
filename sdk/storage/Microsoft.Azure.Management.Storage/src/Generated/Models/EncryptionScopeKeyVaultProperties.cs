// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The key vault properties for the encryption scope. This is a required
    /// field if encryption scope 'source' attribute is set to
    /// 'Microsoft.KeyVault'.
    /// </summary>
    public partial class EncryptionScopeKeyVaultProperties
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionScopeKeyVaultProperties
        /// class.
        /// </summary>
        public EncryptionScopeKeyVaultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionScopeKeyVaultProperties
        /// class.
        /// </summary>
        /// <param name="keyUri">The object identifier for a key vault key
        /// object. When applied, the encryption scope will use the key
        /// referenced by the identifier to enable customer-managed key support
        /// on this encryption scope.</param>
        public EncryptionScopeKeyVaultProperties(string keyUri = default(string))
        {
            KeyUri = keyUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the object identifier for a key vault key object. When
        /// applied, the encryption scope will use the key referenced by the
        /// identifier to enable customer-managed key support on this
        /// encryption scope.
        /// </summary>
        [JsonProperty(PropertyName = "keyUri")]
        public string KeyUri { get; set; }

    }
}
