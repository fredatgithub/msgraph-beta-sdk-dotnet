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
    /// The type RiskyUserHistoryItemRequest.
    /// </summary>
    public partial class RiskyUserHistoryItemRequest : BaseRequest, IRiskyUserHistoryItemRequest
    {
        /// <summary>
        /// Constructs a new RiskyUserHistoryItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public RiskyUserHistoryItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified RiskyUserHistoryItem using POST.
        /// </summary>
        /// <param name="riskyUserHistoryItemToCreate">The RiskyUserHistoryItem to create.</param>
        /// <returns>The created RiskyUserHistoryItem.</returns>
        public System.Threading.Tasks.Task<RiskyUserHistoryItem> CreateAsync(RiskyUserHistoryItem riskyUserHistoryItemToCreate)
        {
            return this.CreateAsync(riskyUserHistoryItemToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RiskyUserHistoryItem using POST.
        /// </summary>
        /// <param name="riskyUserHistoryItemToCreate">The RiskyUserHistoryItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RiskyUserHistoryItem.</returns>
        public async System.Threading.Tasks.Task<RiskyUserHistoryItem> CreateAsync(RiskyUserHistoryItem riskyUserHistoryItemToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<RiskyUserHistoryItem>(riskyUserHistoryItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified RiskyUserHistoryItem using POST and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <param name="riskyUserHistoryItemToCreate">The RiskyUserHistoryItem to create.</param>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> CreateResponseAsync(RiskyUserHistoryItem riskyUserHistoryItemToCreate)
        {
            return this.CreateResponseAsync(riskyUserHistoryItemToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RiskyUserHistoryItem using POST and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <param name="riskyUserHistoryItemToCreate">The RiskyUserHistoryItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> CreateResponseAsync(RiskyUserHistoryItem riskyUserHistoryItemToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<RiskyUserHistoryItem>(riskyUserHistoryItemToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified RiskyUserHistoryItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified RiskyUserHistoryItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<RiskyUserHistoryItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified RiskyUserHistoryItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified RiskyUserHistoryItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified RiskyUserHistoryItem.
        /// </summary>
        /// <returns>The RiskyUserHistoryItem.</returns>
        public System.Threading.Tasks.Task<RiskyUserHistoryItem> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified RiskyUserHistoryItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RiskyUserHistoryItem.</returns>
        public async System.Threading.Tasks.Task<RiskyUserHistoryItem> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<RiskyUserHistoryItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified RiskyUserHistoryItem and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified RiskyUserHistoryItem and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<RiskyUserHistoryItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified RiskyUserHistoryItem using PATCH.
        /// </summary>
        /// <param name="riskyUserHistoryItemToUpdate">The RiskyUserHistoryItem to update.</param>
        /// <returns>The updated RiskyUserHistoryItem.</returns>
        public System.Threading.Tasks.Task<RiskyUserHistoryItem> UpdateAsync(RiskyUserHistoryItem riskyUserHistoryItemToUpdate)
        {
            return this.UpdateAsync(riskyUserHistoryItemToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified RiskyUserHistoryItem using PATCH.
        /// </summary>
        /// <param name="riskyUserHistoryItemToUpdate">The RiskyUserHistoryItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RiskyUserHistoryItem.</returns>
        public async System.Threading.Tasks.Task<RiskyUserHistoryItem> UpdateAsync(RiskyUserHistoryItem riskyUserHistoryItemToUpdate, CancellationToken cancellationToken)
        {
			if (riskyUserHistoryItemToUpdate.AdditionalData != null)
			{
				if (riskyUserHistoryItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					riskyUserHistoryItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, riskyUserHistoryItemToUpdate.GetType().Name)
						});
				}
			}
            if (riskyUserHistoryItemToUpdate.AdditionalData != null)
            {
                if (riskyUserHistoryItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    riskyUserHistoryItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, riskyUserHistoryItemToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<RiskyUserHistoryItem>(riskyUserHistoryItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified RiskyUserHistoryItem using PATCH and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <param name="riskyUserHistoryItemToUpdate">The RiskyUserHistoryItem to update.</param>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> UpdateResponseAsync(RiskyUserHistoryItem riskyUserHistoryItemToUpdate)
        {
            return this.UpdateResponseAsync(riskyUserHistoryItemToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified RiskyUserHistoryItem using PATCH and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <param name="riskyUserHistoryItemToUpdate">The RiskyUserHistoryItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> UpdateResponseAsync(RiskyUserHistoryItem riskyUserHistoryItemToUpdate, CancellationToken cancellationToken)
        {
			if (riskyUserHistoryItemToUpdate.AdditionalData != null)
			{
				if (riskyUserHistoryItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					riskyUserHistoryItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, riskyUserHistoryItemToUpdate.GetType().Name)
						});
				}
			}
            if (riskyUserHistoryItemToUpdate.AdditionalData != null)
            {
                if (riskyUserHistoryItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    riskyUserHistoryItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, riskyUserHistoryItemToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<RiskyUserHistoryItem>(riskyUserHistoryItemToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyUserHistoryItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyUserHistoryItemRequest Expand(Expression<Func<RiskyUserHistoryItem, object>> expandExpression)
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
        public IRiskyUserHistoryItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyUserHistoryItemRequest Select(Expression<Func<RiskyUserHistoryItem, object>> selectExpression)
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
        /// <param name="riskyUserHistoryItemToInitialize">The <see cref="RiskyUserHistoryItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(RiskyUserHistoryItem riskyUserHistoryItemToInitialize)
        {

        }
    }
}
