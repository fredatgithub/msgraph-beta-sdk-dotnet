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
    /// The interface IHostSecurityProfileRequest.
    /// </summary>
    public partial interface IHostSecurityProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified HostSecurityProfile using PUT.
        /// </summary>
        /// <param name="hostSecurityProfileToCreate">The HostSecurityProfile to create.</param>
        /// <returns>The created HostSecurityProfile.</returns>
        System.Threading.Tasks.Task<HostSecurityProfile> CreateAsync(HostSecurityProfile hostSecurityProfileToCreate);        /// <summary>
        /// Creates the specified HostSecurityProfile using PUT.
        /// </summary>
        /// <param name="hostSecurityProfileToCreate">The HostSecurityProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created HostSecurityProfile.</returns>
        System.Threading.Tasks.Task<HostSecurityProfile> CreateAsync(HostSecurityProfile hostSecurityProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified HostSecurityProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified HostSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified HostSecurityProfile.
        /// </summary>
        /// <returns>The HostSecurityProfile.</returns>
        System.Threading.Tasks.Task<HostSecurityProfile> GetAsync();

        /// <summary>
        /// Gets the specified HostSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The HostSecurityProfile.</returns>
        System.Threading.Tasks.Task<HostSecurityProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified HostSecurityProfile using PATCH.
        /// </summary>
        /// <param name="hostSecurityProfileToUpdate">The HostSecurityProfile to update.</param>
        /// <returns>The updated HostSecurityProfile.</returns>
        System.Threading.Tasks.Task<HostSecurityProfile> UpdateAsync(HostSecurityProfile hostSecurityProfileToUpdate);

        /// <summary>
        /// Updates the specified HostSecurityProfile using PATCH.
        /// </summary>
        /// <param name="hostSecurityProfileToUpdate">The HostSecurityProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated HostSecurityProfile.</returns>
        System.Threading.Tasks.Task<HostSecurityProfile> UpdateAsync(HostSecurityProfile hostSecurityProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IHostSecurityProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IHostSecurityProfileRequest Expand(Expression<Func<HostSecurityProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IHostSecurityProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IHostSecurityProfileRequest Select(Expression<Func<HostSecurityProfile, object>> selectExpression);

    }
}