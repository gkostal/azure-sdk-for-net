namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes a data disk.
    /// </summary>
    public partial class DataDisk
    {
        /// <summary>
        /// Gets or sets the logical unit number.
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int? Lun { get; set; }

        /// <summary>
        /// Gets or sets the disk size in GB for a blank data disk to be
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Virtual Hard Disk.
        /// </summary>
        [JsonProperty(PropertyName = "vhd")]
        public VirtualHardDisk Vhd { get; set; }

        /// <summary>
        /// Gets or sets the Source User Image VirtualHardDisk. This
        /// VirtualHardDisk will be copied before using it to attach to the
        /// Virtual Machine.If SourceImage is provided, the destination
        /// VirtualHardDisk should not exist.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public VirtualHardDisk Image { get; set; }

        /// <summary>
        /// Gets or sets the caching type. Possible values for this property
        /// include: 'None', 'ReadOnly', 'ReadWrite'
        /// </summary>
        [JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets the create option. Possible values for this property
        /// include: 'fromImage', 'empty', 'attach'
        /// </summary>
        [JsonProperty(PropertyName = "createOption")]
        public DiskCreateOptionTypes? CreateOption { get; set; }

    }
}
