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
    /// The interface IWindowsQualityUpdateCatalogItemRequest.
    /// </summary>
    public partial interface IWindowsQualityUpdateCatalogItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsQualityUpdateCatalogItem using POST.
        /// </summary>
        /// <param name="windowsQualityUpdateCatalogItemToCreate">The WindowsQualityUpdateCatalogItem to create.</param>
        /// <returns>The created WindowsQualityUpdateCatalogItem.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateCatalogItem> CreateAsync(WindowsQualityUpdateCatalogItem windowsQualityUpdateCatalogItemToCreate);

        /// <summary>
        /// Creates the specified WindowsQualityUpdateCatalogItem using POST.
        /// </summary>
        /// <param name="windowsQualityUpdateCatalogItemToCreate">The WindowsQualityUpdateCatalogItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsQualityUpdateCatalogItem.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateCatalogItem> CreateAsync(WindowsQualityUpdateCatalogItem windowsQualityUpdateCatalogItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WindowsQualityUpdateCatalogItem using POST and returns a <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object.
        /// </summary>
        /// <param name="windowsQualityUpdateCatalogItemToCreate">The WindowsQualityUpdateCatalogItem to create.</param>
        /// <returns>The <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsQualityUpdateCatalogItem>> CreateResponseAsync(WindowsQualityUpdateCatalogItem windowsQualityUpdateCatalogItemToCreate);

        /// <summary>
        /// Creates the specified WindowsQualityUpdateCatalogItem using POST and returns a <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object.
        /// </summary>
        /// <param name="windowsQualityUpdateCatalogItemToCreate">The WindowsQualityUpdateCatalogItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsQualityUpdateCatalogItem>> CreateResponseAsync(WindowsQualityUpdateCatalogItem windowsQualityUpdateCatalogItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsQualityUpdateCatalogItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsQualityUpdateCatalogItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsQualityUpdateCatalogItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WindowsQualityUpdateCatalogItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsQualityUpdateCatalogItem.
        /// </summary>
        /// <returns>The WindowsQualityUpdateCatalogItem.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateCatalogItem> GetAsync();

        /// <summary>
        /// Gets the specified WindowsQualityUpdateCatalogItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsQualityUpdateCatalogItem.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateCatalogItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsQualityUpdateCatalogItem and returns a <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsQualityUpdateCatalogItem>> GetResponseAsync();

        /// <summary>
        /// Gets the specified WindowsQualityUpdateCatalogItem and returns a <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsQualityUpdateCatalogItem>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsQualityUpdateCatalogItem using PATCH.
        /// </summary>
        /// <param name="windowsQualityUpdateCatalogItemToUpdate">The WindowsQualityUpdateCatalogItem to update.</param>
        /// <returns>The updated WindowsQualityUpdateCatalogItem.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateCatalogItem> UpdateAsync(WindowsQualityUpdateCatalogItem windowsQualityUpdateCatalogItemToUpdate);

        /// <summary>
        /// Updates the specified WindowsQualityUpdateCatalogItem using PATCH.
        /// </summary>
        /// <param name="windowsQualityUpdateCatalogItemToUpdate">The WindowsQualityUpdateCatalogItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsQualityUpdateCatalogItem.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateCatalogItem> UpdateAsync(WindowsQualityUpdateCatalogItem windowsQualityUpdateCatalogItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsQualityUpdateCatalogItem using PATCH and returns a <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object.
        /// </summary>
        /// <param name="windowsQualityUpdateCatalogItemToUpdate">The WindowsQualityUpdateCatalogItem to update.</param>
        /// <returns>The <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsQualityUpdateCatalogItem>> UpdateResponseAsync(WindowsQualityUpdateCatalogItem windowsQualityUpdateCatalogItemToUpdate);

        /// <summary>
        /// Updates the specified WindowsQualityUpdateCatalogItem using PATCH and returns a <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object.
        /// </summary>
        /// <param name="windowsQualityUpdateCatalogItemToUpdate">The WindowsQualityUpdateCatalogItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsQualityUpdateCatalogItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsQualityUpdateCatalogItem>> UpdateResponseAsync(WindowsQualityUpdateCatalogItem windowsQualityUpdateCatalogItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsQualityUpdateCatalogItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsQualityUpdateCatalogItemRequest Expand(Expression<Func<WindowsQualityUpdateCatalogItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsQualityUpdateCatalogItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsQualityUpdateCatalogItemRequest Select(Expression<Func<WindowsQualityUpdateCatalogItem, object>> selectExpression);

    }
}
