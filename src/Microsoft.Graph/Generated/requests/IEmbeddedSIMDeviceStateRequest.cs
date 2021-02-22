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
    /// The interface IEmbeddedSIMDeviceStateRequest.
    /// </summary>
    public partial interface IEmbeddedSIMDeviceStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EmbeddedSIMDeviceState using POST.
        /// </summary>
        /// <param name="embeddedSIMDeviceStateToCreate">The EmbeddedSIMDeviceState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmbeddedSIMDeviceState.</returns>
        System.Threading.Tasks.Task<EmbeddedSIMDeviceState> CreateAsync(EmbeddedSIMDeviceState embeddedSIMDeviceStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified EmbeddedSIMDeviceState using POST and returns a <see cref="GraphResponse{EmbeddedSIMDeviceState}"/> object.
        /// </summary>
        /// <param name="embeddedSIMDeviceStateToCreate">The EmbeddedSIMDeviceState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmbeddedSIMDeviceState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmbeddedSIMDeviceState>> CreateResponseAsync(EmbeddedSIMDeviceState embeddedSIMDeviceStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EmbeddedSIMDeviceState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EmbeddedSIMDeviceState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EmbeddedSIMDeviceState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmbeddedSIMDeviceState.</returns>
        System.Threading.Tasks.Task<EmbeddedSIMDeviceState> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EmbeddedSIMDeviceState and returns a <see cref="GraphResponse{EmbeddedSIMDeviceState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmbeddedSIMDeviceState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmbeddedSIMDeviceState>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EmbeddedSIMDeviceState using PATCH.
        /// </summary>
        /// <param name="embeddedSIMDeviceStateToUpdate">The EmbeddedSIMDeviceState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EmbeddedSIMDeviceState.</returns>
        System.Threading.Tasks.Task<EmbeddedSIMDeviceState> UpdateAsync(EmbeddedSIMDeviceState embeddedSIMDeviceStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EmbeddedSIMDeviceState using PATCH and returns a <see cref="GraphResponse{EmbeddedSIMDeviceState}"/> object.
        /// </summary>
        /// <param name="embeddedSIMDeviceStateToUpdate">The EmbeddedSIMDeviceState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EmbeddedSIMDeviceState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmbeddedSIMDeviceState>> UpdateResponseAsync(EmbeddedSIMDeviceState embeddedSIMDeviceStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmbeddedSIMDeviceStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmbeddedSIMDeviceStateRequest Expand(Expression<Func<EmbeddedSIMDeviceState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEmbeddedSIMDeviceStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEmbeddedSIMDeviceStateRequest Select(Expression<Func<EmbeddedSIMDeviceState, object>> selectExpression);

    }
}
