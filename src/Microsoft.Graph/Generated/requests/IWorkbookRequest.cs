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
    /// The interface IWorkbookRequest.
    /// </summary>
    public partial interface IWorkbookRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Workbook using POST.
        /// </summary>
        /// <param name="workbookToCreate">The Workbook to create.</param>
        /// <returns>The created Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> CreateAsync(Workbook workbookToCreate);

        /// <summary>
        /// Creates the specified Workbook using POST.
        /// </summary>
        /// <param name="workbookToCreate">The Workbook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> CreateAsync(Workbook workbookToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Workbook using POST and returns a <see cref="GraphResponse{Workbook}"/> object.
        /// </summary>
        /// <param name="workbookToCreate">The Workbook to create.</param>
        /// <returns>The <see cref="GraphResponse{Workbook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Workbook>> CreateResponseAsync(Workbook workbookToCreate);

        /// <summary>
        /// Creates the specified Workbook using POST and returns a <see cref="GraphResponse{Workbook}"/> object.
        /// </summary>
        /// <param name="workbookToCreate">The Workbook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Workbook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Workbook>> CreateResponseAsync(Workbook workbookToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Workbook.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Workbook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Workbook and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Workbook and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Workbook.
        /// </summary>
        /// <returns>The Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> GetAsync();

        /// <summary>
        /// Gets the specified Workbook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Workbook and returns a <see cref="GraphResponse{Workbook}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Workbook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Workbook>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Workbook and returns a <see cref="GraphResponse{Workbook}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Workbook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Workbook>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Workbook using PATCH.
        /// </summary>
        /// <param name="workbookToUpdate">The Workbook to update.</param>
        /// <returns>The updated Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> UpdateAsync(Workbook workbookToUpdate);

        /// <summary>
        /// Updates the specified Workbook using PATCH.
        /// </summary>
        /// <param name="workbookToUpdate">The Workbook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> UpdateAsync(Workbook workbookToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Workbook using PATCH and returns a <see cref="GraphResponse{Workbook}"/> object.
        /// </summary>
        /// <param name="workbookToUpdate">The Workbook to update.</param>
        /// <returns>The <see cref="GraphResponse{Workbook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Workbook>> UpdateResponseAsync(Workbook workbookToUpdate);

        /// <summary>
        /// Updates the specified Workbook using PATCH and returns a <see cref="GraphResponse{Workbook}"/> object.
        /// </summary>
        /// <param name="workbookToUpdate">The Workbook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Workbook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Workbook>> UpdateResponseAsync(Workbook workbookToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRequest Expand(Expression<Func<Workbook, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRequest Select(Expression<Func<Workbook, object>> selectExpression);

    }
}
