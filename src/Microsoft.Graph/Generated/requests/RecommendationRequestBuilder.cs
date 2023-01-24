// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type RecommendationRequestBuilder.
    /// </summary>
    public partial class RecommendationRequestBuilder : RecommendationBaseRequestBuilder, IRecommendationRequestBuilder
    {

        /// <summary>
        /// Constructs a new RecommendationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RecommendationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IRecommendationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IRecommendationRequest Request(IEnumerable<Option> options)
        {
            return new RecommendationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RecommendationComplete.
        /// </summary>
        /// <returns>The <see cref="IRecommendationCompleteRequestBuilder"/>.</returns>
        public IRecommendationCompleteRequestBuilder Complete()
        {
            return new RecommendationCompleteRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.complete"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for RecommendationDismiss.
        /// </summary>
        /// <returns>The <see cref="IRecommendationDismissRequestBuilder"/>.</returns>
        public IRecommendationDismissRequestBuilder Dismiss(
            string dismissReason = null)
        {
            return new RecommendationDismissRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.dismiss"),
                this.Client,
                dismissReason);
        }

        /// <summary>
        /// Gets the request builder for RecommendationPostpone.
        /// </summary>
        /// <returns>The <see cref="IRecommendationPostponeRequestBuilder"/>.</returns>
        public IRecommendationPostponeRequestBuilder Postpone(
            DateTimeOffset postponeUntilDateTime)
        {
            return new RecommendationPostponeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.postpone"),
                this.Client,
                postponeUntilDateTime);
        }

        /// <summary>
        /// Gets the request builder for RecommendationReactivate.
        /// </summary>
        /// <returns>The <see cref="IRecommendationReactivateRequestBuilder"/>.</returns>
        public IRecommendationReactivateRequestBuilder Reactivate()
        {
            return new RecommendationReactivateRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.reactivate"),
                this.Client);
        }
    
    }
}
