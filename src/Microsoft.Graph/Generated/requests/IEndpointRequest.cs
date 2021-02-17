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
    /// The interface IEndpointRequest.
    /// </summary>
    public partial interface IEndpointRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Endpoint using POST.
        /// </summary>
        /// <param name="endpointToCreate">The Endpoint to create.</param>
        /// <returns>The created Endpoint.</returns>
        System.Threading.Tasks.Task<Endpoint> CreateAsync(Endpoint endpointToCreate);

        /// <summary>
        /// Creates the specified Endpoint using POST.
        /// </summary>
        /// <param name="endpointToCreate">The Endpoint to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Endpoint.</returns>
        System.Threading.Tasks.Task<Endpoint> CreateAsync(Endpoint endpointToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Endpoint using POST and returns a <see cref="GraphResponse{Endpoint}"/> object.
        /// </summary>
        /// <param name="endpointToCreate">The Endpoint to create.</param>
        /// <returns>The <see cref="GraphResponse{Endpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Endpoint>> CreateResponseAsync(Endpoint endpointToCreate);

        /// <summary>
        /// Creates the specified Endpoint using POST and returns a <see cref="GraphResponse{Endpoint}"/> object.
        /// </summary>
        /// <param name="endpointToCreate">The Endpoint to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Endpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Endpoint>> CreateResponseAsync(Endpoint endpointToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Endpoint.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Endpoint.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Endpoint and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Endpoint and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Endpoint.
        /// </summary>
        /// <returns>The Endpoint.</returns>
        System.Threading.Tasks.Task<Endpoint> GetAsync();

        /// <summary>
        /// Gets the specified Endpoint.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Endpoint.</returns>
        System.Threading.Tasks.Task<Endpoint> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Endpoint and returns a <see cref="GraphResponse{Endpoint}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Endpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Endpoint>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Endpoint and returns a <see cref="GraphResponse{Endpoint}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Endpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Endpoint>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Endpoint using PATCH.
        /// </summary>
        /// <param name="endpointToUpdate">The Endpoint to update.</param>
        /// <returns>The updated Endpoint.</returns>
        System.Threading.Tasks.Task<Endpoint> UpdateAsync(Endpoint endpointToUpdate);

        /// <summary>
        /// Updates the specified Endpoint using PATCH.
        /// </summary>
        /// <param name="endpointToUpdate">The Endpoint to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Endpoint.</returns>
        System.Threading.Tasks.Task<Endpoint> UpdateAsync(Endpoint endpointToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Endpoint using PATCH and returns a <see cref="GraphResponse{Endpoint}"/> object.
        /// </summary>
        /// <param name="endpointToUpdate">The Endpoint to update.</param>
        /// <returns>The <see cref="GraphResponse{Endpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Endpoint>> UpdateResponseAsync(Endpoint endpointToUpdate);

        /// <summary>
        /// Updates the specified Endpoint using PATCH and returns a <see cref="GraphResponse{Endpoint}"/> object.
        /// </summary>
        /// <param name="endpointToUpdate">The Endpoint to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Endpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Endpoint>> UpdateResponseAsync(Endpoint endpointToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEndpointRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEndpointRequest Expand(Expression<Func<Endpoint, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEndpointRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEndpointRequest Select(Expression<Func<Endpoint, object>> selectExpression);

    }
}
