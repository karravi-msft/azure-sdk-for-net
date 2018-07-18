// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure ML Update Resource management activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureMLUpdateResource")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureMLUpdateResourceActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the AzureMLUpdateResourceActivity
        /// class.
        /// </summary>
        public AzureMLUpdateResourceActivity()
        {
            TrainedModelLinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMLUpdateResourceActivity
        /// class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="trainedModelName">Name of the Trained Model module in
        /// the Web Service experiment to be updated. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="trainedModelLinkedServiceName">Name of Azure Storage
        /// linked service holding the .ilearner file that will be uploaded by
        /// the update operation.</param>
        /// <param name="trainedModelFilePath">The relative file path in
        /// trainedModelLinkedService to represent the .ilearner file that will
        /// be uploaded by the update operation.  Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        public AzureMLUpdateResourceActivity(string name, object trainedModelName, LinkedServiceReference trainedModelLinkedServiceName, object trainedModelFilePath, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IDictionary<string, string> userProperties = default(IDictionary<string, string>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy))
            : base(name, additionalProperties, description, dependsOn, userProperties, linkedServiceName, policy)
        {
            TrainedModelName = trainedModelName;
            TrainedModelLinkedServiceName = trainedModelLinkedServiceName;
            TrainedModelFilePath = trainedModelFilePath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Trained Model module in the Web Service
        /// experiment to be updated. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.trainedModelName")]
        public object TrainedModelName { get; set; }

        /// <summary>
        /// Gets or sets name of Azure Storage linked service holding the
        /// .ilearner file that will be uploaded by the update operation.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.trainedModelLinkedServiceName")]
        public LinkedServiceReference TrainedModelLinkedServiceName { get; set; }

        /// <summary>
        /// Gets or sets the relative file path in trainedModelLinkedService to
        /// represent the .ilearner file that will be uploaded by the update
        /// operation.  Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.trainedModelFilePath")]
        public object TrainedModelFilePath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (TrainedModelName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TrainedModelName");
            }
            if (TrainedModelLinkedServiceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TrainedModelLinkedServiceName");
            }
            if (TrainedModelFilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TrainedModelFilePath");
            }
            if (TrainedModelLinkedServiceName != null)
            {
                TrainedModelLinkedServiceName.Validate();
            }
        }
    }
}
