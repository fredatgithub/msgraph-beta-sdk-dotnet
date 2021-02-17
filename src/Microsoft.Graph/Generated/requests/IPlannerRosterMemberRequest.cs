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
    /// The interface IPlannerRosterMemberRequest.
    /// </summary>
    public partial interface IPlannerRosterMemberRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlannerRosterMember using POST.
        /// </summary>
        /// <param name="plannerRosterMemberToCreate">The PlannerRosterMember to create.</param>
        /// <returns>The created PlannerRosterMember.</returns>
        System.Threading.Tasks.Task<PlannerRosterMember> CreateAsync(PlannerRosterMember plannerRosterMemberToCreate);

        /// <summary>
        /// Creates the specified PlannerRosterMember using POST.
        /// </summary>
        /// <param name="plannerRosterMemberToCreate">The PlannerRosterMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerRosterMember.</returns>
        System.Threading.Tasks.Task<PlannerRosterMember> CreateAsync(PlannerRosterMember plannerRosterMemberToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified PlannerRosterMember using POST and returns a <see cref="GraphResponse{PlannerRosterMember}"/> object.
        /// </summary>
        /// <param name="plannerRosterMemberToCreate">The PlannerRosterMember to create.</param>
        /// <returns>The <see cref="GraphResponse{PlannerRosterMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerRosterMember>> CreateResponseAsync(PlannerRosterMember plannerRosterMemberToCreate);

        /// <summary>
        /// Creates the specified PlannerRosterMember using POST and returns a <see cref="GraphResponse{PlannerRosterMember}"/> object.
        /// </summary>
        /// <param name="plannerRosterMemberToCreate">The PlannerRosterMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerRosterMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerRosterMember>> CreateResponseAsync(PlannerRosterMember plannerRosterMemberToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlannerRosterMember.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PlannerRosterMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlannerRosterMember and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified PlannerRosterMember and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlannerRosterMember.
        /// </summary>
        /// <returns>The PlannerRosterMember.</returns>
        System.Threading.Tasks.Task<PlannerRosterMember> GetAsync();

        /// <summary>
        /// Gets the specified PlannerRosterMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerRosterMember.</returns>
        System.Threading.Tasks.Task<PlannerRosterMember> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlannerRosterMember and returns a <see cref="GraphResponse{PlannerRosterMember}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PlannerRosterMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerRosterMember>> GetResponseAsync();

        /// <summary>
        /// Gets the specified PlannerRosterMember and returns a <see cref="GraphResponse{PlannerRosterMember}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerRosterMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerRosterMember>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlannerRosterMember using PATCH.
        /// </summary>
        /// <param name="plannerRosterMemberToUpdate">The PlannerRosterMember to update.</param>
        /// <returns>The updated PlannerRosterMember.</returns>
        System.Threading.Tasks.Task<PlannerRosterMember> UpdateAsync(PlannerRosterMember plannerRosterMemberToUpdate);

        /// <summary>
        /// Updates the specified PlannerRosterMember using PATCH.
        /// </summary>
        /// <param name="plannerRosterMemberToUpdate">The PlannerRosterMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerRosterMember.</returns>
        System.Threading.Tasks.Task<PlannerRosterMember> UpdateAsync(PlannerRosterMember plannerRosterMemberToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlannerRosterMember using PATCH and returns a <see cref="GraphResponse{PlannerRosterMember}"/> object.
        /// </summary>
        /// <param name="plannerRosterMemberToUpdate">The PlannerRosterMember to update.</param>
        /// <returns>The <see cref="GraphResponse{PlannerRosterMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerRosterMember>> UpdateResponseAsync(PlannerRosterMember plannerRosterMemberToUpdate);

        /// <summary>
        /// Updates the specified PlannerRosterMember using PATCH and returns a <see cref="GraphResponse{PlannerRosterMember}"/> object.
        /// </summary>
        /// <param name="plannerRosterMemberToUpdate">The PlannerRosterMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PlannerRosterMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerRosterMember>> UpdateResponseAsync(PlannerRosterMember plannerRosterMemberToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRosterMemberRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRosterMemberRequest Expand(Expression<Func<PlannerRosterMember, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRosterMemberRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRosterMemberRequest Select(Expression<Func<PlannerRosterMember, object>> selectExpression);

    }
}
