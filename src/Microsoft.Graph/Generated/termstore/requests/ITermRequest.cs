// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITermRequest.
    /// </summary>
    public partial interface ITermRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified Term using POST.
        /// </summary>
        /// <param name="termToCreate">The Term to create.</param>
        /// <returns>The created Term.</returns>
        System.Threading.Tasks.Task<Term> CreateAsync(Term termToCreate);

        /// <summary>
        /// Creates the specified Term using POST.
        /// </summary>
        /// <param name="termToCreate">The Term to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Term.</returns>
        System.Threading.Tasks.Task<Term> CreateAsync(Term termToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Term using POST and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <param name="termToCreate">The Term to create.</param>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Term>> CreateResponseAsync(Term termToCreate);

        /// <summary>
        /// Creates the specified Term using POST and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <param name="termToCreate">The Term to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Term>> CreateResponseAsync(Term termToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Term.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Term.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Term and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Term and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Term.
        /// </summary>
        /// <returns>The Term.</returns>
        System.Threading.Tasks.Task<Term> GetAsync();

        /// <summary>
        /// Gets the specified Term.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Term.</returns>
        System.Threading.Tasks.Task<Term> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Term and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Term>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Term and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Term>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Term using PATCH.
        /// </summary>
        /// <param name="termToUpdate">The Term to update.</param>
        /// <returns>The updated Term.</returns>
        System.Threading.Tasks.Task<Term> UpdateAsync(Term termToUpdate);

        /// <summary>
        /// Updates the specified Term using PATCH.
        /// </summary>
        /// <param name="termToUpdate">The Term to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Term.</returns>
        System.Threading.Tasks.Task<Term> UpdateAsync(Term termToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Term using PATCH and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <param name="termToUpdate">The Term to update.</param>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Term>> UpdateResponseAsync(Term termToUpdate);

        /// <summary>
        /// Updates the specified Term using PATCH and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <param name="termToUpdate">The Term to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Term>> UpdateResponseAsync(Term termToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITermRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITermRequest Expand(Expression<Func<Term, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITermRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITermRequest Select(Expression<Func<Term, object>> selectExpression);

    }
}
