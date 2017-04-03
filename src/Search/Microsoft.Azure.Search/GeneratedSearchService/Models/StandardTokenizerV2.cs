// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Breaks text following the Unicode Text Segmentation rules. This
    /// tokenizer is implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/standard/StandardTokenizer.html" />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.StandardTokenizerV2")]
    public partial class StandardTokenizerV2 : Tokenizer
    {
        /// <summary>
        /// Initializes a new instance of the StandardTokenizerV2 class.
        /// </summary>
        public StandardTokenizerV2() { }

        /// <summary>
        /// Initializes a new instance of the StandardTokenizerV2 class.
        /// </summary>
        /// <param name="name">The name of the tokenizer. It must only contain
        /// letters, digits, spaces, dashes or underscores, can only start and
        /// end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="maxTokenLength">The maximum token length. Default is
        /// 255. Tokens longer than the maximum length are split. The maximum
        /// token length that can be used is 300 characters.</param>
        public StandardTokenizerV2(string name, int? maxTokenLength = default(int?))
            : base(name)
        {
            MaxTokenLength = maxTokenLength;
        }

        /// <summary>
        /// Gets or sets the maximum token length. Default is 255. Tokens
        /// longer than the maximum length are split. The maximum token length
        /// that can be used is 300 characters.
        /// </summary>
        [JsonProperty(PropertyName = "maxTokenLength")]
        public int? MaxTokenLength { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (MaxTokenLength > 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxTokenLength", 300);
            }
        }
    }
}

