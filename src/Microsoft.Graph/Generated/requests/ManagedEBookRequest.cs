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
    /// The type ManagedEBookRequest.
    /// </summary>
    public partial class ManagedEBookRequest : BaseRequest, IManagedEBookRequest
    {
        /// <summary>
        /// Constructs a new ManagedEBookRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedEBookRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ManagedEBook using POST.
        /// </summary>
        /// <param name="managedEBookToCreate">The ManagedEBook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedEBook.</returns>
        public async System.Threading.Tasks.Task<ManagedEBook> CreateAsync(ManagedEBook managedEBookToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<ManagedEBook>(managedEBookToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ManagedEBook using POST and returns a <see cref="GraphResponse{ManagedEBook}"/> object.
        /// </summary>
        /// <param name="managedEBookToCreate">The ManagedEBook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedEBook}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedEBook>> CreateResponseAsync(ManagedEBook managedEBookToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<ManagedEBook>(managedEBookToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ManagedEBook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<ManagedEBook>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ManagedEBook and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ManagedEBook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedEBook.</returns>
        public async System.Threading.Tasks.Task<ManagedEBook> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<ManagedEBook>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ManagedEBook and returns a <see cref="GraphResponse{ManagedEBook}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedEBook}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedEBook>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<ManagedEBook>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagedEBook using PATCH.
        /// </summary>
        /// <param name="managedEBookToUpdate">The ManagedEBook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedEBook.</returns>
        public async System.Threading.Tasks.Task<ManagedEBook> UpdateAsync(ManagedEBook managedEBookToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<ManagedEBook>(managedEBookToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedEBook using PATCH and returns a <see cref="GraphResponse{ManagedEBook}"/> object.
        /// </summary>
        /// <param name="managedEBookToUpdate">The ManagedEBook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedEBook}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedEBook>> UpdateResponseAsync(ManagedEBook managedEBookToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<ManagedEBook>(managedEBookToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedEBookRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedEBookRequest Expand(Expression<Func<ManagedEBook, object>> expandExpression)
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
        public IManagedEBookRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedEBookRequest Select(Expression<Func<ManagedEBook, object>> selectExpression)
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
        /// <param name="managedEBookToInitialize">The <see cref="ManagedEBook"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ManagedEBook managedEBookToInitialize)
        {

            if (managedEBookToInitialize != null && managedEBookToInitialize.AdditionalData != null)
            {

                if (managedEBookToInitialize.Assignments != null && managedEBookToInitialize.Assignments.CurrentPage != null)
                {
                    managedEBookToInitialize.Assignments.AdditionalData = managedEBookToInitialize.AdditionalData;

                    object nextPageLink;
                    managedEBookToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        managedEBookToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (managedEBookToInitialize.Categories != null && managedEBookToInitialize.Categories.CurrentPage != null)
                {
                    managedEBookToInitialize.Categories.AdditionalData = managedEBookToInitialize.AdditionalData;

                    object nextPageLink;
                    managedEBookToInitialize.AdditionalData.TryGetValue("categories@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        managedEBookToInitialize.Categories.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (managedEBookToInitialize.DeviceStates != null && managedEBookToInitialize.DeviceStates.CurrentPage != null)
                {
                    managedEBookToInitialize.DeviceStates.AdditionalData = managedEBookToInitialize.AdditionalData;

                    object nextPageLink;
                    managedEBookToInitialize.AdditionalData.TryGetValue("deviceStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        managedEBookToInitialize.DeviceStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (managedEBookToInitialize.UserStateSummary != null && managedEBookToInitialize.UserStateSummary.CurrentPage != null)
                {
                    managedEBookToInitialize.UserStateSummary.AdditionalData = managedEBookToInitialize.AdditionalData;

                    object nextPageLink;
                    managedEBookToInitialize.AdditionalData.TryGetValue("userStateSummary@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        managedEBookToInitialize.UserStateSummary.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
