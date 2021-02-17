// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISegmentRequest.
    /// </summary>
    public partial interface ISegmentRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified Segment using POST.
        /// </summary>
        /// <param name="segmentToCreate">The Segment to create.</param>
        /// <returns>The created Segment.</returns>
        System.Threading.Tasks.Task<Segment> CreateAsync(Segment segmentToCreate);

        /// <summary>
        /// Creates the specified Segment using POST.
        /// </summary>
        /// <param name="segmentToCreate">The Segment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Segment.</returns>
        System.Threading.Tasks.Task<Segment> CreateAsync(Segment segmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Segment using POST and returns a <see cref="GraphResponse{Segment}"/> object.
        /// </summary>
        /// <param name="segmentToCreate">The Segment to create.</param>
        /// <returns>The <see cref="GraphResponse{Segment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Segment>> CreateResponseAsync(Segment segmentToCreate);

        /// <summary>
        /// Creates the specified Segment using POST and returns a <see cref="GraphResponse{Segment}"/> object.
        /// </summary>
        /// <param name="segmentToCreate">The Segment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Segment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Segment>> CreateResponseAsync(Segment segmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Segment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Segment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Segment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Segment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Segment.
        /// </summary>
        /// <returns>The Segment.</returns>
        System.Threading.Tasks.Task<Segment> GetAsync();

        /// <summary>
        /// Gets the specified Segment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Segment.</returns>
        System.Threading.Tasks.Task<Segment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Segment and returns a <see cref="GraphResponse{Segment}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Segment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Segment>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Segment and returns a <see cref="GraphResponse{Segment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Segment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Segment>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Segment using PATCH.
        /// </summary>
        /// <param name="segmentToUpdate">The Segment to update.</param>
        /// <returns>The updated Segment.</returns>
        System.Threading.Tasks.Task<Segment> UpdateAsync(Segment segmentToUpdate);

        /// <summary>
        /// Updates the specified Segment using PATCH.
        /// </summary>
        /// <param name="segmentToUpdate">The Segment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Segment.</returns>
        System.Threading.Tasks.Task<Segment> UpdateAsync(Segment segmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Segment using PATCH and returns a <see cref="GraphResponse{Segment}"/> object.
        /// </summary>
        /// <param name="segmentToUpdate">The Segment to update.</param>
        /// <returns>The <see cref="GraphResponse{Segment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Segment>> UpdateResponseAsync(Segment segmentToUpdate);

        /// <summary>
        /// Updates the specified Segment using PATCH and returns a <see cref="GraphResponse{Segment}"/> object.
        /// </summary>
        /// <param name="segmentToUpdate">The Segment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Segment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Segment>> UpdateResponseAsync(Segment segmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISegmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISegmentRequest Expand(Expression<Func<Segment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISegmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISegmentRequest Select(Expression<Func<Segment, object>> selectExpression);

    }
}
