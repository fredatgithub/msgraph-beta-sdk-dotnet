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
    /// The interface IPlannerUserRequest.
    /// </summary>
    public partial interface IPlannerUserRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlannerUser using POST.
        /// </summary>
        /// <param name="plannerUserToCreate">The PlannerUser to create.</param>
        /// <returns>The created PlannerUser.</returns>
        System.Threading.Tasks.Task<PlannerUser> CreateAsync(PlannerUser plannerUserToCreate);

        /// <summary>
        /// Creates the specified PlannerUser using POST.
        /// </summary>
        /// <param name="plannerUserToCreate">The PlannerUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerUser.</returns>
        System.Threading.Tasks.Task<PlannerUser> CreateAsync(PlannerUser plannerUserToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified PlannerUser using POST and returns a <see cref="GraphResponse{PlannerUser}"/> object.
        /// </summary>
        /// <param name="plannerUserToCreate">The PlannerUser to create.</param>
        /// <returns>The <see cref="GraphResponse{PlannerUser}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerUser>> CreateResponseAsync(PlannerUser plannerUserToCreate);

        /// <summary>
        /// Creates the specified PlannerUser using POST and returns a <see cref="GraphResponse{PlannerUser}"/> object.
        /// </summary>
        /// <param name="plannerUserToCreate">The PlannerUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerUser}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerUser>> CreateResponseAsync(PlannerUser plannerUserToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlannerUser.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PlannerUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlannerUser and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified PlannerUser and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlannerUser.
        /// </summary>
        /// <returns>The PlannerUser.</returns>
        System.Threading.Tasks.Task<PlannerUser> GetAsync();

        /// <summary>
        /// Gets the specified PlannerUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerUser.</returns>
        System.Threading.Tasks.Task<PlannerUser> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlannerUser and returns a <see cref="GraphResponse{PlannerUser}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PlannerUser}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerUser>> GetResponseAsync();

        /// <summary>
        /// Gets the specified PlannerUser and returns a <see cref="GraphResponse{PlannerUser}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerUser}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerUser>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlannerUser using PATCH.
        /// </summary>
        /// <param name="plannerUserToUpdate">The PlannerUser to update.</param>
        /// <returns>The updated PlannerUser.</returns>
        System.Threading.Tasks.Task<PlannerUser> UpdateAsync(PlannerUser plannerUserToUpdate);

        /// <summary>
        /// Updates the specified PlannerUser using PATCH.
        /// </summary>
        /// <param name="plannerUserToUpdate">The PlannerUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerUser.</returns>
        System.Threading.Tasks.Task<PlannerUser> UpdateAsync(PlannerUser plannerUserToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlannerUser using PATCH and returns a <see cref="GraphResponse{PlannerUser}"/> object.
        /// </summary>
        /// <param name="plannerUserToUpdate">The PlannerUser to update.</param>
        /// <returns>The <see cref="GraphResponse{PlannerUser}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerUser>> UpdateResponseAsync(PlannerUser plannerUserToUpdate);

        /// <summary>
        /// Updates the specified PlannerUser using PATCH and returns a <see cref="GraphResponse{PlannerUser}"/> object.
        /// </summary>
        /// <param name="plannerUserToUpdate">The PlannerUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PlannerUser}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerUser>> UpdateResponseAsync(PlannerUser plannerUserToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerUserRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerUserRequest Expand(Expression<Func<PlannerUser, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerUserRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerUserRequest Select(Expression<Func<PlannerUser, object>> selectExpression);

    }
}
