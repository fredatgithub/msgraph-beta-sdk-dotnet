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
    /// The type Organization Settings.
    /// </summary>
    public partial class OrganizationSettings : Entity
    {
    
        /// <summary>
        /// Gets or sets item insights.
        /// Contains the properties that are configured by an administrator for the visibility of Microsoft Graph-derived insights, between a user and other items in Microsoft 365, such as documents or sites. Get itemInsightsSettings through this navigation property.
        /// </summary>
        [JsonPropertyName("itemInsights")]
        public ItemInsightsSettings ItemInsights { get; set; }
    
        /// <summary>
        /// Gets or sets profile card properties.
        /// Contains a collection of the properties an administrator has defined as visible on the Microsoft 365 profile card. Get organization settings returns the properties configured for profile cards for the organization.
        /// </summary>
        [JsonPropertyName("profileCardProperties")]
        public IOrganizationSettingsProfileCardPropertiesCollectionPage ProfileCardProperties { get; set; }

        /// <summary>
        /// Gets or sets profileCardPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("profileCardProperties@odata.nextLink")]
        public string ProfileCardPropertiesNextLink { get; set; }
    
    }
}

