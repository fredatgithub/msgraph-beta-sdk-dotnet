// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type PrivateLinkResourcePolicyRequest.
    /// </summary>
    public partial class PrivateLinkResourcePolicyRequest : BaseRequest, IPrivateLinkResourcePolicyRequest
    {
        /// <summary>
        /// Constructs a new PrivateLinkResourcePolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PrivateLinkResourcePolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PrivateLinkResourcePolicy using POST.
        /// </summary>
        /// <param name="privateLinkResourcePolicyToCreate">The PrivateLinkResourcePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivateLinkResourcePolicy.</returns>
        public async System.Threading.Tasks.Task<PrivateLinkResourcePolicy> CreateAsync(PrivateLinkResourcePolicy privateLinkResourcePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<PrivateLinkResourcePolicy>(privateLinkResourcePolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PrivateLinkResourcePolicy using POST and returns a <see cref="GraphResponse{PrivateLinkResourcePolicy}"/> object.
        /// </summary>
        /// <param name="privateLinkResourcePolicyToCreate">The PrivateLinkResourcePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrivateLinkResourcePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrivateLinkResourcePolicy>> CreateResponseAsync(PrivateLinkResourcePolicy privateLinkResourcePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<PrivateLinkResourcePolicy>(privateLinkResourcePolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified PrivateLinkResourcePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<PrivateLinkResourcePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PrivateLinkResourcePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified PrivateLinkResourcePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivateLinkResourcePolicy.</returns>
        public async System.Threading.Tasks.Task<PrivateLinkResourcePolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<PrivateLinkResourcePolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PrivateLinkResourcePolicy and returns a <see cref="GraphResponse{PrivateLinkResourcePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrivateLinkResourcePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrivateLinkResourcePolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<PrivateLinkResourcePolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PrivateLinkResourcePolicy using PATCH.
        /// </summary>
        /// <param name="privateLinkResourcePolicyToUpdate">The PrivateLinkResourcePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrivateLinkResourcePolicy.</returns>
        public async System.Threading.Tasks.Task<PrivateLinkResourcePolicy> UpdateAsync(PrivateLinkResourcePolicy privateLinkResourcePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<PrivateLinkResourcePolicy>(privateLinkResourcePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PrivateLinkResourcePolicy using PATCH and returns a <see cref="GraphResponse{PrivateLinkResourcePolicy}"/> object.
        /// </summary>
        /// <param name="privateLinkResourcePolicyToUpdate">The PrivateLinkResourcePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrivateLinkResourcePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrivateLinkResourcePolicy>> UpdateResponseAsync(PrivateLinkResourcePolicy privateLinkResourcePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<PrivateLinkResourcePolicy>(privateLinkResourcePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPrivateLinkResourcePolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPrivateLinkResourcePolicyRequest Expand(Expression<Func<PrivateLinkResourcePolicy, object>> expandExpression)
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
        public IPrivateLinkResourcePolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPrivateLinkResourcePolicyRequest Select(Expression<Func<PrivateLinkResourcePolicy, object>> selectExpression)
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

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="privateLinkResourcePolicyToInitialize">The <see cref="PrivateLinkResourcePolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PrivateLinkResourcePolicy privateLinkResourcePolicyToInitialize)
        {

        }
    }
}
