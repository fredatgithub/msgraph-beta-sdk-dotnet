// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type GroupPolicyDefinitionWithReferenceRequest.
    /// </summary>
    public partial class GroupPolicyDefinitionWithReferenceRequest : BaseRequest, IGroupPolicyDefinitionWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyDefinitionWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyDefinitionWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified GroupPolicyDefinition.
        /// </summary>
        /// <returns>The GroupPolicyDefinition.</returns>
        public System.Threading.Tasks.Task<GroupPolicyDefinition> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GroupPolicyDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyDefinition.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyDefinition> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<GroupPolicyDefinition>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified GroupPolicyDefinition using POST.
        /// </summary>
        /// <param name="groupPolicyDefinitionToCreate">The GroupPolicyDefinition to create.</param>
        /// <returns>The created GroupPolicyDefinition.</returns>
        public System.Threading.Tasks.Task<GroupPolicyDefinition> CreateAsync(GroupPolicyDefinition groupPolicyDefinitionToCreate)
        {
            return this.CreateAsync(groupPolicyDefinitionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GroupPolicyDefinition using POST.
        /// </summary>
        /// <param name="groupPolicyDefinitionToCreate">The GroupPolicyDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyDefinition.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyDefinition> CreateAsync(GroupPolicyDefinition groupPolicyDefinitionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<GroupPolicyDefinition>(groupPolicyDefinitionToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified GroupPolicyDefinition using PATCH.
        /// </summary>
        /// <param name="groupPolicyDefinitionToUpdate">The GroupPolicyDefinition to update.</param>
        /// <returns>The updated GroupPolicyDefinition.</returns>
        public System.Threading.Tasks.Task<GroupPolicyDefinition> UpdateAsync(GroupPolicyDefinition groupPolicyDefinitionToUpdate)
        {
            return this.UpdateAsync(groupPolicyDefinitionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GroupPolicyDefinition using PATCH.
        /// </summary>
        /// <param name="groupPolicyDefinitionToUpdate">The GroupPolicyDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated GroupPolicyDefinition.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyDefinition> UpdateAsync(GroupPolicyDefinition groupPolicyDefinitionToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<GroupPolicyDefinition>(groupPolicyDefinitionToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified GroupPolicyDefinition.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<GroupPolicyDefinition>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyDefinitionWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyDefinitionWithReferenceRequest Expand(Expression<Func<GroupPolicyDefinition, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyDefinitionWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyDefinitionWithReferenceRequest Select(Expression<Func<GroupPolicyDefinition, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

    }
}