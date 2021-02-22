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
    /// The type PermissionGrantPolicyRequest.
    /// </summary>
    public partial class PermissionGrantPolicyRequest : BaseRequest, IPermissionGrantPolicyRequest
    {
        /// <summary>
        /// Constructs a new PermissionGrantPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PermissionGrantPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PermissionGrantPolicy using POST.
        /// </summary>
        /// <param name="permissionGrantPolicyToCreate">The PermissionGrantPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PermissionGrantPolicy.</returns>
        public async System.Threading.Tasks.Task<PermissionGrantPolicy> CreateAsync(PermissionGrantPolicy permissionGrantPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<PermissionGrantPolicy>(permissionGrantPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PermissionGrantPolicy using POST and returns a <see cref="GraphResponse{PermissionGrantPolicy}"/> object.
        /// </summary>
        /// <param name="permissionGrantPolicyToCreate">The PermissionGrantPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PermissionGrantPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PermissionGrantPolicy>> CreateResponseAsync(PermissionGrantPolicy permissionGrantPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<PermissionGrantPolicy>(permissionGrantPolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified PermissionGrantPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<PermissionGrantPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PermissionGrantPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified PermissionGrantPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PermissionGrantPolicy.</returns>
        public async System.Threading.Tasks.Task<PermissionGrantPolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<PermissionGrantPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PermissionGrantPolicy and returns a <see cref="GraphResponse{PermissionGrantPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PermissionGrantPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PermissionGrantPolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<PermissionGrantPolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PermissionGrantPolicy using PATCH.
        /// </summary>
        /// <param name="permissionGrantPolicyToUpdate">The PermissionGrantPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PermissionGrantPolicy.</returns>
        public async System.Threading.Tasks.Task<PermissionGrantPolicy> UpdateAsync(PermissionGrantPolicy permissionGrantPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<PermissionGrantPolicy>(permissionGrantPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PermissionGrantPolicy using PATCH and returns a <see cref="GraphResponse{PermissionGrantPolicy}"/> object.
        /// </summary>
        /// <param name="permissionGrantPolicyToUpdate">The PermissionGrantPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PermissionGrantPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PermissionGrantPolicy>> UpdateResponseAsync(PermissionGrantPolicy permissionGrantPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<PermissionGrantPolicy>(permissionGrantPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPermissionGrantPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPermissionGrantPolicyRequest Expand(Expression<Func<PermissionGrantPolicy, object>> expandExpression)
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
        public IPermissionGrantPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPermissionGrantPolicyRequest Select(Expression<Func<PermissionGrantPolicy, object>> selectExpression)
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
        /// <param name="permissionGrantPolicyToInitialize">The <see cref="PermissionGrantPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PermissionGrantPolicy permissionGrantPolicyToInitialize)
        {

            if (permissionGrantPolicyToInitialize != null && permissionGrantPolicyToInitialize.AdditionalData != null)
            {

                if (permissionGrantPolicyToInitialize.Excludes != null && permissionGrantPolicyToInitialize.Excludes.CurrentPage != null)
                {
                    permissionGrantPolicyToInitialize.Excludes.AdditionalData = permissionGrantPolicyToInitialize.AdditionalData;

                    object nextPageLink;
                    permissionGrantPolicyToInitialize.AdditionalData.TryGetValue("excludes@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        permissionGrantPolicyToInitialize.Excludes.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (permissionGrantPolicyToInitialize.Includes != null && permissionGrantPolicyToInitialize.Includes.CurrentPage != null)
                {
                    permissionGrantPolicyToInitialize.Includes.AdditionalData = permissionGrantPolicyToInitialize.AdditionalData;

                    object nextPageLink;
                    permissionGrantPolicyToInitialize.AdditionalData.TryGetValue("includes@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        permissionGrantPolicyToInitialize.Includes.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
