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
    /// The type OnPremisesAgentGroupRequest.
    /// </summary>
    public partial class OnPremisesAgentGroupRequest : BaseRequest, IOnPremisesAgentGroupRequest
    {
        /// <summary>
        /// Constructs a new OnPremisesAgentGroupRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OnPremisesAgentGroupRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OnPremisesAgentGroup using POST.
        /// </summary>
        /// <param name="onPremisesAgentGroupToCreate">The OnPremisesAgentGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnPremisesAgentGroup.</returns>
        public async System.Threading.Tasks.Task<OnPremisesAgentGroup> CreateAsync(OnPremisesAgentGroup onPremisesAgentGroupToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<OnPremisesAgentGroup>(onPremisesAgentGroupToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OnPremisesAgentGroup using POST and returns a <see cref="GraphResponse{OnPremisesAgentGroup}"/> object.
        /// </summary>
        /// <param name="onPremisesAgentGroupToCreate">The OnPremisesAgentGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnPremisesAgentGroup}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnPremisesAgentGroup>> CreateResponseAsync(OnPremisesAgentGroup onPremisesAgentGroupToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<OnPremisesAgentGroup>(onPremisesAgentGroupToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified OnPremisesAgentGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<OnPremisesAgentGroup>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OnPremisesAgentGroup and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified OnPremisesAgentGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnPremisesAgentGroup.</returns>
        public async System.Threading.Tasks.Task<OnPremisesAgentGroup> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<OnPremisesAgentGroup>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified OnPremisesAgentGroup and returns a <see cref="GraphResponse{OnPremisesAgentGroup}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnPremisesAgentGroup}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnPremisesAgentGroup>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<OnPremisesAgentGroup>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OnPremisesAgentGroup using PATCH.
        /// </summary>
        /// <param name="onPremisesAgentGroupToUpdate">The OnPremisesAgentGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnPremisesAgentGroup.</returns>
        public async System.Threading.Tasks.Task<OnPremisesAgentGroup> UpdateAsync(OnPremisesAgentGroup onPremisesAgentGroupToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<OnPremisesAgentGroup>(onPremisesAgentGroupToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OnPremisesAgentGroup using PATCH and returns a <see cref="GraphResponse{OnPremisesAgentGroup}"/> object.
        /// </summary>
        /// <param name="onPremisesAgentGroupToUpdate">The OnPremisesAgentGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OnPremisesAgentGroup}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnPremisesAgentGroup>> UpdateResponseAsync(OnPremisesAgentGroup onPremisesAgentGroupToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<OnPremisesAgentGroup>(onPremisesAgentGroupToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnPremisesAgentGroupRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnPremisesAgentGroupRequest Expand(Expression<Func<OnPremisesAgentGroup, object>> expandExpression)
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
        public IOnPremisesAgentGroupRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOnPremisesAgentGroupRequest Select(Expression<Func<OnPremisesAgentGroup, object>> selectExpression)
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
        /// <param name="onPremisesAgentGroupToInitialize">The <see cref="OnPremisesAgentGroup"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OnPremisesAgentGroup onPremisesAgentGroupToInitialize)
        {

            if (onPremisesAgentGroupToInitialize != null && onPremisesAgentGroupToInitialize.AdditionalData != null)
            {

                if (onPremisesAgentGroupToInitialize.Agents != null && onPremisesAgentGroupToInitialize.Agents.CurrentPage != null)
                {
                    onPremisesAgentGroupToInitialize.Agents.AdditionalData = onPremisesAgentGroupToInitialize.AdditionalData;

                    object nextPageLink;
                    onPremisesAgentGroupToInitialize.AdditionalData.TryGetValue("agents@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        onPremisesAgentGroupToInitialize.Agents.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (onPremisesAgentGroupToInitialize.PublishedResources != null && onPremisesAgentGroupToInitialize.PublishedResources.CurrentPage != null)
                {
                    onPremisesAgentGroupToInitialize.PublishedResources.AdditionalData = onPremisesAgentGroupToInitialize.AdditionalData;

                    object nextPageLink;
                    onPremisesAgentGroupToInitialize.AdditionalData.TryGetValue("publishedResources@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        onPremisesAgentGroupToInitialize.PublishedResources.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
