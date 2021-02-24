// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type SourceCollectionRequest.
    /// </summary>
    public partial class SourceCollectionRequest : Microsoft.Graph.BaseRequest, ISourceCollectionRequest
    {
        /// <summary>
        /// Constructs a new SourceCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SourceCollectionRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SourceCollection using POST.
        /// </summary>
        /// <param name="sourceCollectionToCreate">The SourceCollection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SourceCollection.</returns>
        public async System.Threading.Tasks.Task<SourceCollection> CreateAsync(SourceCollection sourceCollectionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<SourceCollection>(sourceCollectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SourceCollection using POST and returns a <see cref="GraphResponse{SourceCollection}"/> object.
        /// </summary>
        /// <param name="sourceCollectionToCreate">The SourceCollection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SourceCollection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SourceCollection>> CreateResponseAsync(SourceCollection sourceCollectionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<SourceCollection>(sourceCollectionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified SourceCollection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<SourceCollection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SourceCollection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified SourceCollection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SourceCollection.</returns>
        public async System.Threading.Tasks.Task<SourceCollection> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<SourceCollection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SourceCollection and returns a <see cref="GraphResponse{SourceCollection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SourceCollection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SourceCollection>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<SourceCollection>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SourceCollection using PATCH.
        /// </summary>
        /// <param name="sourceCollectionToUpdate">The SourceCollection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SourceCollection.</returns>
        public async System.Threading.Tasks.Task<SourceCollection> UpdateAsync(SourceCollection sourceCollectionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<SourceCollection>(sourceCollectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SourceCollection using PATCH and returns a <see cref="GraphResponse{SourceCollection}"/> object.
        /// </summary>
        /// <param name="sourceCollectionToUpdate">The SourceCollection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SourceCollection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SourceCollection>> UpdateResponseAsync(SourceCollection sourceCollectionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<SourceCollection>(sourceCollectionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISourceCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISourceCollectionRequest Expand(Expression<Func<SourceCollection, object>> expandExpression)
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
        public ISourceCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISourceCollectionRequest Select(Expression<Func<SourceCollection, object>> selectExpression)
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

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="sourceCollectionToInitialize">The <see cref="SourceCollection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SourceCollection sourceCollectionToInitialize)
        {

            if (sourceCollectionToInitialize != null && sourceCollectionToInitialize.AdditionalData != null)
            {

                if (sourceCollectionToInitialize.AdditionalSources != null && sourceCollectionToInitialize.AdditionalSources.CurrentPage != null)
                {
                    sourceCollectionToInitialize.AdditionalSources.AdditionalData = sourceCollectionToInitialize.AdditionalData;

                    object nextPageLink;
                    sourceCollectionToInitialize.AdditionalData.TryGetValue("additionalSources@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        sourceCollectionToInitialize.AdditionalSources.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (sourceCollectionToInitialize.CustodianSources != null && sourceCollectionToInitialize.CustodianSources.CurrentPage != null)
                {
                    sourceCollectionToInitialize.CustodianSources.AdditionalData = sourceCollectionToInitialize.AdditionalData;

                    object nextPageLink;
                    sourceCollectionToInitialize.AdditionalData.TryGetValue("custodianSources@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        sourceCollectionToInitialize.CustodianSources.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (sourceCollectionToInitialize.NoncustodialSources != null && sourceCollectionToInitialize.NoncustodialSources.CurrentPage != null)
                {
                    sourceCollectionToInitialize.NoncustodialSources.AdditionalData = sourceCollectionToInitialize.AdditionalData;

                    object nextPageLink;
                    sourceCollectionToInitialize.AdditionalData.TryGetValue("noncustodialSources@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        sourceCollectionToInitialize.NoncustodialSources.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
