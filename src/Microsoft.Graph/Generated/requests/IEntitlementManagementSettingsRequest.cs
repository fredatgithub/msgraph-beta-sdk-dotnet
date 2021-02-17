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
    /// The interface IEntitlementManagementSettingsRequest.
    /// </summary>
    public partial interface IEntitlementManagementSettingsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EntitlementManagementSettings using POST.
        /// </summary>
        /// <param name="entitlementManagementSettingsToCreate">The EntitlementManagementSettings to create.</param>
        /// <returns>The created EntitlementManagementSettings.</returns>
        System.Threading.Tasks.Task<EntitlementManagementSettings> CreateAsync(EntitlementManagementSettings entitlementManagementSettingsToCreate);

        /// <summary>
        /// Creates the specified EntitlementManagementSettings using POST.
        /// </summary>
        /// <param name="entitlementManagementSettingsToCreate">The EntitlementManagementSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EntitlementManagementSettings.</returns>
        System.Threading.Tasks.Task<EntitlementManagementSettings> CreateAsync(EntitlementManagementSettings entitlementManagementSettingsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified EntitlementManagementSettings using POST and returns a <see cref="GraphResponse{EntitlementManagementSettings}"/> object.
        /// </summary>
        /// <param name="entitlementManagementSettingsToCreate">The EntitlementManagementSettings to create.</param>
        /// <returns>The <see cref="GraphResponse{EntitlementManagementSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EntitlementManagementSettings>> CreateResponseAsync(EntitlementManagementSettings entitlementManagementSettingsToCreate);

        /// <summary>
        /// Creates the specified EntitlementManagementSettings using POST and returns a <see cref="GraphResponse{EntitlementManagementSettings}"/> object.
        /// </summary>
        /// <param name="entitlementManagementSettingsToCreate">The EntitlementManagementSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EntitlementManagementSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EntitlementManagementSettings>> CreateResponseAsync(EntitlementManagementSettings entitlementManagementSettingsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EntitlementManagementSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EntitlementManagementSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EntitlementManagementSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified EntitlementManagementSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EntitlementManagementSettings.
        /// </summary>
        /// <returns>The EntitlementManagementSettings.</returns>
        System.Threading.Tasks.Task<EntitlementManagementSettings> GetAsync();

        /// <summary>
        /// Gets the specified EntitlementManagementSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EntitlementManagementSettings.</returns>
        System.Threading.Tasks.Task<EntitlementManagementSettings> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EntitlementManagementSettings and returns a <see cref="GraphResponse{EntitlementManagementSettings}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{EntitlementManagementSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EntitlementManagementSettings>> GetResponseAsync();

        /// <summary>
        /// Gets the specified EntitlementManagementSettings and returns a <see cref="GraphResponse{EntitlementManagementSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EntitlementManagementSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EntitlementManagementSettings>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EntitlementManagementSettings using PATCH.
        /// </summary>
        /// <param name="entitlementManagementSettingsToUpdate">The EntitlementManagementSettings to update.</param>
        /// <returns>The updated EntitlementManagementSettings.</returns>
        System.Threading.Tasks.Task<EntitlementManagementSettings> UpdateAsync(EntitlementManagementSettings entitlementManagementSettingsToUpdate);

        /// <summary>
        /// Updates the specified EntitlementManagementSettings using PATCH.
        /// </summary>
        /// <param name="entitlementManagementSettingsToUpdate">The EntitlementManagementSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EntitlementManagementSettings.</returns>
        System.Threading.Tasks.Task<EntitlementManagementSettings> UpdateAsync(EntitlementManagementSettings entitlementManagementSettingsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EntitlementManagementSettings using PATCH and returns a <see cref="GraphResponse{EntitlementManagementSettings}"/> object.
        /// </summary>
        /// <param name="entitlementManagementSettingsToUpdate">The EntitlementManagementSettings to update.</param>
        /// <returns>The <see cref="GraphResponse{EntitlementManagementSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EntitlementManagementSettings>> UpdateResponseAsync(EntitlementManagementSettings entitlementManagementSettingsToUpdate);

        /// <summary>
        /// Updates the specified EntitlementManagementSettings using PATCH and returns a <see cref="GraphResponse{EntitlementManagementSettings}"/> object.
        /// </summary>
        /// <param name="entitlementManagementSettingsToUpdate">The EntitlementManagementSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EntitlementManagementSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EntitlementManagementSettings>> UpdateResponseAsync(EntitlementManagementSettings entitlementManagementSettingsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEntitlementManagementSettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEntitlementManagementSettingsRequest Expand(Expression<Func<EntitlementManagementSettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEntitlementManagementSettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEntitlementManagementSettingsRequest Select(Expression<Func<EntitlementManagementSettings, object>> selectExpression);

    }
}
