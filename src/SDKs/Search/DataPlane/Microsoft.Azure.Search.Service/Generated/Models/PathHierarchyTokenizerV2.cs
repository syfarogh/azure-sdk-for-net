// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Tokenizer for path-like hierarchies. This tokenizer is implemented
    /// using Apache Lucene.
    /// <see
    /// href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/path/PathHierarchyTokenizer.html"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.PathHierarchyTokenizerV2")]
    public partial class PathHierarchyTokenizerV2 : Tokenizer
    {
        /// <summary>
        /// Initializes a new instance of the PathHierarchyTokenizerV2 class.
        /// </summary>
        public PathHierarchyTokenizerV2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PathHierarchyTokenizerV2 class.
        /// </summary>
        /// <param name="name">The name of the tokenizer. It must only contain
        /// letters, digits, spaces, dashes or underscores, can only start and
        /// end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="delimiter">The delimiter character to use. Default is
        /// "/".</param>
        /// <param name="replacement">A value that, if set, replaces the
        /// delimiter character. Default is "/".</param>
        /// <param name="maxTokenLength">The maximum token length. Default and
        /// maximum is 300.</param>
        /// <param name="reverseTokenOrder">A value indicating whether to
        /// generate tokens in reverse order. Default is false.</param>
        /// <param name="numberOfTokensToSkip">The number of initial tokens to
        /// skip. Default is 0.</param>
        public PathHierarchyTokenizerV2(string name, char? delimiter = default(char?), char? replacement = default(char?), int? maxTokenLength = default(int?), bool? reverseTokenOrder = default(bool?), int? numberOfTokensToSkip = default(int?))
            : base(name)
        {
            Delimiter = delimiter;
            Replacement = replacement;
            MaxTokenLength = maxTokenLength;
            ReverseTokenOrder = reverseTokenOrder;
            NumberOfTokensToSkip = numberOfTokensToSkip;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the delimiter character to use. Default is "/".
        /// </summary>
        [JsonProperty(PropertyName = "delimiter")]
        public char? Delimiter { get; set; }

        /// <summary>
        /// Gets or sets a value that, if set, replaces the delimiter
        /// character. Default is "/".
        /// </summary>
        [JsonProperty(PropertyName = "replacement")]
        public char? Replacement { get; set; }

        /// <summary>
        /// Gets or sets the maximum token length. Default and maximum is 300.
        /// </summary>
        [JsonProperty(PropertyName = "maxTokenLength")]
        public int? MaxTokenLength { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to generate tokens in
        /// reverse order. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "reverse")]
        public bool? ReverseTokenOrder { get; set; }

        /// <summary>
        /// Gets or sets the number of initial tokens to skip. Default is 0.
        /// </summary>
        [JsonProperty(PropertyName = "skip")]
        public int? NumberOfTokensToSkip { get; set; }

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
