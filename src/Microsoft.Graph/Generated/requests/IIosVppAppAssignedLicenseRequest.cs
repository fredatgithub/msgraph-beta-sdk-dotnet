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
    /// The interface IIosVppAppAssignedLicenseRequest.
    /// </summary>
    public partial interface IIosVppAppAssignedLicenseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosVppAppAssignedLicense using POST.
        /// </summary>
        /// <param name="iosVppAppAssignedLicenseToCreate">The IosVppAppAssignedLicense to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosVppAppAssignedLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedLicense> CreateAsync(IosVppAppAssignedLicense iosVppAppAssignedLicenseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified IosVppAppAssignedLicense using POST and returns a <see cref="GraphResponse{IosVppAppAssignedLicense}"/> object.
        /// </summary>
        /// <param name="iosVppAppAssignedLicenseToCreate">The IosVppAppAssignedLicense to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedLicense}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedLicense>> CreateResponseAsync(IosVppAppAssignedLicense iosVppAppAssignedLicenseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosVppAppAssignedLicense.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosVppAppAssignedLicense and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IosVppAppAssignedLicense.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosVppAppAssignedLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedLicense> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IosVppAppAssignedLicense and returns a <see cref="GraphResponse{IosVppAppAssignedLicense}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedLicense}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedLicense>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosVppAppAssignedLicense using PATCH.
        /// </summary>
        /// <param name="iosVppAppAssignedLicenseToUpdate">The IosVppAppAssignedLicense to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosVppAppAssignedLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedLicense> UpdateAsync(IosVppAppAssignedLicense iosVppAppAssignedLicenseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosVppAppAssignedLicense using PATCH and returns a <see cref="GraphResponse{IosVppAppAssignedLicense}"/> object.
        /// </summary>
        /// <param name="iosVppAppAssignedLicenseToUpdate">The IosVppAppAssignedLicense to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedLicense}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedLicense>> UpdateResponseAsync(IosVppAppAssignedLicense iosVppAppAssignedLicenseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedLicenseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedLicenseRequest Expand(Expression<Func<IosVppAppAssignedLicense, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedLicenseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedLicenseRequest Select(Expression<Func<IosVppAppAssignedLicense, object>> selectExpression);

    }
}
