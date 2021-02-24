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
    /// The type DeviceManagementScriptRequest.
    /// </summary>
    public partial class DeviceManagementScriptRequest : BaseRequest, IDeviceManagementScriptRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementScriptRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementScriptRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementScript using POST.
        /// </summary>
        /// <param name="deviceManagementScriptToCreate">The DeviceManagementScript to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScript.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScript> CreateAsync(DeviceManagementScript deviceManagementScriptToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<DeviceManagementScript>(deviceManagementScriptToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementScript using POST and returns a <see cref="GraphResponse{DeviceManagementScript}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptToCreate">The DeviceManagementScript to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScript}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScript>> CreateResponseAsync(DeviceManagementScript deviceManagementScriptToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementScript>(deviceManagementScriptToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<DeviceManagementScript>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScript and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScript.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScript> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<DeviceManagementScript>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementScript and returns a <see cref="GraphResponse{DeviceManagementScript}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScript}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScript>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementScript>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementScript using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptToUpdate">The DeviceManagementScript to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementScript.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScript> UpdateAsync(DeviceManagementScript deviceManagementScriptToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<DeviceManagementScript>(deviceManagementScriptToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementScript using PATCH and returns a <see cref="GraphResponse{DeviceManagementScript}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptToUpdate">The DeviceManagementScript to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScript}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScript>> UpdateResponseAsync(DeviceManagementScript deviceManagementScriptToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementScript>(deviceManagementScriptToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptRequest Expand(Expression<Func<DeviceManagementScript, object>> expandExpression)
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
        public IDeviceManagementScriptRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptRequest Select(Expression<Func<DeviceManagementScript, object>> selectExpression)
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
        /// <param name="deviceManagementScriptToInitialize">The <see cref="DeviceManagementScript"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementScript deviceManagementScriptToInitialize)
        {

            if (deviceManagementScriptToInitialize != null && deviceManagementScriptToInitialize.AdditionalData != null)
            {

                if (deviceManagementScriptToInitialize.Assignments != null && deviceManagementScriptToInitialize.Assignments.CurrentPage != null)
                {
                    deviceManagementScriptToInitialize.Assignments.AdditionalData = deviceManagementScriptToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementScriptToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementScriptToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementScriptToInitialize.DeviceRunStates != null && deviceManagementScriptToInitialize.DeviceRunStates.CurrentPage != null)
                {
                    deviceManagementScriptToInitialize.DeviceRunStates.AdditionalData = deviceManagementScriptToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementScriptToInitialize.AdditionalData.TryGetValue("deviceRunStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementScriptToInitialize.DeviceRunStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementScriptToInitialize.GroupAssignments != null && deviceManagementScriptToInitialize.GroupAssignments.CurrentPage != null)
                {
                    deviceManagementScriptToInitialize.GroupAssignments.AdditionalData = deviceManagementScriptToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementScriptToInitialize.AdditionalData.TryGetValue("groupAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementScriptToInitialize.GroupAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementScriptToInitialize.UserRunStates != null && deviceManagementScriptToInitialize.UserRunStates.CurrentPage != null)
                {
                    deviceManagementScriptToInitialize.UserRunStates.AdditionalData = deviceManagementScriptToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementScriptToInitialize.AdditionalData.TryGetValue("userRunStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementScriptToInitialize.UserRunStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
