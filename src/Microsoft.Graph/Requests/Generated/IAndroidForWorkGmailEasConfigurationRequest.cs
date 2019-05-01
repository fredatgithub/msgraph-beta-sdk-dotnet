// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAndroidForWorkGmailEasConfigurationRequest.
    /// </summary>
    public partial interface IAndroidForWorkGmailEasConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidForWorkGmailEasConfiguration using PUT.
        /// </summary>
        /// <param name="androidForWorkGmailEasConfigurationToCreate">The AndroidForWorkGmailEasConfiguration to create.</param>
        /// <returns>The created AndroidForWorkGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkGmailEasConfiguration> CreateAsync(AndroidForWorkGmailEasConfiguration androidForWorkGmailEasConfigurationToCreate);        /// <summary>
        /// Creates the specified AndroidForWorkGmailEasConfiguration using PUT.
        /// </summary>
        /// <param name="androidForWorkGmailEasConfigurationToCreate">The AndroidForWorkGmailEasConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkGmailEasConfiguration> CreateAsync(AndroidForWorkGmailEasConfiguration androidForWorkGmailEasConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidForWorkGmailEasConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidForWorkGmailEasConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidForWorkGmailEasConfiguration.
        /// </summary>
        /// <returns>The AndroidForWorkGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkGmailEasConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidForWorkGmailEasConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkGmailEasConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidForWorkGmailEasConfiguration using PATCH.
        /// </summary>
        /// <param name="androidForWorkGmailEasConfigurationToUpdate">The AndroidForWorkGmailEasConfiguration to update.</param>
        /// <returns>The updated AndroidForWorkGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkGmailEasConfiguration> UpdateAsync(AndroidForWorkGmailEasConfiguration androidForWorkGmailEasConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidForWorkGmailEasConfiguration using PATCH.
        /// </summary>
        /// <param name="androidForWorkGmailEasConfigurationToUpdate">The AndroidForWorkGmailEasConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AndroidForWorkGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkGmailEasConfiguration> UpdateAsync(AndroidForWorkGmailEasConfiguration androidForWorkGmailEasConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkGmailEasConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkGmailEasConfigurationRequest Expand(Expression<Func<AndroidForWorkGmailEasConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkGmailEasConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkGmailEasConfigurationRequest Select(Expression<Func<AndroidForWorkGmailEasConfiguration, object>> selectExpression);

    }
}