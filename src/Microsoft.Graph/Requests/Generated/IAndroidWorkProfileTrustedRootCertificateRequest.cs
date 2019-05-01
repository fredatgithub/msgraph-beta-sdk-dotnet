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
    /// The interface IAndroidWorkProfileTrustedRootCertificateRequest.
    /// </summary>
    public partial interface IAndroidWorkProfileTrustedRootCertificateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidWorkProfileTrustedRootCertificate using PUT.
        /// </summary>
        /// <param name="androidWorkProfileTrustedRootCertificateToCreate">The AndroidWorkProfileTrustedRootCertificate to create.</param>
        /// <returns>The created AndroidWorkProfileTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileTrustedRootCertificate> CreateAsync(AndroidWorkProfileTrustedRootCertificate androidWorkProfileTrustedRootCertificateToCreate);        /// <summary>
        /// Creates the specified AndroidWorkProfileTrustedRootCertificate using PUT.
        /// </summary>
        /// <param name="androidWorkProfileTrustedRootCertificateToCreate">The AndroidWorkProfileTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWorkProfileTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileTrustedRootCertificate> CreateAsync(AndroidWorkProfileTrustedRootCertificate androidWorkProfileTrustedRootCertificateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidWorkProfileTrustedRootCertificate.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidWorkProfileTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidWorkProfileTrustedRootCertificate.
        /// </summary>
        /// <returns>The AndroidWorkProfileTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileTrustedRootCertificate> GetAsync();

        /// <summary>
        /// Gets the specified AndroidWorkProfileTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWorkProfileTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileTrustedRootCertificate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidWorkProfileTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileTrustedRootCertificateToUpdate">The AndroidWorkProfileTrustedRootCertificate to update.</param>
        /// <returns>The updated AndroidWorkProfileTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileTrustedRootCertificate> UpdateAsync(AndroidWorkProfileTrustedRootCertificate androidWorkProfileTrustedRootCertificateToUpdate);

        /// <summary>
        /// Updates the specified AndroidWorkProfileTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileTrustedRootCertificateToUpdate">The AndroidWorkProfileTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AndroidWorkProfileTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileTrustedRootCertificate> UpdateAsync(AndroidWorkProfileTrustedRootCertificate androidWorkProfileTrustedRootCertificateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileTrustedRootCertificateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileTrustedRootCertificateRequest Expand(Expression<Func<AndroidWorkProfileTrustedRootCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileTrustedRootCertificateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileTrustedRootCertificateRequest Select(Expression<Func<AndroidWorkProfileTrustedRootCertificate, object>> selectExpression);

    }
}