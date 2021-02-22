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
    /// The interface IDeviceManagementAutopilotPolicyStatusDetailRequest.
    /// </summary>
    public partial interface IDeviceManagementAutopilotPolicyStatusDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementAutopilotPolicyStatusDetail using POST.
        /// </summary>
        /// <param name="deviceManagementAutopilotPolicyStatusDetailToCreate">The DeviceManagementAutopilotPolicyStatusDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementAutopilotPolicyStatusDetail.</returns>
        System.Threading.Tasks.Task<DeviceManagementAutopilotPolicyStatusDetail> CreateAsync(DeviceManagementAutopilotPolicyStatusDetail deviceManagementAutopilotPolicyStatusDetailToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceManagementAutopilotPolicyStatusDetail using POST and returns a <see cref="GraphResponse{DeviceManagementAutopilotPolicyStatusDetail}"/> object.
        /// </summary>
        /// <param name="deviceManagementAutopilotPolicyStatusDetailToCreate">The DeviceManagementAutopilotPolicyStatusDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAutopilotPolicyStatusDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementAutopilotPolicyStatusDetail>> CreateResponseAsync(DeviceManagementAutopilotPolicyStatusDetail deviceManagementAutopilotPolicyStatusDetailToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementAutopilotPolicyStatusDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementAutopilotPolicyStatusDetail and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementAutopilotPolicyStatusDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementAutopilotPolicyStatusDetail.</returns>
        System.Threading.Tasks.Task<DeviceManagementAutopilotPolicyStatusDetail> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementAutopilotPolicyStatusDetail and returns a <see cref="GraphResponse{DeviceManagementAutopilotPolicyStatusDetail}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAutopilotPolicyStatusDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementAutopilotPolicyStatusDetail>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementAutopilotPolicyStatusDetail using PATCH.
        /// </summary>
        /// <param name="deviceManagementAutopilotPolicyStatusDetailToUpdate">The DeviceManagementAutopilotPolicyStatusDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementAutopilotPolicyStatusDetail.</returns>
        System.Threading.Tasks.Task<DeviceManagementAutopilotPolicyStatusDetail> UpdateAsync(DeviceManagementAutopilotPolicyStatusDetail deviceManagementAutopilotPolicyStatusDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementAutopilotPolicyStatusDetail using PATCH and returns a <see cref="GraphResponse{DeviceManagementAutopilotPolicyStatusDetail}"/> object.
        /// </summary>
        /// <param name="deviceManagementAutopilotPolicyStatusDetailToUpdate">The DeviceManagementAutopilotPolicyStatusDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAutopilotPolicyStatusDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementAutopilotPolicyStatusDetail>> UpdateResponseAsync(DeviceManagementAutopilotPolicyStatusDetail deviceManagementAutopilotPolicyStatusDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAutopilotPolicyStatusDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAutopilotPolicyStatusDetailRequest Expand(Expression<Func<DeviceManagementAutopilotPolicyStatusDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAutopilotPolicyStatusDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAutopilotPolicyStatusDetailRequest Select(Expression<Func<DeviceManagementAutopilotPolicyStatusDetail, object>> selectExpression);

    }
}
