// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The results of a image tag operation, including any tags and image
    /// metadata.
    /// </summary>
    public partial class TagResult
    {
        /// <summary>
        /// Initializes a new instance of the TagResult class.
        /// </summary>
        public TagResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagResult class.
        /// </summary>
        /// <param name="tags">A list of tags with confidence level.</param>
        /// <param name="requestId">Id of the REST API request.</param>
        public TagResult(IList<ImageTag> tags = default(IList<ImageTag>), string requestId = default(string), ImageMetadata metadata = default(ImageMetadata))
        {
            Tags = tags;
            RequestId = requestId;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of tags with confidence level.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<ImageTag> Tags { get; set; }

        /// <summary>
        /// Gets or sets id of the REST API request.
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public ImageMetadata Metadata { get; set; }

    }
}
