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
    /// The type Office365ActiveUserCountsRequest.
    /// </summary>
    public partial class Office365ActiveUserCountsRequest : BaseRequest, IOffice365ActiveUserCountsRequest
    {
        /// <summary>
        /// Constructs a new Office365ActiveUserCountsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Office365ActiveUserCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Office365ActiveUserCounts using POST.
        /// </summary>
        /// <param name="office365ActiveUserCountsToCreate">The Office365ActiveUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Office365ActiveUserCounts.</returns>
        public async System.Threading.Tasks.Task<Office365ActiveUserCounts> CreateAsync(Office365ActiveUserCounts office365ActiveUserCountsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<Office365ActiveUserCounts>(office365ActiveUserCountsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Office365ActiveUserCounts using POST and returns a <see cref="GraphResponse{Office365ActiveUserCounts}"/> object.
        /// </summary>
        /// <param name="office365ActiveUserCountsToCreate">The Office365ActiveUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Office365ActiveUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365ActiveUserCounts>> CreateResponseAsync(Office365ActiveUserCounts office365ActiveUserCountsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<Office365ActiveUserCounts>(office365ActiveUserCountsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Office365ActiveUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<Office365ActiveUserCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Office365ActiveUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Office365ActiveUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Office365ActiveUserCounts.</returns>
        public async System.Threading.Tasks.Task<Office365ActiveUserCounts> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<Office365ActiveUserCounts>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Office365ActiveUserCounts and returns a <see cref="GraphResponse{Office365ActiveUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Office365ActiveUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365ActiveUserCounts>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<Office365ActiveUserCounts>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Office365ActiveUserCounts using PATCH.
        /// </summary>
        /// <param name="office365ActiveUserCountsToUpdate">The Office365ActiveUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Office365ActiveUserCounts.</returns>
        public async System.Threading.Tasks.Task<Office365ActiveUserCounts> UpdateAsync(Office365ActiveUserCounts office365ActiveUserCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<Office365ActiveUserCounts>(office365ActiveUserCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Office365ActiveUserCounts using PATCH and returns a <see cref="GraphResponse{Office365ActiveUserCounts}"/> object.
        /// </summary>
        /// <param name="office365ActiveUserCountsToUpdate">The Office365ActiveUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Office365ActiveUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365ActiveUserCounts>> UpdateResponseAsync(Office365ActiveUserCounts office365ActiveUserCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<Office365ActiveUserCounts>(office365ActiveUserCountsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365ActiveUserCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365ActiveUserCountsRequest Expand(Expression<Func<Office365ActiveUserCounts, object>> expandExpression)
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
        public IOffice365ActiveUserCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365ActiveUserCountsRequest Select(Expression<Func<Office365ActiveUserCounts, object>> selectExpression)
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
        /// <param name="office365ActiveUserCountsToInitialize">The <see cref="Office365ActiveUserCounts"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Office365ActiveUserCounts office365ActiveUserCountsToInitialize)
        {

        }
    }
}
