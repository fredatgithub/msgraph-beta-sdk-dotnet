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
    /// The type UrlAssessmentRequestRequest.
    /// </summary>
    public partial class UrlAssessmentRequestRequest : BaseRequest, IUrlAssessmentRequestRequest
    {
        /// <summary>
        /// Constructs a new UrlAssessmentRequestRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UrlAssessmentRequestRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UrlAssessmentRequestObject using POST.
        /// </summary>
        /// <param name="urlAssessmentRequestObjectToCreate">The UrlAssessmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UrlAssessmentRequestObject.</returns>
        public async System.Threading.Tasks.Task<UrlAssessmentRequestObject> CreateAsync(UrlAssessmentRequestObject urlAssessmentRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<UrlAssessmentRequestObject>(urlAssessmentRequestObjectToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UrlAssessmentRequestObject using POST and returns a <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object.
        /// </summary>
        /// <param name="urlAssessmentRequestObjectToCreate">The UrlAssessmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UrlAssessmentRequestObject>> CreateResponseAsync(UrlAssessmentRequestObject urlAssessmentRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<UrlAssessmentRequestObject>(urlAssessmentRequestObjectToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UrlAssessmentRequest.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<UrlAssessmentRequestObject>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UrlAssessmentRequest and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UrlAssessmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UrlAssessmentRequestObject.</returns>
        public async System.Threading.Tasks.Task<UrlAssessmentRequestObject> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<UrlAssessmentRequestObject>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UrlAssessmentRequestObject and returns a <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UrlAssessmentRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<UrlAssessmentRequestObject>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UrlAssessmentRequestObject using PATCH.
        /// </summary>
        /// <param name="urlAssessmentRequestObjectToUpdate">The UrlAssessmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UrlAssessmentRequestObject.</returns>
        public async System.Threading.Tasks.Task<UrlAssessmentRequestObject> UpdateAsync(UrlAssessmentRequestObject urlAssessmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<UrlAssessmentRequestObject>(urlAssessmentRequestObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UrlAssessmentRequestObject using PATCH and returns a <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object.
        /// </summary>
        /// <param name="urlAssessmentRequestObjectToUpdate">The UrlAssessmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UrlAssessmentRequestObject>> UpdateResponseAsync(UrlAssessmentRequestObject urlAssessmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<UrlAssessmentRequestObject>(urlAssessmentRequestObjectToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUrlAssessmentRequestRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUrlAssessmentRequestRequest Expand(Expression<Func<UrlAssessmentRequestObject, object>> expandExpression)
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
        public IUrlAssessmentRequestRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUrlAssessmentRequestRequest Select(Expression<Func<UrlAssessmentRequestObject, object>> selectExpression)
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
        /// <param name="urlAssessmentRequestObjectToInitialize">The <see cref="UrlAssessmentRequestObject"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UrlAssessmentRequestObject urlAssessmentRequestObjectToInitialize)
        {

        }
    }
}
