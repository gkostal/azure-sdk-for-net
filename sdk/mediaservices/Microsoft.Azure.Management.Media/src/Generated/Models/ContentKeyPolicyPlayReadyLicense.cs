// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The PlayReady license
    /// </summary>
    public partial class ContentKeyPolicyPlayReadyLicense
    {
        /// <summary>
        /// Initializes a new instance of the ContentKeyPolicyPlayReadyLicense
        /// class.
        /// </summary>
        public ContentKeyPolicyPlayReadyLicense()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContentKeyPolicyPlayReadyLicense
        /// class.
        /// </summary>
        /// <param name="allowTestDevices">A flag indicating whether test
        /// devices can use the license.</param>
        /// <param name="licenseType">The license type. Possible values
        /// include: 'Unknown', 'NonPersistent', 'Persistent'</param>
        /// <param name="contentKeyLocation">The content key location.</param>
        /// <param name="contentType">The PlayReady content type. Possible
        /// values include: 'Unknown', 'Unspecified', 'UltraVioletDownload',
        /// 'UltraVioletStreaming'</param>
        /// <param name="beginDate">The begin date of license</param>
        /// <param name="expirationDate">The expiration date of
        /// license.</param>
        /// <param name="relativeBeginDate">The relative begin date of
        /// license.</param>
        /// <param name="relativeExpirationDate">The relative expiration date
        /// of license.</param>
        /// <param name="gracePeriod">The grace period of license.</param>
        /// <param name="playRight">The license PlayRight</param>
        public ContentKeyPolicyPlayReadyLicense(bool allowTestDevices, ContentKeyPolicyPlayReadyLicenseType licenseType, ContentKeyPolicyPlayReadyContentKeyLocation contentKeyLocation, ContentKeyPolicyPlayReadyContentType contentType, System.DateTime? beginDate = default(System.DateTime?), System.DateTime? expirationDate = default(System.DateTime?), System.TimeSpan? relativeBeginDate = default(System.TimeSpan?), System.TimeSpan? relativeExpirationDate = default(System.TimeSpan?), System.TimeSpan? gracePeriod = default(System.TimeSpan?), ContentKeyPolicyPlayReadyPlayRight playRight = default(ContentKeyPolicyPlayReadyPlayRight))
        {
            AllowTestDevices = allowTestDevices;
            BeginDate = beginDate;
            ExpirationDate = expirationDate;
            RelativeBeginDate = relativeBeginDate;
            RelativeExpirationDate = relativeExpirationDate;
            GracePeriod = gracePeriod;
            PlayRight = playRight;
            LicenseType = licenseType;
            ContentKeyLocation = contentKeyLocation;
            ContentType = contentType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a flag indicating whether test devices can use the
        /// license.
        /// </summary>
        [JsonProperty(PropertyName = "allowTestDevices")]
        public bool AllowTestDevices { get; set; }

        /// <summary>
        /// Gets or sets the begin date of license
        /// </summary>
        [JsonProperty(PropertyName = "beginDate")]
        public System.DateTime? BeginDate { get; set; }

        /// <summary>
        /// Gets or sets the expiration date of license.
        /// </summary>
        [JsonProperty(PropertyName = "expirationDate")]
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the relative begin date of license.
        /// </summary>
        [JsonProperty(PropertyName = "relativeBeginDate")]
        public System.TimeSpan? RelativeBeginDate { get; set; }

        /// <summary>
        /// Gets or sets the relative expiration date of license.
        /// </summary>
        [JsonProperty(PropertyName = "relativeExpirationDate")]
        public System.TimeSpan? RelativeExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the grace period of license.
        /// </summary>
        [JsonProperty(PropertyName = "gracePeriod")]
        public System.TimeSpan? GracePeriod { get; set; }

        /// <summary>
        /// Gets or sets the license PlayRight
        /// </summary>
        [JsonProperty(PropertyName = "playRight")]
        public ContentKeyPolicyPlayReadyPlayRight PlayRight { get; set; }

        /// <summary>
        /// Gets or sets the license type. Possible values include: 'Unknown',
        /// 'NonPersistent', 'Persistent'
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public ContentKeyPolicyPlayReadyLicenseType LicenseType { get; set; }

        /// <summary>
        /// Gets or sets the content key location.
        /// </summary>
        [JsonProperty(PropertyName = "contentKeyLocation")]
        public ContentKeyPolicyPlayReadyContentKeyLocation ContentKeyLocation { get; set; }

        /// <summary>
        /// Gets or sets the PlayReady content type. Possible values include:
        /// 'Unknown', 'Unspecified', 'UltraVioletDownload',
        /// 'UltraVioletStreaming'
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public ContentKeyPolicyPlayReadyContentType ContentType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContentKeyLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContentKeyLocation");
            }
            if (PlayRight != null)
            {
                PlayRight.Validate();
            }
        }
    }
}
