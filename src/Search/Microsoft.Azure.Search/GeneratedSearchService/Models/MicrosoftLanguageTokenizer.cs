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
    /// Divides text using language-specific rules.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.MicrosoftLanguageTokenizer")]
    public partial class MicrosoftLanguageTokenizer : Tokenizer
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftLanguageTokenizer class.
        /// </summary>
        public MicrosoftLanguageTokenizer() { }

        /// <summary>
        /// Initializes a new instance of the MicrosoftLanguageTokenizer class.
        /// </summary>
        /// <param name="name">The name of the tokenizer. It must only contain
        /// letters, digits, spaces, dashes or underscores, can only start and
        /// end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="maxTokenLength">The maximum token length. Tokens
        /// longer than the maximum length are split. Maximum token length that
        /// can be used is 300 characters. Tokens longer than 300 characters
        /// are first split into tokens of length 300 and then each of those
        /// tokens is split based on the max token length set. Default is
        /// 255.</param>
        /// <param name="isSearchTokenizer">A value indicating how the
        /// tokenizer is used. Set to true if used as the search tokenizer, set
        /// to false if used as the indexing tokenizer. Default is
        /// false.</param>
        /// <param name="language">The language to use. The default is English.
        /// Possible values include: 'bangla', 'bulgarian', 'catalan',
        /// 'chineseSimplified', 'chineseTraditional', 'croatian', 'czech',
        /// 'danish', 'dutch', 'english', 'french', 'german', 'greek',
        /// 'gujarati', 'hindi', 'icelandic', 'indonesian', 'italian',
        /// 'japanese', 'kannada', 'korean', 'malay', 'malayalam', 'marathi',
        /// 'norwegianBokmaal', 'polish', 'portuguese', 'portugueseBrazilian',
        /// 'punjabi', 'romanian', 'russian', 'serbianCyrillic',
        /// 'serbianLatin', 'slovenian', 'spanish', 'swedish', 'tamil',
        /// 'telugu', 'thai', 'ukrainian', 'urdu', 'vietnamese'</param>
        public MicrosoftLanguageTokenizer(string name, int? maxTokenLength = default(int?), bool? isSearchTokenizer = default(bool?), MicrosoftTokenizerLanguage? language = default(MicrosoftTokenizerLanguage?))
            : base(name)
        {
            MaxTokenLength = maxTokenLength;
            IsSearchTokenizer = isSearchTokenizer;
            Language = language;
        }

        /// <summary>
        /// Gets or sets the maximum token length. Tokens longer than the
        /// maximum length are split. Maximum token length that can be used is
        /// 300 characters. Tokens longer than 300 characters are first split
        /// into tokens of length 300 and then each of those tokens is split
        /// based on the max token length set. Default is 255.
        /// </summary>
        [JsonProperty(PropertyName = "maxTokenLength")]
        public int? MaxTokenLength { get; set; }

        /// <summary>
        /// Gets or sets a value indicating how the tokenizer is used. Set to
        /// true if used as the search tokenizer, set to false if used as the
        /// indexing tokenizer. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "isSearchTokenizer")]
        public bool? IsSearchTokenizer { get; set; }

        /// <summary>
        /// Gets or sets the language to use. The default is English. Possible
        /// values include: 'bangla', 'bulgarian', 'catalan',
        /// 'chineseSimplified', 'chineseTraditional', 'croatian', 'czech',
        /// 'danish', 'dutch', 'english', 'french', 'german', 'greek',
        /// 'gujarati', 'hindi', 'icelandic', 'indonesian', 'italian',
        /// 'japanese', 'kannada', 'korean', 'malay', 'malayalam', 'marathi',
        /// 'norwegianBokmaal', 'polish', 'portuguese', 'portugueseBrazilian',
        /// 'punjabi', 'romanian', 'russian', 'serbianCyrillic',
        /// 'serbianLatin', 'slovenian', 'spanish', 'swedish', 'tamil',
        /// 'telugu', 'thai', 'ukrainian', 'urdu', 'vietnamese'
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public MicrosoftTokenizerLanguage? Language { get; set; }

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

