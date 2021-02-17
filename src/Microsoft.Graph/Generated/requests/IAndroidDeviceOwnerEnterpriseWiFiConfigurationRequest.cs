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
    /// The interface IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest.
    /// </summary>
    public partial interface IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToCreate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to create.</param>
        /// <returns>The created AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> CreateAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToCreate);

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToCreate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> CreateAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToCreate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> CreateResponseAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToCreate);

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToCreate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> CreateResponseAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to update.</param>
        /// <returns>The updated AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> UpdateAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> UpdateAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> UpdateResponseAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> UpdateResponseAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest Expand(Expression<Func<AndroidDeviceOwnerEnterpriseWiFiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest Select(Expression<Func<AndroidDeviceOwnerEnterpriseWiFiConfiguration, object>> selectExpression);

    }
}
