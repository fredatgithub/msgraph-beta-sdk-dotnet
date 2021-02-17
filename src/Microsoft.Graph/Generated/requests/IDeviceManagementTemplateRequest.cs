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
    /// The interface IDeviceManagementTemplateRequest.
    /// </summary>
    public partial interface IDeviceManagementTemplateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementTemplate using POST.
        /// </summary>
        /// <param name="deviceManagementTemplateToCreate">The DeviceManagementTemplate to create.</param>
        /// <returns>The created DeviceManagementTemplate.</returns>
        System.Threading.Tasks.Task<DeviceManagementTemplate> CreateAsync(DeviceManagementTemplate deviceManagementTemplateToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementTemplate using POST.
        /// </summary>
        /// <param name="deviceManagementTemplateToCreate">The DeviceManagementTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementTemplate.</returns>
        System.Threading.Tasks.Task<DeviceManagementTemplate> CreateAsync(DeviceManagementTemplate deviceManagementTemplateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceManagementTemplate using POST and returns a <see cref="GraphResponse{DeviceManagementTemplate}"/> object.
        /// </summary>
        /// <param name="deviceManagementTemplateToCreate">The DeviceManagementTemplate to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplate>> CreateResponseAsync(DeviceManagementTemplate deviceManagementTemplateToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementTemplate using POST and returns a <see cref="GraphResponse{DeviceManagementTemplate}"/> object.
        /// </summary>
        /// <param name="deviceManagementTemplateToCreate">The DeviceManagementTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplate>> CreateResponseAsync(DeviceManagementTemplate deviceManagementTemplateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementTemplate.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementTemplate.
        /// </summary>
        /// <returns>The DeviceManagementTemplate.</returns>
        System.Threading.Tasks.Task<DeviceManagementTemplate> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementTemplate.</returns>
        System.Threading.Tasks.Task<DeviceManagementTemplate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementTemplate and returns a <see cref="GraphResponse{DeviceManagementTemplate}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplate>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceManagementTemplate and returns a <see cref="GraphResponse{DeviceManagementTemplate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplate>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementTemplate using PATCH.
        /// </summary>
        /// <param name="deviceManagementTemplateToUpdate">The DeviceManagementTemplate to update.</param>
        /// <returns>The updated DeviceManagementTemplate.</returns>
        System.Threading.Tasks.Task<DeviceManagementTemplate> UpdateAsync(DeviceManagementTemplate deviceManagementTemplateToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementTemplate using PATCH.
        /// </summary>
        /// <param name="deviceManagementTemplateToUpdate">The DeviceManagementTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementTemplate.</returns>
        System.Threading.Tasks.Task<DeviceManagementTemplate> UpdateAsync(DeviceManagementTemplate deviceManagementTemplateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementTemplate using PATCH and returns a <see cref="GraphResponse{DeviceManagementTemplate}"/> object.
        /// </summary>
        /// <param name="deviceManagementTemplateToUpdate">The DeviceManagementTemplate to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplate>> UpdateResponseAsync(DeviceManagementTemplate deviceManagementTemplateToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementTemplate using PATCH and returns a <see cref="GraphResponse{DeviceManagementTemplate}"/> object.
        /// </summary>
        /// <param name="deviceManagementTemplateToUpdate">The DeviceManagementTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplate>> UpdateResponseAsync(DeviceManagementTemplate deviceManagementTemplateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTemplateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTemplateRequest Expand(Expression<Func<DeviceManagementTemplate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTemplateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTemplateRequest Select(Expression<Func<DeviceManagementTemplate, object>> selectExpression);

    }
}
