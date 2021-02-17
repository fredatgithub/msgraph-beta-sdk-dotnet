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
    /// The interface IVpnConfigurationRequest.
    /// </summary>
    public partial interface IVpnConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified VpnConfiguration using POST.
        /// </summary>
        /// <param name="vpnConfigurationToCreate">The VpnConfiguration to create.</param>
        /// <returns>The created VpnConfiguration.</returns>
        System.Threading.Tasks.Task<VpnConfiguration> CreateAsync(VpnConfiguration vpnConfigurationToCreate);

        /// <summary>
        /// Creates the specified VpnConfiguration using POST.
        /// </summary>
        /// <param name="vpnConfigurationToCreate">The VpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created VpnConfiguration.</returns>
        System.Threading.Tasks.Task<VpnConfiguration> CreateAsync(VpnConfiguration vpnConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified VpnConfiguration using POST and returns a <see cref="GraphResponse{VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="vpnConfigurationToCreate">The VpnConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VpnConfiguration>> CreateResponseAsync(VpnConfiguration vpnConfigurationToCreate);

        /// <summary>
        /// Creates the specified VpnConfiguration using POST and returns a <see cref="GraphResponse{VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="vpnConfigurationToCreate">The VpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VpnConfiguration>> CreateResponseAsync(VpnConfiguration vpnConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified VpnConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified VpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified VpnConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified VpnConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified VpnConfiguration.
        /// </summary>
        /// <returns>The VpnConfiguration.</returns>
        System.Threading.Tasks.Task<VpnConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified VpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The VpnConfiguration.</returns>
        System.Threading.Tasks.Task<VpnConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified VpnConfiguration and returns a <see cref="GraphResponse{VpnConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VpnConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified VpnConfiguration and returns a <see cref="GraphResponse{VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VpnConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified VpnConfiguration using PATCH.
        /// </summary>
        /// <param name="vpnConfigurationToUpdate">The VpnConfiguration to update.</param>
        /// <returns>The updated VpnConfiguration.</returns>
        System.Threading.Tasks.Task<VpnConfiguration> UpdateAsync(VpnConfiguration vpnConfigurationToUpdate);

        /// <summary>
        /// Updates the specified VpnConfiguration using PATCH.
        /// </summary>
        /// <param name="vpnConfigurationToUpdate">The VpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated VpnConfiguration.</returns>
        System.Threading.Tasks.Task<VpnConfiguration> UpdateAsync(VpnConfiguration vpnConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified VpnConfiguration using PATCH and returns a <see cref="GraphResponse{VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="vpnConfigurationToUpdate">The VpnConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VpnConfiguration>> UpdateResponseAsync(VpnConfiguration vpnConfigurationToUpdate);

        /// <summary>
        /// Updates the specified VpnConfiguration using PATCH and returns a <see cref="GraphResponse{VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="vpnConfigurationToUpdate">The VpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VpnConfiguration>> UpdateResponseAsync(VpnConfiguration vpnConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IVpnConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IVpnConfigurationRequest Expand(Expression<Func<VpnConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IVpnConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IVpnConfigurationRequest Select(Expression<Func<VpnConfiguration, object>> selectExpression);

    }
}
