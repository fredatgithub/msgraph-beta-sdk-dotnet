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
    /// The type OutlookTaskRequest.
    /// </summary>
    public partial class OutlookTaskRequest : BaseRequest, IOutlookTaskRequest
    {
        /// <summary>
        /// Constructs a new OutlookTaskRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OutlookTaskRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OutlookTask using POST.
        /// </summary>
        /// <param name="outlookTaskToCreate">The OutlookTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OutlookTask.</returns>
        public async System.Threading.Tasks.Task<OutlookTask> CreateAsync(OutlookTask outlookTaskToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<OutlookTask>(outlookTaskToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OutlookTask using POST and returns a <see cref="GraphResponse{OutlookTask}"/> object.
        /// </summary>
        /// <param name="outlookTaskToCreate">The OutlookTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OutlookTask}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OutlookTask>> CreateResponseAsync(OutlookTask outlookTaskToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<OutlookTask>(outlookTaskToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified OutlookTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<OutlookTask>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OutlookTask and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified OutlookTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OutlookTask.</returns>
        public async System.Threading.Tasks.Task<OutlookTask> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<OutlookTask>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified OutlookTask and returns a <see cref="GraphResponse{OutlookTask}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OutlookTask}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OutlookTask>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<OutlookTask>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OutlookTask using PATCH.
        /// </summary>
        /// <param name="outlookTaskToUpdate">The OutlookTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OutlookTask.</returns>
        public async System.Threading.Tasks.Task<OutlookTask> UpdateAsync(OutlookTask outlookTaskToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<OutlookTask>(outlookTaskToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OutlookTask using PATCH and returns a <see cref="GraphResponse{OutlookTask}"/> object.
        /// </summary>
        /// <param name="outlookTaskToUpdate">The OutlookTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OutlookTask}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OutlookTask>> UpdateResponseAsync(OutlookTask outlookTaskToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<OutlookTask>(outlookTaskToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOutlookTaskRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOutlookTaskRequest Expand(Expression<Func<OutlookTask, object>> expandExpression)
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
        public IOutlookTaskRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOutlookTaskRequest Select(Expression<Func<OutlookTask, object>> selectExpression)
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
        /// <param name="outlookTaskToInitialize">The <see cref="OutlookTask"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OutlookTask outlookTaskToInitialize)
        {

            if (outlookTaskToInitialize != null && outlookTaskToInitialize.AdditionalData != null)
            {

                if (outlookTaskToInitialize.Attachments != null && outlookTaskToInitialize.Attachments.CurrentPage != null)
                {
                    outlookTaskToInitialize.Attachments.AdditionalData = outlookTaskToInitialize.AdditionalData;

                    object nextPageLink;
                    outlookTaskToInitialize.AdditionalData.TryGetValue("attachments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        outlookTaskToInitialize.Attachments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (outlookTaskToInitialize.MultiValueExtendedProperties != null && outlookTaskToInitialize.MultiValueExtendedProperties.CurrentPage != null)
                {
                    outlookTaskToInitialize.MultiValueExtendedProperties.AdditionalData = outlookTaskToInitialize.AdditionalData;

                    object nextPageLink;
                    outlookTaskToInitialize.AdditionalData.TryGetValue("multiValueExtendedProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        outlookTaskToInitialize.MultiValueExtendedProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (outlookTaskToInitialize.SingleValueExtendedProperties != null && outlookTaskToInitialize.SingleValueExtendedProperties.CurrentPage != null)
                {
                    outlookTaskToInitialize.SingleValueExtendedProperties.AdditionalData = outlookTaskToInitialize.AdditionalData;

                    object nextPageLink;
                    outlookTaskToInitialize.AdditionalData.TryGetValue("singleValueExtendedProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        outlookTaskToInitialize.SingleValueExtendedProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
