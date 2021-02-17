// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IGroupPolicyCategoryWithReferenceRequest.
    /// </summary>
    public partial interface IGroupPolicyCategoryWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified GroupPolicyCategory.
        /// </summary>
        /// <returns>The GroupPolicyCategory.</returns>
        System.Threading.Tasks.Task<GroupPolicyCategory> GetAsync();

        /// <summary>
        /// Gets the specified GroupPolicyCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyCategory.</returns>
        System.Threading.Tasks.Task<GroupPolicyCategory> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupPolicyCategory and returns a <see cref="GraphResponse{GroupPolicyCategory}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GroupPolicyCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyCategory>> GetResponseAsync();

        /// <summary>
        /// Gets the specified GroupPolicyCategory and returns a <see cref="GraphResponse{GroupPolicyCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyCategory>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified GroupPolicyCategory using POST.
        /// </summary>
        /// <param name="groupPolicyCategoryToCreate">The GroupPolicyCategory to create.</param>
        /// <returns>The created GroupPolicyCategory.</returns>
        System.Threading.Tasks.Task<GroupPolicyCategory> CreateAsync(GroupPolicyCategory groupPolicyCategoryToCreate);

        /// <summary>
        /// Creates the specified GroupPolicyCategory using POST.
        /// </summary>
        /// <param name="groupPolicyCategoryToCreate">The GroupPolicyCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyCategory.</returns>
        System.Threading.Tasks.Task<GroupPolicyCategory> CreateAsync(GroupPolicyCategory groupPolicyCategoryToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified GroupPolicyCategory using POST and returns a <see cref="GraphResponse{GroupPolicyCategory}"/> object.
        /// </summary>
        /// <param name="groupPolicyCategoryToCreate">The GroupPolicyCategory to create.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyCategory>> CreateResponseAsync(GroupPolicyCategory groupPolicyCategoryToCreate);

        /// <summary>
        /// Creates the specified GroupPolicyCategory using POST and returns a <see cref="GraphResponse{GroupPolicyCategory}"/> object.
        /// </summary>
        /// <param name="groupPolicyCategoryToCreate">The GroupPolicyCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyCategory>> CreateResponseAsync(GroupPolicyCategory groupPolicyCategoryToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified GroupPolicyCategory using PATCH.
        /// </summary>
        /// <param name="groupPolicyCategoryToUpdate">The GroupPolicyCategory to update.</param>
        /// <returns>The updated GroupPolicyCategory.</returns>
        System.Threading.Tasks.Task<GroupPolicyCategory> UpdateAsync(GroupPolicyCategory groupPolicyCategoryToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyCategory using PATCH.
        /// </summary>
        /// <param name="groupPolicyCategoryToUpdate">The GroupPolicyCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyCategory.</returns>
        System.Threading.Tasks.Task<GroupPolicyCategory> UpdateAsync(GroupPolicyCategory groupPolicyCategoryToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified GroupPolicyCategory using PATCH and returns a <see cref="GraphResponse{GroupPolicyCategory}"/> object.
        /// </summary>
        /// <param name="groupPolicyCategoryToUpdate">The GroupPolicyCategory to update.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyCategory>> UpdateResponseAsync(GroupPolicyCategory groupPolicyCategoryToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyCategory using PATCH and returns a <see cref="GraphResponse{GroupPolicyCategory}"/> object.
        /// </summary>
        /// <param name="groupPolicyCategoryToUpdate">The GroupPolicyCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyCategory>> UpdateResponseAsync(GroupPolicyCategory groupPolicyCategoryToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified GroupPolicyCategory.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified GroupPolicyCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyCategoryWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyCategoryWithReferenceRequest Expand(Expression<Func<GroupPolicyCategory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyCategoryWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyCategoryWithReferenceRequest Select(Expression<Func<GroupPolicyCategory, object>> selectExpression);

    }
}
