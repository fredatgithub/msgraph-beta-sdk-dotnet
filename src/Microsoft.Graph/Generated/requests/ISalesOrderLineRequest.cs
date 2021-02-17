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
    /// The interface ISalesOrderLineRequest.
    /// </summary>
    public partial interface ISalesOrderLineRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SalesOrderLine using POST.
        /// </summary>
        /// <param name="salesOrderLineToCreate">The SalesOrderLine to create.</param>
        /// <returns>The created SalesOrderLine.</returns>
        System.Threading.Tasks.Task<SalesOrderLine> CreateAsync(SalesOrderLine salesOrderLineToCreate);

        /// <summary>
        /// Creates the specified SalesOrderLine using POST.
        /// </summary>
        /// <param name="salesOrderLineToCreate">The SalesOrderLine to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SalesOrderLine.</returns>
        System.Threading.Tasks.Task<SalesOrderLine> CreateAsync(SalesOrderLine salesOrderLineToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified SalesOrderLine using POST and returns a <see cref="GraphResponse{SalesOrderLine}"/> object.
        /// </summary>
        /// <param name="salesOrderLineToCreate">The SalesOrderLine to create.</param>
        /// <returns>The <see cref="GraphResponse{SalesOrderLine}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesOrderLine>> CreateResponseAsync(SalesOrderLine salesOrderLineToCreate);

        /// <summary>
        /// Creates the specified SalesOrderLine using POST and returns a <see cref="GraphResponse{SalesOrderLine}"/> object.
        /// </summary>
        /// <param name="salesOrderLineToCreate">The SalesOrderLine to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SalesOrderLine}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesOrderLine>> CreateResponseAsync(SalesOrderLine salesOrderLineToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SalesOrderLine.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SalesOrderLine.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SalesOrderLine and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified SalesOrderLine and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SalesOrderLine.
        /// </summary>
        /// <returns>The SalesOrderLine.</returns>
        System.Threading.Tasks.Task<SalesOrderLine> GetAsync();

        /// <summary>
        /// Gets the specified SalesOrderLine.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SalesOrderLine.</returns>
        System.Threading.Tasks.Task<SalesOrderLine> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SalesOrderLine and returns a <see cref="GraphResponse{SalesOrderLine}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SalesOrderLine}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesOrderLine>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SalesOrderLine and returns a <see cref="GraphResponse{SalesOrderLine}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SalesOrderLine}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesOrderLine>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SalesOrderLine using PATCH.
        /// </summary>
        /// <param name="salesOrderLineToUpdate">The SalesOrderLine to update.</param>
        /// <returns>The updated SalesOrderLine.</returns>
        System.Threading.Tasks.Task<SalesOrderLine> UpdateAsync(SalesOrderLine salesOrderLineToUpdate);

        /// <summary>
        /// Updates the specified SalesOrderLine using PATCH.
        /// </summary>
        /// <param name="salesOrderLineToUpdate">The SalesOrderLine to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SalesOrderLine.</returns>
        System.Threading.Tasks.Task<SalesOrderLine> UpdateAsync(SalesOrderLine salesOrderLineToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SalesOrderLine using PATCH and returns a <see cref="GraphResponse{SalesOrderLine}"/> object.
        /// </summary>
        /// <param name="salesOrderLineToUpdate">The SalesOrderLine to update.</param>
        /// <returns>The <see cref="GraphResponse{SalesOrderLine}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesOrderLine>> UpdateResponseAsync(SalesOrderLine salesOrderLineToUpdate);

        /// <summary>
        /// Updates the specified SalesOrderLine using PATCH and returns a <see cref="GraphResponse{SalesOrderLine}"/> object.
        /// </summary>
        /// <param name="salesOrderLineToUpdate">The SalesOrderLine to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SalesOrderLine}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesOrderLine>> UpdateResponseAsync(SalesOrderLine salesOrderLineToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISalesOrderLineRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISalesOrderLineRequest Expand(Expression<Func<SalesOrderLine, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISalesOrderLineRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISalesOrderLineRequest Select(Expression<Func<SalesOrderLine, object>> selectExpression);

    }
}
