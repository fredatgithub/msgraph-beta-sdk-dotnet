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
    /// The interface IWindows10ImportedPFXCertificateProfileRequest.
    /// </summary>
    public partial interface IWindows10ImportedPFXCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10ImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="windows10ImportedPFXCertificateProfileToCreate">The Windows10ImportedPFXCertificateProfile to create.</param>
        /// <returns>The created Windows10ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10ImportedPFXCertificateProfile> CreateAsync(Windows10ImportedPFXCertificateProfile windows10ImportedPFXCertificateProfileToCreate);

        /// <summary>
        /// Creates the specified Windows10ImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="windows10ImportedPFXCertificateProfileToCreate">The Windows10ImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10ImportedPFXCertificateProfile> CreateAsync(Windows10ImportedPFXCertificateProfile windows10ImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Windows10ImportedPFXCertificateProfile using POST and returns a <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="windows10ImportedPFXCertificateProfileToCreate">The Windows10ImportedPFXCertificateProfile to create.</param>
        /// <returns>The <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10ImportedPFXCertificateProfile>> CreateResponseAsync(Windows10ImportedPFXCertificateProfile windows10ImportedPFXCertificateProfileToCreate);

        /// <summary>
        /// Creates the specified Windows10ImportedPFXCertificateProfile using POST and returns a <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="windows10ImportedPFXCertificateProfileToCreate">The Windows10ImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10ImportedPFXCertificateProfile>> CreateResponseAsync(Windows10ImportedPFXCertificateProfile windows10ImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10ImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10ImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10ImportedPFXCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Windows10ImportedPFXCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10ImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The Windows10ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10ImportedPFXCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified Windows10ImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10ImportedPFXCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10ImportedPFXCertificateProfile and returns a <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10ImportedPFXCertificateProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Windows10ImportedPFXCertificateProfile and returns a <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10ImportedPFXCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10ImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="windows10ImportedPFXCertificateProfileToUpdate">The Windows10ImportedPFXCertificateProfile to update.</param>
        /// <returns>The updated Windows10ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10ImportedPFXCertificateProfile> UpdateAsync(Windows10ImportedPFXCertificateProfile windows10ImportedPFXCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified Windows10ImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="windows10ImportedPFXCertificateProfileToUpdate">The Windows10ImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10ImportedPFXCertificateProfile> UpdateAsync(Windows10ImportedPFXCertificateProfile windows10ImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10ImportedPFXCertificateProfile using PATCH and returns a <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="windows10ImportedPFXCertificateProfileToUpdate">The Windows10ImportedPFXCertificateProfile to update.</param>
        /// <returns>The <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10ImportedPFXCertificateProfile>> UpdateResponseAsync(Windows10ImportedPFXCertificateProfile windows10ImportedPFXCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified Windows10ImportedPFXCertificateProfile using PATCH and returns a <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="windows10ImportedPFXCertificateProfileToUpdate">The Windows10ImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows10ImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10ImportedPFXCertificateProfile>> UpdateResponseAsync(Windows10ImportedPFXCertificateProfile windows10ImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10ImportedPFXCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10ImportedPFXCertificateProfileRequest Expand(Expression<Func<Windows10ImportedPFXCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10ImportedPFXCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10ImportedPFXCertificateProfileRequest Select(Expression<Func<Windows10ImportedPFXCertificateProfile, object>> selectExpression);

    }
}
