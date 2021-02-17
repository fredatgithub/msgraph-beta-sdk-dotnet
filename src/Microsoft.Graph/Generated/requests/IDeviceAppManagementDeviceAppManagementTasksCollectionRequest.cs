// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceAppManagementDeviceAppManagementTasksCollectionRequest.
    /// </summary>
    public partial interface IDeviceAppManagementDeviceAppManagementTasksCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified DeviceAppManagementTask to the collection via POST.
        /// </summary>
        /// <param name="deviceAppManagementTask">The DeviceAppManagementTask to add.</param>
        /// <returns>The created DeviceAppManagementTask.</returns>
        System.Threading.Tasks.Task<DeviceAppManagementTask> AddAsync(DeviceAppManagementTask deviceAppManagementTask);

        /// <summary>
        /// Adds the specified DeviceAppManagementTask to the collection via POST.
        /// </summary>
        /// <param name="deviceAppManagementTask">The DeviceAppManagementTask to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceAppManagementTask.</returns>
        System.Threading.Tasks.Task<DeviceAppManagementTask> AddAsync(DeviceAppManagementTask deviceAppManagementTask, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified DeviceAppManagementTask to the collection via POST and returns a <see cref="GraphResponse{DeviceAppManagementTask}"/> object of the request.
        /// </summary>
        /// <param name="deviceAppManagementTask">The DeviceAppManagementTask to add.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagementTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagementTask>> AddResponseAsync(DeviceAppManagementTask deviceAppManagementTask);

        /// <summary>
        /// Adds the specified DeviceAppManagementTask to the collection via POST and returns a <see cref="GraphResponse{DeviceAppManagementTask}"/> object of the request.
        /// </summary>
        /// <param name="deviceAppManagementTask">The DeviceAppManagementTask to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagementTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagementTask>> AddResponseAsync(DeviceAppManagementTask deviceAppManagementTask, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceAppManagementDeviceAppManagementTasksCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceAppManagementDeviceAppManagementTasksCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceAppManagementDeviceAppManagementTasksCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagementDeviceAppManagementTasksCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagementDeviceAppManagementTasksCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceAppManagementDeviceAppManagementTasksCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagementDeviceAppManagementTasksCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagementDeviceAppManagementTasksCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementDeviceAppManagementTasksCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementDeviceAppManagementTasksCollectionRequest Expand(Expression<Func<DeviceAppManagementTask, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementDeviceAppManagementTasksCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementDeviceAppManagementTasksCollectionRequest Select(Expression<Func<DeviceAppManagementTask, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementDeviceAppManagementTasksCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementDeviceAppManagementTasksCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementDeviceAppManagementTasksCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementDeviceAppManagementTasksCollectionRequest OrderBy(string value);
    }
}
