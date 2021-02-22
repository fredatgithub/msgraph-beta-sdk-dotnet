// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IEvaluateLabelJobResponseRequest.
    /// </summary>
    public partial interface IEvaluateLabelJobResponseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EvaluateLabelJobResponse using POST.
        /// </summary>
        /// <param name="evaluateLabelJobResponseToCreate">The EvaluateLabelJobResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EvaluateLabelJobResponse.</returns>
        System.Threading.Tasks.Task<EvaluateLabelJobResponse> CreateAsync(EvaluateLabelJobResponse evaluateLabelJobResponseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified EvaluateLabelJobResponse using POST and returns a <see cref="GraphResponse{EvaluateLabelJobResponse}"/> object.
        /// </summary>
        /// <param name="evaluateLabelJobResponseToCreate">The EvaluateLabelJobResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EvaluateLabelJobResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EvaluateLabelJobResponse>> CreateResponseAsync(EvaluateLabelJobResponse evaluateLabelJobResponseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EvaluateLabelJobResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EvaluateLabelJobResponse and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EvaluateLabelJobResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EvaluateLabelJobResponse.</returns>
        System.Threading.Tasks.Task<EvaluateLabelJobResponse> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EvaluateLabelJobResponse and returns a <see cref="GraphResponse{EvaluateLabelJobResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EvaluateLabelJobResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EvaluateLabelJobResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EvaluateLabelJobResponse using PATCH.
        /// </summary>
        /// <param name="evaluateLabelJobResponseToUpdate">The EvaluateLabelJobResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EvaluateLabelJobResponse.</returns>
        System.Threading.Tasks.Task<EvaluateLabelJobResponse> UpdateAsync(EvaluateLabelJobResponse evaluateLabelJobResponseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EvaluateLabelJobResponse using PATCH and returns a <see cref="GraphResponse{EvaluateLabelJobResponse}"/> object.
        /// </summary>
        /// <param name="evaluateLabelJobResponseToUpdate">The EvaluateLabelJobResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EvaluateLabelJobResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EvaluateLabelJobResponse>> UpdateResponseAsync(EvaluateLabelJobResponse evaluateLabelJobResponseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEvaluateLabelJobResponseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEvaluateLabelJobResponseRequest Expand(Expression<Func<EvaluateLabelJobResponse, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEvaluateLabelJobResponseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEvaluateLabelJobResponseRequest Select(Expression<Func<EvaluateLabelJobResponse, object>> selectExpression);

    }
}
