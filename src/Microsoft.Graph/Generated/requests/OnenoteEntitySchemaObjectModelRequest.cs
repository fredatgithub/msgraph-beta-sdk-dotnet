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
    /// The type OnenoteEntitySchemaObjectModelRequest.
    /// </summary>
    public partial class OnenoteEntitySchemaObjectModelRequest : BaseRequest, IOnenoteEntitySchemaObjectModelRequest
    {
        /// <summary>
        /// Constructs a new OnenoteEntitySchemaObjectModelRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OnenoteEntitySchemaObjectModelRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OnenoteEntitySchemaObjectModel using POST.
        /// </summary>
        /// <param name="onenoteEntitySchemaObjectModelToCreate">The OnenoteEntitySchemaObjectModel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteEntitySchemaObjectModel.</returns>
        public async System.Threading.Tasks.Task<OnenoteEntitySchemaObjectModel> CreateAsync(OnenoteEntitySchemaObjectModel onenoteEntitySchemaObjectModelToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<OnenoteEntitySchemaObjectModel>(onenoteEntitySchemaObjectModelToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OnenoteEntitySchemaObjectModel using POST and returns a <see cref="GraphResponse{OnenoteEntitySchemaObjectModel}"/> object.
        /// </summary>
        /// <param name="onenoteEntitySchemaObjectModelToCreate">The OnenoteEntitySchemaObjectModel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteEntitySchemaObjectModel}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnenoteEntitySchemaObjectModel>> CreateResponseAsync(OnenoteEntitySchemaObjectModel onenoteEntitySchemaObjectModelToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<OnenoteEntitySchemaObjectModel>(onenoteEntitySchemaObjectModelToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified OnenoteEntitySchemaObjectModel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<OnenoteEntitySchemaObjectModel>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OnenoteEntitySchemaObjectModel and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified OnenoteEntitySchemaObjectModel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnenoteEntitySchemaObjectModel.</returns>
        public async System.Threading.Tasks.Task<OnenoteEntitySchemaObjectModel> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<OnenoteEntitySchemaObjectModel>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified OnenoteEntitySchemaObjectModel and returns a <see cref="GraphResponse{OnenoteEntitySchemaObjectModel}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteEntitySchemaObjectModel}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnenoteEntitySchemaObjectModel>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<OnenoteEntitySchemaObjectModel>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OnenoteEntitySchemaObjectModel using PATCH.
        /// </summary>
        /// <param name="onenoteEntitySchemaObjectModelToUpdate">The OnenoteEntitySchemaObjectModel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnenoteEntitySchemaObjectModel.</returns>
        public async System.Threading.Tasks.Task<OnenoteEntitySchemaObjectModel> UpdateAsync(OnenoteEntitySchemaObjectModel onenoteEntitySchemaObjectModelToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<OnenoteEntitySchemaObjectModel>(onenoteEntitySchemaObjectModelToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OnenoteEntitySchemaObjectModel using PATCH and returns a <see cref="GraphResponse{OnenoteEntitySchemaObjectModel}"/> object.
        /// </summary>
        /// <param name="onenoteEntitySchemaObjectModelToUpdate">The OnenoteEntitySchemaObjectModel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OnenoteEntitySchemaObjectModel}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnenoteEntitySchemaObjectModel>> UpdateResponseAsync(OnenoteEntitySchemaObjectModel onenoteEntitySchemaObjectModelToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<OnenoteEntitySchemaObjectModel>(onenoteEntitySchemaObjectModelToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteEntitySchemaObjectModelRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteEntitySchemaObjectModelRequest Expand(Expression<Func<OnenoteEntitySchemaObjectModel, object>> expandExpression)
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
        public IOnenoteEntitySchemaObjectModelRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteEntitySchemaObjectModelRequest Select(Expression<Func<OnenoteEntitySchemaObjectModel, object>> selectExpression)
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
        /// <param name="onenoteEntitySchemaObjectModelToInitialize">The <see cref="OnenoteEntitySchemaObjectModel"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OnenoteEntitySchemaObjectModel onenoteEntitySchemaObjectModelToInitialize)
        {

        }
    }
}
