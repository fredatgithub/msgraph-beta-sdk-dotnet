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
    /// The interface IDeviceManagementDerivedCredentialSettingsWithReferenceRequest.
    /// </summary>
    public partial interface IDeviceManagementDerivedCredentialSettingsWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified DeviceManagementDerivedCredentialSettings.
        /// </summary>
        /// <returns>The DeviceManagementDerivedCredentialSettings.</returns>
        System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementDerivedCredentialSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementDerivedCredentialSettings.</returns>
        System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementDerivedCredentialSettings and returns a <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementDerivedCredentialSettings>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceManagementDerivedCredentialSettings and returns a <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementDerivedCredentialSettings>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified DeviceManagementDerivedCredentialSettings using POST.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToCreate">The DeviceManagementDerivedCredentialSettings to create.</param>
        /// <returns>The created DeviceManagementDerivedCredentialSettings.</returns>
        System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> CreateAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementDerivedCredentialSettings using POST.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToCreate">The DeviceManagementDerivedCredentialSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementDerivedCredentialSettings.</returns>
        System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> CreateAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified DeviceManagementDerivedCredentialSettings using POST and returns a <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToCreate">The DeviceManagementDerivedCredentialSettings to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementDerivedCredentialSettings>> CreateResponseAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementDerivedCredentialSettings using POST and returns a <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToCreate">The DeviceManagementDerivedCredentialSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementDerivedCredentialSettings>> CreateResponseAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified DeviceManagementDerivedCredentialSettings using PATCH.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToUpdate">The DeviceManagementDerivedCredentialSettings to update.</param>
        /// <returns>The updated DeviceManagementDerivedCredentialSettings.</returns>
        System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> UpdateAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementDerivedCredentialSettings using PATCH.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToUpdate">The DeviceManagementDerivedCredentialSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementDerivedCredentialSettings.</returns>
        System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> UpdateAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified DeviceManagementDerivedCredentialSettings using PATCH and returns a <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToUpdate">The DeviceManagementDerivedCredentialSettings to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementDerivedCredentialSettings>> UpdateResponseAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementDerivedCredentialSettings using PATCH and returns a <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToUpdate">The DeviceManagementDerivedCredentialSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementDerivedCredentialSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementDerivedCredentialSettings>> UpdateResponseAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified DeviceManagementDerivedCredentialSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementDerivedCredentialSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified DeviceManagementDerivedCredentialSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementDerivedCredentialSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDerivedCredentialSettingsWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDerivedCredentialSettingsWithReferenceRequest Expand(Expression<Func<DeviceManagementDerivedCredentialSettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDerivedCredentialSettingsWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDerivedCredentialSettingsWithReferenceRequest Select(Expression<Func<DeviceManagementDerivedCredentialSettings, object>> selectExpression);

    }
}
