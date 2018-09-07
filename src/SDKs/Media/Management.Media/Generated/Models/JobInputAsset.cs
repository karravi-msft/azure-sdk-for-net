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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an Asset for input into a Job.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.JobInputAsset")]
    public partial class JobInputAsset : JobInputClip
    {
        /// <summary>
        /// Initializes a new instance of the JobInputAsset class.
        /// </summary>
        public JobInputAsset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobInputAsset class.
        /// </summary>
        /// <param name="assetName">The name of the input Asset.</param>
        /// <param name="label">A label that is assigned to a JobInput, that is
        /// used to satisfy a reference used in the Transform. For example, a
        /// Transform can be authored so as to take an image file with the
        /// label 'xyz' and apply it as an overlay onto the input video before
        /// it is encoded. When submitting a Job, exactly one of the JobInputs
        /// should be the image file, and it should have the label
        /// 'xyz'.</param>
        /// <param name="files">List of files. Required for
        /// JobInputHttp.</param>
        public JobInputAsset(string assetName, string label = default(string), IList<string> files = default(IList<string>))
            : base(label, files)
        {
            AssetName = assetName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the input Asset.
        /// </summary>
        [JsonProperty(PropertyName = "assetName")]
        public string AssetName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AssetName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssetName");
            }
        }
    }
}
