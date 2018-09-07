// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the properties of a Compute Operation value.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ComputeOperationValue
    {
        /// <summary>
        /// Initializes a new instance of the ComputeOperationValue class.
        /// </summary>
        public ComputeOperationValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComputeOperationValue class.
        /// </summary>
        /// <param name="origin">The origin of the compute operation.</param>
        /// <param name="name">The name of the compute operation.</param>
        /// <param name="operation">The display name of the compute
        /// operation.</param>
        /// <param name="resource">The display name of the resource the
        /// operation applies to.</param>
        /// <param name="description">The description of the operation.</param>
        /// <param name="provider">The resource provider for the
        /// operation.</param>
        public ComputeOperationValue(string origin = default(string), string name = default(string), string operation = default(string), string resource = default(string), string description = default(string), string provider = default(string))
        {
            Origin = origin;
            Name = name;
            Operation = operation;
            Resource = resource;
            Description = description;
            Provider = provider;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the origin of the compute operation.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; private set; }

        /// <summary>
        /// Gets the name of the compute operation.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the display name of the compute operation.
        /// </summary>
        [JsonProperty(PropertyName = "display.operation")]
        public string Operation { get; private set; }

        /// <summary>
        /// Gets the display name of the resource the operation applies to.
        /// </summary>
        [JsonProperty(PropertyName = "display.resource")]
        public string Resource { get; private set; }

        /// <summary>
        /// Gets the description of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "display.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the resource provider for the operation.
        /// </summary>
        [JsonProperty(PropertyName = "display.provider")]
        public string Provider { get; private set; }

    }
}
