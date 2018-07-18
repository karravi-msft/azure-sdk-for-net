// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the update schedule operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ScheduleUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleUpdateParameters class.
        /// </summary>
        public ScheduleUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleUpdateParameters class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the Schedule.</param>
        /// <param name="description">Gets or sets the description of the
        /// schedule.</param>
        /// <param name="isEnabled">Gets or sets a value indicating whether
        /// this schedule is enabled.</param>
        public ScheduleUpdateParameters(string name = default(string), string description = default(string), bool? isEnabled = default(bool?))
        {
            Name = name;
            Description = description;
            IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Schedule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this schedule is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEnabled")]
        public bool? IsEnabled { get; set; }

    }
}
