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
    /// The interface IAndroidDeviceOwnerWiFiConfigurationRequest.
    /// </summary>
    public partial interface IAndroidDeviceOwnerWiFiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidDeviceOwnerWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerWiFiConfigurationToCreate">The AndroidDeviceOwnerWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceOwnerWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerWiFiConfiguration> CreateAsync(AndroidDeviceOwnerWiFiConfiguration androidDeviceOwnerWiFiConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerWiFiConfiguration using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerWiFiConfigurationToCreate">The AndroidDeviceOwnerWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerWiFiConfiguration>> CreateResponseAsync(AndroidDeviceOwnerWiFiConfiguration androidDeviceOwnerWiFiConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceOwnerWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerWiFiConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerWiFiConfiguration and returns a <see cref="GraphResponse{AndroidDeviceOwnerWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerWiFiConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerWiFiConfigurationToUpdate">The AndroidDeviceOwnerWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceOwnerWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerWiFiConfiguration> UpdateAsync(AndroidDeviceOwnerWiFiConfiguration androidDeviceOwnerWiFiConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerWiFiConfigurationToUpdate">The AndroidDeviceOwnerWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerWiFiConfiguration>> UpdateResponseAsync(AndroidDeviceOwnerWiFiConfiguration androidDeviceOwnerWiFiConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerWiFiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerWiFiConfigurationRequest Expand(Expression<Func<AndroidDeviceOwnerWiFiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerWiFiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerWiFiConfigurationRequest Select(Expression<Func<AndroidDeviceOwnerWiFiConfiguration, object>> selectExpression);

    }
}
