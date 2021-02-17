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
    /// The interface IAgreementFileVersionRequest.
    /// </summary>
    public partial interface IAgreementFileVersionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AgreementFileVersion using POST.
        /// </summary>
        /// <param name="agreementFileVersionToCreate">The AgreementFileVersion to create.</param>
        /// <returns>The created AgreementFileVersion.</returns>
        System.Threading.Tasks.Task<AgreementFileVersion> CreateAsync(AgreementFileVersion agreementFileVersionToCreate);

        /// <summary>
        /// Creates the specified AgreementFileVersion using POST.
        /// </summary>
        /// <param name="agreementFileVersionToCreate">The AgreementFileVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AgreementFileVersion.</returns>
        System.Threading.Tasks.Task<AgreementFileVersion> CreateAsync(AgreementFileVersion agreementFileVersionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified AgreementFileVersion using POST and returns a <see cref="GraphResponse{AgreementFileVersion}"/> object.
        /// </summary>
        /// <param name="agreementFileVersionToCreate">The AgreementFileVersion to create.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFileVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgreementFileVersion>> CreateResponseAsync(AgreementFileVersion agreementFileVersionToCreate);

        /// <summary>
        /// Creates the specified AgreementFileVersion using POST and returns a <see cref="GraphResponse{AgreementFileVersion}"/> object.
        /// </summary>
        /// <param name="agreementFileVersionToCreate">The AgreementFileVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFileVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgreementFileVersion>> CreateResponseAsync(AgreementFileVersion agreementFileVersionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AgreementFileVersion.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AgreementFileVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AgreementFileVersion and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified AgreementFileVersion and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AgreementFileVersion.
        /// </summary>
        /// <returns>The AgreementFileVersion.</returns>
        System.Threading.Tasks.Task<AgreementFileVersion> GetAsync();

        /// <summary>
        /// Gets the specified AgreementFileVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AgreementFileVersion.</returns>
        System.Threading.Tasks.Task<AgreementFileVersion> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AgreementFileVersion and returns a <see cref="GraphResponse{AgreementFileVersion}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AgreementFileVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgreementFileVersion>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AgreementFileVersion and returns a <see cref="GraphResponse{AgreementFileVersion}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFileVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgreementFileVersion>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AgreementFileVersion using PATCH.
        /// </summary>
        /// <param name="agreementFileVersionToUpdate">The AgreementFileVersion to update.</param>
        /// <returns>The updated AgreementFileVersion.</returns>
        System.Threading.Tasks.Task<AgreementFileVersion> UpdateAsync(AgreementFileVersion agreementFileVersionToUpdate);

        /// <summary>
        /// Updates the specified AgreementFileVersion using PATCH.
        /// </summary>
        /// <param name="agreementFileVersionToUpdate">The AgreementFileVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AgreementFileVersion.</returns>
        System.Threading.Tasks.Task<AgreementFileVersion> UpdateAsync(AgreementFileVersion agreementFileVersionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AgreementFileVersion using PATCH and returns a <see cref="GraphResponse{AgreementFileVersion}"/> object.
        /// </summary>
        /// <param name="agreementFileVersionToUpdate">The AgreementFileVersion to update.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFileVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgreementFileVersion>> UpdateResponseAsync(AgreementFileVersion agreementFileVersionToUpdate);

        /// <summary>
        /// Updates the specified AgreementFileVersion using PATCH and returns a <see cref="GraphResponse{AgreementFileVersion}"/> object.
        /// </summary>
        /// <param name="agreementFileVersionToUpdate">The AgreementFileVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AgreementFileVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgreementFileVersion>> UpdateResponseAsync(AgreementFileVersion agreementFileVersionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementFileVersionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementFileVersionRequest Expand(Expression<Func<AgreementFileVersion, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementFileVersionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementFileVersionRequest Select(Expression<Func<AgreementFileVersion, object>> selectExpression);

    }
}
