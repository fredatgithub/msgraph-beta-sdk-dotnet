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
    /// The interface IItemActivityOLDRequest.
    /// </summary>
    public partial interface IItemActivityOLDRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ItemActivityOLD using POST.
        /// </summary>
        /// <param name="itemActivityOLDToCreate">The ItemActivityOLD to create.</param>
        /// <returns>The created ItemActivityOLD.</returns>
        System.Threading.Tasks.Task<ItemActivityOLD> CreateAsync(ItemActivityOLD itemActivityOLDToCreate);

        /// <summary>
        /// Creates the specified ItemActivityOLD using POST.
        /// </summary>
        /// <param name="itemActivityOLDToCreate">The ItemActivityOLD to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemActivityOLD.</returns>
        System.Threading.Tasks.Task<ItemActivityOLD> CreateAsync(ItemActivityOLD itemActivityOLDToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified ItemActivityOLD using POST and returns a <see cref="GraphResponse{ItemActivityOLD}"/> object.
        /// </summary>
        /// <param name="itemActivityOLDToCreate">The ItemActivityOLD to create.</param>
        /// <returns>The <see cref="GraphResponse{ItemActivityOLD}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivityOLD>> CreateResponseAsync(ItemActivityOLD itemActivityOLDToCreate);

        /// <summary>
        /// Creates the specified ItemActivityOLD using POST and returns a <see cref="GraphResponse{ItemActivityOLD}"/> object.
        /// </summary>
        /// <param name="itemActivityOLDToCreate">The ItemActivityOLD to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemActivityOLD}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivityOLD>> CreateResponseAsync(ItemActivityOLD itemActivityOLDToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ItemActivityOLD.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ItemActivityOLD.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ItemActivityOLD and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified ItemActivityOLD and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ItemActivityOLD.
        /// </summary>
        /// <returns>The ItemActivityOLD.</returns>
        System.Threading.Tasks.Task<ItemActivityOLD> GetAsync();

        /// <summary>
        /// Gets the specified ItemActivityOLD.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemActivityOLD.</returns>
        System.Threading.Tasks.Task<ItemActivityOLD> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ItemActivityOLD and returns a <see cref="GraphResponse{ItemActivityOLD}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ItemActivityOLD}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivityOLD>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ItemActivityOLD and returns a <see cref="GraphResponse{ItemActivityOLD}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemActivityOLD}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivityOLD>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ItemActivityOLD using PATCH.
        /// </summary>
        /// <param name="itemActivityOLDToUpdate">The ItemActivityOLD to update.</param>
        /// <returns>The updated ItemActivityOLD.</returns>
        System.Threading.Tasks.Task<ItemActivityOLD> UpdateAsync(ItemActivityOLD itemActivityOLDToUpdate);

        /// <summary>
        /// Updates the specified ItemActivityOLD using PATCH.
        /// </summary>
        /// <param name="itemActivityOLDToUpdate">The ItemActivityOLD to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ItemActivityOLD.</returns>
        System.Threading.Tasks.Task<ItemActivityOLD> UpdateAsync(ItemActivityOLD itemActivityOLDToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ItemActivityOLD using PATCH and returns a <see cref="GraphResponse{ItemActivityOLD}"/> object.
        /// </summary>
        /// <param name="itemActivityOLDToUpdate">The ItemActivityOLD to update.</param>
        /// <returns>The <see cref="GraphResponse{ItemActivityOLD}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivityOLD>> UpdateResponseAsync(ItemActivityOLD itemActivityOLDToUpdate);

        /// <summary>
        /// Updates the specified ItemActivityOLD using PATCH and returns a <see cref="GraphResponse{ItemActivityOLD}"/> object.
        /// </summary>
        /// <param name="itemActivityOLDToUpdate">The ItemActivityOLD to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ItemActivityOLD}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivityOLD>> UpdateResponseAsync(ItemActivityOLD itemActivityOLDToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityOLDRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityOLDRequest Expand(Expression<Func<ItemActivityOLD, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityOLDRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityOLDRequest Select(Expression<Func<ItemActivityOLD, object>> selectExpression);

    }
}
