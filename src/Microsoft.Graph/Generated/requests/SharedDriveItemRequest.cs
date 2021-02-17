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
    /// The type SharedDriveItemRequest.
    /// </summary>
    public partial class SharedDriveItemRequest : BaseRequest, ISharedDriveItemRequest
    {
        /// <summary>
        /// Constructs a new SharedDriveItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SharedDriveItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SharedDriveItem using POST.
        /// </summary>
        /// <param name="sharedDriveItemToCreate">The SharedDriveItem to create.</param>
        /// <returns>The created SharedDriveItem.</returns>
        public System.Threading.Tasks.Task<SharedDriveItem> CreateAsync(SharedDriveItem sharedDriveItemToCreate)
        {
            return this.CreateAsync(sharedDriveItemToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SharedDriveItem using POST.
        /// </summary>
        /// <param name="sharedDriveItemToCreate">The SharedDriveItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharedDriveItem.</returns>
        public async System.Threading.Tasks.Task<SharedDriveItem> CreateAsync(SharedDriveItem sharedDriveItemToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SharedDriveItem>(sharedDriveItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SharedDriveItem using POST and returns a <see cref="GraphResponse{SharedDriveItem}"/> object.
        /// </summary>
        /// <param name="sharedDriveItemToCreate">The SharedDriveItem to create.</param>
        /// <returns>The <see cref="GraphResponse{SharedDriveItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedDriveItem>> CreateResponseAsync(SharedDriveItem sharedDriveItemToCreate)
        {
            return this.CreateResponseAsync(sharedDriveItemToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SharedDriveItem using POST and returns a <see cref="GraphResponse{SharedDriveItem}"/> object.
        /// </summary>
        /// <param name="sharedDriveItemToCreate">The SharedDriveItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedDriveItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SharedDriveItem>> CreateResponseAsync(SharedDriveItem sharedDriveItemToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<SharedDriveItem>(sharedDriveItemToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SharedDriveItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SharedDriveItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<SharedDriveItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SharedDriveItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SharedDriveItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SharedDriveItem.
        /// </summary>
        /// <returns>The SharedDriveItem.</returns>
        public System.Threading.Tasks.Task<SharedDriveItem> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SharedDriveItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharedDriveItem.</returns>
        public async System.Threading.Tasks.Task<SharedDriveItem> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SharedDriveItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SharedDriveItem and returns a <see cref="GraphResponse{SharedDriveItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SharedDriveItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedDriveItem>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SharedDriveItem and returns a <see cref="GraphResponse{SharedDriveItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedDriveItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SharedDriveItem>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<SharedDriveItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified SharedDriveItem using PATCH.
        /// </summary>
        /// <param name="sharedDriveItemToUpdate">The SharedDriveItem to update.</param>
        /// <returns>The updated SharedDriveItem.</returns>
        public System.Threading.Tasks.Task<SharedDriveItem> UpdateAsync(SharedDriveItem sharedDriveItemToUpdate)
        {
            return this.UpdateAsync(sharedDriveItemToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SharedDriveItem using PATCH.
        /// </summary>
        /// <param name="sharedDriveItemToUpdate">The SharedDriveItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SharedDriveItem.</returns>
        public async System.Threading.Tasks.Task<SharedDriveItem> UpdateAsync(SharedDriveItem sharedDriveItemToUpdate, CancellationToken cancellationToken)
        {
			if (sharedDriveItemToUpdate.AdditionalData != null)
			{
				if (sharedDriveItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					sharedDriveItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, sharedDriveItemToUpdate.GetType().Name)
						});
				}
			}
            if (sharedDriveItemToUpdate.AdditionalData != null)
            {
                if (sharedDriveItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    sharedDriveItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, sharedDriveItemToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SharedDriveItem>(sharedDriveItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SharedDriveItem using PATCH and returns a <see cref="GraphResponse{SharedDriveItem}"/> object.
        /// </summary>
        /// <param name="sharedDriveItemToUpdate">The SharedDriveItem to update.</param>
        /// <returns>The <see cref="GraphResponse{SharedDriveItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedDriveItem>> UpdateResponseAsync(SharedDriveItem sharedDriveItemToUpdate)
        {
            return this.UpdateResponseAsync(sharedDriveItemToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SharedDriveItem using PATCH and returns a <see cref="GraphResponse{SharedDriveItem}"/> object.
        /// </summary>
        /// <param name="sharedDriveItemToUpdate">The SharedDriveItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SharedDriveItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SharedDriveItem>> UpdateResponseAsync(SharedDriveItem sharedDriveItemToUpdate, CancellationToken cancellationToken)
        {
			if (sharedDriveItemToUpdate.AdditionalData != null)
			{
				if (sharedDriveItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					sharedDriveItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, sharedDriveItemToUpdate.GetType().Name)
						});
				}
			}
            if (sharedDriveItemToUpdate.AdditionalData != null)
            {
                if (sharedDriveItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    sharedDriveItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, sharedDriveItemToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<SharedDriveItem>(sharedDriveItemToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISharedDriveItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISharedDriveItemRequest Expand(Expression<Func<SharedDriveItem, object>> expandExpression)
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
        public ISharedDriveItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISharedDriveItemRequest Select(Expression<Func<SharedDriveItem, object>> selectExpression)
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
        /// <param name="sharedDriveItemToInitialize">The <see cref="SharedDriveItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SharedDriveItem sharedDriveItemToInitialize)
        {

            if (sharedDriveItemToInitialize != null && sharedDriveItemToInitialize.AdditionalData != null)
            {

                if (sharedDriveItemToInitialize.Items != null && sharedDriveItemToInitialize.Items.CurrentPage != null)
                {
                    sharedDriveItemToInitialize.Items.AdditionalData = sharedDriveItemToInitialize.AdditionalData;

                    object nextPageLink;
                    sharedDriveItemToInitialize.AdditionalData.TryGetValue("items@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        sharedDriveItemToInitialize.Items.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
