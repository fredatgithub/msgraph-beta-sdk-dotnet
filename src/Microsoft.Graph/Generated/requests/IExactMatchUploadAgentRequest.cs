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
    /// The interface IExactMatchUploadAgentRequest.
    /// </summary>
    public partial interface IExactMatchUploadAgentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ExactMatchUploadAgent using POST.
        /// </summary>
        /// <param name="exactMatchUploadAgentToCreate">The ExactMatchUploadAgent to create.</param>
        /// <returns>The created ExactMatchUploadAgent.</returns>
        System.Threading.Tasks.Task<ExactMatchUploadAgent> CreateAsync(ExactMatchUploadAgent exactMatchUploadAgentToCreate);

        /// <summary>
        /// Creates the specified ExactMatchUploadAgent using POST.
        /// </summary>
        /// <param name="exactMatchUploadAgentToCreate">The ExactMatchUploadAgent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExactMatchUploadAgent.</returns>
        System.Threading.Tasks.Task<ExactMatchUploadAgent> CreateAsync(ExactMatchUploadAgent exactMatchUploadAgentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified ExactMatchUploadAgent using POST and returns a <see cref="GraphResponse{ExactMatchUploadAgent}"/> object.
        /// </summary>
        /// <param name="exactMatchUploadAgentToCreate">The ExactMatchUploadAgent to create.</param>
        /// <returns>The <see cref="GraphResponse{ExactMatchUploadAgent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExactMatchUploadAgent>> CreateResponseAsync(ExactMatchUploadAgent exactMatchUploadAgentToCreate);

        /// <summary>
        /// Creates the specified ExactMatchUploadAgent using POST and returns a <see cref="GraphResponse{ExactMatchUploadAgent}"/> object.
        /// </summary>
        /// <param name="exactMatchUploadAgentToCreate">The ExactMatchUploadAgent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExactMatchUploadAgent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExactMatchUploadAgent>> CreateResponseAsync(ExactMatchUploadAgent exactMatchUploadAgentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ExactMatchUploadAgent.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ExactMatchUploadAgent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ExactMatchUploadAgent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified ExactMatchUploadAgent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ExactMatchUploadAgent.
        /// </summary>
        /// <returns>The ExactMatchUploadAgent.</returns>
        System.Threading.Tasks.Task<ExactMatchUploadAgent> GetAsync();

        /// <summary>
        /// Gets the specified ExactMatchUploadAgent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExactMatchUploadAgent.</returns>
        System.Threading.Tasks.Task<ExactMatchUploadAgent> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ExactMatchUploadAgent and returns a <see cref="GraphResponse{ExactMatchUploadAgent}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ExactMatchUploadAgent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExactMatchUploadAgent>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ExactMatchUploadAgent and returns a <see cref="GraphResponse{ExactMatchUploadAgent}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExactMatchUploadAgent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExactMatchUploadAgent>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ExactMatchUploadAgent using PATCH.
        /// </summary>
        /// <param name="exactMatchUploadAgentToUpdate">The ExactMatchUploadAgent to update.</param>
        /// <returns>The updated ExactMatchUploadAgent.</returns>
        System.Threading.Tasks.Task<ExactMatchUploadAgent> UpdateAsync(ExactMatchUploadAgent exactMatchUploadAgentToUpdate);

        /// <summary>
        /// Updates the specified ExactMatchUploadAgent using PATCH.
        /// </summary>
        /// <param name="exactMatchUploadAgentToUpdate">The ExactMatchUploadAgent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ExactMatchUploadAgent.</returns>
        System.Threading.Tasks.Task<ExactMatchUploadAgent> UpdateAsync(ExactMatchUploadAgent exactMatchUploadAgentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ExactMatchUploadAgent using PATCH and returns a <see cref="GraphResponse{ExactMatchUploadAgent}"/> object.
        /// </summary>
        /// <param name="exactMatchUploadAgentToUpdate">The ExactMatchUploadAgent to update.</param>
        /// <returns>The <see cref="GraphResponse{ExactMatchUploadAgent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExactMatchUploadAgent>> UpdateResponseAsync(ExactMatchUploadAgent exactMatchUploadAgentToUpdate);

        /// <summary>
        /// Updates the specified ExactMatchUploadAgent using PATCH and returns a <see cref="GraphResponse{ExactMatchUploadAgent}"/> object.
        /// </summary>
        /// <param name="exactMatchUploadAgentToUpdate">The ExactMatchUploadAgent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ExactMatchUploadAgent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExactMatchUploadAgent>> UpdateResponseAsync(ExactMatchUploadAgent exactMatchUploadAgentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchUploadAgentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchUploadAgentRequest Expand(Expression<Func<ExactMatchUploadAgent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchUploadAgentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchUploadAgentRequest Select(Expression<Func<ExactMatchUploadAgent, object>> selectExpression);

    }
}
