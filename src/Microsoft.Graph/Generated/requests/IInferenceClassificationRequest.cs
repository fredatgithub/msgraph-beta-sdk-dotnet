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
    /// The interface IInferenceClassificationRequest.
    /// </summary>
    public partial interface IInferenceClassificationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified InferenceClassification using POST.
        /// </summary>
        /// <param name="inferenceClassificationToCreate">The InferenceClassification to create.</param>
        /// <returns>The created InferenceClassification.</returns>
        System.Threading.Tasks.Task<InferenceClassification> CreateAsync(InferenceClassification inferenceClassificationToCreate);

        /// <summary>
        /// Creates the specified InferenceClassification using POST.
        /// </summary>
        /// <param name="inferenceClassificationToCreate">The InferenceClassification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created InferenceClassification.</returns>
        System.Threading.Tasks.Task<InferenceClassification> CreateAsync(InferenceClassification inferenceClassificationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified InferenceClassification using POST and returns a <see cref="GraphResponse{InferenceClassification}"/> object.
        /// </summary>
        /// <param name="inferenceClassificationToCreate">The InferenceClassification to create.</param>
        /// <returns>The <see cref="GraphResponse{InferenceClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InferenceClassification>> CreateResponseAsync(InferenceClassification inferenceClassificationToCreate);

        /// <summary>
        /// Creates the specified InferenceClassification using POST and returns a <see cref="GraphResponse{InferenceClassification}"/> object.
        /// </summary>
        /// <param name="inferenceClassificationToCreate">The InferenceClassification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InferenceClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InferenceClassification>> CreateResponseAsync(InferenceClassification inferenceClassificationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified InferenceClassification.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified InferenceClassification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified InferenceClassification and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified InferenceClassification and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified InferenceClassification.
        /// </summary>
        /// <returns>The InferenceClassification.</returns>
        System.Threading.Tasks.Task<InferenceClassification> GetAsync();

        /// <summary>
        /// Gets the specified InferenceClassification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The InferenceClassification.</returns>
        System.Threading.Tasks.Task<InferenceClassification> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified InferenceClassification and returns a <see cref="GraphResponse{InferenceClassification}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{InferenceClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InferenceClassification>> GetResponseAsync();

        /// <summary>
        /// Gets the specified InferenceClassification and returns a <see cref="GraphResponse{InferenceClassification}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InferenceClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InferenceClassification>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified InferenceClassification using PATCH.
        /// </summary>
        /// <param name="inferenceClassificationToUpdate">The InferenceClassification to update.</param>
        /// <returns>The updated InferenceClassification.</returns>
        System.Threading.Tasks.Task<InferenceClassification> UpdateAsync(InferenceClassification inferenceClassificationToUpdate);

        /// <summary>
        /// Updates the specified InferenceClassification using PATCH.
        /// </summary>
        /// <param name="inferenceClassificationToUpdate">The InferenceClassification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated InferenceClassification.</returns>
        System.Threading.Tasks.Task<InferenceClassification> UpdateAsync(InferenceClassification inferenceClassificationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified InferenceClassification using PATCH and returns a <see cref="GraphResponse{InferenceClassification}"/> object.
        /// </summary>
        /// <param name="inferenceClassificationToUpdate">The InferenceClassification to update.</param>
        /// <returns>The <see cref="GraphResponse{InferenceClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InferenceClassification>> UpdateResponseAsync(InferenceClassification inferenceClassificationToUpdate);

        /// <summary>
        /// Updates the specified InferenceClassification using PATCH and returns a <see cref="GraphResponse{InferenceClassification}"/> object.
        /// </summary>
        /// <param name="inferenceClassificationToUpdate">The InferenceClassification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{InferenceClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InferenceClassification>> UpdateResponseAsync(InferenceClassification inferenceClassificationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IInferenceClassificationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IInferenceClassificationRequest Expand(Expression<Func<InferenceClassification, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IInferenceClassificationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IInferenceClassificationRequest Select(Expression<Func<InferenceClassification, object>> selectExpression);

    }
}
