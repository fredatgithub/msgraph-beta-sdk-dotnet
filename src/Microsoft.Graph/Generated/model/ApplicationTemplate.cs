// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Application Template.
    /// </summary>
    public partial class ApplicationTemplate : Entity
    {
    
        /// <summary>
        /// Gets or sets categories.
        /// The list of categories for the application. Supported values can be: Collaboration, Business Management, Consumer, Content management, CRM, Data services, Developer services, E-commerce, Education, ERP, Finance, Health, Human resources, IT infrastructure, Mail, Management, Marketing, Media, Productivity, Project management, Telecommunications, Tools, Travel, and Web design &amp; hosting.
        /// </summary>
        [JsonPropertyName("categories")]
        public IEnumerable<string> Categories { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// A description of the application.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the application.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets home page url.
        /// The home page URL of the application.
        /// </summary>
        [JsonPropertyName("homePageUrl")]
        public string HomePageUrl { get; set; }
    
        /// <summary>
        /// Gets or sets logo url.
        /// The URL to get the logo for this application.
        /// </summary>
        [JsonPropertyName("logoUrl")]
        public string LogoUrl { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// The name of the publisher for this application.
        /// </summary>
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
    
        /// <summary>
        /// Gets or sets supported provisioning types.
        /// The list of provisioning modes supported by this application. The only valid value is sync.
        /// </summary>
        [JsonPropertyName("supportedProvisioningTypes")]
        public IEnumerable<string> SupportedProvisioningTypes { get; set; }
    
        /// <summary>
        /// Gets or sets supported single sign on modes.
        /// The list of single sign-on modes supported by this application. The supported values are oidc, password, saml, and notSupported.
        /// </summary>
        [JsonPropertyName("supportedSingleSignOnModes")]
        public IEnumerable<string> SupportedSingleSignOnModes { get; set; }
    
    }
}

