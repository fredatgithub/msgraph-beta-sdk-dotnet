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
    /// The type SkypeForBusinessDeviceUsageDistributionUserCountsRequest.
    /// </summary>
    public partial class SkypeForBusinessDeviceUsageDistributionUserCountsRequest : BaseRequest, ISkypeForBusinessDeviceUsageDistributionUserCountsRequest
    {
        /// <summary>
        /// Constructs a new SkypeForBusinessDeviceUsageDistributionUserCountsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SkypeForBusinessDeviceUsageDistributionUserCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToCreate">The SkypeForBusinessDeviceUsageDistributionUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessDeviceUsageDistributionUserCounts.</returns>
        public async System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageDistributionUserCounts> CreateAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<SkypeForBusinessDeviceUsageDistributionUserCounts>(skypeForBusinessDeviceUsageDistributionUserCountsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToCreate">The SkypeForBusinessDeviceUsageDistributionUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>> CreateResponseAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>(skypeForBusinessDeviceUsageDistributionUserCountsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified SkypeForBusinessDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<SkypeForBusinessDeviceUsageDistributionUserCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SkypeForBusinessDeviceUsageDistributionUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified SkypeForBusinessDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessDeviceUsageDistributionUserCounts.</returns>
        public async System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageDistributionUserCounts> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<SkypeForBusinessDeviceUsageDistributionUserCounts>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SkypeForBusinessDeviceUsageDistributionUserCounts and returns a <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToUpdate">The SkypeForBusinessDeviceUsageDistributionUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeForBusinessDeviceUsageDistributionUserCounts.</returns>
        public async System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageDistributionUserCounts> UpdateAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<SkypeForBusinessDeviceUsageDistributionUserCounts>(skypeForBusinessDeviceUsageDistributionUserCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToUpdate">The SkypeForBusinessDeviceUsageDistributionUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>> UpdateResponseAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>(skypeForBusinessDeviceUsageDistributionUserCountsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeForBusinessDeviceUsageDistributionUserCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeForBusinessDeviceUsageDistributionUserCountsRequest Expand(Expression<Func<SkypeForBusinessDeviceUsageDistributionUserCounts, object>> expandExpression)
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
        public ISkypeForBusinessDeviceUsageDistributionUserCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeForBusinessDeviceUsageDistributionUserCountsRequest Select(Expression<Func<SkypeForBusinessDeviceUsageDistributionUserCounts, object>> selectExpression)
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
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToInitialize">The <see cref="SkypeForBusinessDeviceUsageDistributionUserCounts"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToInitialize)
        {

        }
    }
}
