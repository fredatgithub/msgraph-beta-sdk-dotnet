// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IReportRootDailyPrintUsageByPrinterCollectionRequest.
    /// </summary>
    public partial interface IReportRootDailyPrintUsageByPrinterCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified PrintUsageByPrinter to the collection via POST.
        /// </summary>
        /// <param name="printUsageByPrinter">The PrintUsageByPrinter to add.</param>
        /// <returns>The created PrintUsageByPrinter.</returns>
        System.Threading.Tasks.Task<PrintUsageByPrinter> AddAsync(PrintUsageByPrinter printUsageByPrinter);

        /// <summary>
        /// Adds the specified PrintUsageByPrinter to the collection via POST.
        /// </summary>
        /// <param name="printUsageByPrinter">The PrintUsageByPrinter to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintUsageByPrinter.</returns>
        System.Threading.Tasks.Task<PrintUsageByPrinter> AddAsync(PrintUsageByPrinter printUsageByPrinter, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified PrintUsageByPrinter to the collection via POST and returns a <see cref="GraphResponse{PrintUsageByPrinter}"/> object of the request.
        /// </summary>
        /// <param name="printUsageByPrinter">The PrintUsageByPrinter to add.</param>
        /// <returns>The <see cref="GraphResponse{PrintUsageByPrinter}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintUsageByPrinter>> AddResponseAsync(PrintUsageByPrinter printUsageByPrinter);

        /// <summary>
        /// Adds the specified PrintUsageByPrinter to the collection via POST and returns a <see cref="GraphResponse{PrintUsageByPrinter}"/> object of the request.
        /// </summary>
        /// <param name="printUsageByPrinter">The PrintUsageByPrinter to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintUsageByPrinter}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintUsageByPrinter>> AddResponseAsync(PrintUsageByPrinter printUsageByPrinter, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IReportRootDailyPrintUsageByPrinterCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IReportRootDailyPrintUsageByPrinterCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ReportRootDailyPrintUsageByPrinterCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ReportRootDailyPrintUsageByPrinterCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRootDailyPrintUsageByPrinterCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ReportRootDailyPrintUsageByPrinterCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ReportRootDailyPrintUsageByPrinterCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRootDailyPrintUsageByPrinterCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootDailyPrintUsageByPrinterCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootDailyPrintUsageByPrinterCollectionRequest Expand(Expression<Func<PrintUsageByPrinter, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootDailyPrintUsageByPrinterCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootDailyPrintUsageByPrinterCollectionRequest Select(Expression<Func<PrintUsageByPrinter, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootDailyPrintUsageByPrinterCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootDailyPrintUsageByPrinterCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootDailyPrintUsageByPrinterCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootDailyPrintUsageByPrinterCollectionRequest OrderBy(string value);
    }
}
