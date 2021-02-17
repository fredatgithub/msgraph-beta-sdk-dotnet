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
    /// The interface IMicrosoftTunnelServerLogCollectionResponseRequest.
    /// </summary>
    public partial interface IMicrosoftTunnelServerLogCollectionResponseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MicrosoftTunnelServerLogCollectionResponse using POST.
        /// </summary>
        /// <param name="microsoftTunnelServerLogCollectionResponseToCreate">The MicrosoftTunnelServerLogCollectionResponse to create.</param>
        /// <returns>The created MicrosoftTunnelServerLogCollectionResponse.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelServerLogCollectionResponse> CreateAsync(MicrosoftTunnelServerLogCollectionResponse microsoftTunnelServerLogCollectionResponseToCreate);

        /// <summary>
        /// Creates the specified MicrosoftTunnelServerLogCollectionResponse using POST.
        /// </summary>
        /// <param name="microsoftTunnelServerLogCollectionResponseToCreate">The MicrosoftTunnelServerLogCollectionResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MicrosoftTunnelServerLogCollectionResponse.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelServerLogCollectionResponse> CreateAsync(MicrosoftTunnelServerLogCollectionResponse microsoftTunnelServerLogCollectionResponseToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified MicrosoftTunnelServerLogCollectionResponse using POST and returns a <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelServerLogCollectionResponseToCreate">The MicrosoftTunnelServerLogCollectionResponse to create.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelServerLogCollectionResponse>> CreateResponseAsync(MicrosoftTunnelServerLogCollectionResponse microsoftTunnelServerLogCollectionResponseToCreate);

        /// <summary>
        /// Creates the specified MicrosoftTunnelServerLogCollectionResponse using POST and returns a <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelServerLogCollectionResponseToCreate">The MicrosoftTunnelServerLogCollectionResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelServerLogCollectionResponse>> CreateResponseAsync(MicrosoftTunnelServerLogCollectionResponse microsoftTunnelServerLogCollectionResponseToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MicrosoftTunnelServerLogCollectionResponse.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MicrosoftTunnelServerLogCollectionResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MicrosoftTunnelServerLogCollectionResponse and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified MicrosoftTunnelServerLogCollectionResponse and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MicrosoftTunnelServerLogCollectionResponse.
        /// </summary>
        /// <returns>The MicrosoftTunnelServerLogCollectionResponse.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelServerLogCollectionResponse> GetAsync();

        /// <summary>
        /// Gets the specified MicrosoftTunnelServerLogCollectionResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MicrosoftTunnelServerLogCollectionResponse.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelServerLogCollectionResponse> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MicrosoftTunnelServerLogCollectionResponse and returns a <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelServerLogCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the specified MicrosoftTunnelServerLogCollectionResponse and returns a <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelServerLogCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MicrosoftTunnelServerLogCollectionResponse using PATCH.
        /// </summary>
        /// <param name="microsoftTunnelServerLogCollectionResponseToUpdate">The MicrosoftTunnelServerLogCollectionResponse to update.</param>
        /// <returns>The updated MicrosoftTunnelServerLogCollectionResponse.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelServerLogCollectionResponse> UpdateAsync(MicrosoftTunnelServerLogCollectionResponse microsoftTunnelServerLogCollectionResponseToUpdate);

        /// <summary>
        /// Updates the specified MicrosoftTunnelServerLogCollectionResponse using PATCH.
        /// </summary>
        /// <param name="microsoftTunnelServerLogCollectionResponseToUpdate">The MicrosoftTunnelServerLogCollectionResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MicrosoftTunnelServerLogCollectionResponse.</returns>
        System.Threading.Tasks.Task<MicrosoftTunnelServerLogCollectionResponse> UpdateAsync(MicrosoftTunnelServerLogCollectionResponse microsoftTunnelServerLogCollectionResponseToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MicrosoftTunnelServerLogCollectionResponse using PATCH and returns a <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelServerLogCollectionResponseToUpdate">The MicrosoftTunnelServerLogCollectionResponse to update.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelServerLogCollectionResponse>> UpdateResponseAsync(MicrosoftTunnelServerLogCollectionResponse microsoftTunnelServerLogCollectionResponseToUpdate);

        /// <summary>
        /// Updates the specified MicrosoftTunnelServerLogCollectionResponse using PATCH and returns a <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelServerLogCollectionResponseToUpdate">The MicrosoftTunnelServerLogCollectionResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelServerLogCollectionResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelServerLogCollectionResponse>> UpdateResponseAsync(MicrosoftTunnelServerLogCollectionResponse microsoftTunnelServerLogCollectionResponseToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftTunnelServerLogCollectionResponseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftTunnelServerLogCollectionResponseRequest Expand(Expression<Func<MicrosoftTunnelServerLogCollectionResponse, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftTunnelServerLogCollectionResponseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftTunnelServerLogCollectionResponseRequest Select(Expression<Func<MicrosoftTunnelServerLogCollectionResponse, object>> selectExpression);

    }
}
