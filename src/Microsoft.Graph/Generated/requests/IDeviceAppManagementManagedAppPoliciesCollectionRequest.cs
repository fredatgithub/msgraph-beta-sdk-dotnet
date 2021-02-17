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
    /// The interface IDeviceAppManagementManagedAppPoliciesCollectionRequest.
    /// </summary>
    public partial interface IDeviceAppManagementManagedAppPoliciesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified ManagedAppPolicy to the collection via POST.
        /// </summary>
        /// <param name="managedAppPolicy">The ManagedAppPolicy to add.</param>
        /// <returns>The created ManagedAppPolicy.</returns>
        System.Threading.Tasks.Task<ManagedAppPolicy> AddAsync(ManagedAppPolicy managedAppPolicy);

        /// <summary>
        /// Adds the specified ManagedAppPolicy to the collection via POST.
        /// </summary>
        /// <param name="managedAppPolicy">The ManagedAppPolicy to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppPolicy.</returns>
        System.Threading.Tasks.Task<ManagedAppPolicy> AddAsync(ManagedAppPolicy managedAppPolicy, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified ManagedAppPolicy to the collection via POST and returns a <see cref="GraphResponse{ManagedAppPolicy}"/> object of the request.
        /// </summary>
        /// <param name="managedAppPolicy">The ManagedAppPolicy to add.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAppPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppPolicy>> AddResponseAsync(ManagedAppPolicy managedAppPolicy);

        /// <summary>
        /// Adds the specified ManagedAppPolicy to the collection via POST and returns a <see cref="GraphResponse{ManagedAppPolicy}"/> object of the request.
        /// </summary>
        /// <param name="managedAppPolicy">The ManagedAppPolicy to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAppPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppPolicy>> AddResponseAsync(ManagedAppPolicy managedAppPolicy, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceAppManagementManagedAppPoliciesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceAppManagementManagedAppPoliciesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceAppManagementManagedAppPoliciesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagementManagedAppPoliciesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagementManagedAppPoliciesCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceAppManagementManagedAppPoliciesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagementManagedAppPoliciesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagementManagedAppPoliciesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementManagedAppPoliciesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementManagedAppPoliciesCollectionRequest Expand(Expression<Func<ManagedAppPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementManagedAppPoliciesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementManagedAppPoliciesCollectionRequest Select(Expression<Func<ManagedAppPolicy, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementManagedAppPoliciesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementManagedAppPoliciesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementManagedAppPoliciesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementManagedAppPoliciesCollectionRequest OrderBy(string value);
    }
}
