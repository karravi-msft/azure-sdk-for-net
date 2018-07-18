// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Container extended information
    /// </summary>
    public partial class GenericContainerExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the GenericContainerExtendedInfo
        /// class.
        /// </summary>
        public GenericContainerExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenericContainerExtendedInfo
        /// class.
        /// </summary>
        /// <param name="rawCertData">Public key of container cert</param>
        /// <param name="containerIdentityInfo">Container identity
        /// information</param>
        /// <param name="serviceEndpoints">Azure Backup Service Endpoints for
        /// the container</param>
        public GenericContainerExtendedInfo(string rawCertData = default(string), ContainerIdentityInfo containerIdentityInfo = default(ContainerIdentityInfo), IDictionary<string, string> serviceEndpoints = default(IDictionary<string, string>))
        {
            RawCertData = rawCertData;
            ContainerIdentityInfo = containerIdentityInfo;
            ServiceEndpoints = serviceEndpoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets public key of container cert
        /// </summary>
        [JsonProperty(PropertyName = "rawCertData")]
        public string RawCertData { get; set; }

        /// <summary>
        /// Gets or sets container identity information
        /// </summary>
        [JsonProperty(PropertyName = "containerIdentityInfo")]
        public ContainerIdentityInfo ContainerIdentityInfo { get; set; }

        /// <summary>
        /// Gets or sets azure Backup Service Endpoints for the container
        /// </summary>
        [JsonProperty(PropertyName = "serviceEndpoints")]
        public IDictionary<string, string> ServiceEndpoints { get; set; }

    }
}
