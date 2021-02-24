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
    /// The type DeviceManagementAbstractComplexSettingInstanceRequest.
    /// </summary>
    public partial class DeviceManagementAbstractComplexSettingInstanceRequest : BaseRequest, IDeviceManagementAbstractComplexSettingInstanceRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementAbstractComplexSettingInstanceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementAbstractComplexSettingInstanceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementAbstractComplexSettingInstance using POST.
        /// </summary>
        /// <param name="deviceManagementAbstractComplexSettingInstanceToCreate">The DeviceManagementAbstractComplexSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementAbstractComplexSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementAbstractComplexSettingInstance> CreateAsync(DeviceManagementAbstractComplexSettingInstance deviceManagementAbstractComplexSettingInstanceToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<DeviceManagementAbstractComplexSettingInstance>(deviceManagementAbstractComplexSettingInstanceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementAbstractComplexSettingInstance using POST and returns a <see cref="GraphResponse{DeviceManagementAbstractComplexSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementAbstractComplexSettingInstanceToCreate">The DeviceManagementAbstractComplexSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAbstractComplexSettingInstance}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementAbstractComplexSettingInstance>> CreateResponseAsync(DeviceManagementAbstractComplexSettingInstance deviceManagementAbstractComplexSettingInstanceToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementAbstractComplexSettingInstance>(deviceManagementAbstractComplexSettingInstanceToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementAbstractComplexSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<DeviceManagementAbstractComplexSettingInstance>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementAbstractComplexSettingInstance and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementAbstractComplexSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementAbstractComplexSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementAbstractComplexSettingInstance> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<DeviceManagementAbstractComplexSettingInstance>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementAbstractComplexSettingInstance and returns a <see cref="GraphResponse{DeviceManagementAbstractComplexSettingInstance}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAbstractComplexSettingInstance}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementAbstractComplexSettingInstance>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementAbstractComplexSettingInstance>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementAbstractComplexSettingInstance using PATCH.
        /// </summary>
        /// <param name="deviceManagementAbstractComplexSettingInstanceToUpdate">The DeviceManagementAbstractComplexSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementAbstractComplexSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementAbstractComplexSettingInstance> UpdateAsync(DeviceManagementAbstractComplexSettingInstance deviceManagementAbstractComplexSettingInstanceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<DeviceManagementAbstractComplexSettingInstance>(deviceManagementAbstractComplexSettingInstanceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementAbstractComplexSettingInstance using PATCH and returns a <see cref="GraphResponse{DeviceManagementAbstractComplexSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementAbstractComplexSettingInstanceToUpdate">The DeviceManagementAbstractComplexSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAbstractComplexSettingInstance}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementAbstractComplexSettingInstance>> UpdateResponseAsync(DeviceManagementAbstractComplexSettingInstance deviceManagementAbstractComplexSettingInstanceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementAbstractComplexSettingInstance>(deviceManagementAbstractComplexSettingInstanceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementAbstractComplexSettingInstanceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementAbstractComplexSettingInstanceRequest Expand(Expression<Func<DeviceManagementAbstractComplexSettingInstance, object>> expandExpression)
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
        public IDeviceManagementAbstractComplexSettingInstanceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementAbstractComplexSettingInstanceRequest Select(Expression<Func<DeviceManagementAbstractComplexSettingInstance, object>> selectExpression)
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
        /// <param name="deviceManagementAbstractComplexSettingInstanceToInitialize">The <see cref="DeviceManagementAbstractComplexSettingInstance"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementAbstractComplexSettingInstance deviceManagementAbstractComplexSettingInstanceToInitialize)
        {

            if (deviceManagementAbstractComplexSettingInstanceToInitialize != null && deviceManagementAbstractComplexSettingInstanceToInitialize.AdditionalData != null)
            {

                if (deviceManagementAbstractComplexSettingInstanceToInitialize.Value != null && deviceManagementAbstractComplexSettingInstanceToInitialize.Value.CurrentPage != null)
                {
                    deviceManagementAbstractComplexSettingInstanceToInitialize.Value.AdditionalData = deviceManagementAbstractComplexSettingInstanceToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementAbstractComplexSettingInstanceToInitialize.AdditionalData.TryGetValue("value@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementAbstractComplexSettingInstanceToInitialize.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
