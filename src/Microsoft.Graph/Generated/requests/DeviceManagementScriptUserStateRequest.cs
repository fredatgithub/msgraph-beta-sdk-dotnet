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
    /// The type DeviceManagementScriptUserStateRequest.
    /// </summary>
    public partial class DeviceManagementScriptUserStateRequest : BaseRequest, IDeviceManagementScriptUserStateRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementScriptUserStateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementScriptUserStateRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementScriptUserState using POST.
        /// </summary>
        /// <param name="deviceManagementScriptUserStateToCreate">The DeviceManagementScriptUserState to create.</param>
        /// <returns>The created DeviceManagementScriptUserState.</returns>
        public System.Threading.Tasks.Task<DeviceManagementScriptUserState> CreateAsync(DeviceManagementScriptUserState deviceManagementScriptUserStateToCreate)
        {
            return this.CreateAsync(deviceManagementScriptUserStateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementScriptUserState using POST.
        /// </summary>
        /// <param name="deviceManagementScriptUserStateToCreate">The DeviceManagementScriptUserState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScriptUserState.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptUserState> CreateAsync(DeviceManagementScriptUserState deviceManagementScriptUserStateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceManagementScriptUserState>(deviceManagementScriptUserStateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementScriptUserState using POST and returns a <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptUserStateToCreate">The DeviceManagementScriptUserState to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptUserState>> CreateResponseAsync(DeviceManagementScriptUserState deviceManagementScriptUserStateToCreate)
        {
            return this.CreateResponseAsync(deviceManagementScriptUserStateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementScriptUserState using POST and returns a <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptUserStateToCreate">The DeviceManagementScriptUserState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptUserState>> CreateResponseAsync(DeviceManagementScriptUserState deviceManagementScriptUserStateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceManagementScriptUserState>(deviceManagementScriptUserStateToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScriptUserState.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScriptUserState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceManagementScriptUserState>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScriptUserState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScriptUserState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceManagementScriptUserState.
        /// </summary>
        /// <returns>The DeviceManagementScriptUserState.</returns>
        public System.Threading.Tasks.Task<DeviceManagementScriptUserState> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementScriptUserState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScriptUserState.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptUserState> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceManagementScriptUserState>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementScriptUserState and returns a <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptUserState>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementScriptUserState and returns a <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptUserState>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DeviceManagementScriptUserState>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptUserState using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptUserStateToUpdate">The DeviceManagementScriptUserState to update.</param>
        /// <returns>The updated DeviceManagementScriptUserState.</returns>
        public System.Threading.Tasks.Task<DeviceManagementScriptUserState> UpdateAsync(DeviceManagementScriptUserState deviceManagementScriptUserStateToUpdate)
        {
            return this.UpdateAsync(deviceManagementScriptUserStateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptUserState using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptUserStateToUpdate">The DeviceManagementScriptUserState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementScriptUserState.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptUserState> UpdateAsync(DeviceManagementScriptUserState deviceManagementScriptUserStateToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementScriptUserStateToUpdate.AdditionalData != null)
			{
				if (deviceManagementScriptUserStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementScriptUserStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementScriptUserStateToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementScriptUserStateToUpdate.AdditionalData != null)
            {
                if (deviceManagementScriptUserStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementScriptUserStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementScriptUserStateToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceManagementScriptUserState>(deviceManagementScriptUserStateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptUserState using PATCH and returns a <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptUserStateToUpdate">The DeviceManagementScriptUserState to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptUserState>> UpdateResponseAsync(DeviceManagementScriptUserState deviceManagementScriptUserStateToUpdate)
        {
            return this.UpdateResponseAsync(deviceManagementScriptUserStateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptUserState using PATCH and returns a <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptUserStateToUpdate">The DeviceManagementScriptUserState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptUserState}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptUserState>> UpdateResponseAsync(DeviceManagementScriptUserState deviceManagementScriptUserStateToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementScriptUserStateToUpdate.AdditionalData != null)
			{
				if (deviceManagementScriptUserStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementScriptUserStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementScriptUserStateToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementScriptUserStateToUpdate.AdditionalData != null)
            {
                if (deviceManagementScriptUserStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementScriptUserStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementScriptUserStateToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceManagementScriptUserState>(deviceManagementScriptUserStateToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptUserStateRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptUserStateRequest Expand(Expression<Func<DeviceManagementScriptUserState, object>> expandExpression)
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
        public IDeviceManagementScriptUserStateRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptUserStateRequest Select(Expression<Func<DeviceManagementScriptUserState, object>> selectExpression)
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
        /// <param name="deviceManagementScriptUserStateToInitialize">The <see cref="DeviceManagementScriptUserState"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementScriptUserState deviceManagementScriptUserStateToInitialize)
        {

            if (deviceManagementScriptUserStateToInitialize != null && deviceManagementScriptUserStateToInitialize.AdditionalData != null)
            {

                if (deviceManagementScriptUserStateToInitialize.DeviceRunStates != null && deviceManagementScriptUserStateToInitialize.DeviceRunStates.CurrentPage != null)
                {
                    deviceManagementScriptUserStateToInitialize.DeviceRunStates.AdditionalData = deviceManagementScriptUserStateToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementScriptUserStateToInitialize.AdditionalData.TryGetValue("deviceRunStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementScriptUserStateToInitialize.DeviceRunStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
