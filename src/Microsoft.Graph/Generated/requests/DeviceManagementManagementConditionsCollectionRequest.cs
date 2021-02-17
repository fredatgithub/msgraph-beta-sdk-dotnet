// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DeviceManagementManagementConditionsCollectionRequest.
    /// </summary>
    public partial class DeviceManagementManagementConditionsCollectionRequest : BaseRequest, IDeviceManagementManagementConditionsCollectionRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementManagementConditionsCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementManagementConditionsCollectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        
        /// <summary>
        /// Adds the specified ManagementCondition to the collection via POST.
        /// </summary>
        /// <param name="managementCondition">The ManagementCondition to add.</param>
        /// <returns>The created ManagementCondition.</returns>
        public System.Threading.Tasks.Task<ManagementCondition> AddAsync(ManagementCondition managementCondition)
        {
            return this.AddAsync(managementCondition, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified ManagementCondition to the collection via POST.
        /// </summary>
        /// <param name="managementCondition">The ManagementCondition to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagementCondition.</returns>
        public System.Threading.Tasks.Task<ManagementCondition> AddAsync(ManagementCondition managementCondition, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            managementCondition.ODataType = string.Concat("#", StringHelper.ConvertTypeToLowerCamelCase(managementCondition.GetType().FullName));
            return this.SendAsync<ManagementCondition>(managementCondition, cancellationToken);
        }

        
        /// <summary>
        /// Adds the specified ManagementCondition to the collection via POST and returns a <see cref="GraphResponse{ManagementCondition}"/> object of the request.
        /// </summary>
        /// <param name="managementCondition">The ManagementCondition to add.</param>
        /// <returns>The <see cref="GraphResponse{ManagementCondition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagementCondition>> AddResponseAsync(ManagementCondition managementCondition)
        {
            return this.AddResponseAsync(managementCondition, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified ManagementCondition to the collection via POST and returns a <see cref="GraphResponse{ManagementCondition}"/> object of the request.
        /// </summary>
        /// <param name="managementCondition">The ManagementCondition to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementCondition}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ManagementCondition>> AddResponseAsync(ManagementCondition managementCondition, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            managementCondition.ODataType = string.Concat("#", StringHelper.ConvertTypeToLowerCamelCase(managementCondition.GetType().FullName));
            return await this.SendAsyncWithGraphResponse<ManagementCondition>(managementCondition, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        public System.Threading.Tasks.Task<IDeviceManagementManagementConditionsCollectionPage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async System.Threading.Tasks.Task<IDeviceManagementManagementConditionsCollectionPage> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var response = await this.SendAsync<DeviceManagementManagementConditionsCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }

                    // Copy the additional data collection to the page itself so that information is not lost
                    response.Value.AdditionalData = response.AdditionalData;
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceManagementManagementConditionsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementManagementConditionsCollectionResponse}"/> object.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementManagementConditionsCollectionResponse>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceManagementManagementConditionsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementManagementConditionsCollectionResponse}"/> object.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementManagementConditionsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DeviceManagementManagementConditionsCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementManagementConditionsCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementManagementConditionsCollectionRequest Expand(Expression<Func<ManagementCondition, object>> expandExpression)
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
        public IDeviceManagementManagementConditionsCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementManagementConditionsCollectionRequest Select(Expression<Func<ManagementCondition, object>> selectExpression)
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
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementManagementConditionsCollectionRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementManagementConditionsCollectionRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementManagementConditionsCollectionRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementManagementConditionsCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
