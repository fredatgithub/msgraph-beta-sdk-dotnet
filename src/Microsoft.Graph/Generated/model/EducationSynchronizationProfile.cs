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
    /// The type Education Synchronization Profile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EducationSynchronizationProfile>))]
    public partial class EducationSynchronizationProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets data provider.
        /// The data provider used for the profile.
        /// </summary>
        [JsonPropertyName("dataProvider")]
        public EducationSynchronizationDataProvider DataProvider { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the configuration profile for syncing identities.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date.
        /// The date the profile should be considered expired and cease syncing. Provide the date in YYYY-MM-DD format, following ISO 8601. Maximum value is 18 months from profile creation.  (optional)
        /// </summary>
        [JsonPropertyName("expirationDate")]
        public Date ExpirationDate { get; set; }
    
        /// <summary>
        /// Gets or sets handle special character constraint.
        /// Determines if School Data Sync should automatically replace unsupported special characters while syncing from source.
        /// </summary>
        [JsonPropertyName("handleSpecialCharacterConstraint")]
        public bool? HandleSpecialCharacterConstraint { get; set; }
    
        /// <summary>
        /// Gets or sets identity synchronization configuration.
        /// Determines how the Profile should [create new][fullsync] or [match existing][dirsync] AAD Users.
        /// </summary>
        [JsonPropertyName("identitySynchronizationConfiguration")]
        public EducationIdentitySynchronizationConfiguration IdentitySynchronizationConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets licenses to assign.
        /// License setup configuration.
        /// </summary>
        [JsonPropertyName("licensesToAssign")]
        public IEnumerable<EducationSynchronizationLicenseAssignment> LicensesToAssign { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The state of the profile. Possible values are: provisioning, provisioned, provisioningFailed, deleting, deletionFailed.
        /// </summary>
        [JsonPropertyName("state")]
        public EducationSynchronizationProfileState? State { get; set; }
    
        /// <summary>
        /// Gets or sets errors.
        /// All errors associated with this synchronization profile.
        /// </summary>
        [JsonPropertyName("errors")]
        public IEducationSynchronizationProfileErrorsCollectionPage Errors { get; set; }

        /// <summary>
        /// Gets or sets errorsNextLink.
        /// </summary>
        [JsonPropertyName("errors@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ErrorsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets profile status.
        /// The synchronization status.
        /// </summary>
        [JsonPropertyName("profileStatus")]
        public EducationSynchronizationProfileStatus ProfileStatus { get; set; }
    
    }
}

