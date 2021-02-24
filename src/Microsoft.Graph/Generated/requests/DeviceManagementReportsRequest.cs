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
    /// The type DeviceManagementReportsRequest.
    /// </summary>
    public partial class DeviceManagementReportsRequest : BaseRequest, IDeviceManagementReportsRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementReportsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementReportsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementReports using POST.
        /// </summary>
        /// <param name="deviceManagementReportsToCreate">The DeviceManagementReports to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementReports.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementReports> CreateAsync(DeviceManagementReports deviceManagementReportsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<DeviceManagementReports>(deviceManagementReportsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementReports using POST and returns a <see cref="GraphResponse{DeviceManagementReports}"/> object.
        /// </summary>
        /// <param name="deviceManagementReportsToCreate">The DeviceManagementReports to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementReports}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementReports>> CreateResponseAsync(DeviceManagementReports deviceManagementReportsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementReports>(deviceManagementReportsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementReports.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<DeviceManagementReports>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementReports and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementReports.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementReports.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementReports> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<DeviceManagementReports>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementReports and returns a <see cref="GraphResponse{DeviceManagementReports}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementReports}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementReports>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementReports>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementReports using PATCH.
        /// </summary>
        /// <param name="deviceManagementReportsToUpdate">The DeviceManagementReports to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementReports.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementReports> UpdateAsync(DeviceManagementReports deviceManagementReportsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<DeviceManagementReports>(deviceManagementReportsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementReports using PATCH and returns a <see cref="GraphResponse{DeviceManagementReports}"/> object.
        /// </summary>
        /// <param name="deviceManagementReportsToUpdate">The DeviceManagementReports to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementReports}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementReports>> UpdateResponseAsync(DeviceManagementReports deviceManagementReportsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<DeviceManagementReports>(deviceManagementReportsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementReportsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementReportsRequest Expand(Expression<Func<DeviceManagementReports, object>> expandExpression)
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
        public IDeviceManagementReportsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementReportsRequest Select(Expression<Func<DeviceManagementReports, object>> selectExpression)
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
        /// <param name="deviceManagementReportsToInitialize">The <see cref="DeviceManagementReports"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementReports deviceManagementReportsToInitialize)
        {

            if (deviceManagementReportsToInitialize != null && deviceManagementReportsToInitialize.AdditionalData != null)
            {

                if (deviceManagementReportsToInitialize.CachedReportConfigurations != null && deviceManagementReportsToInitialize.CachedReportConfigurations.CurrentPage != null)
                {
                    deviceManagementReportsToInitialize.CachedReportConfigurations.AdditionalData = deviceManagementReportsToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementReportsToInitialize.AdditionalData.TryGetValue("cachedReportConfigurations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementReportsToInitialize.CachedReportConfigurations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementReportsToInitialize.ExportJobs != null && deviceManagementReportsToInitialize.ExportJobs.CurrentPage != null)
                {
                    deviceManagementReportsToInitialize.ExportJobs.AdditionalData = deviceManagementReportsToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementReportsToInitialize.AdditionalData.TryGetValue("exportJobs@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementReportsToInitialize.ExportJobs.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementReportsToInitialize.ReportSchedules != null && deviceManagementReportsToInitialize.ReportSchedules.CurrentPage != null)
                {
                    deviceManagementReportsToInitialize.ReportSchedules.AdditionalData = deviceManagementReportsToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementReportsToInitialize.AdditionalData.TryGetValue("reportSchedules@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementReportsToInitialize.ReportSchedules.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
