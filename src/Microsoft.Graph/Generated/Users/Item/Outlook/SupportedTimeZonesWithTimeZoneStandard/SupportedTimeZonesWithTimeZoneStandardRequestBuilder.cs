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
namespace Microsoft.Graph.Beta.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard
{
    /// <summary>
    /// Provides operations to call the supportedTimeZones method.
    /// </summary>
    public class SupportedTimeZonesWithTimeZoneStandardRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="SupportedTimeZonesWithTimeZoneStandardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="timeZoneStandard">Usage: TimeZoneStandard=&apos;{TimeZoneStandard}&apos;</param>
        public SupportedTimeZonesWithTimeZoneStandardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string timeZoneStandard = "") : base(requestAdapter, "{+baseurl}/users/{user%2Did}/outlook/supportedTimeZones(TimeZoneStandard='{TimeZoneStandard}'){?%24count,%24filter,%24search,%24skip,%24top}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(timeZoneStandard)) PathParameters.Add("TimeZoneStandard", timeZoneStandard);
        }
        /// <summary>
        /// Instantiates a new <see cref="SupportedTimeZonesWithTimeZoneStandardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SupportedTimeZonesWithTimeZoneStandardRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/outlook/supportedTimeZones(TimeZoneStandard='{TimeZoneStandard}'){?%24count,%24filter,%24search,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function supportedTimeZones
        /// </summary>
        /// <returns>A <see cref="SupportedTimeZonesWithTimeZoneStandardGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SupportedTimeZonesWithTimeZoneStandardGetResponse?> GetAsSupportedTimeZonesWithTimeZoneStandardGetResponseAsync(Action<RequestConfiguration<SupportedTimeZonesWithTimeZoneStandardRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<SupportedTimeZonesWithTimeZoneStandardGetResponse> GetAsSupportedTimeZonesWithTimeZoneStandardGetResponseAsync(Action<RequestConfiguration<SupportedTimeZonesWithTimeZoneStandardRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<SupportedTimeZonesWithTimeZoneStandardGetResponse>(requestInfo, SupportedTimeZonesWithTimeZoneStandardGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function supportedTimeZones
        /// </summary>
        /// <returns>A <see cref="SupportedTimeZonesWithTimeZoneStandardResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsSupportedTimeZonesWithTimeZoneStandardGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SupportedTimeZonesWithTimeZoneStandardResponse?> GetAsync(Action<RequestConfiguration<SupportedTimeZonesWithTimeZoneStandardRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<SupportedTimeZonesWithTimeZoneStandardResponse> GetAsync(Action<RequestConfiguration<SupportedTimeZonesWithTimeZoneStandardRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<SupportedTimeZonesWithTimeZoneStandardResponse>(requestInfo, SupportedTimeZonesWithTimeZoneStandardResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function supportedTimeZones
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SupportedTimeZonesWithTimeZoneStandardRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SupportedTimeZonesWithTimeZoneStandardRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="SupportedTimeZonesWithTimeZoneStandardRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SupportedTimeZonesWithTimeZoneStandardRequestBuilder WithUrl(string rawUrl)
        {
            return new SupportedTimeZonesWithTimeZoneStandardRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Invoke function supportedTimeZones
        /// </summary>
        public class SupportedTimeZonesWithTimeZoneStandardRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class SupportedTimeZonesWithTimeZoneStandardRequestBuilderGetRequestConfiguration : RequestConfiguration<SupportedTimeZonesWithTimeZoneStandardRequestBuilderGetQueryParameters>
        {
        }
    }
}
