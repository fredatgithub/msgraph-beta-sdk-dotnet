// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ScheduleTimeCardsCollectionRequestBuilder.
    /// </summary>
    public partial class ScheduleTimeCardsCollectionRequestBuilder : BaseRequestBuilder, IScheduleTimeCardsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ScheduleTimeCardsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ScheduleTimeCardsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IScheduleTimeCardsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IScheduleTimeCardsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ScheduleTimeCardsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITimeCardRequestBuilder"/> for the specified ScheduleTimeCard.
        /// </summary>
        /// <param name="id">The ID for the ScheduleTimeCard.</param>
        /// <returns>The <see cref="ITimeCardRequestBuilder"/>.</returns>
        public ITimeCardRequestBuilder this[string id]
        {
            get
            {
                return new TimeCardRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TimeCardClockIn.
        /// </summary>
        /// <returns>The <see cref="ITimeCardClockInRequestBuilder"/>.</returns>
        public ITimeCardClockInRequestBuilder ClockIn(
            bool? atApprovedLocation = null,
            string onBehalfOfUserId = null,
            ItemBody notes = null)
        {
            return new TimeCardClockInRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.clockIn"),
                this.Client,
                atApprovedLocation,
                onBehalfOfUserId,
                notes);
        }
    }
}