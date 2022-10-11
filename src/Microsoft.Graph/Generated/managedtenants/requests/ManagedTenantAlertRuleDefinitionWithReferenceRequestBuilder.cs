// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedTenantAlertRuleDefinitionWithReferenceRequestBuilder.
    /// </summary>
    public partial class ManagedTenantAlertRuleDefinitionWithReferenceRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IManagedTenantAlertRuleDefinitionWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedTenantAlertRuleDefinitionWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantAlertRuleDefinitionWithReferenceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedTenantAlertRuleDefinitionWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedTenantAlertRuleDefinitionWithReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantAlertRuleDefinitionWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the managedTenantAlertRuleDefinition.
        /// </summary>
        /// <returns>The <see cref="IManagedTenantAlertRuleDefinitionReferenceRequestBuilder"/>.</returns>
        public IManagedTenantAlertRuleDefinitionReferenceRequestBuilder Reference
        {
            get
            {
                return new ManagedTenantAlertRuleDefinitionReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
