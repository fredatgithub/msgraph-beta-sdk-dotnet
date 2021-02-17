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
    /// The interface IDeviceAppManagementSideLoadingKeysCollectionRequest.
    /// </summary>
    public partial interface IDeviceAppManagementSideLoadingKeysCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified SideLoadingKey to the collection via POST.
        /// </summary>
        /// <param name="sideLoadingKey">The SideLoadingKey to add.</param>
        /// <returns>The created SideLoadingKey.</returns>
        System.Threading.Tasks.Task<SideLoadingKey> AddAsync(SideLoadingKey sideLoadingKey);

        /// <summary>
        /// Adds the specified SideLoadingKey to the collection via POST.
        /// </summary>
        /// <param name="sideLoadingKey">The SideLoadingKey to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SideLoadingKey.</returns>
        System.Threading.Tasks.Task<SideLoadingKey> AddAsync(SideLoadingKey sideLoadingKey, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified SideLoadingKey to the collection via POST and returns a <see cref="GraphResponse{SideLoadingKey}"/> object of the request.
        /// </summary>
        /// <param name="sideLoadingKey">The SideLoadingKey to add.</param>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> AddResponseAsync(SideLoadingKey sideLoadingKey);

        /// <summary>
        /// Adds the specified SideLoadingKey to the collection via POST and returns a <see cref="GraphResponse{SideLoadingKey}"/> object of the request.
        /// </summary>
        /// <param name="sideLoadingKey">The SideLoadingKey to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> AddResponseAsync(SideLoadingKey sideLoadingKey, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceAppManagementSideLoadingKeysCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceAppManagementSideLoadingKeysCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceAppManagementSideLoadingKeysCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagementSideLoadingKeysCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagementSideLoadingKeysCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceAppManagementSideLoadingKeysCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagementSideLoadingKeysCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagementSideLoadingKeysCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementSideLoadingKeysCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementSideLoadingKeysCollectionRequest Expand(Expression<Func<SideLoadingKey, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementSideLoadingKeysCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementSideLoadingKeysCollectionRequest Select(Expression<Func<SideLoadingKey, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementSideLoadingKeysCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementSideLoadingKeysCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementSideLoadingKeysCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementSideLoadingKeysCollectionRequest OrderBy(string value);
    }
}
