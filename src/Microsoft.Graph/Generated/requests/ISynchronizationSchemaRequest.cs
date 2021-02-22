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
    /// The interface ISynchronizationSchemaRequest.
    /// </summary>
    public partial interface ISynchronizationSchemaRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SynchronizationSchema using POST.
        /// </summary>
        /// <param name="synchronizationSchemaToCreate">The SynchronizationSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SynchronizationSchema.</returns>
        System.Threading.Tasks.Task<SynchronizationSchema> CreateAsync(SynchronizationSchema synchronizationSchemaToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SynchronizationSchema using POST and returns a <see cref="GraphResponse{SynchronizationSchema}"/> object.
        /// </summary>
        /// <param name="synchronizationSchemaToCreate">The SynchronizationSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SynchronizationSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SynchronizationSchema>> CreateResponseAsync(SynchronizationSchema synchronizationSchemaToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SynchronizationSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SynchronizationSchema and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SynchronizationSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SynchronizationSchema.</returns>
        System.Threading.Tasks.Task<SynchronizationSchema> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SynchronizationSchema and returns a <see cref="GraphResponse{SynchronizationSchema}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SynchronizationSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SynchronizationSchema>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SynchronizationSchema using PATCH.
        /// </summary>
        /// <param name="synchronizationSchemaToUpdate">The SynchronizationSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SynchronizationSchema.</returns>
        System.Threading.Tasks.Task<SynchronizationSchema> UpdateAsync(SynchronizationSchema synchronizationSchemaToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SynchronizationSchema using PATCH and returns a <see cref="GraphResponse{SynchronizationSchema}"/> object.
        /// </summary>
        /// <param name="synchronizationSchemaToUpdate">The SynchronizationSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SynchronizationSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SynchronizationSchema>> UpdateResponseAsync(SynchronizationSchema synchronizationSchemaToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationSchemaRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationSchemaRequest Expand(Expression<Func<SynchronizationSchema, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationSchemaRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationSchemaRequest Select(Expression<Func<SynchronizationSchema, object>> selectExpression);

    }
}
