// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.BulkReprovisionCloudPc {
    /// <summary>
    /// Provides operations to call the bulkReprovisionCloudPc method.
    /// </summary>
    public class BulkReprovisionCloudPcRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new BulkReprovisionCloudPcRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkReprovisionCloudPcRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/managedDevices/bulkReprovisionCloudPc", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new BulkReprovisionCloudPcRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkReprovisionCloudPcRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/managedDevices/bulkReprovisionCloudPc", rawUrl) {
        }
        /// <summary>
        /// Bulk reprovision a set of Cloud PC devices with Intune managed device IDs.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/manageddevice-bulkreprovisioncloudpc?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The bulkReprovisionCloudPc action is deprecated and will stop supporting on September 24, 2023. Please use bulk action entity api. as of 2023-05/bulkReprovisionCloudPc")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CloudPcBulkRemoteActionResult?> PostAsync(BulkReprovisionCloudPcPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CloudPcBulkRemoteActionResult> PostAsync(BulkReprovisionCloudPcPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CloudPcBulkRemoteActionResult>(requestInfo, CloudPcBulkRemoteActionResult.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Bulk reprovision a set of Cloud PC devices with Intune managed device IDs.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The bulkReprovisionCloudPc action is deprecated and will stop supporting on September 24, 2023. Please use bulk action entity api. as of 2023-05/bulkReprovisionCloudPc")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(BulkReprovisionCloudPcPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(BulkReprovisionCloudPcPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("The bulkReprovisionCloudPc action is deprecated and will stop supporting on September 24, 2023. Please use bulk action entity api. as of 2023-05/bulkReprovisionCloudPc")]
        public BulkReprovisionCloudPcRequestBuilder WithUrl(string rawUrl) {
            return new BulkReprovisionCloudPcRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class BulkReprovisionCloudPcRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
