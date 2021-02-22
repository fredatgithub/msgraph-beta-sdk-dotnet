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
    /// The interface IAndroidWorkProfileGmailEasConfigurationRequest.
    /// </summary>
    public partial interface IAndroidWorkProfileGmailEasConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidWorkProfileGmailEasConfiguration using POST.
        /// </summary>
        /// <param name="androidWorkProfileGmailEasConfigurationToCreate">The AndroidWorkProfileGmailEasConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWorkProfileGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGmailEasConfiguration> CreateAsync(AndroidWorkProfileGmailEasConfiguration androidWorkProfileGmailEasConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidWorkProfileGmailEasConfiguration using POST and returns a <see cref="GraphResponse{AndroidWorkProfileGmailEasConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileGmailEasConfigurationToCreate">The AndroidWorkProfileGmailEasConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileGmailEasConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileGmailEasConfiguration>> CreateResponseAsync(AndroidWorkProfileGmailEasConfiguration androidWorkProfileGmailEasConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidWorkProfileGmailEasConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidWorkProfileGmailEasConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidWorkProfileGmailEasConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWorkProfileGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGmailEasConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidWorkProfileGmailEasConfiguration and returns a <see cref="GraphResponse{AndroidWorkProfileGmailEasConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileGmailEasConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileGmailEasConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidWorkProfileGmailEasConfiguration using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileGmailEasConfigurationToUpdate">The AndroidWorkProfileGmailEasConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidWorkProfileGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGmailEasConfiguration> UpdateAsync(AndroidWorkProfileGmailEasConfiguration androidWorkProfileGmailEasConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidWorkProfileGmailEasConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidWorkProfileGmailEasConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileGmailEasConfigurationToUpdate">The AndroidWorkProfileGmailEasConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileGmailEasConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileGmailEasConfiguration>> UpdateResponseAsync(AndroidWorkProfileGmailEasConfiguration androidWorkProfileGmailEasConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGmailEasConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGmailEasConfigurationRequest Expand(Expression<Func<AndroidWorkProfileGmailEasConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGmailEasConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGmailEasConfigurationRequest Select(Expression<Func<AndroidWorkProfileGmailEasConfiguration, object>> selectExpression);

    }
}
