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
    /// The type DeviceManagementSettingCategoryRequest.
    /// </summary>
    public partial class DeviceManagementSettingCategoryRequest : BaseRequest, IDeviceManagementSettingCategoryRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementSettingCategoryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementSettingCategoryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementSettingCategory using POST.
        /// </summary>
        /// <param name="deviceManagementSettingCategoryToCreate">The DeviceManagementSettingCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementSettingCategory.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementSettingCategory> CreateAsync(DeviceManagementSettingCategory deviceManagementSettingCategoryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<DeviceManagementSettingCategory>(deviceManagementSettingCategoryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementSettingCategory using POST and returns a <see cref="GraphResponse{DeviceManagementSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementSettingCategoryToCreate">The DeviceManagementSettingCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementSettingCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementSettingCategory>> CreateResponseAsync(DeviceManagementSettingCategory deviceManagementSettingCategoryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementSettingCategory>(deviceManagementSettingCategoryToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementSettingCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<DeviceManagementSettingCategory>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementSettingCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementSettingCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementSettingCategory.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementSettingCategory> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<DeviceManagementSettingCategory>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementSettingCategory and returns a <see cref="GraphResponse{DeviceManagementSettingCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementSettingCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementSettingCategory>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementSettingCategory>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementSettingCategory using PATCH.
        /// </summary>
        /// <param name="deviceManagementSettingCategoryToUpdate">The DeviceManagementSettingCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementSettingCategory.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementSettingCategory> UpdateAsync(DeviceManagementSettingCategory deviceManagementSettingCategoryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<DeviceManagementSettingCategory>(deviceManagementSettingCategoryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementSettingCategory using PATCH and returns a <see cref="GraphResponse{DeviceManagementSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementSettingCategoryToUpdate">The DeviceManagementSettingCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementSettingCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementSettingCategory>> UpdateResponseAsync(DeviceManagementSettingCategory deviceManagementSettingCategoryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementSettingCategory>(deviceManagementSettingCategoryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementSettingCategoryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementSettingCategoryRequest Expand(Expression<Func<DeviceManagementSettingCategory, object>> expandExpression)
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
        public IDeviceManagementSettingCategoryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementSettingCategoryRequest Select(Expression<Func<DeviceManagementSettingCategory, object>> selectExpression)
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
        /// <param name="deviceManagementSettingCategoryToInitialize">The <see cref="DeviceManagementSettingCategory"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementSettingCategory deviceManagementSettingCategoryToInitialize)
        {

            if (deviceManagementSettingCategoryToInitialize != null && deviceManagementSettingCategoryToInitialize.AdditionalData != null)
            {

                if (deviceManagementSettingCategoryToInitialize.SettingDefinitions != null && deviceManagementSettingCategoryToInitialize.SettingDefinitions.CurrentPage != null)
                {
                    deviceManagementSettingCategoryToInitialize.SettingDefinitions.AdditionalData = deviceManagementSettingCategoryToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementSettingCategoryToInitialize.AdditionalData.TryGetValue("settingDefinitions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementSettingCategoryToInitialize.SettingDefinitions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
