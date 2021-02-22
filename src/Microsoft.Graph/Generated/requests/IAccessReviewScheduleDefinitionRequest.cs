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
    /// The interface IAccessReviewScheduleDefinitionRequest.
    /// </summary>
    public partial interface IAccessReviewScheduleDefinitionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AccessReviewScheduleDefinition using POST.
        /// </summary>
        /// <param name="accessReviewScheduleDefinitionToCreate">The AccessReviewScheduleDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessReviewScheduleDefinition.</returns>
        System.Threading.Tasks.Task<AccessReviewScheduleDefinition> CreateAsync(AccessReviewScheduleDefinition accessReviewScheduleDefinitionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AccessReviewScheduleDefinition using POST and returns a <see cref="GraphResponse{AccessReviewScheduleDefinition}"/> object.
        /// </summary>
        /// <param name="accessReviewScheduleDefinitionToCreate">The AccessReviewScheduleDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewScheduleDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewScheduleDefinition>> CreateResponseAsync(AccessReviewScheduleDefinition accessReviewScheduleDefinitionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AccessReviewScheduleDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AccessReviewScheduleDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AccessReviewScheduleDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessReviewScheduleDefinition.</returns>
        System.Threading.Tasks.Task<AccessReviewScheduleDefinition> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AccessReviewScheduleDefinition and returns a <see cref="GraphResponse{AccessReviewScheduleDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewScheduleDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewScheduleDefinition>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessReviewScheduleDefinition using PATCH.
        /// </summary>
        /// <param name="accessReviewScheduleDefinitionToUpdate">The AccessReviewScheduleDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessReviewScheduleDefinition.</returns>
        System.Threading.Tasks.Task<AccessReviewScheduleDefinition> UpdateAsync(AccessReviewScheduleDefinition accessReviewScheduleDefinitionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessReviewScheduleDefinition using PATCH and returns a <see cref="GraphResponse{AccessReviewScheduleDefinition}"/> object.
        /// </summary>
        /// <param name="accessReviewScheduleDefinitionToUpdate">The AccessReviewScheduleDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessReviewScheduleDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewScheduleDefinition>> UpdateResponseAsync(AccessReviewScheduleDefinition accessReviewScheduleDefinitionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewScheduleDefinitionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewScheduleDefinitionRequest Expand(Expression<Func<AccessReviewScheduleDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewScheduleDefinitionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewScheduleDefinitionRequest Select(Expression<Func<AccessReviewScheduleDefinition, object>> selectExpression);

    }
}
