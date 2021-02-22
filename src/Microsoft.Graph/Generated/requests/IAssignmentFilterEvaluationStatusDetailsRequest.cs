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
    /// The interface IAssignmentFilterEvaluationStatusDetailsRequest.
    /// </summary>
    public partial interface IAssignmentFilterEvaluationStatusDetailsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AssignmentFilterEvaluationStatusDetails using POST.
        /// </summary>
        /// <param name="assignmentFilterEvaluationStatusDetailsToCreate">The AssignmentFilterEvaluationStatusDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AssignmentFilterEvaluationStatusDetails.</returns>
        System.Threading.Tasks.Task<AssignmentFilterEvaluationStatusDetails> CreateAsync(AssignmentFilterEvaluationStatusDetails assignmentFilterEvaluationStatusDetailsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AssignmentFilterEvaluationStatusDetails using POST and returns a <see cref="GraphResponse{AssignmentFilterEvaluationStatusDetails}"/> object.
        /// </summary>
        /// <param name="assignmentFilterEvaluationStatusDetailsToCreate">The AssignmentFilterEvaluationStatusDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AssignmentFilterEvaluationStatusDetails}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AssignmentFilterEvaluationStatusDetails>> CreateResponseAsync(AssignmentFilterEvaluationStatusDetails assignmentFilterEvaluationStatusDetailsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AssignmentFilterEvaluationStatusDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AssignmentFilterEvaluationStatusDetails and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AssignmentFilterEvaluationStatusDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AssignmentFilterEvaluationStatusDetails.</returns>
        System.Threading.Tasks.Task<AssignmentFilterEvaluationStatusDetails> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AssignmentFilterEvaluationStatusDetails and returns a <see cref="GraphResponse{AssignmentFilterEvaluationStatusDetails}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AssignmentFilterEvaluationStatusDetails}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AssignmentFilterEvaluationStatusDetails>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AssignmentFilterEvaluationStatusDetails using PATCH.
        /// </summary>
        /// <param name="assignmentFilterEvaluationStatusDetailsToUpdate">The AssignmentFilterEvaluationStatusDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AssignmentFilterEvaluationStatusDetails.</returns>
        System.Threading.Tasks.Task<AssignmentFilterEvaluationStatusDetails> UpdateAsync(AssignmentFilterEvaluationStatusDetails assignmentFilterEvaluationStatusDetailsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AssignmentFilterEvaluationStatusDetails using PATCH and returns a <see cref="GraphResponse{AssignmentFilterEvaluationStatusDetails}"/> object.
        /// </summary>
        /// <param name="assignmentFilterEvaluationStatusDetailsToUpdate">The AssignmentFilterEvaluationStatusDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AssignmentFilterEvaluationStatusDetails}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AssignmentFilterEvaluationStatusDetails>> UpdateResponseAsync(AssignmentFilterEvaluationStatusDetails assignmentFilterEvaluationStatusDetailsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAssignmentFilterEvaluationStatusDetailsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAssignmentFilterEvaluationStatusDetailsRequest Expand(Expression<Func<AssignmentFilterEvaluationStatusDetails, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAssignmentFilterEvaluationStatusDetailsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAssignmentFilterEvaluationStatusDetailsRequest Select(Expression<Func<AssignmentFilterEvaluationStatusDetails, object>> selectExpression);

    }
}
