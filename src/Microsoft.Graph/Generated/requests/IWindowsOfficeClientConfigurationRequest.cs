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
    /// The interface IWindowsOfficeClientConfigurationRequest.
    /// </summary>
    public partial interface IWindowsOfficeClientConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsOfficeClientConfiguration using POST.
        /// </summary>
        /// <param name="windowsOfficeClientConfigurationToCreate">The WindowsOfficeClientConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsOfficeClientConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsOfficeClientConfiguration> CreateAsync(WindowsOfficeClientConfiguration windowsOfficeClientConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WindowsOfficeClientConfiguration using POST and returns a <see cref="GraphResponse{WindowsOfficeClientConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsOfficeClientConfigurationToCreate">The WindowsOfficeClientConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsOfficeClientConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsOfficeClientConfiguration>> CreateResponseAsync(WindowsOfficeClientConfiguration windowsOfficeClientConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsOfficeClientConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsOfficeClientConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsOfficeClientConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsOfficeClientConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsOfficeClientConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsOfficeClientConfiguration and returns a <see cref="GraphResponse{WindowsOfficeClientConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsOfficeClientConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsOfficeClientConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsOfficeClientConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsOfficeClientConfigurationToUpdate">The WindowsOfficeClientConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsOfficeClientConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsOfficeClientConfiguration> UpdateAsync(WindowsOfficeClientConfiguration windowsOfficeClientConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsOfficeClientConfiguration using PATCH and returns a <see cref="GraphResponse{WindowsOfficeClientConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsOfficeClientConfigurationToUpdate">The WindowsOfficeClientConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsOfficeClientConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsOfficeClientConfiguration>> UpdateResponseAsync(WindowsOfficeClientConfiguration windowsOfficeClientConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsOfficeClientConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsOfficeClientConfigurationRequest Expand(Expression<Func<WindowsOfficeClientConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsOfficeClientConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsOfficeClientConfigurationRequest Select(Expression<Func<WindowsOfficeClientConfiguration, object>> selectExpression);

    }
}
