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
    /// The interface IIosImportedPFXCertificateProfileRequest.
    /// </summary>
    public partial interface IIosImportedPFXCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToCreate">The IosImportedPFXCertificateProfile to create.</param>
        /// <returns>The created IosImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosImportedPFXCertificateProfile> CreateAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToCreate);

        /// <summary>
        /// Creates the specified IosImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToCreate">The IosImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosImportedPFXCertificateProfile> CreateAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified IosImportedPFXCertificateProfile using POST and returns a <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToCreate">The IosImportedPFXCertificateProfile to create.</param>
        /// <returns>The <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosImportedPFXCertificateProfile>> CreateResponseAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToCreate);

        /// <summary>
        /// Creates the specified IosImportedPFXCertificateProfile using POST and returns a <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToCreate">The IosImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosImportedPFXCertificateProfile>> CreateResponseAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosImportedPFXCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified IosImportedPFXCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The IosImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosImportedPFXCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified IosImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosImportedPFXCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosImportedPFXCertificateProfile and returns a <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosImportedPFXCertificateProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified IosImportedPFXCertificateProfile and returns a <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosImportedPFXCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToUpdate">The IosImportedPFXCertificateProfile to update.</param>
        /// <returns>The updated IosImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosImportedPFXCertificateProfile> UpdateAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified IosImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToUpdate">The IosImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosImportedPFXCertificateProfile> UpdateAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosImportedPFXCertificateProfile using PATCH and returns a <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToUpdate">The IosImportedPFXCertificateProfile to update.</param>
        /// <returns>The <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosImportedPFXCertificateProfile>> UpdateResponseAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified IosImportedPFXCertificateProfile using PATCH and returns a <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToUpdate">The IosImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosImportedPFXCertificateProfile>> UpdateResponseAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosImportedPFXCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosImportedPFXCertificateProfileRequest Expand(Expression<Func<IosImportedPFXCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosImportedPFXCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosImportedPFXCertificateProfileRequest Select(Expression<Func<IosImportedPFXCertificateProfile, object>> selectExpression);

    }
}
