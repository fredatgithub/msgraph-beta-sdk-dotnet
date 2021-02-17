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
    /// The interface IDeviceManagementConfigurationPolicyAssignmentRequest.
    /// </summary>
    public partial interface IDeviceManagementConfigurationPolicyAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicyAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToCreate">The DeviceManagementConfigurationPolicyAssignment to create.</param>
        /// <returns>The created DeviceManagementConfigurationPolicyAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> CreateAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicyAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToCreate">The DeviceManagementConfigurationPolicyAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementConfigurationPolicyAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> CreateAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicyAssignment using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToCreate">The DeviceManagementConfigurationPolicyAssignment to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> CreateResponseAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicyAssignment using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToCreate">The DeviceManagementConfigurationPolicyAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> CreateResponseAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicyAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicyAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicyAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicyAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicyAssignment.
        /// </summary>
        /// <returns>The DeviceManagementConfigurationPolicyAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicyAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementConfigurationPolicyAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicyAssignment and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicyAssignment and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToUpdate">The DeviceManagementConfigurationPolicyAssignment to update.</param>
        /// <returns>The updated DeviceManagementConfigurationPolicyAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> UpdateAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToUpdate">The DeviceManagementConfigurationPolicyAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementConfigurationPolicyAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyAssignment> UpdateAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyAssignment using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToUpdate">The DeviceManagementConfigurationPolicyAssignment to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> UpdateResponseAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyAssignment using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyAssignmentToUpdate">The DeviceManagementConfigurationPolicyAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyAssignment>> UpdateResponseAsync(DeviceManagementConfigurationPolicyAssignment deviceManagementConfigurationPolicyAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationPolicyAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationPolicyAssignmentRequest Expand(Expression<Func<DeviceManagementConfigurationPolicyAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationPolicyAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationPolicyAssignmentRequest Select(Expression<Func<DeviceManagementConfigurationPolicyAssignment, object>> selectExpression);

    }
}
