// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ReportRootDailyPrintUsageSummariesByUserCollectionRequest.
    /// </summary>
    public partial class ReportRootDailyPrintUsageSummariesByUserCollectionRequest : BaseRequest, IReportRootDailyPrintUsageSummariesByUserCollectionRequest
    {
        /// <summary>
        /// Constructs a new ReportRootDailyPrintUsageSummariesByUserCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ReportRootDailyPrintUsageSummariesByUserCollectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        
        /// <summary>
        /// Adds the specified PrintUsageByUser to the collection via POST.
        /// </summary>
        /// <param name="printUsageByUser">The PrintUsageByUser to add.</param>
        /// <returns>The created PrintUsageByUser.</returns>
        public System.Threading.Tasks.Task<PrintUsageByUser> AddAsync(PrintUsageByUser printUsageByUser)
        {
            return this.AddAsync(printUsageByUser, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified PrintUsageByUser to the collection via POST.
        /// </summary>
        /// <param name="printUsageByUser">The PrintUsageByUser to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintUsageByUser.</returns>
        public System.Threading.Tasks.Task<PrintUsageByUser> AddAsync(PrintUsageByUser printUsageByUser, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return this.SendAsync<PrintUsageByUser>(printUsageByUser, cancellationToken);
        }

        
        /// <summary>
        /// Adds the specified PrintUsageByUser to the collection via POST and returns a <see cref="GraphResponse{PrintUsageByUser}"/> object of the request.
        /// </summary>
        /// <param name="printUsageByUser">The PrintUsageByUser to add.</param>
        /// <returns>The <see cref="GraphResponse{PrintUsageByUser}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrintUsageByUser>> AddResponseAsync(PrintUsageByUser printUsageByUser)
        {
            return this.AddResponseAsync(printUsageByUser, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified PrintUsageByUser to the collection via POST and returns a <see cref="GraphResponse{PrintUsageByUser}"/> object of the request.
        /// </summary>
        /// <param name="printUsageByUser">The PrintUsageByUser to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintUsageByUser}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PrintUsageByUser>> AddResponseAsync(PrintUsageByUser printUsageByUser, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<PrintUsageByUser>(printUsageByUser, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        public System.Threading.Tasks.Task<IReportRootDailyPrintUsageSummariesByUserCollectionPage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async System.Threading.Tasks.Task<IReportRootDailyPrintUsageSummariesByUserCollectionPage> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var response = await this.SendAsync<ReportRootDailyPrintUsageSummariesByUserCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }

                    // Copy the additional data collection to the page itself so that information is not lost
                    response.Value.AdditionalData = response.AdditionalData;
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ReportRootDailyPrintUsageSummariesByUserCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ReportRootDailyPrintUsageSummariesByUserCollectionResponse}"/> object.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRootDailyPrintUsageSummariesByUserCollectionResponse>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ReportRootDailyPrintUsageSummariesByUserCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ReportRootDailyPrintUsageSummariesByUserCollectionResponse}"/> object.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ReportRootDailyPrintUsageSummariesByUserCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<ReportRootDailyPrintUsageSummariesByUserCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootDailyPrintUsageSummariesByUserCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootDailyPrintUsageSummariesByUserCollectionRequest Expand(Expression<Func<PrintUsageByUser, object>> expandExpression)
        {
            if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootDailyPrintUsageSummariesByUserCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootDailyPrintUsageSummariesByUserCollectionRequest Select(Expression<Func<PrintUsageByUser, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootDailyPrintUsageSummariesByUserCollectionRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootDailyPrintUsageSummariesByUserCollectionRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootDailyPrintUsageSummariesByUserCollectionRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootDailyPrintUsageSummariesByUserCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
