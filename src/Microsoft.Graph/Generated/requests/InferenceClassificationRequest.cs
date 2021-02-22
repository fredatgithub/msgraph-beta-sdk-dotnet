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
    /// The type InferenceClassificationRequest.
    /// </summary>
    public partial class InferenceClassificationRequest : BaseRequest, IInferenceClassificationRequest
    {
        /// <summary>
        /// Constructs a new InferenceClassificationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public InferenceClassificationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified InferenceClassification using POST.
        /// </summary>
        /// <param name="inferenceClassificationToCreate">The InferenceClassification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created InferenceClassification.</returns>
        public async System.Threading.Tasks.Task<InferenceClassification> CreateAsync(InferenceClassification inferenceClassificationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<InferenceClassification>(inferenceClassificationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified InferenceClassification using POST and returns a <see cref="GraphResponse{InferenceClassification}"/> object.
        /// </summary>
        /// <param name="inferenceClassificationToCreate">The InferenceClassification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InferenceClassification}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<InferenceClassification>> CreateResponseAsync(InferenceClassification inferenceClassificationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<InferenceClassification>(inferenceClassificationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified InferenceClassification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<InferenceClassification>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified InferenceClassification and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified InferenceClassification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The InferenceClassification.</returns>
        public async System.Threading.Tasks.Task<InferenceClassification> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<InferenceClassification>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified InferenceClassification and returns a <see cref="GraphResponse{InferenceClassification}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InferenceClassification}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<InferenceClassification>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<InferenceClassification>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified InferenceClassification using PATCH.
        /// </summary>
        /// <param name="inferenceClassificationToUpdate">The InferenceClassification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated InferenceClassification.</returns>
        public async System.Threading.Tasks.Task<InferenceClassification> UpdateAsync(InferenceClassification inferenceClassificationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<InferenceClassification>(inferenceClassificationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified InferenceClassification using PATCH and returns a <see cref="GraphResponse{InferenceClassification}"/> object.
        /// </summary>
        /// <param name="inferenceClassificationToUpdate">The InferenceClassification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{InferenceClassification}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<InferenceClassification>> UpdateResponseAsync(InferenceClassification inferenceClassificationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<InferenceClassification>(inferenceClassificationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IInferenceClassificationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IInferenceClassificationRequest Expand(Expression<Func<InferenceClassification, object>> expandExpression)
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
        public IInferenceClassificationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IInferenceClassificationRequest Select(Expression<Func<InferenceClassification, object>> selectExpression)
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
        /// <param name="inferenceClassificationToInitialize">The <see cref="InferenceClassification"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(InferenceClassification inferenceClassificationToInitialize)
        {

            if (inferenceClassificationToInitialize != null && inferenceClassificationToInitialize.AdditionalData != null)
            {

                if (inferenceClassificationToInitialize.Overrides != null && inferenceClassificationToInitialize.Overrides.CurrentPage != null)
                {
                    inferenceClassificationToInitialize.Overrides.AdditionalData = inferenceClassificationToInitialize.AdditionalData;

                    object nextPageLink;
                    inferenceClassificationToInitialize.AdditionalData.TryGetValue("overrides@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        inferenceClassificationToInitialize.Overrides.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
