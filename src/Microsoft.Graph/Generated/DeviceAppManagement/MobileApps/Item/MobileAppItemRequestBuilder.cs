// <auto-generated/>
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.Assign;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.Assignments;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.Categories;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidForWorkApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidManagedStoreApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidStoreApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphIosLobApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphIosStoreApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphIosVppApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphMacOSDmgApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphMacOSLobApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphMacOSPkgApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphManagedAndroidLobApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphManagedIOSLobApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphManagedMobileLobApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphMicrosoftStoreForBusinessApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphWin32LobApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphWinGetApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphWindowsMobileMSI;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphWindowsStoreApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphWindowsUniversalAppX;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphWindowsWebApp;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.Relationships;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.UpdateRelationships;
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
namespace Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item
{
    /// <summary>
    /// Provides operations to manage the mobileApps property of the microsoft.graph.deviceAppManagement entity.
    /// </summary>
    public class MobileAppItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the assign method.</summary>
        public AssignRequestBuilder Assign
        {
            get => new AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignments property of the microsoft.graph.mobileApp entity.</summary>
        public AssignmentsRequestBuilder Assignments
        {
            get => new AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the categories property of the microsoft.graph.mobileApp entity.</summary>
        public CategoriesRequestBuilder Categories
        {
            get => new CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to androidForWorkApp.</summary>
        public GraphAndroidForWorkAppRequestBuilder GraphAndroidForWorkApp
        {
            get => new GraphAndroidForWorkAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to androidLobApp.</summary>
        public GraphAndroidLobAppRequestBuilder GraphAndroidLobApp
        {
            get => new GraphAndroidLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to androidManagedStoreApp.</summary>
        public GraphAndroidManagedStoreAppRequestBuilder GraphAndroidManagedStoreApp
        {
            get => new GraphAndroidManagedStoreAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to androidStoreApp.</summary>
        public GraphAndroidStoreAppRequestBuilder GraphAndroidStoreApp
        {
            get => new GraphAndroidStoreAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosLobApp.</summary>
        public GraphIosLobAppRequestBuilder GraphIosLobApp
        {
            get => new GraphIosLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosStoreApp.</summary>
        public GraphIosStoreAppRequestBuilder GraphIosStoreApp
        {
            get => new GraphIosStoreAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosVppApp.</summary>
        public GraphIosVppAppRequestBuilder GraphIosVppApp
        {
            get => new GraphIosVppAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to macOSDmgApp.</summary>
        public GraphMacOSDmgAppRequestBuilder GraphMacOSDmgApp
        {
            get => new GraphMacOSDmgAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to macOSLobApp.</summary>
        public GraphMacOSLobAppRequestBuilder GraphMacOSLobApp
        {
            get => new GraphMacOSLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to macOSPkgApp.</summary>
        public GraphMacOSPkgAppRequestBuilder GraphMacOSPkgApp
        {
            get => new GraphMacOSPkgAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedAndroidLobApp.</summary>
        public GraphManagedAndroidLobAppRequestBuilder GraphManagedAndroidLobApp
        {
            get => new GraphManagedAndroidLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedIOSLobApp.</summary>
        public GraphManagedIOSLobAppRequestBuilder GraphManagedIOSLobApp
        {
            get => new GraphManagedIOSLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedMobileLobApp.</summary>
        public GraphManagedMobileLobAppRequestBuilder GraphManagedMobileLobApp
        {
            get => new GraphManagedMobileLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to microsoftStoreForBusinessApp.</summary>
        public GraphMicrosoftStoreForBusinessAppRequestBuilder GraphMicrosoftStoreForBusinessApp
        {
            get => new GraphMicrosoftStoreForBusinessAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to win32LobApp.</summary>
        public GraphWin32LobAppRequestBuilder GraphWin32LobApp
        {
            get => new GraphWin32LobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsAppX.</summary>
        public GraphWindowsAppXRequestBuilder GraphWindowsAppX
        {
            get => new GraphWindowsAppXRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsMobileMSI.</summary>
        public GraphWindowsMobileMSIRequestBuilder GraphWindowsMobileMSI
        {
            get => new GraphWindowsMobileMSIRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsStoreApp.</summary>
        public GraphWindowsStoreAppRequestBuilder GraphWindowsStoreApp
        {
            get => new GraphWindowsStoreAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsUniversalAppX.</summary>
        public GraphWindowsUniversalAppXRequestBuilder GraphWindowsUniversalAppX
        {
            get => new GraphWindowsUniversalAppXRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsWebApp.</summary>
        public GraphWindowsWebAppRequestBuilder GraphWindowsWebApp
        {
            get => new GraphWindowsWebAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to winGetApp.</summary>
        public GraphWinGetAppRequestBuilder GraphWinGetApp
        {
            get => new GraphWinGetAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the relationships property of the microsoft.graph.mobileApp entity.</summary>
        public RelationshipsRequestBuilder Relationships
        {
            get => new RelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateRelationships method.</summary>
        public UpdateRelationshipsRequestBuilder UpdateRelationships
        {
            get => new UpdateRelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="MobileAppItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MobileAppItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MobileAppItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MobileAppItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property mobileApps for deviceAppManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The mobile apps.
        /// </summary>
        /// <returns>A <see cref="MobileApp"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<MobileApp?> GetAsync(Action<RequestConfiguration<MobileAppItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<MobileApp> GetAsync(Action<RequestConfiguration<MobileAppItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<MobileApp>(requestInfo, MobileApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property mobileApps in deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="MobileApp"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<MobileApp?> PatchAsync(MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<MobileApp> PatchAsync(MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<MobileApp>(requestInfo, MobileApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property mobileApps for deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The mobile apps.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MobileAppItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MobileAppItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property mobileApps in deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="MobileAppItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MobileAppItemRequestBuilder WithUrl(string rawUrl)
        {
            return new MobileAppItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MobileAppItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The mobile apps.
        /// </summary>
        public class MobileAppItemRequestBuilderGetQueryParameters 
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
        public class MobileAppItemRequestBuilderGetRequestConfiguration : RequestConfiguration<MobileAppItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MobileAppItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
