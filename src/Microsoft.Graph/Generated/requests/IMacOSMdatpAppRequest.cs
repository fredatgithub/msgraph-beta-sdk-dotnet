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
    /// The interface IMacOSMdatpAppRequest.
    /// </summary>
    public partial interface IMacOSMdatpAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSMdatpApp using POST.
        /// </summary>
        /// <param name="macOSMdatpAppToCreate">The MacOSMdatpApp to create.</param>
        /// <returns>The created MacOSMdatpApp.</returns>
        System.Threading.Tasks.Task<MacOSMdatpApp> CreateAsync(MacOSMdatpApp macOSMdatpAppToCreate);

        /// <summary>
        /// Creates the specified MacOSMdatpApp using POST.
        /// </summary>
        /// <param name="macOSMdatpAppToCreate">The MacOSMdatpApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSMdatpApp.</returns>
        System.Threading.Tasks.Task<MacOSMdatpApp> CreateAsync(MacOSMdatpApp macOSMdatpAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified MacOSMdatpApp using POST and returns a <see cref="GraphResponse{MacOSMdatpApp}"/> object.
        /// </summary>
        /// <param name="macOSMdatpAppToCreate">The MacOSMdatpApp to create.</param>
        /// <returns>The <see cref="GraphResponse{MacOSMdatpApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSMdatpApp>> CreateResponseAsync(MacOSMdatpApp macOSMdatpAppToCreate);

        /// <summary>
        /// Creates the specified MacOSMdatpApp using POST and returns a <see cref="GraphResponse{MacOSMdatpApp}"/> object.
        /// </summary>
        /// <param name="macOSMdatpAppToCreate">The MacOSMdatpApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSMdatpApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSMdatpApp>> CreateResponseAsync(MacOSMdatpApp macOSMdatpAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSMdatpApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSMdatpApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSMdatpApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified MacOSMdatpApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSMdatpApp.
        /// </summary>
        /// <returns>The MacOSMdatpApp.</returns>
        System.Threading.Tasks.Task<MacOSMdatpApp> GetAsync();

        /// <summary>
        /// Gets the specified MacOSMdatpApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSMdatpApp.</returns>
        System.Threading.Tasks.Task<MacOSMdatpApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSMdatpApp and returns a <see cref="GraphResponse{MacOSMdatpApp}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MacOSMdatpApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSMdatpApp>> GetResponseAsync();

        /// <summary>
        /// Gets the specified MacOSMdatpApp and returns a <see cref="GraphResponse{MacOSMdatpApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSMdatpApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSMdatpApp>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSMdatpApp using PATCH.
        /// </summary>
        /// <param name="macOSMdatpAppToUpdate">The MacOSMdatpApp to update.</param>
        /// <returns>The updated MacOSMdatpApp.</returns>
        System.Threading.Tasks.Task<MacOSMdatpApp> UpdateAsync(MacOSMdatpApp macOSMdatpAppToUpdate);

        /// <summary>
        /// Updates the specified MacOSMdatpApp using PATCH.
        /// </summary>
        /// <param name="macOSMdatpAppToUpdate">The MacOSMdatpApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSMdatpApp.</returns>
        System.Threading.Tasks.Task<MacOSMdatpApp> UpdateAsync(MacOSMdatpApp macOSMdatpAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSMdatpApp using PATCH and returns a <see cref="GraphResponse{MacOSMdatpApp}"/> object.
        /// </summary>
        /// <param name="macOSMdatpAppToUpdate">The MacOSMdatpApp to update.</param>
        /// <returns>The <see cref="GraphResponse{MacOSMdatpApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSMdatpApp>> UpdateResponseAsync(MacOSMdatpApp macOSMdatpAppToUpdate);

        /// <summary>
        /// Updates the specified MacOSMdatpApp using PATCH and returns a <see cref="GraphResponse{MacOSMdatpApp}"/> object.
        /// </summary>
        /// <param name="macOSMdatpAppToUpdate">The MacOSMdatpApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSMdatpApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSMdatpApp>> UpdateResponseAsync(MacOSMdatpApp macOSMdatpAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSMdatpAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSMdatpAppRequest Expand(Expression<Func<MacOSMdatpApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSMdatpAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSMdatpAppRequest Select(Expression<Func<MacOSMdatpApp, object>> selectExpression);

    }
}
