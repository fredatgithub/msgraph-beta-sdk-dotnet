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
    /// The interface IDeviceManagementIntentAssignmentRequest.
    /// </summary>
    public partial interface IDeviceManagementIntentAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementIntentAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementIntentAssignmentToCreate">The DeviceManagementIntentAssignment to create.</param>
        /// <returns>The created DeviceManagementIntentAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentAssignment> CreateAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignmentToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementIntentAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementIntentAssignmentToCreate">The DeviceManagementIntentAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementIntentAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentAssignment> CreateAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceManagementIntentAssignment using POST and returns a <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentAssignmentToCreate">The DeviceManagementIntentAssignment to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentAssignment>> CreateResponseAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignmentToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementIntentAssignment using POST and returns a <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentAssignmentToCreate">The DeviceManagementIntentAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentAssignment>> CreateResponseAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementIntentAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementIntentAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementIntentAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementIntentAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementIntentAssignment.
        /// </summary>
        /// <returns>The DeviceManagementIntentAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentAssignment> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementIntentAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementIntentAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementIntentAssignment and returns a <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentAssignment>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceManagementIntentAssignment and returns a <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentAssignment>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementIntentAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementIntentAssignmentToUpdate">The DeviceManagementIntentAssignment to update.</param>
        /// <returns>The updated DeviceManagementIntentAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentAssignment> UpdateAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignmentToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementIntentAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementIntentAssignmentToUpdate">The DeviceManagementIntentAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementIntentAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentAssignment> UpdateAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementIntentAssignment using PATCH and returns a <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentAssignmentToUpdate">The DeviceManagementIntentAssignment to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentAssignment>> UpdateResponseAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignmentToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementIntentAssignment using PATCH and returns a <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentAssignmentToUpdate">The DeviceManagementIntentAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentAssignment>> UpdateResponseAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentRequest Expand(Expression<Func<DeviceManagementIntentAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentRequest Select(Expression<Func<DeviceManagementIntentAssignment, object>> selectExpression);

    }
}
