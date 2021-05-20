// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ApiApplication.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ApiApplication>))]
    public partial class ApiApplication
    {

        /// <summary>
        /// Gets or sets acceptMappedClaims.
        /// When true, allows an application to use claims mapping without specifying a custom signing key.
        /// </summary>
        [JsonPropertyName("acceptMappedClaims")]
        public bool? AcceptMappedClaims { get; set; }
    
        /// <summary>
        /// Gets or sets knownClientApplications.
        /// Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
        /// </summary>
        [JsonPropertyName("knownClientApplications")]
        public IEnumerable<Guid> KnownClientApplications { get; set; }
    
        /// <summary>
        /// Gets or sets oauth2PermissionScopes.
        /// The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
        /// </summary>
        [JsonPropertyName("oauth2PermissionScopes")]
        public IEnumerable<PermissionScope> Oauth2PermissionScopes { get; set; }
    
        /// <summary>
        /// Gets or sets preAuthorizedApplications.
        /// Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
        /// </summary>
        [JsonPropertyName("preAuthorizedApplications")]
        public IEnumerable<PreAuthorizedApplication> PreAuthorizedApplications { get; set; }
    
        /// <summary>
        /// Gets or sets requestedAccessTokenVersion.
        /// Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
        /// </summary>
        [JsonPropertyName("requestedAccessTokenVersion")]
        public Int32? RequestedAccessTokenVersion { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
