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
    /// The interface IOrganizationSettingsRequest.
    /// </summary>
    public partial interface IOrganizationSettingsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OrganizationSettings using POST.
        /// </summary>
        /// <param name="organizationSettingsToCreate">The OrganizationSettings to create.</param>
        /// <returns>The created OrganizationSettings.</returns>
        System.Threading.Tasks.Task<OrganizationSettings> CreateAsync(OrganizationSettings organizationSettingsToCreate);

        /// <summary>
        /// Creates the specified OrganizationSettings using POST.
        /// </summary>
        /// <param name="organizationSettingsToCreate">The OrganizationSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OrganizationSettings.</returns>
        System.Threading.Tasks.Task<OrganizationSettings> CreateAsync(OrganizationSettings organizationSettingsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified OrganizationSettings using POST and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <param name="organizationSettingsToCreate">The OrganizationSettings to create.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> CreateResponseAsync(OrganizationSettings organizationSettingsToCreate);

        /// <summary>
        /// Creates the specified OrganizationSettings using POST and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <param name="organizationSettingsToCreate">The OrganizationSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> CreateResponseAsync(OrganizationSettings organizationSettingsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OrganizationSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OrganizationSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OrganizationSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified OrganizationSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OrganizationSettings.
        /// </summary>
        /// <returns>The OrganizationSettings.</returns>
        System.Threading.Tasks.Task<OrganizationSettings> GetAsync();

        /// <summary>
        /// Gets the specified OrganizationSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OrganizationSettings.</returns>
        System.Threading.Tasks.Task<OrganizationSettings> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OrganizationSettings and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> GetResponseAsync();

        /// <summary>
        /// Gets the specified OrganizationSettings and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OrganizationSettings using PATCH.
        /// </summary>
        /// <param name="organizationSettingsToUpdate">The OrganizationSettings to update.</param>
        /// <returns>The updated OrganizationSettings.</returns>
        System.Threading.Tasks.Task<OrganizationSettings> UpdateAsync(OrganizationSettings organizationSettingsToUpdate);

        /// <summary>
        /// Updates the specified OrganizationSettings using PATCH.
        /// </summary>
        /// <param name="organizationSettingsToUpdate">The OrganizationSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OrganizationSettings.</returns>
        System.Threading.Tasks.Task<OrganizationSettings> UpdateAsync(OrganizationSettings organizationSettingsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OrganizationSettings using PATCH and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <param name="organizationSettingsToUpdate">The OrganizationSettings to update.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> UpdateResponseAsync(OrganizationSettings organizationSettingsToUpdate);

        /// <summary>
        /// Updates the specified OrganizationSettings using PATCH and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <param name="organizationSettingsToUpdate">The OrganizationSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> UpdateResponseAsync(OrganizationSettings organizationSettingsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationSettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationSettingsRequest Expand(Expression<Func<OrganizationSettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationSettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationSettingsRequest Select(Expression<Func<OrganizationSettings, object>> selectExpression);

    }
}
