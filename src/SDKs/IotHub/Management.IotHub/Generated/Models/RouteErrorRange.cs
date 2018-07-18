// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Range of route errors
    /// </summary>
    public partial class RouteErrorRange
    {
        /// <summary>
        /// Initializes a new instance of the RouteErrorRange class.
        /// </summary>
        public RouteErrorRange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteErrorRange class.
        /// </summary>
        /// <param name="start">Start where the route error happened</param>
        /// <param name="end">End where the route error happened</param>
        public RouteErrorRange(RouteErrorPosition start = default(RouteErrorPosition), RouteErrorPosition end = default(RouteErrorPosition))
        {
            Start = start;
            End = end;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start where the route error happened
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public RouteErrorPosition Start { get; set; }

        /// <summary>
        /// Gets or sets end where the route error happened
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public RouteErrorPosition End { get; set; }

    }
}
