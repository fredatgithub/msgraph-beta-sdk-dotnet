// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Places.Item.GraphRoomList.Rooms;
using Microsoft.Graph.Beta.Places.Item.GraphRoomList.RoomsWithPlaceId;
using Microsoft.Graph.Beta.Places.Item.GraphRoomList.Workspaces;
using Microsoft.Graph.Beta.Places.Item.GraphRoomList.WorkspacesWithPlaceId;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Places.Item.GraphRoomList
{
    /// <summary>
    /// Casts the previous resource to roomList.
    /// </summary>
    public class GraphRoomListRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the rooms property of the microsoft.graph.roomList entity.</summary>
        public RoomsRequestBuilder Rooms
        {
            get => new RoomsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the workspaces property of the microsoft.graph.roomList entity.</summary>
        public WorkspacesRequestBuilder Workspaces
        {
            get => new WorkspacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="GraphRoomListRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GraphRoomListRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/places/{place%2Did}/graph.roomList{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GraphRoomListRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GraphRoomListRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/places/{place%2Did}/graph.roomList{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get the item of type microsoft.graph.place as microsoft.graph.roomList
        /// </summary>
        /// <returns>A <see cref="RoomList"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RoomList?> GetAsync(Action<RequestConfiguration<GraphRoomListRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<RoomList> GetAsync(Action<RequestConfiguration<GraphRoomListRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<RoomList>(requestInfo, RoomList.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to manage the rooms property of the microsoft.graph.roomList entity.
        /// </summary>
        /// <returns>A <see cref="RoomsWithPlaceIdRequestBuilder"/></returns>
        /// <param name="placeId">Alternate key of room</param>
        public RoomsWithPlaceIdRequestBuilder RoomsWithPlaceId(string placeId)
        {
            if(string.IsNullOrEmpty(placeId)) throw new ArgumentNullException(nameof(placeId));
            return new RoomsWithPlaceIdRequestBuilder(PathParameters, RequestAdapter, placeId);
        }
        /// <summary>
        /// Get the item of type microsoft.graph.place as microsoft.graph.roomList
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GraphRoomListRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GraphRoomListRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="GraphRoomListRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GraphRoomListRequestBuilder WithUrl(string rawUrl)
        {
            return new GraphRoomListRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to manage the workspaces property of the microsoft.graph.roomList entity.
        /// </summary>
        /// <returns>A <see cref="WorkspacesWithPlaceIdRequestBuilder"/></returns>
        /// <param name="placeId">Alternate key of workspace</param>
        public WorkspacesWithPlaceIdRequestBuilder WorkspacesWithPlaceId(string placeId)
        {
            if(string.IsNullOrEmpty(placeId)) throw new ArgumentNullException(nameof(placeId));
            return new WorkspacesWithPlaceIdRequestBuilder(PathParameters, RequestAdapter, placeId);
        }
        /// <summary>
        /// Get the item of type microsoft.graph.place as microsoft.graph.roomList
        /// </summary>
        public class GraphRoomListRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GraphRoomListRequestBuilderGetRequestConfiguration : RequestConfiguration<GraphRoomListRequestBuilderGetQueryParameters>
        {
        }
    }
}
