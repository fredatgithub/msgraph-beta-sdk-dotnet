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
    /// The interface IDeviceManagementTroubleshootingEventRequest.
    /// </summary>
    public partial interface IDeviceManagementTroubleshootingEventRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementTroubleshootingEvent using POST.
        /// </summary>
        /// <param name="deviceManagementTroubleshootingEventToCreate">The DeviceManagementTroubleshootingEvent to create.</param>
        /// <returns>The created DeviceManagementTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<DeviceManagementTroubleshootingEvent> CreateAsync(DeviceManagementTroubleshootingEvent deviceManagementTroubleshootingEventToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementTroubleshootingEvent using POST.
        /// </summary>
        /// <param name="deviceManagementTroubleshootingEventToCreate">The DeviceManagementTroubleshootingEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<DeviceManagementTroubleshootingEvent> CreateAsync(DeviceManagementTroubleshootingEvent deviceManagementTroubleshootingEventToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceManagementTroubleshootingEvent using POST and returns a <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="deviceManagementTroubleshootingEventToCreate">The DeviceManagementTroubleshootingEvent to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTroubleshootingEvent>> CreateResponseAsync(DeviceManagementTroubleshootingEvent deviceManagementTroubleshootingEventToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementTroubleshootingEvent using POST and returns a <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="deviceManagementTroubleshootingEventToCreate">The DeviceManagementTroubleshootingEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTroubleshootingEvent>> CreateResponseAsync(DeviceManagementTroubleshootingEvent deviceManagementTroubleshootingEventToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementTroubleshootingEvent.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementTroubleshootingEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementTroubleshootingEvent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementTroubleshootingEvent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementTroubleshootingEvent.
        /// </summary>
        /// <returns>The DeviceManagementTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<DeviceManagementTroubleshootingEvent> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementTroubleshootingEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<DeviceManagementTroubleshootingEvent> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementTroubleshootingEvent and returns a <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTroubleshootingEvent>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceManagementTroubleshootingEvent and returns a <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTroubleshootingEvent>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementTroubleshootingEvent using PATCH.
        /// </summary>
        /// <param name="deviceManagementTroubleshootingEventToUpdate">The DeviceManagementTroubleshootingEvent to update.</param>
        /// <returns>The updated DeviceManagementTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<DeviceManagementTroubleshootingEvent> UpdateAsync(DeviceManagementTroubleshootingEvent deviceManagementTroubleshootingEventToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementTroubleshootingEvent using PATCH.
        /// </summary>
        /// <param name="deviceManagementTroubleshootingEventToUpdate">The DeviceManagementTroubleshootingEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<DeviceManagementTroubleshootingEvent> UpdateAsync(DeviceManagementTroubleshootingEvent deviceManagementTroubleshootingEventToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementTroubleshootingEvent using PATCH and returns a <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="deviceManagementTroubleshootingEventToUpdate">The DeviceManagementTroubleshootingEvent to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTroubleshootingEvent>> UpdateResponseAsync(DeviceManagementTroubleshootingEvent deviceManagementTroubleshootingEventToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementTroubleshootingEvent using PATCH and returns a <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="deviceManagementTroubleshootingEventToUpdate">The DeviceManagementTroubleshootingEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTroubleshootingEvent>> UpdateResponseAsync(DeviceManagementTroubleshootingEvent deviceManagementTroubleshootingEventToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTroubleshootingEventRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTroubleshootingEventRequest Expand(Expression<Func<DeviceManagementTroubleshootingEvent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTroubleshootingEventRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTroubleshootingEventRequest Select(Expression<Func<DeviceManagementTroubleshootingEvent, object>> selectExpression);

    }
}
