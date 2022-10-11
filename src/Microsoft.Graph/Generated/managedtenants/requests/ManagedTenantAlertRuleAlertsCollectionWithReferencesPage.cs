// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;

    /// <summary>
    /// The type ManagedTenantAlertRuleAlertsCollectionWithReferencesPage.
    /// </summary>
    public partial class ManagedTenantAlertRuleAlertsCollectionWithReferencesPage : Microsoft.Graph.CollectionPage<ManagedTenantAlert>, IManagedTenantAlertRuleAlertsCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IManagedTenantAlertRuleAlertsCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IManagedTenantAlertRuleAlertsCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ManagedTenantAlertRuleAlertsCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
