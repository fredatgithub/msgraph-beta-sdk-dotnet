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
    /// The interface IDirectoryDefinitionRequest.
    /// </summary>
    public partial interface IDirectoryDefinitionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DirectoryDefinition using POST.
        /// </summary>
        /// <param name="directoryDefinitionToCreate">The DirectoryDefinition to create.</param>
        /// <returns>The created DirectoryDefinition.</returns>
        System.Threading.Tasks.Task<DirectoryDefinition> CreateAsync(DirectoryDefinition directoryDefinitionToCreate);

        /// <summary>
        /// Creates the specified DirectoryDefinition using POST.
        /// </summary>
        /// <param name="directoryDefinitionToCreate">The DirectoryDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryDefinition.</returns>
        System.Threading.Tasks.Task<DirectoryDefinition> CreateAsync(DirectoryDefinition directoryDefinitionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DirectoryDefinition using POST and returns a <see cref="GraphResponse{DirectoryDefinition}"/> object.
        /// </summary>
        /// <param name="directoryDefinitionToCreate">The DirectoryDefinition to create.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryDefinition>> CreateResponseAsync(DirectoryDefinition directoryDefinitionToCreate);

        /// <summary>
        /// Creates the specified DirectoryDefinition using POST and returns a <see cref="GraphResponse{DirectoryDefinition}"/> object.
        /// </summary>
        /// <param name="directoryDefinitionToCreate">The DirectoryDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryDefinition>> CreateResponseAsync(DirectoryDefinition directoryDefinitionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DirectoryDefinition.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DirectoryDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DirectoryDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DirectoryDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DirectoryDefinition.
        /// </summary>
        /// <returns>The DirectoryDefinition.</returns>
        System.Threading.Tasks.Task<DirectoryDefinition> GetAsync();

        /// <summary>
        /// Gets the specified DirectoryDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectoryDefinition.</returns>
        System.Threading.Tasks.Task<DirectoryDefinition> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DirectoryDefinition and returns a <see cref="GraphResponse{DirectoryDefinition}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DirectoryDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryDefinition>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DirectoryDefinition and returns a <see cref="GraphResponse{DirectoryDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryDefinition>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DirectoryDefinition using PATCH.
        /// </summary>
        /// <param name="directoryDefinitionToUpdate">The DirectoryDefinition to update.</param>
        /// <returns>The updated DirectoryDefinition.</returns>
        System.Threading.Tasks.Task<DirectoryDefinition> UpdateAsync(DirectoryDefinition directoryDefinitionToUpdate);

        /// <summary>
        /// Updates the specified DirectoryDefinition using PATCH.
        /// </summary>
        /// <param name="directoryDefinitionToUpdate">The DirectoryDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DirectoryDefinition.</returns>
        System.Threading.Tasks.Task<DirectoryDefinition> UpdateAsync(DirectoryDefinition directoryDefinitionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DirectoryDefinition using PATCH and returns a <see cref="GraphResponse{DirectoryDefinition}"/> object.
        /// </summary>
        /// <param name="directoryDefinitionToUpdate">The DirectoryDefinition to update.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryDefinition>> UpdateResponseAsync(DirectoryDefinition directoryDefinitionToUpdate);

        /// <summary>
        /// Updates the specified DirectoryDefinition using PATCH and returns a <see cref="GraphResponse{DirectoryDefinition}"/> object.
        /// </summary>
        /// <param name="directoryDefinitionToUpdate">The DirectoryDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DirectoryDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryDefinition>> UpdateResponseAsync(DirectoryDefinition directoryDefinitionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryDefinitionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryDefinitionRequest Expand(Expression<Func<DirectoryDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryDefinitionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryDefinitionRequest Select(Expression<Func<DirectoryDefinition, object>> selectExpression);

    }
}
