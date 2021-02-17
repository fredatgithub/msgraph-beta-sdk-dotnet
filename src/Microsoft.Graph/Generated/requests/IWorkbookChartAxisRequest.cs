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
    /// The interface IWorkbookChartAxisRequest.
    /// </summary>
    public partial interface IWorkbookChartAxisRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartAxis using POST.
        /// </summary>
        /// <param name="workbookChartAxisToCreate">The WorkbookChartAxis to create.</param>
        /// <returns>The created WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> CreateAsync(WorkbookChartAxis workbookChartAxisToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartAxis using POST.
        /// </summary>
        /// <param name="workbookChartAxisToCreate">The WorkbookChartAxis to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> CreateAsync(WorkbookChartAxis workbookChartAxisToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WorkbookChartAxis using POST and returns a <see cref="GraphResponse{WorkbookChartAxis}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisToCreate">The WorkbookChartAxis to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxis}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxis>> CreateResponseAsync(WorkbookChartAxis workbookChartAxisToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartAxis using POST and returns a <see cref="GraphResponse{WorkbookChartAxis}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisToCreate">The WorkbookChartAxis to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxis}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxis>> CreateResponseAsync(WorkbookChartAxis workbookChartAxisToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartAxis.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartAxis.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartAxis and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartAxis and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartAxis.
        /// </summary>
        /// <returns>The WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartAxis.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartAxis and returns a <see cref="GraphResponse{WorkbookChartAxis}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxis}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxis>> GetResponseAsync();

        /// <summary>
        /// Gets the specified WorkbookChartAxis and returns a <see cref="GraphResponse{WorkbookChartAxis}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxis}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxis>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartAxis using PATCH.
        /// </summary>
        /// <param name="workbookChartAxisToUpdate">The WorkbookChartAxis to update.</param>
        /// <returns>The updated WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> UpdateAsync(WorkbookChartAxis workbookChartAxisToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartAxis using PATCH.
        /// </summary>
        /// <param name="workbookChartAxisToUpdate">The WorkbookChartAxis to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> UpdateAsync(WorkbookChartAxis workbookChartAxisToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartAxis using PATCH and returns a <see cref="GraphResponse{WorkbookChartAxis}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisToUpdate">The WorkbookChartAxis to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxis}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxis>> UpdateResponseAsync(WorkbookChartAxis workbookChartAxisToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartAxis using PATCH and returns a <see cref="GraphResponse{WorkbookChartAxis}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisToUpdate">The WorkbookChartAxis to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxis}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxis>> UpdateResponseAsync(WorkbookChartAxis workbookChartAxisToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisRequest Expand(Expression<Func<WorkbookChartAxis, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisRequest Select(Expression<Func<WorkbookChartAxis, object>> selectExpression);

    }
}
