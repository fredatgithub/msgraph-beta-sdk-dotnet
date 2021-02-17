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
    /// The interface IItemAddressRequest.
    /// </summary>
    public partial interface IItemAddressRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ItemAddress using POST.
        /// </summary>
        /// <param name="itemAddressToCreate">The ItemAddress to create.</param>
        /// <returns>The created ItemAddress.</returns>
        System.Threading.Tasks.Task<ItemAddress> CreateAsync(ItemAddress itemAddressToCreate);

        /// <summary>
        /// Creates the specified ItemAddress using POST.
        /// </summary>
        /// <param name="itemAddressToCreate">The ItemAddress to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemAddress.</returns>
        System.Threading.Tasks.Task<ItemAddress> CreateAsync(ItemAddress itemAddressToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified ItemAddress using POST and returns a <see cref="GraphResponse{ItemAddress}"/> object.
        /// </summary>
        /// <param name="itemAddressToCreate">The ItemAddress to create.</param>
        /// <returns>The <see cref="GraphResponse{ItemAddress}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemAddress>> CreateResponseAsync(ItemAddress itemAddressToCreate);

        /// <summary>
        /// Creates the specified ItemAddress using POST and returns a <see cref="GraphResponse{ItemAddress}"/> object.
        /// </summary>
        /// <param name="itemAddressToCreate">The ItemAddress to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemAddress}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemAddress>> CreateResponseAsync(ItemAddress itemAddressToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ItemAddress.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ItemAddress.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ItemAddress and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified ItemAddress and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ItemAddress.
        /// </summary>
        /// <returns>The ItemAddress.</returns>
        System.Threading.Tasks.Task<ItemAddress> GetAsync();

        /// <summary>
        /// Gets the specified ItemAddress.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemAddress.</returns>
        System.Threading.Tasks.Task<ItemAddress> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ItemAddress and returns a <see cref="GraphResponse{ItemAddress}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ItemAddress}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemAddress>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ItemAddress and returns a <see cref="GraphResponse{ItemAddress}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemAddress}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemAddress>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ItemAddress using PATCH.
        /// </summary>
        /// <param name="itemAddressToUpdate">The ItemAddress to update.</param>
        /// <returns>The updated ItemAddress.</returns>
        System.Threading.Tasks.Task<ItemAddress> UpdateAsync(ItemAddress itemAddressToUpdate);

        /// <summary>
        /// Updates the specified ItemAddress using PATCH.
        /// </summary>
        /// <param name="itemAddressToUpdate">The ItemAddress to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ItemAddress.</returns>
        System.Threading.Tasks.Task<ItemAddress> UpdateAsync(ItemAddress itemAddressToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ItemAddress using PATCH and returns a <see cref="GraphResponse{ItemAddress}"/> object.
        /// </summary>
        /// <param name="itemAddressToUpdate">The ItemAddress to update.</param>
        /// <returns>The <see cref="GraphResponse{ItemAddress}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemAddress>> UpdateResponseAsync(ItemAddress itemAddressToUpdate);

        /// <summary>
        /// Updates the specified ItemAddress using PATCH and returns a <see cref="GraphResponse{ItemAddress}"/> object.
        /// </summary>
        /// <param name="itemAddressToUpdate">The ItemAddress to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ItemAddress}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemAddress>> UpdateResponseAsync(ItemAddress itemAddressToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemAddressRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemAddressRequest Expand(Expression<Func<ItemAddress, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemAddressRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IItemAddressRequest Select(Expression<Func<ItemAddress, object>> selectExpression);

    }
}
