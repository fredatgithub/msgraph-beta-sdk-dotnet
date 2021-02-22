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
    /// The interface IRecordOperationRequest.
    /// </summary>
    public partial interface IRecordOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RecordOperation using POST.
        /// </summary>
        /// <param name="recordOperationToCreate">The RecordOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RecordOperation.</returns>
        System.Threading.Tasks.Task<RecordOperation> CreateAsync(RecordOperation recordOperationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified RecordOperation using POST and returns a <see cref="GraphResponse{RecordOperation}"/> object.
        /// </summary>
        /// <param name="recordOperationToCreate">The RecordOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RecordOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RecordOperation>> CreateResponseAsync(RecordOperation recordOperationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified RecordOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified RecordOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified RecordOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RecordOperation.</returns>
        System.Threading.Tasks.Task<RecordOperation> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified RecordOperation and returns a <see cref="GraphResponse{RecordOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RecordOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RecordOperation>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RecordOperation using PATCH.
        /// </summary>
        /// <param name="recordOperationToUpdate">The RecordOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RecordOperation.</returns>
        System.Threading.Tasks.Task<RecordOperation> UpdateAsync(RecordOperation recordOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RecordOperation using PATCH and returns a <see cref="GraphResponse{RecordOperation}"/> object.
        /// </summary>
        /// <param name="recordOperationToUpdate">The RecordOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RecordOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RecordOperation>> UpdateResponseAsync(RecordOperation recordOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRecordOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRecordOperationRequest Expand(Expression<Func<RecordOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRecordOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRecordOperationRequest Select(Expression<Func<RecordOperation, object>> selectExpression);

    }
}
