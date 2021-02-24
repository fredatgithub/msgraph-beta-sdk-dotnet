// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type DeviceManagementReportsGetConfigurationPolicyDevicesReportRequest.
    /// </summary>
    public partial class DeviceManagementReportsGetConfigurationPolicyDevicesReportRequest : BaseRequest, IDeviceManagementReportsGetConfigurationPolicyDevicesReportRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementReportsGetConfigurationPolicyDevicesReportRequest.
        /// </summary>
        public DeviceManagementReportsGetConfigurationPolicyDevicesReportRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.RequestBody = new DeviceManagementReportsGetConfigurationPolicyDevicesReportRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public DeviceManagementReportsGetConfigurationPolicyDevicesReportRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="httpCompletionOption">The <see cref="HttpCompletionOption"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<Stream> PostAsync(
            CancellationToken cancellationToken = default(CancellationToken),
            HttpCompletionOption httpCompletionOption = HttpCompletionOption.ResponseContentRead)
        {
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendStreamRequestAsync(null, cancellationToken, httpCompletionOption);
        }

        /// <summary>
        /// Issues the POST request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse> PostResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse(this.RequestBody, cancellationToken);
        }


    }
}
