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
    /// The type SideLoadingKeyRequest.
    /// </summary>
    public partial class SideLoadingKeyRequest : BaseRequest, ISideLoadingKeyRequest
    {
        /// <summary>
        /// Constructs a new SideLoadingKeyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SideLoadingKeyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SideLoadingKey using POST.
        /// </summary>
        /// <param name="sideLoadingKeyToCreate">The SideLoadingKey to create.</param>
        /// <returns>The created SideLoadingKey.</returns>
        public System.Threading.Tasks.Task<SideLoadingKey> CreateAsync(SideLoadingKey sideLoadingKeyToCreate)
        {
            return this.CreateAsync(sideLoadingKeyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SideLoadingKey using POST.
        /// </summary>
        /// <param name="sideLoadingKeyToCreate">The SideLoadingKey to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SideLoadingKey.</returns>
        public async System.Threading.Tasks.Task<SideLoadingKey> CreateAsync(SideLoadingKey sideLoadingKeyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SideLoadingKey>(sideLoadingKeyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SideLoadingKey using POST and returns a <see cref="GraphResponse{SideLoadingKey}"/> object.
        /// </summary>
        /// <param name="sideLoadingKeyToCreate">The SideLoadingKey to create.</param>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> CreateResponseAsync(SideLoadingKey sideLoadingKeyToCreate)
        {
            return this.CreateResponseAsync(sideLoadingKeyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SideLoadingKey using POST and returns a <see cref="GraphResponse{SideLoadingKey}"/> object.
        /// </summary>
        /// <param name="sideLoadingKeyToCreate">The SideLoadingKey to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> CreateResponseAsync(SideLoadingKey sideLoadingKeyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<SideLoadingKey>(sideLoadingKeyToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SideLoadingKey.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SideLoadingKey.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<SideLoadingKey>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SideLoadingKey and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SideLoadingKey and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SideLoadingKey.
        /// </summary>
        /// <returns>The SideLoadingKey.</returns>
        public System.Threading.Tasks.Task<SideLoadingKey> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SideLoadingKey.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SideLoadingKey.</returns>
        public async System.Threading.Tasks.Task<SideLoadingKey> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SideLoadingKey>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SideLoadingKey and returns a <see cref="GraphResponse{SideLoadingKey}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SideLoadingKey and returns a <see cref="GraphResponse{SideLoadingKey}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<SideLoadingKey>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified SideLoadingKey using PATCH.
        /// </summary>
        /// <param name="sideLoadingKeyToUpdate">The SideLoadingKey to update.</param>
        /// <returns>The updated SideLoadingKey.</returns>
        public System.Threading.Tasks.Task<SideLoadingKey> UpdateAsync(SideLoadingKey sideLoadingKeyToUpdate)
        {
            return this.UpdateAsync(sideLoadingKeyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SideLoadingKey using PATCH.
        /// </summary>
        /// <param name="sideLoadingKeyToUpdate">The SideLoadingKey to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SideLoadingKey.</returns>
        public async System.Threading.Tasks.Task<SideLoadingKey> UpdateAsync(SideLoadingKey sideLoadingKeyToUpdate, CancellationToken cancellationToken)
        {
			if (sideLoadingKeyToUpdate.AdditionalData != null)
			{
				if (sideLoadingKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					sideLoadingKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, sideLoadingKeyToUpdate.GetType().Name)
						});
				}
			}
            if (sideLoadingKeyToUpdate.AdditionalData != null)
            {
                if (sideLoadingKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    sideLoadingKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, sideLoadingKeyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SideLoadingKey>(sideLoadingKeyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SideLoadingKey using PATCH and returns a <see cref="GraphResponse{SideLoadingKey}"/> object.
        /// </summary>
        /// <param name="sideLoadingKeyToUpdate">The SideLoadingKey to update.</param>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> UpdateResponseAsync(SideLoadingKey sideLoadingKeyToUpdate)
        {
            return this.UpdateResponseAsync(sideLoadingKeyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SideLoadingKey using PATCH and returns a <see cref="GraphResponse{SideLoadingKey}"/> object.
        /// </summary>
        /// <param name="sideLoadingKeyToUpdate">The SideLoadingKey to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> UpdateResponseAsync(SideLoadingKey sideLoadingKeyToUpdate, CancellationToken cancellationToken)
        {
			if (sideLoadingKeyToUpdate.AdditionalData != null)
			{
				if (sideLoadingKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					sideLoadingKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, sideLoadingKeyToUpdate.GetType().Name)
						});
				}
			}
            if (sideLoadingKeyToUpdate.AdditionalData != null)
            {
                if (sideLoadingKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    sideLoadingKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, sideLoadingKeyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<SideLoadingKey>(sideLoadingKeyToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISideLoadingKeyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISideLoadingKeyRequest Expand(Expression<Func<SideLoadingKey, object>> expandExpression)
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
        public ISideLoadingKeyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISideLoadingKeyRequest Select(Expression<Func<SideLoadingKey, object>> selectExpression)
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
        /// <param name="sideLoadingKeyToInitialize">The <see cref="SideLoadingKey"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SideLoadingKey sideLoadingKeyToInitialize)
        {

        }
    }
}
