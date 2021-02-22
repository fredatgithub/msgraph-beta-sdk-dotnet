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
    /// The interface IWindowsHealthMonitoringConfigurationRequest.
    /// </summary>
    public partial interface IWindowsHealthMonitoringConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsHealthMonitoringConfiguration using POST.
        /// </summary>
        /// <param name="windowsHealthMonitoringConfigurationToCreate">The WindowsHealthMonitoringConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsHealthMonitoringConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsHealthMonitoringConfiguration> CreateAsync(WindowsHealthMonitoringConfiguration windowsHealthMonitoringConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WindowsHealthMonitoringConfiguration using POST and returns a <see cref="GraphResponse{WindowsHealthMonitoringConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsHealthMonitoringConfigurationToCreate">The WindowsHealthMonitoringConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsHealthMonitoringConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsHealthMonitoringConfiguration>> CreateResponseAsync(WindowsHealthMonitoringConfiguration windowsHealthMonitoringConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsHealthMonitoringConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsHealthMonitoringConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsHealthMonitoringConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsHealthMonitoringConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsHealthMonitoringConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsHealthMonitoringConfiguration and returns a <see cref="GraphResponse{WindowsHealthMonitoringConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsHealthMonitoringConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsHealthMonitoringConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsHealthMonitoringConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsHealthMonitoringConfigurationToUpdate">The WindowsHealthMonitoringConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsHealthMonitoringConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsHealthMonitoringConfiguration> UpdateAsync(WindowsHealthMonitoringConfiguration windowsHealthMonitoringConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsHealthMonitoringConfiguration using PATCH and returns a <see cref="GraphResponse{WindowsHealthMonitoringConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsHealthMonitoringConfigurationToUpdate">The WindowsHealthMonitoringConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsHealthMonitoringConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsHealthMonitoringConfiguration>> UpdateResponseAsync(WindowsHealthMonitoringConfiguration windowsHealthMonitoringConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsHealthMonitoringConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsHealthMonitoringConfigurationRequest Expand(Expression<Func<WindowsHealthMonitoringConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsHealthMonitoringConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsHealthMonitoringConfigurationRequest Select(Expression<Func<WindowsHealthMonitoringConfiguration, object>> selectExpression);

    }
}
