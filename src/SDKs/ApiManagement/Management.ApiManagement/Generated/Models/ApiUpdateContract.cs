// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// API update contract details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApiUpdateContract
    {
        /// <summary>
        /// Initializes a new instance of the ApiUpdateContract class.
        /// </summary>
        public ApiUpdateContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiUpdateContract class.
        /// </summary>
        /// <param name="description">Description of the API. May include HTML
        /// formatting tags.</param>
        /// <param name="authenticationSettings">Collection of authentication
        /// settings included into this API.</param>
        /// <param name="subscriptionKeyParameterNames">Protocols over which
        /// API is made available.</param>
        /// <param name="apiType">Type of API. Possible values include: 'http',
        /// 'soap'</param>
        /// <param name="apiRevision">Describes the Revision of the Api. If no
        /// value is provided, default revision 1 is created</param>
        /// <param name="apiVersion">Indicates the Version identifier of the
        /// API if the API is versioned</param>
        /// <param name="isCurrent">Indicates if API revision is current api
        /// revision.</param>
        /// <param name="isOnline">Indicates if API revision is accessible via
        /// the gateway.</param>
        /// <param name="apiRevisionDescription">Description of the Api
        /// Revision.</param>
        /// <param name="apiVersionDescription">Description of the Api
        /// Version.</param>
        /// <param name="apiVersionSetId">A resource identifier for the related
        /// ApiVersionSet.</param>
        /// <param name="displayName">API name.</param>
        /// <param name="serviceUrl">Absolute URL of the backend service
        /// implementing this API.</param>
        /// <param name="path">Relative URL uniquely identifying this API and
        /// all of its resource paths within the API Management service
        /// instance. It is appended to the API endpoint base URL specified
        /// during the service instance creation to form a public URL for this
        /// API.</param>
        /// <param name="protocols">Describes on which protocols the operations
        /// in this API can be invoked.</param>
        public ApiUpdateContract(string description = default(string), AuthenticationSettingsContract authenticationSettings = default(AuthenticationSettingsContract), SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = default(SubscriptionKeyParameterNamesContract), string apiType = default(string), string apiRevision = default(string), string apiVersion = default(string), bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiRevisionDescription = default(string), string apiVersionDescription = default(string), string apiVersionSetId = default(string), string displayName = default(string), string serviceUrl = default(string), string path = default(string), IList<Protocol?> protocols = default(IList<Protocol?>))
        {
            Description = description;
            AuthenticationSettings = authenticationSettings;
            SubscriptionKeyParameterNames = subscriptionKeyParameterNames;
            ApiType = apiType;
            ApiRevision = apiRevision;
            ApiVersion = apiVersion;
            IsCurrent = isCurrent;
            IsOnline = isOnline;
            ApiRevisionDescription = apiRevisionDescription;
            ApiVersionDescription = apiVersionDescription;
            ApiVersionSetId = apiVersionSetId;
            DisplayName = displayName;
            ServiceUrl = serviceUrl;
            Path = path;
            Protocols = protocols;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the API. May include HTML formatting
        /// tags.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets collection of authentication settings included into
        /// this API.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authenticationSettings")]
        public AuthenticationSettingsContract AuthenticationSettings { get; set; }

        /// <summary>
        /// Gets or sets protocols over which API is made available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionKeyParameterNames")]
        public SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get; set; }

        /// <summary>
        /// Gets or sets type of API. Possible values include: 'http', 'soap'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string ApiType { get; set; }

        /// <summary>
        /// Gets or sets describes the Revision of the Api. If no value is
        /// provided, default revision 1 is created
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiRevision")]
        public string ApiRevision { get; set; }

        /// <summary>
        /// Gets or sets indicates the Version identifier of the API if the API
        /// is versioned
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets indicates if API revision is current api revision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isCurrent")]
        public bool? IsCurrent { get; private set; }

        /// <summary>
        /// Gets indicates if API revision is accessible via the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isOnline")]
        public bool? IsOnline { get; private set; }

        /// <summary>
        /// Gets or sets description of the Api Revision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiRevisionDescription")]
        public string ApiRevisionDescription { get; set; }

        /// <summary>
        /// Gets or sets description of the Api Version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiVersionDescription")]
        public string ApiVersionDescription { get; set; }

        /// <summary>
        /// Gets or sets a resource identifier for the related ApiVersionSet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiVersionSetId")]
        public string ApiVersionSetId { get; set; }

        /// <summary>
        /// Gets or sets API name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets absolute URL of the backend service implementing this
        /// API.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceUrl")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Gets or sets relative URL uniquely identifying this API and all of
        /// its resource paths within the API Management service instance. It
        /// is appended to the API endpoint base URL specified during the
        /// service instance creation to form a public URL for this API.
        /// </summary>
        [JsonProperty(PropertyName = "properties.path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets describes on which protocols the operations in this
        /// API can be invoked.
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocols")]
        public IList<Protocol?> Protocols { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ApiRevision != null)
            {
                if (ApiRevision.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiRevision", 100);
                }
                if (ApiRevision.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ApiRevision", 1);
                }
            }
            if (ApiVersion != null)
            {
                if (ApiVersion.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiVersion", 100);
                }
            }
            if (ApiRevisionDescription != null)
            {
                if (ApiRevisionDescription.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiRevisionDescription", 256);
                }
            }
            if (ApiVersionDescription != null)
            {
                if (ApiVersionDescription.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiVersionDescription", 256);
                }
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 300)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 300);
                }
                if (DisplayName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "DisplayName", 1);
                }
            }
            if (ServiceUrl != null)
            {
                if (ServiceUrl.Length > 2000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ServiceUrl", 2000);
                }
                if (ServiceUrl.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ServiceUrl", 1);
                }
            }
            if (Path != null)
            {
                if (Path.Length > 400)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Path", 400);
                }
                if (Path.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Path", 0);
                }
            }
        }
    }
}
