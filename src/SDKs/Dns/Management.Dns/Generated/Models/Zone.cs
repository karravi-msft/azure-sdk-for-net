// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Dns.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Dns;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a DNS zone.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Zone : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Zone class.
        /// </summary>
        public Zone()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Zone class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="etag">The etag of the zone.</param>
        /// <param name="maxNumberOfRecordSets">The maximum number of record
        /// sets that can be created in this DNS zone.  This is a read-only
        /// property and any attempt to set this value will be ignored.</param>
        /// <param name="numberOfRecordSets">The current number of record sets
        /// in this DNS zone.  This is a read-only property and any attempt to
        /// set this value will be ignored.</param>
        /// <param name="nameServers">The name servers for this DNS zone. This
        /// is a read-only property and any attempt to set this value will be
        /// ignored.</param>
        /// <param name="zoneType">The type of this DNS zone (Public or
        /// Private). Possible values include: 'Public', 'Private'</param>
        /// <param name="registrationVirtualNetworks">A list of references to
        /// virtual networks that register hostnames in this DNS zone. This is
        /// a only when ZoneType is Private.</param>
        /// <param name="resolutionVirtualNetworks">A list of references to
        /// virtual networks that resolve records in this DNS zone. This is a
        /// only when ZoneType is Private.</param>
        public Zone(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), long? maxNumberOfRecordSets = default(long?), long? numberOfRecordSets = default(long?), IList<string> nameServers = default(IList<string>), ZoneType? zoneType = default(ZoneType?), IList<SubResource> registrationVirtualNetworks = default(IList<SubResource>), IList<SubResource> resolutionVirtualNetworks = default(IList<SubResource>))
            : base(location, id, name, type, tags)
        {
            Etag = etag;
            MaxNumberOfRecordSets = maxNumberOfRecordSets;
            NumberOfRecordSets = numberOfRecordSets;
            NameServers = nameServers;
            ZoneType = zoneType;
            RegistrationVirtualNetworks = registrationVirtualNetworks;
            ResolutionVirtualNetworks = resolutionVirtualNetworks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the etag of the zone.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets the maximum number of record sets that can be created in this
        /// DNS zone.  This is a read-only property and any attempt to set this
        /// value will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxNumberOfRecordSets")]
        public long? MaxNumberOfRecordSets { get; private set; }

        /// <summary>
        /// Gets the current number of record sets in this DNS zone.  This is a
        /// read-only property and any attempt to set this value will be
        /// ignored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfRecordSets")]
        public long? NumberOfRecordSets { get; private set; }

        /// <summary>
        /// Gets the name servers for this DNS zone. This is a read-only
        /// property and any attempt to set this value will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nameServers")]
        public IList<string> NameServers { get; private set; }

        /// <summary>
        /// Gets or sets the type of this DNS zone (Public or Private).
        /// Possible values include: 'Public', 'Private'
        /// </summary>
        [JsonProperty(PropertyName = "properties.zoneType")]
        public ZoneType? ZoneType { get; set; }

        /// <summary>
        /// Gets or sets a list of references to virtual networks that register
        /// hostnames in this DNS zone. This is a only when ZoneType is
        /// Private.
        /// </summary>
        [JsonProperty(PropertyName = "properties.registrationVirtualNetworks")]
        public IList<SubResource> RegistrationVirtualNetworks { get; set; }

        /// <summary>
        /// Gets or sets a list of references to virtual networks that resolve
        /// records in this DNS zone. This is a only when ZoneType is Private.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resolutionVirtualNetworks")]
        public IList<SubResource> ResolutionVirtualNetworks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
