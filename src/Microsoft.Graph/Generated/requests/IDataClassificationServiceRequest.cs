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
    /// The interface IDataClassificationServiceRequest.
    /// </summary>
    public partial interface IDataClassificationServiceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DataClassificationService using POST.
        /// </summary>
        /// <param name="dataClassificationServiceToCreate">The DataClassificationService to create.</param>
        /// <returns>The created DataClassificationService.</returns>
        System.Threading.Tasks.Task<DataClassificationService> CreateAsync(DataClassificationService dataClassificationServiceToCreate);

        /// <summary>
        /// Creates the specified DataClassificationService using POST.
        /// </summary>
        /// <param name="dataClassificationServiceToCreate">The DataClassificationService to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DataClassificationService.</returns>
        System.Threading.Tasks.Task<DataClassificationService> CreateAsync(DataClassificationService dataClassificationServiceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DataClassificationService using POST and returns a <see cref="GraphResponse{DataClassificationService}"/> object.
        /// </summary>
        /// <param name="dataClassificationServiceToCreate">The DataClassificationService to create.</param>
        /// <returns>The <see cref="GraphResponse{DataClassificationService}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataClassificationService>> CreateResponseAsync(DataClassificationService dataClassificationServiceToCreate);

        /// <summary>
        /// Creates the specified DataClassificationService using POST and returns a <see cref="GraphResponse{DataClassificationService}"/> object.
        /// </summary>
        /// <param name="dataClassificationServiceToCreate">The DataClassificationService to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DataClassificationService}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataClassificationService>> CreateResponseAsync(DataClassificationService dataClassificationServiceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DataClassificationService.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DataClassificationService.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DataClassificationService and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DataClassificationService and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DataClassificationService.
        /// </summary>
        /// <returns>The DataClassificationService.</returns>
        System.Threading.Tasks.Task<DataClassificationService> GetAsync();

        /// <summary>
        /// Gets the specified DataClassificationService.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DataClassificationService.</returns>
        System.Threading.Tasks.Task<DataClassificationService> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DataClassificationService and returns a <see cref="GraphResponse{DataClassificationService}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DataClassificationService}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataClassificationService>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DataClassificationService and returns a <see cref="GraphResponse{DataClassificationService}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DataClassificationService}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataClassificationService>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DataClassificationService using PATCH.
        /// </summary>
        /// <param name="dataClassificationServiceToUpdate">The DataClassificationService to update.</param>
        /// <returns>The updated DataClassificationService.</returns>
        System.Threading.Tasks.Task<DataClassificationService> UpdateAsync(DataClassificationService dataClassificationServiceToUpdate);

        /// <summary>
        /// Updates the specified DataClassificationService using PATCH.
        /// </summary>
        /// <param name="dataClassificationServiceToUpdate">The DataClassificationService to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DataClassificationService.</returns>
        System.Threading.Tasks.Task<DataClassificationService> UpdateAsync(DataClassificationService dataClassificationServiceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DataClassificationService using PATCH and returns a <see cref="GraphResponse{DataClassificationService}"/> object.
        /// </summary>
        /// <param name="dataClassificationServiceToUpdate">The DataClassificationService to update.</param>
        /// <returns>The <see cref="GraphResponse{DataClassificationService}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataClassificationService>> UpdateResponseAsync(DataClassificationService dataClassificationServiceToUpdate);

        /// <summary>
        /// Updates the specified DataClassificationService using PATCH and returns a <see cref="GraphResponse{DataClassificationService}"/> object.
        /// </summary>
        /// <param name="dataClassificationServiceToUpdate">The DataClassificationService to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DataClassificationService}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataClassificationService>> UpdateResponseAsync(DataClassificationService dataClassificationServiceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceRequest Expand(Expression<Func<DataClassificationService, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceRequest Select(Expression<Func<DataClassificationService, object>> selectExpression);

    }
}
