// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Network.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Objects which have a provisioning state.
    /// </summary>
    public partial class ProvisionedResource
    {
        /// <summary>
        /// Initializes a new instance of the ProvisionedResource class.
        /// </summary>
        public ProvisionedResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProvisionedResource class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state.</param>
        public ProvisionedResource(string provisioningState = default(string))
        {
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
