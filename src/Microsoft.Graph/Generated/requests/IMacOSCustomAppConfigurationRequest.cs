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
    /// The interface IMacOSCustomAppConfigurationRequest.
    /// </summary>
    public partial interface IMacOSCustomAppConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSCustomAppConfiguration using POST.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToCreate">The MacOSCustomAppConfiguration to create.</param>
        /// <returns>The created MacOSCustomAppConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSCustomAppConfiguration> CreateAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToCreate);

        /// <summary>
        /// Creates the specified MacOSCustomAppConfiguration using POST.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToCreate">The MacOSCustomAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSCustomAppConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSCustomAppConfiguration> CreateAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified MacOSCustomAppConfiguration using POST and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToCreate">The MacOSCustomAppConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> CreateResponseAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToCreate);

        /// <summary>
        /// Creates the specified MacOSCustomAppConfiguration using POST and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToCreate">The MacOSCustomAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> CreateResponseAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSCustomAppConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSCustomAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSCustomAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified MacOSCustomAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSCustomAppConfiguration.
        /// </summary>
        /// <returns>The MacOSCustomAppConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSCustomAppConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified MacOSCustomAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSCustomAppConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSCustomAppConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSCustomAppConfiguration and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified MacOSCustomAppConfiguration and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSCustomAppConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToUpdate">The MacOSCustomAppConfiguration to update.</param>
        /// <returns>The updated MacOSCustomAppConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSCustomAppConfiguration> UpdateAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToUpdate);

        /// <summary>
        /// Updates the specified MacOSCustomAppConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToUpdate">The MacOSCustomAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSCustomAppConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSCustomAppConfiguration> UpdateAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSCustomAppConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToUpdate">The MacOSCustomAppConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> UpdateResponseAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToUpdate);

        /// <summary>
        /// Updates the specified MacOSCustomAppConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToUpdate">The MacOSCustomAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> UpdateResponseAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCustomAppConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCustomAppConfigurationRequest Expand(Expression<Func<MacOSCustomAppConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCustomAppConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCustomAppConfigurationRequest Select(Expression<Func<MacOSCustomAppConfiguration, object>> selectExpression);

    }
}
