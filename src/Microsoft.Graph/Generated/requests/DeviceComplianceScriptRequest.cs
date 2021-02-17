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
    /// The type DeviceComplianceScriptRequest.
    /// </summary>
    public partial class DeviceComplianceScriptRequest : BaseRequest, IDeviceComplianceScriptRequest
    {
        /// <summary>
        /// Constructs a new DeviceComplianceScriptRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceComplianceScriptRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceComplianceScript using POST.
        /// </summary>
        /// <param name="deviceComplianceScriptToCreate">The DeviceComplianceScript to create.</param>
        /// <returns>The created DeviceComplianceScript.</returns>
        public System.Threading.Tasks.Task<DeviceComplianceScript> CreateAsync(DeviceComplianceScript deviceComplianceScriptToCreate)
        {
            return this.CreateAsync(deviceComplianceScriptToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceComplianceScript using POST.
        /// </summary>
        /// <param name="deviceComplianceScriptToCreate">The DeviceComplianceScript to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceScript.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceScript> CreateAsync(DeviceComplianceScript deviceComplianceScriptToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceComplianceScript>(deviceComplianceScriptToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceComplianceScript using POST and returns a <see cref="GraphResponse{DeviceComplianceScript}"/> object.
        /// </summary>
        /// <param name="deviceComplianceScriptToCreate">The DeviceComplianceScript to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScript}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScript>> CreateResponseAsync(DeviceComplianceScript deviceComplianceScriptToCreate)
        {
            return this.CreateResponseAsync(deviceComplianceScriptToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceComplianceScript using POST and returns a <see cref="GraphResponse{DeviceComplianceScript}"/> object.
        /// </summary>
        /// <param name="deviceComplianceScriptToCreate">The DeviceComplianceScript to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScript}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScript>> CreateResponseAsync(DeviceComplianceScript deviceComplianceScriptToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceComplianceScript>(deviceComplianceScriptToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceScript.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceComplianceScript>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceScript and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceScript and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceComplianceScript.
        /// </summary>
        /// <returns>The DeviceComplianceScript.</returns>
        public System.Threading.Tasks.Task<DeviceComplianceScript> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceComplianceScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComplianceScript.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceScript> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceComplianceScript>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceComplianceScript and returns a <see cref="GraphResponse{DeviceComplianceScript}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScript}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScript>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceComplianceScript and returns a <see cref="GraphResponse{DeviceComplianceScript}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScript}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScript>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DeviceComplianceScript>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DeviceComplianceScript using PATCH.
        /// </summary>
        /// <param name="deviceComplianceScriptToUpdate">The DeviceComplianceScript to update.</param>
        /// <returns>The updated DeviceComplianceScript.</returns>
        public System.Threading.Tasks.Task<DeviceComplianceScript> UpdateAsync(DeviceComplianceScript deviceComplianceScriptToUpdate)
        {
            return this.UpdateAsync(deviceComplianceScriptToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceComplianceScript using PATCH.
        /// </summary>
        /// <param name="deviceComplianceScriptToUpdate">The DeviceComplianceScript to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceComplianceScript.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceScript> UpdateAsync(DeviceComplianceScript deviceComplianceScriptToUpdate, CancellationToken cancellationToken)
        {
			if (deviceComplianceScriptToUpdate.AdditionalData != null)
			{
				if (deviceComplianceScriptToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceComplianceScriptToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceScriptToUpdate.GetType().Name)
						});
				}
			}
            if (deviceComplianceScriptToUpdate.AdditionalData != null)
            {
                if (deviceComplianceScriptToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceComplianceScriptToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceScriptToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceComplianceScript>(deviceComplianceScriptToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceComplianceScript using PATCH and returns a <see cref="GraphResponse{DeviceComplianceScript}"/> object.
        /// </summary>
        /// <param name="deviceComplianceScriptToUpdate">The DeviceComplianceScript to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScript}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScript>> UpdateResponseAsync(DeviceComplianceScript deviceComplianceScriptToUpdate)
        {
            return this.UpdateResponseAsync(deviceComplianceScriptToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceComplianceScript using PATCH and returns a <see cref="GraphResponse{DeviceComplianceScript}"/> object.
        /// </summary>
        /// <param name="deviceComplianceScriptToUpdate">The DeviceComplianceScript to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScript}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScript>> UpdateResponseAsync(DeviceComplianceScript deviceComplianceScriptToUpdate, CancellationToken cancellationToken)
        {
			if (deviceComplianceScriptToUpdate.AdditionalData != null)
			{
				if (deviceComplianceScriptToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceComplianceScriptToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceScriptToUpdate.GetType().Name)
						});
				}
			}
            if (deviceComplianceScriptToUpdate.AdditionalData != null)
            {
                if (deviceComplianceScriptToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceComplianceScriptToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceScriptToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceComplianceScript>(deviceComplianceScriptToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceScriptRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceScriptRequest Expand(Expression<Func<DeviceComplianceScript, object>> expandExpression)
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
        public IDeviceComplianceScriptRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceScriptRequest Select(Expression<Func<DeviceComplianceScript, object>> selectExpression)
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
        /// <param name="deviceComplianceScriptToInitialize">The <see cref="DeviceComplianceScript"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceComplianceScript deviceComplianceScriptToInitialize)
        {

            if (deviceComplianceScriptToInitialize != null && deviceComplianceScriptToInitialize.AdditionalData != null)
            {

                if (deviceComplianceScriptToInitialize.Assignments != null && deviceComplianceScriptToInitialize.Assignments.CurrentPage != null)
                {
                    deviceComplianceScriptToInitialize.Assignments.AdditionalData = deviceComplianceScriptToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceComplianceScriptToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceComplianceScriptToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceComplianceScriptToInitialize.DeviceRunStates != null && deviceComplianceScriptToInitialize.DeviceRunStates.CurrentPage != null)
                {
                    deviceComplianceScriptToInitialize.DeviceRunStates.AdditionalData = deviceComplianceScriptToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceComplianceScriptToInitialize.AdditionalData.TryGetValue("deviceRunStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceComplianceScriptToInitialize.DeviceRunStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
