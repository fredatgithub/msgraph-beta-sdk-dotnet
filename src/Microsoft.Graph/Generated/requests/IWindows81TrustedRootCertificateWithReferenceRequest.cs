// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindows81TrustedRootCertificateWithReferenceRequest.
    /// </summary>
    public partial interface IWindows81TrustedRootCertificateWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified Windows81TrustedRootCertificate.
        /// </summary>
        /// <returns>The Windows81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<Windows81TrustedRootCertificate> GetAsync();

        /// <summary>
        /// Gets the specified Windows81TrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<Windows81TrustedRootCertificate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows81TrustedRootCertificate and returns a <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81TrustedRootCertificate>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Windows81TrustedRootCertificate and returns a <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81TrustedRootCertificate>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified Windows81TrustedRootCertificate using POST.
        /// </summary>
        /// <param name="windows81TrustedRootCertificateToCreate">The Windows81TrustedRootCertificate to create.</param>
        /// <returns>The created Windows81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<Windows81TrustedRootCertificate> CreateAsync(Windows81TrustedRootCertificate windows81TrustedRootCertificateToCreate);

        /// <summary>
        /// Creates the specified Windows81TrustedRootCertificate using POST.
        /// </summary>
        /// <param name="windows81TrustedRootCertificateToCreate">The Windows81TrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<Windows81TrustedRootCertificate> CreateAsync(Windows81TrustedRootCertificate windows81TrustedRootCertificateToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified Windows81TrustedRootCertificate using POST and returns a <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="windows81TrustedRootCertificateToCreate">The Windows81TrustedRootCertificate to create.</param>
        /// <returns>The <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81TrustedRootCertificate>> CreateResponseAsync(Windows81TrustedRootCertificate windows81TrustedRootCertificateToCreate);

        /// <summary>
        /// Creates the specified Windows81TrustedRootCertificate using POST and returns a <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="windows81TrustedRootCertificateToCreate">The Windows81TrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81TrustedRootCertificate>> CreateResponseAsync(Windows81TrustedRootCertificate windows81TrustedRootCertificateToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified Windows81TrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="windows81TrustedRootCertificateToUpdate">The Windows81TrustedRootCertificate to update.</param>
        /// <returns>The updated Windows81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<Windows81TrustedRootCertificate> UpdateAsync(Windows81TrustedRootCertificate windows81TrustedRootCertificateToUpdate);

        /// <summary>
        /// Updates the specified Windows81TrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="windows81TrustedRootCertificateToUpdate">The Windows81TrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<Windows81TrustedRootCertificate> UpdateAsync(Windows81TrustedRootCertificate windows81TrustedRootCertificateToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified Windows81TrustedRootCertificate using PATCH and returns a <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="windows81TrustedRootCertificateToUpdate">The Windows81TrustedRootCertificate to update.</param>
        /// <returns>The <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81TrustedRootCertificate>> UpdateResponseAsync(Windows81TrustedRootCertificate windows81TrustedRootCertificateToUpdate);

        /// <summary>
        /// Updates the specified Windows81TrustedRootCertificate using PATCH and returns a <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="windows81TrustedRootCertificateToUpdate">The Windows81TrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows81TrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81TrustedRootCertificate>> UpdateResponseAsync(Windows81TrustedRootCertificate windows81TrustedRootCertificateToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified Windows81TrustedRootCertificate.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows81TrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified Windows81TrustedRootCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Windows81TrustedRootCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81TrustedRootCertificateWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81TrustedRootCertificateWithReferenceRequest Expand(Expression<Func<Windows81TrustedRootCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81TrustedRootCertificateWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81TrustedRootCertificateWithReferenceRequest Select(Expression<Func<Windows81TrustedRootCertificate, object>> selectExpression);

    }
}
