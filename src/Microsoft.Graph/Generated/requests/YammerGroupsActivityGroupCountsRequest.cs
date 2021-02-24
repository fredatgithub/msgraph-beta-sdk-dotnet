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
    /// The type YammerGroupsActivityGroupCountsRequest.
    /// </summary>
    public partial class YammerGroupsActivityGroupCountsRequest : BaseRequest, IYammerGroupsActivityGroupCountsRequest
    {
        /// <summary>
        /// Constructs a new YammerGroupsActivityGroupCountsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public YammerGroupsActivityGroupCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified YammerGroupsActivityGroupCounts using POST.
        /// </summary>
        /// <param name="yammerGroupsActivityGroupCountsToCreate">The YammerGroupsActivityGroupCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created YammerGroupsActivityGroupCounts.</returns>
        public async System.Threading.Tasks.Task<YammerGroupsActivityGroupCounts> CreateAsync(YammerGroupsActivityGroupCounts yammerGroupsActivityGroupCountsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<YammerGroupsActivityGroupCounts>(yammerGroupsActivityGroupCountsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified YammerGroupsActivityGroupCounts using POST and returns a <see cref="GraphResponse{YammerGroupsActivityGroupCounts}"/> object.
        /// </summary>
        /// <param name="yammerGroupsActivityGroupCountsToCreate">The YammerGroupsActivityGroupCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{YammerGroupsActivityGroupCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<YammerGroupsActivityGroupCounts>> CreateResponseAsync(YammerGroupsActivityGroupCounts yammerGroupsActivityGroupCountsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<YammerGroupsActivityGroupCounts>(yammerGroupsActivityGroupCountsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified YammerGroupsActivityGroupCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<YammerGroupsActivityGroupCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified YammerGroupsActivityGroupCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified YammerGroupsActivityGroupCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The YammerGroupsActivityGroupCounts.</returns>
        public async System.Threading.Tasks.Task<YammerGroupsActivityGroupCounts> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<YammerGroupsActivityGroupCounts>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified YammerGroupsActivityGroupCounts and returns a <see cref="GraphResponse{YammerGroupsActivityGroupCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{YammerGroupsActivityGroupCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<YammerGroupsActivityGroupCounts>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<YammerGroupsActivityGroupCounts>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified YammerGroupsActivityGroupCounts using PATCH.
        /// </summary>
        /// <param name="yammerGroupsActivityGroupCountsToUpdate">The YammerGroupsActivityGroupCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated YammerGroupsActivityGroupCounts.</returns>
        public async System.Threading.Tasks.Task<YammerGroupsActivityGroupCounts> UpdateAsync(YammerGroupsActivityGroupCounts yammerGroupsActivityGroupCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<YammerGroupsActivityGroupCounts>(yammerGroupsActivityGroupCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified YammerGroupsActivityGroupCounts using PATCH and returns a <see cref="GraphResponse{YammerGroupsActivityGroupCounts}"/> object.
        /// </summary>
        /// <param name="yammerGroupsActivityGroupCountsToUpdate">The YammerGroupsActivityGroupCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{YammerGroupsActivityGroupCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<YammerGroupsActivityGroupCounts>> UpdateResponseAsync(YammerGroupsActivityGroupCounts yammerGroupsActivityGroupCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<YammerGroupsActivityGroupCounts>(yammerGroupsActivityGroupCountsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IYammerGroupsActivityGroupCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IYammerGroupsActivityGroupCountsRequest Expand(Expression<Func<YammerGroupsActivityGroupCounts, object>> expandExpression)
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
        public IYammerGroupsActivityGroupCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IYammerGroupsActivityGroupCountsRequest Select(Expression<Func<YammerGroupsActivityGroupCounts, object>> selectExpression)
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
        /// <param name="yammerGroupsActivityGroupCountsToInitialize">The <see cref="YammerGroupsActivityGroupCounts"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(YammerGroupsActivityGroupCounts yammerGroupsActivityGroupCountsToInitialize)
        {

        }
    }
}
