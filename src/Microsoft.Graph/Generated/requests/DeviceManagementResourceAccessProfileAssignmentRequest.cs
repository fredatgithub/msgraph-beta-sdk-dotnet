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
    /// The type DeviceManagementResourceAccessProfileAssignmentRequest.
    /// </summary>
    public partial class DeviceManagementResourceAccessProfileAssignmentRequest : BaseRequest, IDeviceManagementResourceAccessProfileAssignmentRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementResourceAccessProfileAssignmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementResourceAccessProfileAssignmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementResourceAccessProfileAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToCreate">The DeviceManagementResourceAccessProfileAssignment to create.</param>
        /// <returns>The created DeviceManagementResourceAccessProfileAssignment.</returns>
        public System.Threading.Tasks.Task<DeviceManagementResourceAccessProfileAssignment> CreateAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToCreate)
        {
            return this.CreateAsync(deviceManagementResourceAccessProfileAssignmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementResourceAccessProfileAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToCreate">The DeviceManagementResourceAccessProfileAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementResourceAccessProfileAssignment.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementResourceAccessProfileAssignment> CreateAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceManagementResourceAccessProfileAssignment>(deviceManagementResourceAccessProfileAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementResourceAccessProfileAssignment using POST and returns a <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToCreate">The DeviceManagementResourceAccessProfileAssignment to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementResourceAccessProfileAssignment>> CreateResponseAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToCreate)
        {
            return this.CreateResponseAsync(deviceManagementResourceAccessProfileAssignmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementResourceAccessProfileAssignment using POST and returns a <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToCreate">The DeviceManagementResourceAccessProfileAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementResourceAccessProfileAssignment>> CreateResponseAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceManagementResourceAccessProfileAssignment>(deviceManagementResourceAccessProfileAssignmentToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementResourceAccessProfileAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementResourceAccessProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceManagementResourceAccessProfileAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementResourceAccessProfileAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementResourceAccessProfileAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceManagementResourceAccessProfileAssignment.
        /// </summary>
        /// <returns>The DeviceManagementResourceAccessProfileAssignment.</returns>
        public System.Threading.Tasks.Task<DeviceManagementResourceAccessProfileAssignment> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementResourceAccessProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementResourceAccessProfileAssignment.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementResourceAccessProfileAssignment> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceManagementResourceAccessProfileAssignment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementResourceAccessProfileAssignment and returns a <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementResourceAccessProfileAssignment>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementResourceAccessProfileAssignment and returns a <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementResourceAccessProfileAssignment>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DeviceManagementResourceAccessProfileAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DeviceManagementResourceAccessProfileAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToUpdate">The DeviceManagementResourceAccessProfileAssignment to update.</param>
        /// <returns>The updated DeviceManagementResourceAccessProfileAssignment.</returns>
        public System.Threading.Tasks.Task<DeviceManagementResourceAccessProfileAssignment> UpdateAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToUpdate)
        {
            return this.UpdateAsync(deviceManagementResourceAccessProfileAssignmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementResourceAccessProfileAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToUpdate">The DeviceManagementResourceAccessProfileAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementResourceAccessProfileAssignment.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementResourceAccessProfileAssignment> UpdateAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData != null)
			{
				if (deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementResourceAccessProfileAssignmentToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData != null)
            {
                if (deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementResourceAccessProfileAssignmentToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceManagementResourceAccessProfileAssignment>(deviceManagementResourceAccessProfileAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementResourceAccessProfileAssignment using PATCH and returns a <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToUpdate">The DeviceManagementResourceAccessProfileAssignment to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementResourceAccessProfileAssignment>> UpdateResponseAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToUpdate)
        {
            return this.UpdateResponseAsync(deviceManagementResourceAccessProfileAssignmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementResourceAccessProfileAssignment using PATCH and returns a <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToUpdate">The DeviceManagementResourceAccessProfileAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementResourceAccessProfileAssignment>> UpdateResponseAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData != null)
			{
				if (deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementResourceAccessProfileAssignmentToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData != null)
            {
                if (deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementResourceAccessProfileAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementResourceAccessProfileAssignmentToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceManagementResourceAccessProfileAssignment>(deviceManagementResourceAccessProfileAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementResourceAccessProfileAssignmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementResourceAccessProfileAssignmentRequest Expand(Expression<Func<DeviceManagementResourceAccessProfileAssignment, object>> expandExpression)
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
        public IDeviceManagementResourceAccessProfileAssignmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementResourceAccessProfileAssignmentRequest Select(Expression<Func<DeviceManagementResourceAccessProfileAssignment, object>> selectExpression)
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
        /// <param name="deviceManagementResourceAccessProfileAssignmentToInitialize">The <see cref="DeviceManagementResourceAccessProfileAssignment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToInitialize)
        {

        }
    }
}
