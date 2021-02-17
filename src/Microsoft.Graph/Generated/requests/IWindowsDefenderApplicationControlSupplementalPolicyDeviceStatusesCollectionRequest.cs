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
    /// The interface IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionRequest.
    /// </summary>
    public partial interface IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to the collection via POST.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to add.</param>
        /// <returns>The created WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus> AddAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus);

        /// <summary>
        /// Adds the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to the collection via POST.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus> AddAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to the collection via POST and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object of the request.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to add.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>> AddResponseAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus);

        /// <summary>
        /// Adds the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to the collection via POST and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object of the request.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>> AddResponseAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionRequest Expand(Expression<Func<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionRequest Select(Expression<Func<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeviceStatusesCollectionRequest OrderBy(string value);
    }
}
