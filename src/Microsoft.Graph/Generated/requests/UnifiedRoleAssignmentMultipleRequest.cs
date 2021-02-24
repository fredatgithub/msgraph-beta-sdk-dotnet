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
    /// The type UnifiedRoleAssignmentMultipleRequest.
    /// </summary>
    public partial class UnifiedRoleAssignmentMultipleRequest : BaseRequest, IUnifiedRoleAssignmentMultipleRequest
    {
        /// <summary>
        /// Constructs a new UnifiedRoleAssignmentMultipleRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnifiedRoleAssignmentMultipleRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UnifiedRoleAssignmentMultiple using POST.
        /// </summary>
        /// <param name="unifiedRoleAssignmentMultipleToCreate">The UnifiedRoleAssignmentMultiple to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleAssignmentMultiple.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleAssignmentMultiple> CreateAsync(UnifiedRoleAssignmentMultiple unifiedRoleAssignmentMultipleToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<UnifiedRoleAssignmentMultiple>(unifiedRoleAssignmentMultipleToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UnifiedRoleAssignmentMultiple using POST and returns a <see cref="GraphResponse{UnifiedRoleAssignmentMultiple}"/> object.
        /// </summary>
        /// <param name="unifiedRoleAssignmentMultipleToCreate">The UnifiedRoleAssignmentMultiple to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignmentMultiple}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignmentMultiple>> CreateResponseAsync(UnifiedRoleAssignmentMultiple unifiedRoleAssignmentMultipleToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<UnifiedRoleAssignmentMultiple>(unifiedRoleAssignmentMultipleToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UnifiedRoleAssignmentMultiple.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<UnifiedRoleAssignmentMultiple>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UnifiedRoleAssignmentMultiple and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UnifiedRoleAssignmentMultiple.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleAssignmentMultiple.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleAssignmentMultiple> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<UnifiedRoleAssignmentMultiple>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UnifiedRoleAssignmentMultiple and returns a <see cref="GraphResponse{UnifiedRoleAssignmentMultiple}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignmentMultiple}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignmentMultiple>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<UnifiedRoleAssignmentMultiple>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnifiedRoleAssignmentMultiple using PATCH.
        /// </summary>
        /// <param name="unifiedRoleAssignmentMultipleToUpdate">The UnifiedRoleAssignmentMultiple to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleAssignmentMultiple.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleAssignmentMultiple> UpdateAsync(UnifiedRoleAssignmentMultiple unifiedRoleAssignmentMultipleToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<UnifiedRoleAssignmentMultiple>(unifiedRoleAssignmentMultipleToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnifiedRoleAssignmentMultiple using PATCH and returns a <see cref="GraphResponse{UnifiedRoleAssignmentMultiple}"/> object.
        /// </summary>
        /// <param name="unifiedRoleAssignmentMultipleToUpdate">The UnifiedRoleAssignmentMultiple to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignmentMultiple}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignmentMultiple>> UpdateResponseAsync(UnifiedRoleAssignmentMultiple unifiedRoleAssignmentMultipleToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<UnifiedRoleAssignmentMultiple>(unifiedRoleAssignmentMultipleToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleAssignmentMultipleRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleAssignmentMultipleRequest Expand(Expression<Func<UnifiedRoleAssignmentMultiple, object>> expandExpression)
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
        public IUnifiedRoleAssignmentMultipleRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleAssignmentMultipleRequest Select(Expression<Func<UnifiedRoleAssignmentMultiple, object>> selectExpression)
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
        /// <param name="unifiedRoleAssignmentMultipleToInitialize">The <see cref="UnifiedRoleAssignmentMultiple"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UnifiedRoleAssignmentMultiple unifiedRoleAssignmentMultipleToInitialize)
        {

            if (unifiedRoleAssignmentMultipleToInitialize != null && unifiedRoleAssignmentMultipleToInitialize.AdditionalData != null)
            {

                if (unifiedRoleAssignmentMultipleToInitialize.AppScopes != null && unifiedRoleAssignmentMultipleToInitialize.AppScopes.CurrentPage != null)
                {
                    unifiedRoleAssignmentMultipleToInitialize.AppScopes.AdditionalData = unifiedRoleAssignmentMultipleToInitialize.AdditionalData;

                    object nextPageLink;
                    unifiedRoleAssignmentMultipleToInitialize.AdditionalData.TryGetValue("appScopes@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        unifiedRoleAssignmentMultipleToInitialize.AppScopes.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (unifiedRoleAssignmentMultipleToInitialize.DirectoryScopes != null && unifiedRoleAssignmentMultipleToInitialize.DirectoryScopes.CurrentPage != null)
                {
                    unifiedRoleAssignmentMultipleToInitialize.DirectoryScopes.AdditionalData = unifiedRoleAssignmentMultipleToInitialize.AdditionalData;

                    object nextPageLink;
                    unifiedRoleAssignmentMultipleToInitialize.AdditionalData.TryGetValue("directoryScopes@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        unifiedRoleAssignmentMultipleToInitialize.DirectoryScopes.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (unifiedRoleAssignmentMultipleToInitialize.Principals != null && unifiedRoleAssignmentMultipleToInitialize.Principals.CurrentPage != null)
                {
                    unifiedRoleAssignmentMultipleToInitialize.Principals.AdditionalData = unifiedRoleAssignmentMultipleToInitialize.AdditionalData;

                    object nextPageLink;
                    unifiedRoleAssignmentMultipleToInitialize.AdditionalData.TryGetValue("principals@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        unifiedRoleAssignmentMultipleToInitialize.Principals.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
