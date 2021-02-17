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
    /// The interface IDeviceManagementIntentAssignmentsCollectionRequest.
    /// </summary>
    public partial interface IDeviceManagementIntentAssignmentsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified DeviceManagementIntentAssignment to the collection via POST.
        /// </summary>
        /// <param name="deviceManagementIntentAssignment">The DeviceManagementIntentAssignment to add.</param>
        /// <returns>The created DeviceManagementIntentAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentAssignment> AddAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignment);

        /// <summary>
        /// Adds the specified DeviceManagementIntentAssignment to the collection via POST.
        /// </summary>
        /// <param name="deviceManagementIntentAssignment">The DeviceManagementIntentAssignment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementIntentAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentAssignment> AddAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignment, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified DeviceManagementIntentAssignment to the collection via POST and returns a <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object of the request.
        /// </summary>
        /// <param name="deviceManagementIntentAssignment">The DeviceManagementIntentAssignment to add.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentAssignment>> AddResponseAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignment);

        /// <summary>
        /// Adds the specified DeviceManagementIntentAssignment to the collection via POST and returns a <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object of the request.
        /// </summary>
        /// <param name="deviceManagementIntentAssignment">The DeviceManagementIntentAssignment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentAssignment>> AddResponseAsync(DeviceManagementIntentAssignment deviceManagementIntentAssignment, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementIntentAssignmentsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementIntentAssignmentsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceManagementIntentAssignmentsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentAssignmentsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentAssignmentsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceManagementIntentAssignmentsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentAssignmentsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentAssignmentsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentsCollectionRequest Expand(Expression<Func<DeviceManagementIntentAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentsCollectionRequest Select(Expression<Func<DeviceManagementIntentAssignment, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentAssignmentsCollectionRequest OrderBy(string value);
    }
}
