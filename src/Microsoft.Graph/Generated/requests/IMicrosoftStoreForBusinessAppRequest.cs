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
    /// The interface IMicrosoftStoreForBusinessAppRequest.
    /// </summary>
    public partial interface IMicrosoftStoreForBusinessAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MicrosoftStoreForBusinessApp using POST.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToCreate">The MicrosoftStoreForBusinessApp to create.</param>
        /// <returns>The created MicrosoftStoreForBusinessApp.</returns>
        System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> CreateAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToCreate);

        /// <summary>
        /// Creates the specified MicrosoftStoreForBusinessApp using POST.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToCreate">The MicrosoftStoreForBusinessApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MicrosoftStoreForBusinessApp.</returns>
        System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> CreateAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified MicrosoftStoreForBusinessApp using POST and returns a <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToCreate">The MicrosoftStoreForBusinessApp to create.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftStoreForBusinessApp>> CreateResponseAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToCreate);

        /// <summary>
        /// Creates the specified MicrosoftStoreForBusinessApp using POST and returns a <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToCreate">The MicrosoftStoreForBusinessApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftStoreForBusinessApp>> CreateResponseAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MicrosoftStoreForBusinessApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MicrosoftStoreForBusinessApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MicrosoftStoreForBusinessApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified MicrosoftStoreForBusinessApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MicrosoftStoreForBusinessApp.
        /// </summary>
        /// <returns>The MicrosoftStoreForBusinessApp.</returns>
        System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> GetAsync();

        /// <summary>
        /// Gets the specified MicrosoftStoreForBusinessApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MicrosoftStoreForBusinessApp.</returns>
        System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MicrosoftStoreForBusinessApp and returns a <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftStoreForBusinessApp>> GetResponseAsync();

        /// <summary>
        /// Gets the specified MicrosoftStoreForBusinessApp and returns a <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftStoreForBusinessApp>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MicrosoftStoreForBusinessApp using PATCH.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToUpdate">The MicrosoftStoreForBusinessApp to update.</param>
        /// <returns>The updated MicrosoftStoreForBusinessApp.</returns>
        System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> UpdateAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToUpdate);

        /// <summary>
        /// Updates the specified MicrosoftStoreForBusinessApp using PATCH.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToUpdate">The MicrosoftStoreForBusinessApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MicrosoftStoreForBusinessApp.</returns>
        System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> UpdateAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MicrosoftStoreForBusinessApp using PATCH and returns a <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToUpdate">The MicrosoftStoreForBusinessApp to update.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftStoreForBusinessApp>> UpdateResponseAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToUpdate);

        /// <summary>
        /// Updates the specified MicrosoftStoreForBusinessApp using PATCH and returns a <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToUpdate">The MicrosoftStoreForBusinessApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MicrosoftStoreForBusinessApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftStoreForBusinessApp>> UpdateResponseAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftStoreForBusinessAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftStoreForBusinessAppRequest Expand(Expression<Func<MicrosoftStoreForBusinessApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftStoreForBusinessAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftStoreForBusinessAppRequest Select(Expression<Func<MicrosoftStoreForBusinessApp, object>> selectExpression);

    }
}
