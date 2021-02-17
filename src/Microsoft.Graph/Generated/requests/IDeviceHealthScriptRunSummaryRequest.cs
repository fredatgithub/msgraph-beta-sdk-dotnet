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
    /// The interface IDeviceHealthScriptRunSummaryRequest.
    /// </summary>
    public partial interface IDeviceHealthScriptRunSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceHealthScriptRunSummary using POST.
        /// </summary>
        /// <param name="deviceHealthScriptRunSummaryToCreate">The DeviceHealthScriptRunSummary to create.</param>
        /// <returns>The created DeviceHealthScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceHealthScriptRunSummary> CreateAsync(DeviceHealthScriptRunSummary deviceHealthScriptRunSummaryToCreate);

        /// <summary>
        /// Creates the specified DeviceHealthScriptRunSummary using POST.
        /// </summary>
        /// <param name="deviceHealthScriptRunSummaryToCreate">The DeviceHealthScriptRunSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceHealthScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceHealthScriptRunSummary> CreateAsync(DeviceHealthScriptRunSummary deviceHealthScriptRunSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceHealthScriptRunSummary using POST and returns a <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object.
        /// </summary>
        /// <param name="deviceHealthScriptRunSummaryToCreate">The DeviceHealthScriptRunSummary to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptRunSummary>> CreateResponseAsync(DeviceHealthScriptRunSummary deviceHealthScriptRunSummaryToCreate);

        /// <summary>
        /// Creates the specified DeviceHealthScriptRunSummary using POST and returns a <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object.
        /// </summary>
        /// <param name="deviceHealthScriptRunSummaryToCreate">The DeviceHealthScriptRunSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptRunSummary>> CreateResponseAsync(DeviceHealthScriptRunSummary deviceHealthScriptRunSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceHealthScriptRunSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceHealthScriptRunSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceHealthScriptRunSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceHealthScriptRunSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceHealthScriptRunSummary.
        /// </summary>
        /// <returns>The DeviceHealthScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceHealthScriptRunSummary> GetAsync();

        /// <summary>
        /// Gets the specified DeviceHealthScriptRunSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceHealthScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceHealthScriptRunSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceHealthScriptRunSummary and returns a <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptRunSummary>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceHealthScriptRunSummary and returns a <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptRunSummary>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceHealthScriptRunSummary using PATCH.
        /// </summary>
        /// <param name="deviceHealthScriptRunSummaryToUpdate">The DeviceHealthScriptRunSummary to update.</param>
        /// <returns>The updated DeviceHealthScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceHealthScriptRunSummary> UpdateAsync(DeviceHealthScriptRunSummary deviceHealthScriptRunSummaryToUpdate);

        /// <summary>
        /// Updates the specified DeviceHealthScriptRunSummary using PATCH.
        /// </summary>
        /// <param name="deviceHealthScriptRunSummaryToUpdate">The DeviceHealthScriptRunSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceHealthScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceHealthScriptRunSummary> UpdateAsync(DeviceHealthScriptRunSummary deviceHealthScriptRunSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceHealthScriptRunSummary using PATCH and returns a <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object.
        /// </summary>
        /// <param name="deviceHealthScriptRunSummaryToUpdate">The DeviceHealthScriptRunSummary to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptRunSummary>> UpdateResponseAsync(DeviceHealthScriptRunSummary deviceHealthScriptRunSummaryToUpdate);

        /// <summary>
        /// Updates the specified DeviceHealthScriptRunSummary using PATCH and returns a <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object.
        /// </summary>
        /// <param name="deviceHealthScriptRunSummaryToUpdate">The DeviceHealthScriptRunSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptRunSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptRunSummary>> UpdateResponseAsync(DeviceHealthScriptRunSummary deviceHealthScriptRunSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceHealthScriptRunSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceHealthScriptRunSummaryRequest Expand(Expression<Func<DeviceHealthScriptRunSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceHealthScriptRunSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceHealthScriptRunSummaryRequest Select(Expression<Func<DeviceHealthScriptRunSummary, object>> selectExpression);

    }
}
