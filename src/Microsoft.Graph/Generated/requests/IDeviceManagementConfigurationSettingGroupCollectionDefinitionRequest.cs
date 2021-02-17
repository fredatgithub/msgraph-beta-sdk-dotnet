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
    /// The interface IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest.
    /// </summary>
    public partial interface IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to create.</param>
        /// <returns>The created DeviceManagementConfigurationSettingGroupCollectionDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupCollectionDefinition> CreateAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementConfigurationSettingGroupCollectionDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupCollectionDefinition> CreateAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>> CreateResponseAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>> CreateResponseAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSettingGroupCollectionDefinition.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSettingGroupCollectionDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSettingGroupCollectionDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSettingGroupCollectionDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSettingGroupCollectionDefinition.
        /// </summary>
        /// <returns>The DeviceManagementConfigurationSettingGroupCollectionDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupCollectionDefinition> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSettingGroupCollectionDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementConfigurationSettingGroupCollectionDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupCollectionDefinition> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSettingGroupCollectionDefinition and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSettingGroupCollectionDefinition and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to update.</param>
        /// <returns>The updated DeviceManagementConfigurationSettingGroupCollectionDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupCollectionDefinition> UpdateAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementConfigurationSettingGroupCollectionDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupCollectionDefinition> UpdateAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>> UpdateResponseAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>> UpdateResponseAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest Expand(Expression<Func<DeviceManagementConfigurationSettingGroupCollectionDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest Select(Expression<Func<DeviceManagementConfigurationSettingGroupCollectionDefinition, object>> selectExpression);

    }
}
