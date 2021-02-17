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
    /// The interface IOutlookTaskFolderRequest.
    /// </summary>
    public partial interface IOutlookTaskFolderRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OutlookTaskFolder using POST.
        /// </summary>
        /// <param name="outlookTaskFolderToCreate">The OutlookTaskFolder to create.</param>
        /// <returns>The created OutlookTaskFolder.</returns>
        System.Threading.Tasks.Task<OutlookTaskFolder> CreateAsync(OutlookTaskFolder outlookTaskFolderToCreate);

        /// <summary>
        /// Creates the specified OutlookTaskFolder using POST.
        /// </summary>
        /// <param name="outlookTaskFolderToCreate">The OutlookTaskFolder to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OutlookTaskFolder.</returns>
        System.Threading.Tasks.Task<OutlookTaskFolder> CreateAsync(OutlookTaskFolder outlookTaskFolderToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified OutlookTaskFolder using POST and returns a <see cref="GraphResponse{OutlookTaskFolder}"/> object.
        /// </summary>
        /// <param name="outlookTaskFolderToCreate">The OutlookTaskFolder to create.</param>
        /// <returns>The <see cref="GraphResponse{OutlookTaskFolder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTaskFolder>> CreateResponseAsync(OutlookTaskFolder outlookTaskFolderToCreate);

        /// <summary>
        /// Creates the specified OutlookTaskFolder using POST and returns a <see cref="GraphResponse{OutlookTaskFolder}"/> object.
        /// </summary>
        /// <param name="outlookTaskFolderToCreate">The OutlookTaskFolder to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OutlookTaskFolder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTaskFolder>> CreateResponseAsync(OutlookTaskFolder outlookTaskFolderToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OutlookTaskFolder.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OutlookTaskFolder.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OutlookTaskFolder and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified OutlookTaskFolder and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OutlookTaskFolder.
        /// </summary>
        /// <returns>The OutlookTaskFolder.</returns>
        System.Threading.Tasks.Task<OutlookTaskFolder> GetAsync();

        /// <summary>
        /// Gets the specified OutlookTaskFolder.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OutlookTaskFolder.</returns>
        System.Threading.Tasks.Task<OutlookTaskFolder> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OutlookTaskFolder and returns a <see cref="GraphResponse{OutlookTaskFolder}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{OutlookTaskFolder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTaskFolder>> GetResponseAsync();

        /// <summary>
        /// Gets the specified OutlookTaskFolder and returns a <see cref="GraphResponse{OutlookTaskFolder}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OutlookTaskFolder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTaskFolder>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OutlookTaskFolder using PATCH.
        /// </summary>
        /// <param name="outlookTaskFolderToUpdate">The OutlookTaskFolder to update.</param>
        /// <returns>The updated OutlookTaskFolder.</returns>
        System.Threading.Tasks.Task<OutlookTaskFolder> UpdateAsync(OutlookTaskFolder outlookTaskFolderToUpdate);

        /// <summary>
        /// Updates the specified OutlookTaskFolder using PATCH.
        /// </summary>
        /// <param name="outlookTaskFolderToUpdate">The OutlookTaskFolder to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OutlookTaskFolder.</returns>
        System.Threading.Tasks.Task<OutlookTaskFolder> UpdateAsync(OutlookTaskFolder outlookTaskFolderToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OutlookTaskFolder using PATCH and returns a <see cref="GraphResponse{OutlookTaskFolder}"/> object.
        /// </summary>
        /// <param name="outlookTaskFolderToUpdate">The OutlookTaskFolder to update.</param>
        /// <returns>The <see cref="GraphResponse{OutlookTaskFolder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTaskFolder>> UpdateResponseAsync(OutlookTaskFolder outlookTaskFolderToUpdate);

        /// <summary>
        /// Updates the specified OutlookTaskFolder using PATCH and returns a <see cref="GraphResponse{OutlookTaskFolder}"/> object.
        /// </summary>
        /// <param name="outlookTaskFolderToUpdate">The OutlookTaskFolder to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OutlookTaskFolder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTaskFolder>> UpdateResponseAsync(OutlookTaskFolder outlookTaskFolderToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskFolderRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskFolderRequest Expand(Expression<Func<OutlookTaskFolder, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskFolderRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskFolderRequest Select(Expression<Func<OutlookTaskFolder, object>> selectExpression);

    }
}
