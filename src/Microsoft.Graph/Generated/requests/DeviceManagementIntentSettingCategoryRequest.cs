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
    /// The type DeviceManagementIntentSettingCategoryRequest.
    /// </summary>
    public partial class DeviceManagementIntentSettingCategoryRequest : BaseRequest, IDeviceManagementIntentSettingCategoryRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementIntentSettingCategoryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementIntentSettingCategoryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementIntentSettingCategory using POST.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToCreate">The DeviceManagementIntentSettingCategory to create.</param>
        /// <returns>The created DeviceManagementIntentSettingCategory.</returns>
        public System.Threading.Tasks.Task<DeviceManagementIntentSettingCategory> CreateAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToCreate)
        {
            return this.CreateAsync(deviceManagementIntentSettingCategoryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementIntentSettingCategory using POST.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToCreate">The DeviceManagementIntentSettingCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementIntentSettingCategory.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntentSettingCategory> CreateAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceManagementIntentSettingCategory>(deviceManagementIntentSettingCategoryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementIntentSettingCategory using POST and returns a <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToCreate">The DeviceManagementIntentSettingCategory to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentSettingCategory>> CreateResponseAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToCreate)
        {
            return this.CreateResponseAsync(deviceManagementIntentSettingCategoryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementIntentSettingCategory using POST and returns a <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToCreate">The DeviceManagementIntentSettingCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentSettingCategory>> CreateResponseAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceManagementIntentSettingCategory>(deviceManagementIntentSettingCategoryToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementIntentSettingCategory.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementIntentSettingCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceManagementIntentSettingCategory>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementIntentSettingCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementIntentSettingCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceManagementIntentSettingCategory.
        /// </summary>
        /// <returns>The DeviceManagementIntentSettingCategory.</returns>
        public System.Threading.Tasks.Task<DeviceManagementIntentSettingCategory> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementIntentSettingCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementIntentSettingCategory.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntentSettingCategory> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceManagementIntentSettingCategory>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementIntentSettingCategory and returns a <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentSettingCategory>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementIntentSettingCategory and returns a <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentSettingCategory>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DeviceManagementIntentSettingCategory>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntentSettingCategory using PATCH.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToUpdate">The DeviceManagementIntentSettingCategory to update.</param>
        /// <returns>The updated DeviceManagementIntentSettingCategory.</returns>
        public System.Threading.Tasks.Task<DeviceManagementIntentSettingCategory> UpdateAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToUpdate)
        {
            return this.UpdateAsync(deviceManagementIntentSettingCategoryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntentSettingCategory using PATCH.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToUpdate">The DeviceManagementIntentSettingCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementIntentSettingCategory.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntentSettingCategory> UpdateAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementIntentSettingCategoryToUpdate.AdditionalData != null)
			{
				if (deviceManagementIntentSettingCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementIntentSettingCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementIntentSettingCategoryToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementIntentSettingCategoryToUpdate.AdditionalData != null)
            {
                if (deviceManagementIntentSettingCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementIntentSettingCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementIntentSettingCategoryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceManagementIntentSettingCategory>(deviceManagementIntentSettingCategoryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntentSettingCategory using PATCH and returns a <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToUpdate">The DeviceManagementIntentSettingCategory to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentSettingCategory>> UpdateResponseAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToUpdate)
        {
            return this.UpdateResponseAsync(deviceManagementIntentSettingCategoryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntentSettingCategory using PATCH and returns a <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToUpdate">The DeviceManagementIntentSettingCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentSettingCategory>> UpdateResponseAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementIntentSettingCategoryToUpdate.AdditionalData != null)
			{
				if (deviceManagementIntentSettingCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementIntentSettingCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementIntentSettingCategoryToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementIntentSettingCategoryToUpdate.AdditionalData != null)
            {
                if (deviceManagementIntentSettingCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementIntentSettingCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementIntentSettingCategoryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceManagementIntentSettingCategory>(deviceManagementIntentSettingCategoryToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementIntentSettingCategoryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementIntentSettingCategoryRequest Expand(Expression<Func<DeviceManagementIntentSettingCategory, object>> expandExpression)
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
        public IDeviceManagementIntentSettingCategoryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementIntentSettingCategoryRequest Select(Expression<Func<DeviceManagementIntentSettingCategory, object>> selectExpression)
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
        /// <param name="deviceManagementIntentSettingCategoryToInitialize">The <see cref="DeviceManagementIntentSettingCategory"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToInitialize)
        {

            if (deviceManagementIntentSettingCategoryToInitialize != null && deviceManagementIntentSettingCategoryToInitialize.AdditionalData != null)
            {

                if (deviceManagementIntentSettingCategoryToInitialize.Settings != null && deviceManagementIntentSettingCategoryToInitialize.Settings.CurrentPage != null)
                {
                    deviceManagementIntentSettingCategoryToInitialize.Settings.AdditionalData = deviceManagementIntentSettingCategoryToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementIntentSettingCategoryToInitialize.AdditionalData.TryGetValue("settings@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementIntentSettingCategoryToInitialize.Settings.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
