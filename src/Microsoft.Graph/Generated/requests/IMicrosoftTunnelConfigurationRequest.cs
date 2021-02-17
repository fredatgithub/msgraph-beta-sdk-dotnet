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
    /// The interface IMicrosoftTunnelConfigurationRequest.
    /// </summary>
    public partial interface IMicrosoftTunnelConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MicrosoftTunnelConfiguration using POST.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToCreate">The MicrosoftTunnelConfiguration to create.</param>
        /// <returns>The created MicrosoftTunnelConfiguration.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelConfiguration> CreateAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToCreate);

        /// <summary>
        /// Creates the specified MicrosoftTunnelConfiguration using POST.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToCreate">The MicrosoftTunnelConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MicrosoftTunnelConfiguration.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelConfiguration> CreateAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified MicrosoftTunnelConfiguration using POST and returns a <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToCreate">The MicrosoftTunnelConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelConfiguration>> CreateResponseAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToCreate);

        /// <summary>
        /// Creates the specified MicrosoftTunnelConfiguration using POST and returns a <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToCreate">The MicrosoftTunnelConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelConfiguration>> CreateResponseAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MicrosoftTunnelConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MicrosoftTunnelConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MicrosoftTunnelConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified MicrosoftTunnelConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MicrosoftTunnelConfiguration.
        /// </summary>
        /// <returns>The MicrosoftTunnelConfiguration.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified MicrosoftTunnelConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MicrosoftTunnelConfiguration.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MicrosoftTunnelConfiguration and returns a <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified MicrosoftTunnelConfiguration and returns a <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MicrosoftTunnelConfiguration using PATCH.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToUpdate">The MicrosoftTunnelConfiguration to update.</param>
        /// <returns>The updated MicrosoftTunnelConfiguration.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelConfiguration> UpdateAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToUpdate);

        /// <summary>
        /// Updates the specified MicrosoftTunnelConfiguration using PATCH.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToUpdate">The MicrosoftTunnelConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MicrosoftTunnelConfiguration.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelConfiguration> UpdateAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MicrosoftTunnelConfiguration using PATCH and returns a <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToUpdate">The MicrosoftTunnelConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelConfiguration>> UpdateResponseAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToUpdate);

        /// <summary>
        /// Updates the specified MicrosoftTunnelConfiguration using PATCH and returns a <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToUpdate">The MicrosoftTunnelConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelConfiguration>> UpdateResponseAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftTunnelConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftTunnelConfigurationRequest Expand(Expression<Func<MicrosoftTunnelConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftTunnelConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftTunnelConfigurationRequest Select(Expression<Func<MicrosoftTunnelConfiguration, object>> selectExpression);

    }
}
