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
    /// The interface IIosEasEmailProfileConfigurationRequest.
    /// </summary>
    public partial interface IIosEasEmailProfileConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosEasEmailProfileConfiguration using POST.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToCreate">The IosEasEmailProfileConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> CreateAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified IosEasEmailProfileConfiguration using POST and returns a <see cref="GraphResponse{IosEasEmailProfileConfiguration}"/> object.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToCreate">The IosEasEmailProfileConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosEasEmailProfileConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosEasEmailProfileConfiguration>> CreateResponseAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosEasEmailProfileConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosEasEmailProfileConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IosEasEmailProfileConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IosEasEmailProfileConfiguration and returns a <see cref="GraphResponse{IosEasEmailProfileConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosEasEmailProfileConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosEasEmailProfileConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosEasEmailProfileConfiguration using PATCH.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToUpdate">The IosEasEmailProfileConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> UpdateAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosEasEmailProfileConfiguration using PATCH and returns a <see cref="GraphResponse{IosEasEmailProfileConfiguration}"/> object.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToUpdate">The IosEasEmailProfileConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosEasEmailProfileConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosEasEmailProfileConfiguration>> UpdateResponseAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosEasEmailProfileConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosEasEmailProfileConfigurationRequest Expand(Expression<Func<IosEasEmailProfileConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosEasEmailProfileConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosEasEmailProfileConfigurationRequest Select(Expression<Func<IosEasEmailProfileConfiguration, object>> selectExpression);

    }
}
