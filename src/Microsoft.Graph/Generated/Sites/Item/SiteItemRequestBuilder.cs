// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Sites.Item.Analytics;
using Microsoft.Graph.Beta.Sites.Item.Columns;
using Microsoft.Graph.Beta.Sites.Item.ContentTypes;
using Microsoft.Graph.Beta.Sites.Item.CreatedByUser;
using Microsoft.Graph.Beta.Sites.Item.Drive;
using Microsoft.Graph.Beta.Sites.Item.Drives;
using Microsoft.Graph.Beta.Sites.Item.ExternalColumns;
using Microsoft.Graph.Beta.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using Microsoft.Graph.Beta.Sites.Item.GetApplicableContentTypesForListWithListId;
using Microsoft.Graph.Beta.Sites.Item.GetByPathWithPath;
using Microsoft.Graph.Beta.Sites.Item.InformationProtection;
using Microsoft.Graph.Beta.Sites.Item.Items;
using Microsoft.Graph.Beta.Sites.Item.LastModifiedByUser;
using Microsoft.Graph.Beta.Sites.Item.Lists;
using Microsoft.Graph.Beta.Sites.Item.Onenote;
using Microsoft.Graph.Beta.Sites.Item.Operations;
using Microsoft.Graph.Beta.Sites.Item.Pages;
using Microsoft.Graph.Beta.Sites.Item.Permissions;
using Microsoft.Graph.Beta.Sites.Item.RecycleBin;
using Microsoft.Graph.Beta.Sites.Item.Sites;
using Microsoft.Graph.Beta.Sites.Item.TermStore;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Sites.Item
{
    /// <summary>
    /// Provides operations to manage the collection of site entities.
    /// </summary>
    public class SiteItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the analytics property of the microsoft.graph.site entity.</summary>
        public AnalyticsRequestBuilder Analytics
        {
            get => new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.site entity.</summary>
        public ColumnsRequestBuilder Columns
        {
            get => new ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentTypes property of the microsoft.graph.site entity.</summary>
        public ContentTypesRequestBuilder ContentTypes
        {
            get => new ContentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.</summary>
        public CreatedByUserRequestBuilder CreatedByUser
        {
            get => new CreatedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.site entity.</summary>
        public DriveRequestBuilder Drive
        {
            get => new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drives property of the microsoft.graph.site entity.</summary>
        public DrivesRequestBuilder Drives
        {
            get => new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the externalColumns property of the microsoft.graph.site entity.</summary>
        public ExternalColumnsRequestBuilder ExternalColumns
        {
            get => new ExternalColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the informationProtection property of the microsoft.graph.site entity.</summary>
        public InformationProtectionRequestBuilder InformationProtection
        {
            get => new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the items property of the microsoft.graph.site entity.</summary>
        public ItemsRequestBuilder Items
        {
            get => new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.</summary>
        public LastModifiedByUserRequestBuilder LastModifiedByUser
        {
            get => new LastModifiedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lists property of the microsoft.graph.site entity.</summary>
        public ListsRequestBuilder Lists
        {
            get => new ListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onenote property of the microsoft.graph.site entity.</summary>
        public OnenoteRequestBuilder Onenote
        {
            get => new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.site entity.</summary>
        public OperationsRequestBuilder Operations
        {
            get => new OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the pages property of the microsoft.graph.site entity.</summary>
        public PagesRequestBuilder Pages
        {
            get => new PagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissions property of the microsoft.graph.site entity.</summary>
        public PermissionsRequestBuilder Permissions
        {
            get => new PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the recycleBin property of the microsoft.graph.site entity.</summary>
        public RecycleBinRequestBuilder RecycleBin
        {
            get => new RecycleBinRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sites property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Sites.Item.Sites.SitesRequestBuilder Sites
        {
            get => new Microsoft.Graph.Beta.Sites.Item.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termStore property of the microsoft.graph.site entity.</summary>
        public TermStoreRequestBuilder TermStore
        {
            get => new TermStoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SiteItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SiteItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SiteItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SiteItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <returns>A <see cref="GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder"/></returns>
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="interval">Usage: interval=&apos;{interval}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string endDateTime, string interval, string startDateTime)
        {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, endDateTime, interval, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getApplicableContentTypesForList method.
        /// </summary>
        /// <returns>A <see cref="GetApplicableContentTypesForListWithListIdRequestBuilder"/></returns>
        /// <param name="listId">Usage: listId=&apos;{listId}&apos;</param>
        public GetApplicableContentTypesForListWithListIdRequestBuilder GetApplicableContentTypesForListWithListId(string listId)
        {
            if(string.IsNullOrEmpty(listId)) throw new ArgumentNullException(nameof(listId));
            return new GetApplicableContentTypesForListWithListIdRequestBuilder(PathParameters, RequestAdapter, listId);
        }
        /// <summary>
        /// Retrieve properties and relationships for a site resource.A site resource represents a team site in SharePoint.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/site-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Site"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Site?> GetAsync(Action<RequestConfiguration<SiteItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Site> GetAsync(Action<RequestConfiguration<SiteItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Site>(requestInfo, Microsoft.Graph.Beta.Models.Site.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the getByPath method.
        /// </summary>
        /// <returns>A <see cref="GetByPathWithPathRequestBuilder"/></returns>
        /// <param name="path">Usage: path=&apos;{path}&apos;</param>
        public GetByPathWithPathRequestBuilder GetByPathWithPath(string path)
        {
            if(string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));
            return new GetByPathWithPathRequestBuilder(PathParameters, RequestAdapter, path);
        }
        /// <summary>
        /// Update entity in sites
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Site"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Site?> PatchAsync(Microsoft.Graph.Beta.Models.Site body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Site> PatchAsync(Microsoft.Graph.Beta.Models.Site body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Site>(requestInfo, Microsoft.Graph.Beta.Models.Site.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve properties and relationships for a site resource.A site resource represents a team site in SharePoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SiteItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SiteItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update entity in sites
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Site body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Site body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="SiteItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SiteItemRequestBuilder WithUrl(string rawUrl)
        {
            return new SiteItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve properties and relationships for a site resource.A site resource represents a team site in SharePoint.
        /// </summary>
        public class SiteItemRequestBuilderGetQueryParameters 
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
        public class SiteItemRequestBuilderGetRequestConfiguration : RequestConfiguration<SiteItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class SiteItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
