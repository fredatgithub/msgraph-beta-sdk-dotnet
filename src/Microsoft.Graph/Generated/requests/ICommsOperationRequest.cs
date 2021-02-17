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
    /// The interface ICommsOperationRequest.
    /// </summary>
    public partial interface ICommsOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CommsOperation using POST.
        /// </summary>
        /// <param name="commsOperationToCreate">The CommsOperation to create.</param>
        /// <returns>The created CommsOperation.</returns>
        System.Threading.Tasks.Task<CommsOperation> CreateAsync(CommsOperation commsOperationToCreate);

        /// <summary>
        /// Creates the specified CommsOperation using POST.
        /// </summary>
        /// <param name="commsOperationToCreate">The CommsOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CommsOperation.</returns>
        System.Threading.Tasks.Task<CommsOperation> CreateAsync(CommsOperation commsOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified CommsOperation using POST and returns a <see cref="GraphResponse{CommsOperation}"/> object.
        /// </summary>
        /// <param name="commsOperationToCreate">The CommsOperation to create.</param>
        /// <returns>The <see cref="GraphResponse{CommsOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CommsOperation>> CreateResponseAsync(CommsOperation commsOperationToCreate);

        /// <summary>
        /// Creates the specified CommsOperation using POST and returns a <see cref="GraphResponse{CommsOperation}"/> object.
        /// </summary>
        /// <param name="commsOperationToCreate">The CommsOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CommsOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CommsOperation>> CreateResponseAsync(CommsOperation commsOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CommsOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CommsOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CommsOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified CommsOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CommsOperation.
        /// </summary>
        /// <returns>The CommsOperation.</returns>
        System.Threading.Tasks.Task<CommsOperation> GetAsync();

        /// <summary>
        /// Gets the specified CommsOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CommsOperation.</returns>
        System.Threading.Tasks.Task<CommsOperation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CommsOperation and returns a <see cref="GraphResponse{CommsOperation}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{CommsOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CommsOperation>> GetResponseAsync();

        /// <summary>
        /// Gets the specified CommsOperation and returns a <see cref="GraphResponse{CommsOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CommsOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CommsOperation>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CommsOperation using PATCH.
        /// </summary>
        /// <param name="commsOperationToUpdate">The CommsOperation to update.</param>
        /// <returns>The updated CommsOperation.</returns>
        System.Threading.Tasks.Task<CommsOperation> UpdateAsync(CommsOperation commsOperationToUpdate);

        /// <summary>
        /// Updates the specified CommsOperation using PATCH.
        /// </summary>
        /// <param name="commsOperationToUpdate">The CommsOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CommsOperation.</returns>
        System.Threading.Tasks.Task<CommsOperation> UpdateAsync(CommsOperation commsOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CommsOperation using PATCH and returns a <see cref="GraphResponse{CommsOperation}"/> object.
        /// </summary>
        /// <param name="commsOperationToUpdate">The CommsOperation to update.</param>
        /// <returns>The <see cref="GraphResponse{CommsOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CommsOperation>> UpdateResponseAsync(CommsOperation commsOperationToUpdate);

        /// <summary>
        /// Updates the specified CommsOperation using PATCH and returns a <see cref="GraphResponse{CommsOperation}"/> object.
        /// </summary>
        /// <param name="commsOperationToUpdate">The CommsOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CommsOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CommsOperation>> UpdateResponseAsync(CommsOperation commsOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICommsOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICommsOperationRequest Expand(Expression<Func<CommsOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICommsOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICommsOperationRequest Select(Expression<Func<CommsOperation, object>> selectExpression);

    }
}
