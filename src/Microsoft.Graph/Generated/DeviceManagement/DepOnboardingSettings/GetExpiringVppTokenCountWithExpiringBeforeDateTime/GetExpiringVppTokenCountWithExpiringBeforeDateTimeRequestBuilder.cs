// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.GetExpiringVppTokenCountWithExpiringBeforeDateTime
{
    /// <summary>
    /// Provides operations to call the getExpiringVppTokenCount method.
    /// </summary>
    public class GetExpiringVppTokenCountWithExpiringBeforeDateTimeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="GetExpiringVppTokenCountWithExpiringBeforeDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="expiringBeforeDateTime">Usage: expiringBeforeDateTime=&apos;{expiringBeforeDateTime}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetExpiringVppTokenCountWithExpiringBeforeDateTimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string expiringBeforeDateTime = "") : base(requestAdapter, "{+baseurl}/deviceManagement/depOnboardingSettings/getExpiringVppTokenCount(expiringBeforeDateTime='{expiringBeforeDateTime}')", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(expiringBeforeDateTime)) PathParameters.Add("expiringBeforeDateTime", expiringBeforeDateTime);
        }
        /// <summary>
        /// Instantiates a new <see cref="GetExpiringVppTokenCountWithExpiringBeforeDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetExpiringVppTokenCountWithExpiringBeforeDateTimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/depOnboardingSettings/getExpiringVppTokenCount(expiringBeforeDateTime='{expiringBeforeDateTime}')", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function getExpiringVppTokenCount
        /// </summary>
        /// <returns>A <see cref="GetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponse?> GetAsGetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<GetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponse> GetAsGetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<GetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponse>(requestInfo, GetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function getExpiringVppTokenCount
        /// </summary>
        /// <returns>A <see cref="GetExpiringVppTokenCountWithExpiringBeforeDateTimeResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetExpiringVppTokenCountWithExpiringBeforeDateTimeResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<GetExpiringVppTokenCountWithExpiringBeforeDateTimeResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<GetExpiringVppTokenCountWithExpiringBeforeDateTimeResponse>(requestInfo, GetExpiringVppTokenCountWithExpiringBeforeDateTimeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function getExpiringVppTokenCount
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="GetExpiringVppTokenCountWithExpiringBeforeDateTimeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetExpiringVppTokenCountWithExpiringBeforeDateTimeRequestBuilder WithUrl(string rawUrl)
        {
            return new GetExpiringVppTokenCountWithExpiringBeforeDateTimeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GetExpiringVppTokenCountWithExpiringBeforeDateTimeRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
