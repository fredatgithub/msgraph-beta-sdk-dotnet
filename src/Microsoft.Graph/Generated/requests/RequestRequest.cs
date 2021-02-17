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
    /// The type RequestRequest.
    /// </summary>
    public partial class RequestRequest : BaseRequest, IRequestRequest
    {
        /// <summary>
        /// Constructs a new RequestRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public RequestRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified RequestObject using POST.
        /// </summary>
        /// <param name="requestObjectToCreate">The RequestObject to create.</param>
        /// <returns>The created RequestObject.</returns>
        public System.Threading.Tasks.Task<RequestObject> CreateAsync(RequestObject requestObjectToCreate)
        {
            return this.CreateAsync(requestObjectToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RequestObject using POST.
        /// </summary>
        /// <param name="requestObjectToCreate">The RequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RequestObject.</returns>
        public async System.Threading.Tasks.Task<RequestObject> CreateAsync(RequestObject requestObjectToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<RequestObject>(requestObjectToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified RequestObject using POST and returns a <see cref="GraphResponse{RequestObject}"/> object.
        /// </summary>
        /// <param name="requestObjectToCreate">The RequestObject to create.</param>
        /// <returns>The <see cref="GraphResponse{RequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RequestObject>> CreateResponseAsync(RequestObject requestObjectToCreate)
        {
            return this.CreateResponseAsync(requestObjectToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RequestObject using POST and returns a <see cref="GraphResponse{RequestObject}"/> object.
        /// </summary>
        /// <param name="requestObjectToCreate">The RequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RequestObject}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<RequestObject>> CreateResponseAsync(RequestObject requestObjectToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<RequestObject>(requestObjectToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Request.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<RequestObject>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified RequestObject.
        /// </summary>
        /// <returns>The RequestObject.</returns>
        public System.Threading.Tasks.Task<RequestObject> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified RequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RequestObject.</returns>
        public async System.Threading.Tasks.Task<RequestObject> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<RequestObject>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified RequestObject and returns a <see cref="GraphResponse{RequestObject}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{RequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RequestObject>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified RequestObject and returns a <see cref="GraphResponse{RequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RequestObject}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<RequestObject>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<RequestObject>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified RequestObject using PATCH.
        /// </summary>
        /// <param name="requestObjectToUpdate">The RequestObject to update.</param>
        /// <returns>The updated RequestObject.</returns>
        public System.Threading.Tasks.Task<RequestObject> UpdateAsync(RequestObject requestObjectToUpdate)
        {
            return this.UpdateAsync(requestObjectToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified RequestObject using PATCH.
        /// </summary>
        /// <param name="requestObjectToUpdate">The RequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RequestObject.</returns>
        public async System.Threading.Tasks.Task<RequestObject> UpdateAsync(RequestObject requestObjectToUpdate, CancellationToken cancellationToken)
        {
			if (requestObjectToUpdate.AdditionalData != null)
			{
				if (requestObjectToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					requestObjectToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, requestObjectToUpdate.GetType().Name)
						});
				}
			}
            if (requestObjectToUpdate.AdditionalData != null)
            {
                if (requestObjectToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    requestObjectToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, requestObjectToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<RequestObject>(requestObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified RequestObject using PATCH and returns a <see cref="GraphResponse{RequestObject}"/> object.
        /// </summary>
        /// <param name="requestObjectToUpdate">The RequestObject to update.</param>
        /// <returns>The <see cref="GraphResponse{RequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RequestObject>> UpdateResponseAsync(RequestObject requestObjectToUpdate)
        {
            return this.UpdateResponseAsync(requestObjectToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified RequestObject using PATCH and returns a <see cref="GraphResponse{RequestObject}"/> object.
        /// </summary>
        /// <param name="requestObjectToUpdate">The RequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RequestObject}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<RequestObject>> UpdateResponseAsync(RequestObject requestObjectToUpdate, CancellationToken cancellationToken)
        {
			if (requestObjectToUpdate.AdditionalData != null)
			{
				if (requestObjectToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					requestObjectToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, requestObjectToUpdate.GetType().Name)
						});
				}
			}
            if (requestObjectToUpdate.AdditionalData != null)
            {
                if (requestObjectToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    requestObjectToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, requestObjectToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<RequestObject>(requestObjectToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRequestRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRequestRequest Expand(Expression<Func<RequestObject, object>> expandExpression)
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
        public IRequestRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IRequestRequest Select(Expression<Func<RequestObject, object>> selectExpression)
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
        /// <param name="requestObjectToInitialize">The <see cref="RequestObject"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(RequestObject requestObjectToInitialize)
        {

        }
    }
}
