// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagedTenantAlertLogRequest.
    /// </summary>
    public partial interface IManagedTenantAlertLogRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedTenantAlertLog using POST.
        /// </summary>
        /// <param name="managedTenantAlertLogToCreate">The ManagedTenantAlertLog to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedTenantAlertLog.</returns>
        System.Threading.Tasks.Task<ManagedTenantAlertLog> CreateAsync(ManagedTenantAlertLog managedTenantAlertLogToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagedTenantAlertLog using POST and returns a <see cref="GraphResponse{ManagedTenantAlertLog}"/> object.
        /// </summary>
        /// <param name="managedTenantAlertLogToCreate">The ManagedTenantAlertLog to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantAlertLog}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlertLog>> CreateResponseAsync(ManagedTenantAlertLog managedTenantAlertLogToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedTenantAlertLog.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedTenantAlertLog and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedTenantAlertLog.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedTenantAlertLog.</returns>
        System.Threading.Tasks.Task<ManagedTenantAlertLog> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedTenantAlertLog and returns a <see cref="GraphResponse{ManagedTenantAlertLog}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantAlertLog}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlertLog>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantAlertLog using PATCH.
        /// </summary>
        /// <param name="managedTenantAlertLogToUpdate">The ManagedTenantAlertLog to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedTenantAlertLog.</returns>
        System.Threading.Tasks.Task<ManagedTenantAlertLog> UpdateAsync(ManagedTenantAlertLog managedTenantAlertLogToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantAlertLog using PATCH and returns a <see cref="GraphResponse{ManagedTenantAlertLog}"/> object.
        /// </summary>
        /// <param name="managedTenantAlertLogToUpdate">The ManagedTenantAlertLog to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedTenantAlertLog}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlertLog>> UpdateResponseAsync(ManagedTenantAlertLog managedTenantAlertLogToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantAlertLog using PUT.
        /// </summary>
        /// <param name="managedTenantAlertLogToUpdate">The ManagedTenantAlertLog object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagedTenantAlertLog> PutAsync(ManagedTenantAlertLog managedTenantAlertLogToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantAlertLog using PUT and returns a <see cref="GraphResponse{ManagedTenantAlertLog}"/> object.
        /// </summary>
        /// <param name="managedTenantAlertLogToUpdate">The ManagedTenantAlertLog object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagedTenantAlertLog}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlertLog>> PutResponseAsync(ManagedTenantAlertLog managedTenantAlertLogToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantAlertLogRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantAlertLogRequest Expand(Expression<Func<ManagedTenantAlertLog, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantAlertLogRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantAlertLogRequest Select(Expression<Func<ManagedTenantAlertLog, object>> selectExpression);

    }
}
