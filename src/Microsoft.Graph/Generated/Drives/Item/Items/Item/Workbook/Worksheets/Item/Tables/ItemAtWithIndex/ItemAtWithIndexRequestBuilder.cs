// <auto-generated/>
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ClearFilters;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Columns;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ConvertToRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.DataBodyRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.HeaderRowRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.RangeNamespace;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ReapplyFilters;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Rows;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Sort;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.TotalRowRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Worksheet;
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
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex
{
    /// <summary>
    /// Provides operations to call the itemAt method.
    /// </summary>
    public class ItemAtWithIndexRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the clearFilters method.</summary>
        public ClearFiltersRequestBuilder ClearFilters
        {
            get => new ClearFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.workbookTable entity.</summary>
        public ColumnsRequestBuilder Columns
        {
            get => new ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the convertToRange method.</summary>
        public ConvertToRangeRequestBuilder ConvertToRange
        {
            get => new ConvertToRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the dataBodyRange method.</summary>
        public DataBodyRangeRequestBuilder DataBodyRange
        {
            get => new DataBodyRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the headerRowRange method.</summary>
        public HeaderRowRangeRequestBuilder HeaderRowRange
        {
            get => new HeaderRowRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the range method.</summary>
        public RangeRequestBuilder Range
        {
            get => new RangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reapplyFilters method.</summary>
        public ReapplyFiltersRequestBuilder ReapplyFilters
        {
            get => new ReapplyFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the rows property of the microsoft.graph.workbookTable entity.</summary>
        public RowsRequestBuilder Rows
        {
            get => new RowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sort property of the microsoft.graph.workbookTable entity.</summary>
        public SortRequestBuilder Sort
        {
            get => new SortRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the totalRowRange method.</summary>
        public TotalRowRangeRequestBuilder TotalRowRange
        {
            get => new TotalRowRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookTable entity.</summary>
        public WorksheetRequestBuilder Worksheet
        {
            get => new WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ItemAtWithIndexRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="index">Usage: index={index}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemAtWithIndexRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? index = default) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/itemAt(index={index})", pathParameters)
        {
            if (index != null) PathParameters.Add("index", index);
        }
        /// <summary>
        /// Instantiates a new <see cref="ItemAtWithIndexRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemAtWithIndexRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/itemAt(index={index})", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function itemAt
        /// </summary>
        /// <returns>A <see cref="WorkbookTable"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkbookTable?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<WorkbookTable> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<WorkbookTable>(requestInfo, WorkbookTable.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function itemAt
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
        /// <returns>A <see cref="ItemAtWithIndexRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ItemAtWithIndexRequestBuilder WithUrl(string rawUrl)
        {
            return new ItemAtWithIndexRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ItemAtWithIndexRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
