// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with APIError information.
    /// </summary>
    public partial class APIErrorException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public APIError Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the APIErrorException class.
        /// </summary>
        public APIErrorException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the APIErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public APIErrorException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the APIErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public APIErrorException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
