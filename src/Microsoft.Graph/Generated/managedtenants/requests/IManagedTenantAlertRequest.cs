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
    /// The interface IManagedTenantAlertRequest.
    /// </summary>
    public partial interface IManagedTenantAlertRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedTenantAlert using POST.
        /// </summary>
        /// <param name="managedTenantAlertToCreate">The ManagedTenantAlert to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedTenantAlert.</returns>
        System.Threading.Tasks.Task<ManagedTenantAlert> CreateAsync(ManagedTenantAlert managedTenantAlertToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagedTenantAlert using POST and returns a <see cref="GraphResponse{ManagedTenantAlert}"/> object.
        /// </summary>
        /// <param name="managedTenantAlertToCreate">The ManagedTenantAlert to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantAlert}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlert>> CreateResponseAsync(ManagedTenantAlert managedTenantAlertToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedTenantAlert.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedTenantAlert and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedTenantAlert.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedTenantAlert.</returns>
        System.Threading.Tasks.Task<ManagedTenantAlert> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedTenantAlert and returns a <see cref="GraphResponse{ManagedTenantAlert}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantAlert}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlert>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantAlert using PATCH.
        /// </summary>
        /// <param name="managedTenantAlertToUpdate">The ManagedTenantAlert to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedTenantAlert.</returns>
        System.Threading.Tasks.Task<ManagedTenantAlert> UpdateAsync(ManagedTenantAlert managedTenantAlertToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantAlert using PATCH and returns a <see cref="GraphResponse{ManagedTenantAlert}"/> object.
        /// </summary>
        /// <param name="managedTenantAlertToUpdate">The ManagedTenantAlert to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedTenantAlert}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlert>> UpdateResponseAsync(ManagedTenantAlert managedTenantAlertToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantAlert using PUT.
        /// </summary>
        /// <param name="managedTenantAlertToUpdate">The ManagedTenantAlert object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagedTenantAlert> PutAsync(ManagedTenantAlert managedTenantAlertToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantAlert using PUT and returns a <see cref="GraphResponse{ManagedTenantAlert}"/> object.
        /// </summary>
        /// <param name="managedTenantAlertToUpdate">The ManagedTenantAlert object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagedTenantAlert}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlert>> PutResponseAsync(ManagedTenantAlert managedTenantAlertToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantAlertRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantAlertRequest Expand(Expression<Func<ManagedTenantAlert, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantAlertRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantAlertRequest Select(Expression<Func<ManagedTenantAlert, object>> selectExpression);

    }
}
