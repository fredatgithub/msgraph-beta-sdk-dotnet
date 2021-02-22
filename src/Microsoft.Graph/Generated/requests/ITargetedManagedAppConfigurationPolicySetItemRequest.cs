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
    /// The interface ITargetedManagedAppConfigurationPolicySetItemRequest.
    /// </summary>
    public partial interface ITargetedManagedAppConfigurationPolicySetItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TargetedManagedAppConfigurationPolicySetItem using POST.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationPolicySetItemToCreate">The TargetedManagedAppConfigurationPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TargetedManagedAppConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppConfigurationPolicySetItem> CreateAsync(TargetedManagedAppConfigurationPolicySetItem targetedManagedAppConfigurationPolicySetItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified TargetedManagedAppConfigurationPolicySetItem using POST and returns a <see cref="GraphResponse{TargetedManagedAppConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationPolicySetItemToCreate">The TargetedManagedAppConfigurationPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfigurationPolicySetItem>> CreateResponseAsync(TargetedManagedAppConfigurationPolicySetItem targetedManagedAppConfigurationPolicySetItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfigurationPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfigurationPolicySetItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TargetedManagedAppConfigurationPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TargetedManagedAppConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppConfigurationPolicySetItem> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TargetedManagedAppConfigurationPolicySetItem and returns a <see cref="GraphResponse{TargetedManagedAppConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfigurationPolicySetItem>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TargetedManagedAppConfigurationPolicySetItem using PATCH.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationPolicySetItemToUpdate">The TargetedManagedAppConfigurationPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TargetedManagedAppConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppConfigurationPolicySetItem> UpdateAsync(TargetedManagedAppConfigurationPolicySetItem targetedManagedAppConfigurationPolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TargetedManagedAppConfigurationPolicySetItem using PATCH and returns a <see cref="GraphResponse{TargetedManagedAppConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationPolicySetItemToUpdate">The TargetedManagedAppConfigurationPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfigurationPolicySetItem>> UpdateResponseAsync(TargetedManagedAppConfigurationPolicySetItem targetedManagedAppConfigurationPolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppConfigurationPolicySetItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppConfigurationPolicySetItemRequest Expand(Expression<Func<TargetedManagedAppConfigurationPolicySetItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppConfigurationPolicySetItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppConfigurationPolicySetItemRequest Select(Expression<Func<TargetedManagedAppConfigurationPolicySetItem, object>> selectExpression);

    }
}
