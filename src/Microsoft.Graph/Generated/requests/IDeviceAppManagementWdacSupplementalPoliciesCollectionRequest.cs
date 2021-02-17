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
    /// The interface IDeviceAppManagementWdacSupplementalPoliciesCollectionRequest.
    /// </summary>
    public partial interface IDeviceAppManagementWdacSupplementalPoliciesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified WindowsDefenderApplicationControlSupplementalPolicy to the collection via POST.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicy">The WindowsDefenderApplicationControlSupplementalPolicy to add.</param>
        /// <returns>The created WindowsDefenderApplicationControlSupplementalPolicy.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicy> AddAsync(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicy);

        /// <summary>
        /// Adds the specified WindowsDefenderApplicationControlSupplementalPolicy to the collection via POST.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicy">The WindowsDefenderApplicationControlSupplementalPolicy to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsDefenderApplicationControlSupplementalPolicy.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicy> AddAsync(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicy, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified WindowsDefenderApplicationControlSupplementalPolicy to the collection via POST and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object of the request.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicy">The WindowsDefenderApplicationControlSupplementalPolicy to add.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicy>> AddResponseAsync(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicy);

        /// <summary>
        /// Adds the specified WindowsDefenderApplicationControlSupplementalPolicy to the collection via POST and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object of the request.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicy">The WindowsDefenderApplicationControlSupplementalPolicy to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicy>> AddResponseAsync(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicy, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceAppManagementWdacSupplementalPoliciesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceAppManagementWdacSupplementalPoliciesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceAppManagementWdacSupplementalPoliciesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagementWdacSupplementalPoliciesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagementWdacSupplementalPoliciesCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceAppManagementWdacSupplementalPoliciesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagementWdacSupplementalPoliciesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagementWdacSupplementalPoliciesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementWdacSupplementalPoliciesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementWdacSupplementalPoliciesCollectionRequest Expand(Expression<Func<WindowsDefenderApplicationControlSupplementalPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementWdacSupplementalPoliciesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementWdacSupplementalPoliciesCollectionRequest Select(Expression<Func<WindowsDefenderApplicationControlSupplementalPolicy, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementWdacSupplementalPoliciesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementWdacSupplementalPoliciesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementWdacSupplementalPoliciesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementWdacSupplementalPoliciesCollectionRequest OrderBy(string value);
    }
}
