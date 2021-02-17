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
    /// The interface IWindowsFeatureUpdateProfileRequest.
    /// </summary>
    public partial interface IWindowsFeatureUpdateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsFeatureUpdateProfile using POST.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileToCreate">The WindowsFeatureUpdateProfile to create.</param>
        /// <returns>The created WindowsFeatureUpdateProfile.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfile> CreateAsync(WindowsFeatureUpdateProfile windowsFeatureUpdateProfileToCreate);

        /// <summary>
        /// Creates the specified WindowsFeatureUpdateProfile using POST.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileToCreate">The WindowsFeatureUpdateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsFeatureUpdateProfile.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfile> CreateAsync(WindowsFeatureUpdateProfile windowsFeatureUpdateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WindowsFeatureUpdateProfile using POST and returns a <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileToCreate">The WindowsFeatureUpdateProfile to create.</param>
        /// <returns>The <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsFeatureUpdateProfile>> CreateResponseAsync(WindowsFeatureUpdateProfile windowsFeatureUpdateProfileToCreate);

        /// <summary>
        /// Creates the specified WindowsFeatureUpdateProfile using POST and returns a <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileToCreate">The WindowsFeatureUpdateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsFeatureUpdateProfile>> CreateResponseAsync(WindowsFeatureUpdateProfile windowsFeatureUpdateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsFeatureUpdateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsFeatureUpdateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsFeatureUpdateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WindowsFeatureUpdateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsFeatureUpdateProfile.
        /// </summary>
        /// <returns>The WindowsFeatureUpdateProfile.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfile> GetAsync();

        /// <summary>
        /// Gets the specified WindowsFeatureUpdateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsFeatureUpdateProfile.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsFeatureUpdateProfile and returns a <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsFeatureUpdateProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified WindowsFeatureUpdateProfile and returns a <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsFeatureUpdateProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsFeatureUpdateProfile using PATCH.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileToUpdate">The WindowsFeatureUpdateProfile to update.</param>
        /// <returns>The updated WindowsFeatureUpdateProfile.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfile> UpdateAsync(WindowsFeatureUpdateProfile windowsFeatureUpdateProfileToUpdate);

        /// <summary>
        /// Updates the specified WindowsFeatureUpdateProfile using PATCH.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileToUpdate">The WindowsFeatureUpdateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsFeatureUpdateProfile.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfile> UpdateAsync(WindowsFeatureUpdateProfile windowsFeatureUpdateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsFeatureUpdateProfile using PATCH and returns a <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileToUpdate">The WindowsFeatureUpdateProfile to update.</param>
        /// <returns>The <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsFeatureUpdateProfile>> UpdateResponseAsync(WindowsFeatureUpdateProfile windowsFeatureUpdateProfileToUpdate);

        /// <summary>
        /// Updates the specified WindowsFeatureUpdateProfile using PATCH and returns a <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileToUpdate">The WindowsFeatureUpdateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsFeatureUpdateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsFeatureUpdateProfile>> UpdateResponseAsync(WindowsFeatureUpdateProfile windowsFeatureUpdateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsFeatureUpdateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsFeatureUpdateProfileRequest Expand(Expression<Func<WindowsFeatureUpdateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsFeatureUpdateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsFeatureUpdateProfileRequest Select(Expression<Func<WindowsFeatureUpdateProfile, object>> selectExpression);

    }
}
