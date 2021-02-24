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
    /// The type DeviceConfigurationUserStatusRequest.
    /// </summary>
    public partial class DeviceConfigurationUserStatusRequest : BaseRequest, IDeviceConfigurationUserStatusRequest
    {
        /// <summary>
        /// Constructs a new DeviceConfigurationUserStatusRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceConfigurationUserStatusRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceConfigurationUserStatus using POST.
        /// </summary>
        /// <param name="deviceConfigurationUserStatusToCreate">The DeviceConfigurationUserStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationUserStatus.</returns>
        public async System.Threading.Tasks.Task<DeviceConfigurationUserStatus> CreateAsync(DeviceConfigurationUserStatus deviceConfigurationUserStatusToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<DeviceConfigurationUserStatus>(deviceConfigurationUserStatusToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceConfigurationUserStatus using POST and returns a <see cref="GraphResponse{DeviceConfigurationUserStatus}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationUserStatusToCreate">The DeviceConfigurationUserStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationUserStatus}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationUserStatus>> CreateResponseAsync(DeviceConfigurationUserStatus deviceConfigurationUserStatusToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<DeviceConfigurationUserStatus>(deviceConfigurationUserStatusToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceConfigurationUserStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<DeviceConfigurationUserStatus>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceConfigurationUserStatus and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceConfigurationUserStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationUserStatus.</returns>
        public async System.Threading.Tasks.Task<DeviceConfigurationUserStatus> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<DeviceConfigurationUserStatus>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceConfigurationUserStatus and returns a <see cref="GraphResponse{DeviceConfigurationUserStatus}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationUserStatus}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationUserStatus>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<DeviceConfigurationUserStatus>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceConfigurationUserStatus using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationUserStatusToUpdate">The DeviceConfigurationUserStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceConfigurationUserStatus.</returns>
        public async System.Threading.Tasks.Task<DeviceConfigurationUserStatus> UpdateAsync(DeviceConfigurationUserStatus deviceConfigurationUserStatusToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<DeviceConfigurationUserStatus>(deviceConfigurationUserStatusToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceConfigurationUserStatus using PATCH and returns a <see cref="GraphResponse{DeviceConfigurationUserStatus}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationUserStatusToUpdate">The DeviceConfigurationUserStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationUserStatus}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationUserStatus>> UpdateResponseAsync(DeviceConfigurationUserStatus deviceConfigurationUserStatusToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<DeviceConfigurationUserStatus>(deviceConfigurationUserStatusToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceConfigurationUserStatusRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceConfigurationUserStatusRequest Expand(Expression<Func<DeviceConfigurationUserStatus, object>> expandExpression)
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
        public IDeviceConfigurationUserStatusRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceConfigurationUserStatusRequest Select(Expression<Func<DeviceConfigurationUserStatus, object>> selectExpression)
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
        /// <param name="deviceConfigurationUserStatusToInitialize">The <see cref="DeviceConfigurationUserStatus"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceConfigurationUserStatus deviceConfigurationUserStatusToInitialize)
        {

        }
    }
}
