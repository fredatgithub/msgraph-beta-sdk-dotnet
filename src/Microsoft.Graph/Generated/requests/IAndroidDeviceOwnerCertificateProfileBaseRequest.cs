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
    /// The interface IAndroidDeviceOwnerCertificateProfileBaseRequest.
    /// </summary>
    public partial interface IAndroidDeviceOwnerCertificateProfileBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidDeviceOwnerCertificateProfileBase using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerCertificateProfileBaseToCreate">The AndroidDeviceOwnerCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceOwnerCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerCertificateProfileBase> CreateAsync(AndroidDeviceOwnerCertificateProfileBase androidDeviceOwnerCertificateProfileBaseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerCertificateProfileBase using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerCertificateProfileBaseToCreate">The AndroidDeviceOwnerCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerCertificateProfileBase>> CreateResponseAsync(AndroidDeviceOwnerCertificateProfileBase androidDeviceOwnerCertificateProfileBaseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerCertificateProfileBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceOwnerCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerCertificateProfileBase> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerCertificateProfileBase and returns a <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerCertificateProfileBase>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerCertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerCertificateProfileBaseToUpdate">The AndroidDeviceOwnerCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceOwnerCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerCertificateProfileBase> UpdateAsync(AndroidDeviceOwnerCertificateProfileBase androidDeviceOwnerCertificateProfileBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerCertificateProfileBase using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerCertificateProfileBaseToUpdate">The AndroidDeviceOwnerCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerCertificateProfileBase>> UpdateResponseAsync(AndroidDeviceOwnerCertificateProfileBase androidDeviceOwnerCertificateProfileBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerCertificateProfileBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerCertificateProfileBaseRequest Expand(Expression<Func<AndroidDeviceOwnerCertificateProfileBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerCertificateProfileBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerCertificateProfileBaseRequest Select(Expression<Func<AndroidDeviceOwnerCertificateProfileBase, object>> selectExpression);

    }
}
