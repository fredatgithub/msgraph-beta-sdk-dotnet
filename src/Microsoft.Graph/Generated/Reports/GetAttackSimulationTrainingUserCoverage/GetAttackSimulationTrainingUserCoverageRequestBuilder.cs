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
namespace Microsoft.Graph.Beta.Reports.GetAttackSimulationTrainingUserCoverage
{
    /// <summary>
    /// Provides operations to call the getAttackSimulationTrainingUserCoverage method.
    /// </summary>
    public class GetAttackSimulationTrainingUserCoverageRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="GetAttackSimulationTrainingUserCoverageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetAttackSimulationTrainingUserCoverageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/getAttackSimulationTrainingUserCoverage(){?%24count,%24filter,%24search,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GetAttackSimulationTrainingUserCoverageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetAttackSimulationTrainingUserCoverageRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/getAttackSimulationTrainingUserCoverage(){?%24count,%24filter,%24search,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// List training coverage for each user of a tenant in attack simulation and training campaigns. This function supports @odata.nextLink for pagination.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/reportroot-getattacksimulationtrainingusercoverage?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="GetAttackSimulationTrainingUserCoverageGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This report function api is deprecated and will stop returning data on August 20, 2022. Api is now moved to /reports/security. Please use the new API. as of 2022-05/Tasks_And_Plans")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetAttackSimulationTrainingUserCoverageGetResponse?> GetAsGetAttackSimulationTrainingUserCoverageGetResponseAsync(Action<RequestConfiguration<GetAttackSimulationTrainingUserCoverageRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<GetAttackSimulationTrainingUserCoverageGetResponse> GetAsGetAttackSimulationTrainingUserCoverageGetResponseAsync(Action<RequestConfiguration<GetAttackSimulationTrainingUserCoverageRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<GetAttackSimulationTrainingUserCoverageGetResponse>(requestInfo, GetAttackSimulationTrainingUserCoverageGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List training coverage for each user of a tenant in attack simulation and training campaigns. This function supports @odata.nextLink for pagination.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/reportroot-getattacksimulationtrainingusercoverage?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="GetAttackSimulationTrainingUserCoverageResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetAttackSimulationTrainingUserCoverageGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetAttackSimulationTrainingUserCoverageResponse?> GetAsync(Action<RequestConfiguration<GetAttackSimulationTrainingUserCoverageRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<GetAttackSimulationTrainingUserCoverageResponse> GetAsync(Action<RequestConfiguration<GetAttackSimulationTrainingUserCoverageRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<GetAttackSimulationTrainingUserCoverageResponse>(requestInfo, GetAttackSimulationTrainingUserCoverageResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List training coverage for each user of a tenant in attack simulation and training campaigns. This function supports @odata.nextLink for pagination.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This report function api is deprecated and will stop returning data on August 20, 2022. Api is now moved to /reports/security. Please use the new API. as of 2022-05/Tasks_And_Plans")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GetAttackSimulationTrainingUserCoverageRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GetAttackSimulationTrainingUserCoverageRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="GetAttackSimulationTrainingUserCoverageRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("This report function api is deprecated and will stop returning data on August 20, 2022. Api is now moved to /reports/security. Please use the new API. as of 2022-05/Tasks_And_Plans")]
        public GetAttackSimulationTrainingUserCoverageRequestBuilder WithUrl(string rawUrl)
        {
            return new GetAttackSimulationTrainingUserCoverageRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List training coverage for each user of a tenant in attack simulation and training campaigns. This function supports @odata.nextLink for pagination.
        /// </summary>
        public class GetAttackSimulationTrainingUserCoverageRequestBuilderGetQueryParameters 
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
        public class GetAttackSimulationTrainingUserCoverageRequestBuilderGetRequestConfiguration : RequestConfiguration<GetAttackSimulationTrainingUserCoverageRequestBuilderGetQueryParameters>
        {
        }
    }
}
