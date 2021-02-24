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
    /// The type SynchronizationSchemaRequest.
    /// </summary>
    public partial class SynchronizationSchemaRequest : BaseRequest, ISynchronizationSchemaRequest
    {
        /// <summary>
        /// Constructs a new SynchronizationSchemaRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SynchronizationSchemaRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SynchronizationSchema using POST.
        /// </summary>
        /// <param name="synchronizationSchemaToCreate">The SynchronizationSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SynchronizationSchema.</returns>
        public async System.Threading.Tasks.Task<SynchronizationSchema> CreateAsync(SynchronizationSchema synchronizationSchemaToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<SynchronizationSchema>(synchronizationSchemaToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SynchronizationSchema using POST and returns a <see cref="GraphResponse{SynchronizationSchema}"/> object.
        /// </summary>
        /// <param name="synchronizationSchemaToCreate">The SynchronizationSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SynchronizationSchema}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SynchronizationSchema>> CreateResponseAsync(SynchronizationSchema synchronizationSchemaToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<SynchronizationSchema>(synchronizationSchemaToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified SynchronizationSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<SynchronizationSchema>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SynchronizationSchema and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified SynchronizationSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SynchronizationSchema.</returns>
        public async System.Threading.Tasks.Task<SynchronizationSchema> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<SynchronizationSchema>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SynchronizationSchema and returns a <see cref="GraphResponse{SynchronizationSchema}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SynchronizationSchema}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SynchronizationSchema>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<SynchronizationSchema>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SynchronizationSchema using PATCH.
        /// </summary>
        /// <param name="synchronizationSchemaToUpdate">The SynchronizationSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SynchronizationSchema.</returns>
        public async System.Threading.Tasks.Task<SynchronizationSchema> UpdateAsync(SynchronizationSchema synchronizationSchemaToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<SynchronizationSchema>(synchronizationSchemaToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SynchronizationSchema using PATCH and returns a <see cref="GraphResponse{SynchronizationSchema}"/> object.
        /// </summary>
        /// <param name="synchronizationSchemaToUpdate">The SynchronizationSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SynchronizationSchema}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SynchronizationSchema>> UpdateResponseAsync(SynchronizationSchema synchronizationSchemaToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<SynchronizationSchema>(synchronizationSchemaToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISynchronizationSchemaRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISynchronizationSchemaRequest Expand(Expression<Func<SynchronizationSchema, object>> expandExpression)
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
        public ISynchronizationSchemaRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISynchronizationSchemaRequest Select(Expression<Func<SynchronizationSchema, object>> selectExpression)
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
        /// <param name="synchronizationSchemaToInitialize">The <see cref="SynchronizationSchema"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SynchronizationSchema synchronizationSchemaToInitialize)
        {

            if (synchronizationSchemaToInitialize != null && synchronizationSchemaToInitialize.AdditionalData != null)
            {

                if (synchronizationSchemaToInitialize.Directories != null && synchronizationSchemaToInitialize.Directories.CurrentPage != null)
                {
                    synchronizationSchemaToInitialize.Directories.AdditionalData = synchronizationSchemaToInitialize.AdditionalData;

                    object nextPageLink;
                    synchronizationSchemaToInitialize.AdditionalData.TryGetValue("directories@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        synchronizationSchemaToInitialize.Directories.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
