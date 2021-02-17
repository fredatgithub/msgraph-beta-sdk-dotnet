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
    /// The type DeviceManagementConfigurationPolicyAssignmentRequest.
    /// </summary>
    public partial class DeviceManagementConfigurationPolicyAssignmentRequest : BaseRequest, IDeviceManagementConfigurationPolicyAssignmentRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementConfigurationPolicyAssignmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementConfigurationPolicyAssignmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicyAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToCreate">The DeviceManagementConfigurationPolicyAssignment to create.</param>
        /// <returns>The created DeviceManagementConfigurationPolicyAssignment.</returns>
        public System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> CreateAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToCreate)
        {
            return this.CreateAsync(deviceManagementConfigurationPolicyAssignmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicyAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToCreate">The DeviceManagementConfigurationPolicyAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementConfigurationPolicyAssignment.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> CreateAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceManagementConfigurationPolicyAssignment>(deviceManagementConfigurationPolicyAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicyAssignment using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToCreate">The DeviceManagementConfigurationPolicyAssignment to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> CreateResponseAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToCreate)
        {
            return this.CreateResponseAsync(deviceManagementConfigurationPolicyAssignmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicyAssignment using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToCreate">The DeviceManagementConfigurationPolicyAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> CreateResponseAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicyAssignment>(deviceManagementConfigurationPolicyAssignmentToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicyAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicyAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceManagementConfigurationPolicyAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicyAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicyAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicyAssignment.
        /// </summary>
        /// <returns>The DeviceManagementConfigurationPolicyAssignment.</returns>
        public System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicyAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementConfigurationPolicyAssignment.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceManagementConfigurationPolicyAssignment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicyAssignment and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicyAssignment and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicyAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToUpdate">The DeviceManagementConfigurationPolicyAssignment to update.</param>
        /// <returns>The updated DeviceManagementConfigurationPolicyAssignment.</returns>
        public System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> UpdateAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToUpdate)
        {
            return this.UpdateAsync(deviceManagementConfigurationPolicyAssignmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToUpdate">The DeviceManagementConfigurationPolicyAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementConfigurationPolicyAssignment.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> UpdateAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData != null)
			{
				if (deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementConfigurationPolicyAssignmentToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData != null)
            {
                if (deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementConfigurationPolicyAssignmentToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceManagementConfigurationPolicyAssignment>(deviceManagementConfigurationPolicyAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyAssignment using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToUpdate">The DeviceManagementConfigurationPolicyAssignment to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> UpdateResponseAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToUpdate)
        {
            return this.UpdateResponseAsync(deviceManagementConfigurationPolicyAssignmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyAssignment using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToUpdate">The DeviceManagementConfigurationPolicyAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> UpdateResponseAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData != null)
			{
				if (deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementConfigurationPolicyAssignmentToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData != null)
            {
                if (deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementConfigurationPolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementConfigurationPolicyAssignmentToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicyAssignment>(deviceManagementConfigurationPolicyAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationPolicyAssignmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationPolicyAssignmentRequest Expand(Expression<Func<DeviceManagementConfigurationPolicyAssignment, object>> expandExpression)
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
        public IDeviceManagementConfigurationPolicyAssignmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationPolicyAssignmentRequest Select(Expression<Func<DeviceManagementConfigurationPolicyAssignment, object>> selectExpression)
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
        /// <param name="deviceManagementConfigurationPolicyAssignmentToInitialize">The <see cref="DeviceManagementConfigurationPolicyAssignment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToInitialize)
        {

        }
    }
}
