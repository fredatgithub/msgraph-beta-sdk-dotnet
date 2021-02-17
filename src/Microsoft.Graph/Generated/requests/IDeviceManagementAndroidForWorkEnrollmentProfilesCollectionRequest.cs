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
    /// The interface IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest.
    /// </summary>
    public partial interface IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified AndroidForWorkEnrollmentProfile to the collection via POST.
        /// </summary>
        /// <param name="androidForWorkEnrollmentProfile">The AndroidForWorkEnrollmentProfile to add.</param>
        /// <returns>The created AndroidForWorkEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkEnrollmentProfile> AddAsync(AndroidForWorkEnrollmentProfile androidForWorkEnrollmentProfile);

        /// <summary>
        /// Adds the specified AndroidForWorkEnrollmentProfile to the collection via POST.
        /// </summary>
        /// <param name="androidForWorkEnrollmentProfile">The AndroidForWorkEnrollmentProfile to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkEnrollmentProfile> AddAsync(AndroidForWorkEnrollmentProfile androidForWorkEnrollmentProfile, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified AndroidForWorkEnrollmentProfile to the collection via POST and returns a <see cref="GraphResponse{AndroidForWorkEnrollmentProfile}"/> object of the request.
        /// </summary>
        /// <param name="androidForWorkEnrollmentProfile">The AndroidForWorkEnrollmentProfile to add.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkEnrollmentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkEnrollmentProfile>> AddResponseAsync(AndroidForWorkEnrollmentProfile androidForWorkEnrollmentProfile);

        /// <summary>
        /// Adds the specified AndroidForWorkEnrollmentProfile to the collection via POST and returns a <see cref="GraphResponse{AndroidForWorkEnrollmentProfile}"/> object of the request.
        /// </summary>
        /// <param name="androidForWorkEnrollmentProfile">The AndroidForWorkEnrollmentProfile to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkEnrollmentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkEnrollmentProfile>> AddResponseAsync(AndroidForWorkEnrollmentProfile androidForWorkEnrollmentProfile, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceManagementAndroidForWorkEnrollmentProfilesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAndroidForWorkEnrollmentProfilesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementAndroidForWorkEnrollmentProfilesCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceManagementAndroidForWorkEnrollmentProfilesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAndroidForWorkEnrollmentProfilesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementAndroidForWorkEnrollmentProfilesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest Expand(Expression<Func<AndroidForWorkEnrollmentProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest Select(Expression<Func<AndroidForWorkEnrollmentProfile, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest OrderBy(string value);
    }
}
