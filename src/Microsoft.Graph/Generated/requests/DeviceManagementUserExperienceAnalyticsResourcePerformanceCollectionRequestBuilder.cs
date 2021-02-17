// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementUserExperienceAnalyticsResourcePerformanceCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementUserExperienceAnalyticsResourcePerformanceCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementUserExperienceAnalyticsResourcePerformanceCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementUserExperienceAnalyticsResourcePerformanceCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementUserExperienceAnalyticsResourcePerformanceCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsResourcePerformanceCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsResourcePerformanceCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementUserExperienceAnalyticsResourcePerformanceCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsResourcePerformanceRequestBuilder"/> for the specified DeviceManagementUserExperienceAnalyticsResourcePerformance.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementUserExperienceAnalyticsResourcePerformance.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsResourcePerformanceRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsResourcePerformanceRequestBuilder this[string id]
        {
            get
            {
                return new UserExperienceAnalyticsResourcePerformanceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserExperienceAnalyticsResourcePerformanceSummarizeDeviceResourcePerformance.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsResourcePerformanceSummarizeDeviceResourcePerformanceRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsResourcePerformanceSummarizeDeviceResourcePerformanceRequestBuilder SummarizeDeviceResourcePerformance(
            UserExperienceAnalyticsSummarizedBy summarizeBy)
        {
            return new UserExperienceAnalyticsResourcePerformanceSummarizeDeviceResourcePerformanceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.summarizeDeviceResourcePerformance"),
                this.Client,
                summarizeBy);
        }
    }
}
