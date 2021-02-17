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
    /// The interface IDeviceManagementConfigurationCategoryRequest.
    /// </summary>
    public partial interface IDeviceManagementConfigurationCategoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementConfigurationCategory using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationCategoryToCreate">The DeviceManagementConfigurationCategory to create.</param>
        /// <returns>The created DeviceManagementConfigurationCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationCategory> CreateAsync(DeviceManagementConfigurationCategory deviceManagementConfigurationCategoryToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationCategory using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationCategoryToCreate">The DeviceManagementConfigurationCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementConfigurationCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationCategory> CreateAsync(DeviceManagementConfigurationCategory deviceManagementConfigurationCategoryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationCategory using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationCategoryToCreate">The DeviceManagementConfigurationCategory to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationCategory>> CreateResponseAsync(DeviceManagementConfigurationCategory deviceManagementConfigurationCategoryToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationCategory using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationCategoryToCreate">The DeviceManagementConfigurationCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationCategory>> CreateResponseAsync(DeviceManagementConfigurationCategory deviceManagementConfigurationCategoryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationCategory.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationCategory.
        /// </summary>
        /// <returns>The DeviceManagementConfigurationCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationCategory> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementConfigurationCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationCategory> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationCategory and returns a <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationCategory>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationCategory and returns a <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationCategory>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationCategory using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationCategoryToUpdate">The DeviceManagementConfigurationCategory to update.</param>
        /// <returns>The updated DeviceManagementConfigurationCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationCategory> UpdateAsync(DeviceManagementConfigurationCategory deviceManagementConfigurationCategoryToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationCategory using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationCategoryToUpdate">The DeviceManagementConfigurationCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementConfigurationCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationCategory> UpdateAsync(DeviceManagementConfigurationCategory deviceManagementConfigurationCategoryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationCategory using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationCategoryToUpdate">The DeviceManagementConfigurationCategory to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationCategory>> UpdateResponseAsync(DeviceManagementConfigurationCategory deviceManagementConfigurationCategoryToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationCategory using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationCategoryToUpdate">The DeviceManagementConfigurationCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationCategory>> UpdateResponseAsync(DeviceManagementConfigurationCategory deviceManagementConfigurationCategoryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationCategoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationCategoryRequest Expand(Expression<Func<DeviceManagementConfigurationCategory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationCategoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationCategoryRequest Select(Expression<Func<DeviceManagementConfigurationCategory, object>> selectExpression);

    }
}
