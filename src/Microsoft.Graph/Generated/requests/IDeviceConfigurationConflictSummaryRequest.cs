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
    /// The interface IDeviceConfigurationConflictSummaryRequest.
    /// </summary>
    public partial interface IDeviceConfigurationConflictSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfigurationConflictSummary using POST.
        /// </summary>
        /// <param name="deviceConfigurationConflictSummaryToCreate">The DeviceConfigurationConflictSummary to create.</param>
        /// <returns>The created DeviceConfigurationConflictSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationConflictSummary> CreateAsync(DeviceConfigurationConflictSummary deviceConfigurationConflictSummaryToCreate);

        /// <summary>
        /// Creates the specified DeviceConfigurationConflictSummary using POST.
        /// </summary>
        /// <param name="deviceConfigurationConflictSummaryToCreate">The DeviceConfigurationConflictSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationConflictSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationConflictSummary> CreateAsync(DeviceConfigurationConflictSummary deviceConfigurationConflictSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceConfigurationConflictSummary using POST and returns a <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationConflictSummaryToCreate">The DeviceConfigurationConflictSummary to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationConflictSummary>> CreateResponseAsync(DeviceConfigurationConflictSummary deviceConfigurationConflictSummaryToCreate);

        /// <summary>
        /// Creates the specified DeviceConfigurationConflictSummary using POST and returns a <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationConflictSummaryToCreate">The DeviceConfigurationConflictSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationConflictSummary>> CreateResponseAsync(DeviceConfigurationConflictSummary deviceConfigurationConflictSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceConfigurationConflictSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceConfigurationConflictSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceConfigurationConflictSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceConfigurationConflictSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceConfigurationConflictSummary.
        /// </summary>
        /// <returns>The DeviceConfigurationConflictSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationConflictSummary> GetAsync();

        /// <summary>
        /// Gets the specified DeviceConfigurationConflictSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationConflictSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationConflictSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceConfigurationConflictSummary and returns a <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationConflictSummary>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceConfigurationConflictSummary and returns a <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationConflictSummary>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceConfigurationConflictSummary using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationConflictSummaryToUpdate">The DeviceConfigurationConflictSummary to update.</param>
        /// <returns>The updated DeviceConfigurationConflictSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationConflictSummary> UpdateAsync(DeviceConfigurationConflictSummary deviceConfigurationConflictSummaryToUpdate);

        /// <summary>
        /// Updates the specified DeviceConfigurationConflictSummary using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationConflictSummaryToUpdate">The DeviceConfigurationConflictSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceConfigurationConflictSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationConflictSummary> UpdateAsync(DeviceConfigurationConflictSummary deviceConfigurationConflictSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceConfigurationConflictSummary using PATCH and returns a <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationConflictSummaryToUpdate">The DeviceConfigurationConflictSummary to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationConflictSummary>> UpdateResponseAsync(DeviceConfigurationConflictSummary deviceConfigurationConflictSummaryToUpdate);

        /// <summary>
        /// Updates the specified DeviceConfigurationConflictSummary using PATCH and returns a <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationConflictSummaryToUpdate">The DeviceConfigurationConflictSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationConflictSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationConflictSummary>> UpdateResponseAsync(DeviceConfigurationConflictSummary deviceConfigurationConflictSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationConflictSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationConflictSummaryRequest Expand(Expression<Func<DeviceConfigurationConflictSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationConflictSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationConflictSummaryRequest Select(Expression<Func<DeviceConfigurationConflictSummary, object>> selectExpression);

    }
}
