// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ManagedTenantAlertRuleWithReferenceRequest.
    /// </summary>
    public partial class ManagedTenantAlertRuleWithReferenceRequest : Microsoft.Graph.BaseRequest, IManagedTenantAlertRuleWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new ManagedTenantAlertRuleWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedTenantAlertRuleWithReferenceRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified ManagedTenantAlertRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedTenantAlertRule.</returns>
        public async System.Threading.Tasks.Task<ManagedTenantAlertRule> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ManagedTenantAlertRule>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ManagedTenantAlertRule and returns a <see cref="GraphResponse{ManagedTenantAlertRule}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantAlertRule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlertRule>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ManagedTenantAlertRule>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified ManagedTenantAlertRule using POST.
        /// </summary>
        /// <param name="managedTenantAlertRuleToCreate">The ManagedTenantAlertRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedTenantAlertRule.</returns>
        public async System.Threading.Tasks.Task<ManagedTenantAlertRule> CreateAsync(ManagedTenantAlertRule managedTenantAlertRuleToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ManagedTenantAlertRule>(managedTenantAlertRuleToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified ManagedTenantAlertRule using POST and returns a <see cref="GraphResponse{ManagedTenantAlertRule}"/> object.
        /// </summary>
        /// <param name="managedTenantAlertRuleToCreate">The ManagedTenantAlertRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantAlertRule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlertRule>> CreateResponseAsync(ManagedTenantAlertRule managedTenantAlertRuleToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ManagedTenantAlertRule>(managedTenantAlertRuleToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified ManagedTenantAlertRule using PATCH.
        /// </summary>
        /// <param name="managedTenantAlertRuleToUpdate">The ManagedTenantAlertRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedTenantAlertRule.</returns>
        public async System.Threading.Tasks.Task<ManagedTenantAlertRule> UpdateAsync(ManagedTenantAlertRule managedTenantAlertRuleToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ManagedTenantAlertRule>(managedTenantAlertRuleToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified ManagedTenantAlertRule using PATCH and returns a <see cref="GraphResponse{ManagedTenantAlertRule}"/> object.
        /// </summary>
        /// <param name="managedTenantAlertRuleToUpdate">The ManagedTenantAlertRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedTenantAlertRule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlertRule>> UpdateResponseAsync(ManagedTenantAlertRule managedTenantAlertRuleToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ManagedTenantAlertRule>(managedTenantAlertRuleToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified ManagedTenantAlertRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ManagedTenantAlertRule>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified ManagedTenantAlertRule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantAlertRuleWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantAlertRuleWithReferenceRequest Expand(Expression<Func<ManagedTenantAlertRule, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantAlertRuleWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantAlertRuleWithReferenceRequest Select(Expression<Func<ManagedTenantAlertRule, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

    }
}
