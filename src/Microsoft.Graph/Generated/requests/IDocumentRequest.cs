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
    /// The interface IDocumentRequest.
    /// </summary>
    public partial interface IDocumentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Document using POST.
        /// </summary>
        /// <param name="documentToCreate">The Document to create.</param>
        /// <returns>The created Document.</returns>
        System.Threading.Tasks.Task<Document> CreateAsync(Document documentToCreate);

        /// <summary>
        /// Creates the specified Document using POST.
        /// </summary>
        /// <param name="documentToCreate">The Document to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Document.</returns>
        System.Threading.Tasks.Task<Document> CreateAsync(Document documentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Document using POST and returns a <see cref="GraphResponse{Document}"/> object.
        /// </summary>
        /// <param name="documentToCreate">The Document to create.</param>
        /// <returns>The <see cref="GraphResponse{Document}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Document>> CreateResponseAsync(Document documentToCreate);

        /// <summary>
        /// Creates the specified Document using POST and returns a <see cref="GraphResponse{Document}"/> object.
        /// </summary>
        /// <param name="documentToCreate">The Document to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Document}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Document>> CreateResponseAsync(Document documentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Document.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Document.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Document and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Document and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Document.
        /// </summary>
        /// <returns>The Document.</returns>
        System.Threading.Tasks.Task<Document> GetAsync();

        /// <summary>
        /// Gets the specified Document.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Document.</returns>
        System.Threading.Tasks.Task<Document> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Document and returns a <see cref="GraphResponse{Document}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Document}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Document>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Document and returns a <see cref="GraphResponse{Document}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Document}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Document>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Document using PATCH.
        /// </summary>
        /// <param name="documentToUpdate">The Document to update.</param>
        /// <returns>The updated Document.</returns>
        System.Threading.Tasks.Task<Document> UpdateAsync(Document documentToUpdate);

        /// <summary>
        /// Updates the specified Document using PATCH.
        /// </summary>
        /// <param name="documentToUpdate">The Document to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Document.</returns>
        System.Threading.Tasks.Task<Document> UpdateAsync(Document documentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Document using PATCH and returns a <see cref="GraphResponse{Document}"/> object.
        /// </summary>
        /// <param name="documentToUpdate">The Document to update.</param>
        /// <returns>The <see cref="GraphResponse{Document}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Document>> UpdateResponseAsync(Document documentToUpdate);

        /// <summary>
        /// Updates the specified Document using PATCH and returns a <see cref="GraphResponse{Document}"/> object.
        /// </summary>
        /// <param name="documentToUpdate">The Document to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Document}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Document>> UpdateResponseAsync(Document documentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDocumentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDocumentRequest Expand(Expression<Func<Document, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDocumentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDocumentRequest Select(Expression<Func<Document, object>> selectExpression);

    }
}
