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
    /// The type CaseRequest.
    /// </summary>
    public partial class CaseRequest : Microsoft.Graph.BaseRequest, ICaseRequest
    {
        /// <summary>
        /// Constructs a new CaseRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CaseRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Case using POST.
        /// </summary>
        /// <param name="caseToCreate">The Case to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Case.</returns>
        public async System.Threading.Tasks.Task<Case> CreateAsync(Case caseToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<Case>(caseToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Case using POST and returns a <see cref="GraphResponse{Case}"/> object.
        /// </summary>
        /// <param name="caseToCreate">The Case to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Case}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Case>> CreateResponseAsync(Case caseToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<Case>(caseToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Case.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<Case>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Case and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Case.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Case.</returns>
        public async System.Threading.Tasks.Task<Case> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<Case>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Case and returns a <see cref="GraphResponse{Case}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Case}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Case>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<Case>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Case using PATCH.
        /// </summary>
        /// <param name="caseToUpdate">The Case to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Case.</returns>
        public async System.Threading.Tasks.Task<Case> UpdateAsync(Case caseToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<Case>(caseToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Case using PATCH and returns a <see cref="GraphResponse{Case}"/> object.
        /// </summary>
        /// <param name="caseToUpdate">The Case to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Case}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Case>> UpdateResponseAsync(Case caseToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<Case>(caseToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICaseRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICaseRequest Expand(Expression<Func<Case, object>> expandExpression)
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
        public ICaseRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICaseRequest Select(Expression<Func<Case, object>> selectExpression)
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
        /// <param name="caseToInitialize">The <see cref="Case"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Case caseToInitialize)
        {

            if (caseToInitialize != null && caseToInitialize.AdditionalData != null)
            {

                if (caseToInitialize.Custodians != null && caseToInitialize.Custodians.CurrentPage != null)
                {
                    caseToInitialize.Custodians.AdditionalData = caseToInitialize.AdditionalData;

                    object nextPageLink;
                    caseToInitialize.AdditionalData.TryGetValue("custodians@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        caseToInitialize.Custodians.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (caseToInitialize.LegalHolds != null && caseToInitialize.LegalHolds.CurrentPage != null)
                {
                    caseToInitialize.LegalHolds.AdditionalData = caseToInitialize.AdditionalData;

                    object nextPageLink;
                    caseToInitialize.AdditionalData.TryGetValue("legalHolds@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        caseToInitialize.LegalHolds.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (caseToInitialize.NoncustodialDataSources != null && caseToInitialize.NoncustodialDataSources.CurrentPage != null)
                {
                    caseToInitialize.NoncustodialDataSources.AdditionalData = caseToInitialize.AdditionalData;

                    object nextPageLink;
                    caseToInitialize.AdditionalData.TryGetValue("noncustodialDataSources@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        caseToInitialize.NoncustodialDataSources.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (caseToInitialize.Operations != null && caseToInitialize.Operations.CurrentPage != null)
                {
                    caseToInitialize.Operations.AdditionalData = caseToInitialize.AdditionalData;

                    object nextPageLink;
                    caseToInitialize.AdditionalData.TryGetValue("operations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        caseToInitialize.Operations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (caseToInitialize.ReviewSets != null && caseToInitialize.ReviewSets.CurrentPage != null)
                {
                    caseToInitialize.ReviewSets.AdditionalData = caseToInitialize.AdditionalData;

                    object nextPageLink;
                    caseToInitialize.AdditionalData.TryGetValue("reviewSets@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        caseToInitialize.ReviewSets.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (caseToInitialize.SourceCollections != null && caseToInitialize.SourceCollections.CurrentPage != null)
                {
                    caseToInitialize.SourceCollections.AdditionalData = caseToInitialize.AdditionalData;

                    object nextPageLink;
                    caseToInitialize.AdditionalData.TryGetValue("sourceCollections@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        caseToInitialize.SourceCollections.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (caseToInitialize.Tags != null && caseToInitialize.Tags.CurrentPage != null)
                {
                    caseToInitialize.Tags.AdditionalData = caseToInitialize.AdditionalData;

                    object nextPageLink;
                    caseToInitialize.AdditionalData.TryGetValue("tags@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        caseToInitialize.Tags.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
