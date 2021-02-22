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
    /// The interface INdesConnectorRequest.
    /// </summary>
    public partial interface INdesConnectorRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified NdesConnector using POST.
        /// </summary>
        /// <param name="ndesConnectorToCreate">The NdesConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created NdesConnector.</returns>
        System.Threading.Tasks.Task<NdesConnector> CreateAsync(NdesConnector ndesConnectorToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified NdesConnector using POST and returns a <see cref="GraphResponse{NdesConnector}"/> object.
        /// </summary>
        /// <param name="ndesConnectorToCreate">The NdesConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NdesConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NdesConnector>> CreateResponseAsync(NdesConnector ndesConnectorToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified NdesConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified NdesConnector and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified NdesConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The NdesConnector.</returns>
        System.Threading.Tasks.Task<NdesConnector> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified NdesConnector and returns a <see cref="GraphResponse{NdesConnector}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NdesConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NdesConnector>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified NdesConnector using PATCH.
        /// </summary>
        /// <param name="ndesConnectorToUpdate">The NdesConnector to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated NdesConnector.</returns>
        System.Threading.Tasks.Task<NdesConnector> UpdateAsync(NdesConnector ndesConnectorToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified NdesConnector using PATCH and returns a <see cref="GraphResponse{NdesConnector}"/> object.
        /// </summary>
        /// <param name="ndesConnectorToUpdate">The NdesConnector to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{NdesConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NdesConnector>> UpdateResponseAsync(NdesConnector ndesConnectorToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        INdesConnectorRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        INdesConnectorRequest Expand(Expression<Func<NdesConnector, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        INdesConnectorRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        INdesConnectorRequest Select(Expression<Func<NdesConnector, object>> selectExpression);

    }
}
