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
    /// The interface IPresentationRequest.
    /// </summary>
    public partial interface IPresentationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Presentation using POST.
        /// </summary>
        /// <param name="presentationToCreate">The Presentation to create.</param>
        /// <returns>The created Presentation.</returns>
        System.Threading.Tasks.Task<Presentation> CreateAsync(Presentation presentationToCreate);

        /// <summary>
        /// Creates the specified Presentation using POST.
        /// </summary>
        /// <param name="presentationToCreate">The Presentation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Presentation.</returns>
        System.Threading.Tasks.Task<Presentation> CreateAsync(Presentation presentationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Presentation using POST and returns a <see cref="GraphResponse{Presentation}"/> object.
        /// </summary>
        /// <param name="presentationToCreate">The Presentation to create.</param>
        /// <returns>The <see cref="GraphResponse{Presentation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Presentation>> CreateResponseAsync(Presentation presentationToCreate);

        /// <summary>
        /// Creates the specified Presentation using POST and returns a <see cref="GraphResponse{Presentation}"/> object.
        /// </summary>
        /// <param name="presentationToCreate">The Presentation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Presentation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Presentation>> CreateResponseAsync(Presentation presentationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Presentation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Presentation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Presentation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Presentation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Presentation.
        /// </summary>
        /// <returns>The Presentation.</returns>
        System.Threading.Tasks.Task<Presentation> GetAsync();

        /// <summary>
        /// Gets the specified Presentation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Presentation.</returns>
        System.Threading.Tasks.Task<Presentation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Presentation and returns a <see cref="GraphResponse{Presentation}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Presentation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Presentation>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Presentation and returns a <see cref="GraphResponse{Presentation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Presentation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Presentation>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Presentation using PATCH.
        /// </summary>
        /// <param name="presentationToUpdate">The Presentation to update.</param>
        /// <returns>The updated Presentation.</returns>
        System.Threading.Tasks.Task<Presentation> UpdateAsync(Presentation presentationToUpdate);

        /// <summary>
        /// Updates the specified Presentation using PATCH.
        /// </summary>
        /// <param name="presentationToUpdate">The Presentation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Presentation.</returns>
        System.Threading.Tasks.Task<Presentation> UpdateAsync(Presentation presentationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Presentation using PATCH and returns a <see cref="GraphResponse{Presentation}"/> object.
        /// </summary>
        /// <param name="presentationToUpdate">The Presentation to update.</param>
        /// <returns>The <see cref="GraphResponse{Presentation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Presentation>> UpdateResponseAsync(Presentation presentationToUpdate);

        /// <summary>
        /// Updates the specified Presentation using PATCH and returns a <see cref="GraphResponse{Presentation}"/> object.
        /// </summary>
        /// <param name="presentationToUpdate">The Presentation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Presentation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Presentation>> UpdateResponseAsync(Presentation presentationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPresentationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPresentationRequest Expand(Expression<Func<Presentation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPresentationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPresentationRequest Select(Expression<Func<Presentation, object>> selectExpression);

    }
}
