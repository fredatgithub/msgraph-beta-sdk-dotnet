// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICaseIndexOperationWithReferenceRequest.
    /// </summary>
    public partial interface ICaseIndexOperationWithReferenceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Gets the specified CaseIndexOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CaseIndexOperation.</returns>
        System.Threading.Tasks.Task<CaseIndexOperation> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified CaseIndexOperation and returns a <see cref="GraphResponse{CaseIndexOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CaseIndexOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CaseIndexOperation>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified CaseIndexOperation using POST.
        /// </summary>
        /// <param name="caseIndexOperationToCreate">The CaseIndexOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CaseIndexOperation.</returns>
        System.Threading.Tasks.Task<CaseIndexOperation> CreateAsync(CaseIndexOperation caseIndexOperationToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified CaseIndexOperation using POST and returns a <see cref="GraphResponse{CaseIndexOperation}"/> object.
        /// </summary>
        /// <param name="caseIndexOperationToCreate">The CaseIndexOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CaseIndexOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CaseIndexOperation>> CreateResponseAsync(CaseIndexOperation caseIndexOperationToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified CaseIndexOperation using PATCH.
        /// </summary>
        /// <param name="caseIndexOperationToUpdate">The CaseIndexOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CaseIndexOperation.</returns>
        System.Threading.Tasks.Task<CaseIndexOperation> UpdateAsync(CaseIndexOperation caseIndexOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified CaseIndexOperation using PATCH and returns a <see cref="GraphResponse{CaseIndexOperation}"/> object.
        /// </summary>
        /// <param name="caseIndexOperationToUpdate">The CaseIndexOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CaseIndexOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CaseIndexOperation>> UpdateResponseAsync(CaseIndexOperation caseIndexOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified CaseIndexOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified CaseIndexOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICaseIndexOperationWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICaseIndexOperationWithReferenceRequest Expand(Expression<Func<CaseIndexOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICaseIndexOperationWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICaseIndexOperationWithReferenceRequest Select(Expression<Func<CaseIndexOperation, object>> selectExpression);

    }
}
