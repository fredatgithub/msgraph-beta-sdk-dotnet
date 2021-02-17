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
    /// The interface IIosVppAppAssignedDeviceLicenseRequest.
    /// </summary>
    public partial interface IIosVppAppAssignedDeviceLicenseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosVppAppAssignedDeviceLicense using POST.
        /// </summary>
        /// <param name="iosVppAppAssignedDeviceLicenseToCreate">The IosVppAppAssignedDeviceLicense to create.</param>
        /// <returns>The created IosVppAppAssignedDeviceLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedDeviceLicense> CreateAsync(IosVppAppAssignedDeviceLicense iosVppAppAssignedDeviceLicenseToCreate);

        /// <summary>
        /// Creates the specified IosVppAppAssignedDeviceLicense using POST.
        /// </summary>
        /// <param name="iosVppAppAssignedDeviceLicenseToCreate">The IosVppAppAssignedDeviceLicense to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosVppAppAssignedDeviceLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedDeviceLicense> CreateAsync(IosVppAppAssignedDeviceLicense iosVppAppAssignedDeviceLicenseToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified IosVppAppAssignedDeviceLicense using POST and returns a <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object.
        /// </summary>
        /// <param name="iosVppAppAssignedDeviceLicenseToCreate">The IosVppAppAssignedDeviceLicense to create.</param>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedDeviceLicense>> CreateResponseAsync(IosVppAppAssignedDeviceLicense iosVppAppAssignedDeviceLicenseToCreate);

        /// <summary>
        /// Creates the specified IosVppAppAssignedDeviceLicense using POST and returns a <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object.
        /// </summary>
        /// <param name="iosVppAppAssignedDeviceLicenseToCreate">The IosVppAppAssignedDeviceLicense to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedDeviceLicense>> CreateResponseAsync(IosVppAppAssignedDeviceLicense iosVppAppAssignedDeviceLicenseToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosVppAppAssignedDeviceLicense.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosVppAppAssignedDeviceLicense.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosVppAppAssignedDeviceLicense and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified IosVppAppAssignedDeviceLicense and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosVppAppAssignedDeviceLicense.
        /// </summary>
        /// <returns>The IosVppAppAssignedDeviceLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedDeviceLicense> GetAsync();

        /// <summary>
        /// Gets the specified IosVppAppAssignedDeviceLicense.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosVppAppAssignedDeviceLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedDeviceLicense> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosVppAppAssignedDeviceLicense and returns a <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedDeviceLicense>> GetResponseAsync();

        /// <summary>
        /// Gets the specified IosVppAppAssignedDeviceLicense and returns a <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedDeviceLicense>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosVppAppAssignedDeviceLicense using PATCH.
        /// </summary>
        /// <param name="iosVppAppAssignedDeviceLicenseToUpdate">The IosVppAppAssignedDeviceLicense to update.</param>
        /// <returns>The updated IosVppAppAssignedDeviceLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedDeviceLicense> UpdateAsync(IosVppAppAssignedDeviceLicense iosVppAppAssignedDeviceLicenseToUpdate);

        /// <summary>
        /// Updates the specified IosVppAppAssignedDeviceLicense using PATCH.
        /// </summary>
        /// <param name="iosVppAppAssignedDeviceLicenseToUpdate">The IosVppAppAssignedDeviceLicense to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosVppAppAssignedDeviceLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedDeviceLicense> UpdateAsync(IosVppAppAssignedDeviceLicense iosVppAppAssignedDeviceLicenseToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosVppAppAssignedDeviceLicense using PATCH and returns a <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object.
        /// </summary>
        /// <param name="iosVppAppAssignedDeviceLicenseToUpdate">The IosVppAppAssignedDeviceLicense to update.</param>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedDeviceLicense>> UpdateResponseAsync(IosVppAppAssignedDeviceLicense iosVppAppAssignedDeviceLicenseToUpdate);

        /// <summary>
        /// Updates the specified IosVppAppAssignedDeviceLicense using PATCH and returns a <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object.
        /// </summary>
        /// <param name="iosVppAppAssignedDeviceLicenseToUpdate">The IosVppAppAssignedDeviceLicense to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedDeviceLicense}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedDeviceLicense>> UpdateResponseAsync(IosVppAppAssignedDeviceLicense iosVppAppAssignedDeviceLicenseToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedDeviceLicenseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedDeviceLicenseRequest Expand(Expression<Func<IosVppAppAssignedDeviceLicense, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedDeviceLicenseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedDeviceLicenseRequest Select(Expression<Func<IosVppAppAssignedDeviceLicense, object>> selectExpression);

    }
}
