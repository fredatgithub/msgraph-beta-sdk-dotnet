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
    /// The interface IShipmentMethodRequest.
    /// </summary>
    public partial interface IShipmentMethodRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ShipmentMethod using POST.
        /// </summary>
        /// <param name="shipmentMethodToCreate">The ShipmentMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ShipmentMethod.</returns>
        System.Threading.Tasks.Task<ShipmentMethod> CreateAsync(ShipmentMethod shipmentMethodToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ShipmentMethod using POST and returns a <see cref="GraphResponse{ShipmentMethod}"/> object.
        /// </summary>
        /// <param name="shipmentMethodToCreate">The ShipmentMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ShipmentMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ShipmentMethod>> CreateResponseAsync(ShipmentMethod shipmentMethodToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ShipmentMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ShipmentMethod and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ShipmentMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ShipmentMethod.</returns>
        System.Threading.Tasks.Task<ShipmentMethod> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ShipmentMethod and returns a <see cref="GraphResponse{ShipmentMethod}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ShipmentMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ShipmentMethod>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ShipmentMethod using PATCH.
        /// </summary>
        /// <param name="shipmentMethodToUpdate">The ShipmentMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ShipmentMethod.</returns>
        System.Threading.Tasks.Task<ShipmentMethod> UpdateAsync(ShipmentMethod shipmentMethodToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ShipmentMethod using PATCH and returns a <see cref="GraphResponse{ShipmentMethod}"/> object.
        /// </summary>
        /// <param name="shipmentMethodToUpdate">The ShipmentMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ShipmentMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ShipmentMethod>> UpdateResponseAsync(ShipmentMethod shipmentMethodToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IShipmentMethodRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IShipmentMethodRequest Expand(Expression<Func<ShipmentMethod, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IShipmentMethodRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IShipmentMethodRequest Select(Expression<Func<ShipmentMethod, object>> selectExpression);

    }
}
