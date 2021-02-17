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
    /// The interface IManagedDeviceMobileAppConfigurationAssignmentRequest.
    /// </summary>
    public partial interface IManagedDeviceMobileAppConfigurationAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationAssignment using POST.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationAssignmentToCreate">The ManagedDeviceMobileAppConfigurationAssignment to create.</param>
        /// <returns>The created ManagedDeviceMobileAppConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationAssignment> CreateAsync(ManagedDeviceMobileAppConfigurationAssignment managedDeviceMobileAppConfigurationAssignmentToCreate);

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationAssignment using POST.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationAssignmentToCreate">The ManagedDeviceMobileAppConfigurationAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDeviceMobileAppConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationAssignment> CreateAsync(ManagedDeviceMobileAppConfigurationAssignment managedDeviceMobileAppConfigurationAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationAssignment using POST and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationAssignmentToCreate">The ManagedDeviceMobileAppConfigurationAssignment to create.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationAssignment>> CreateResponseAsync(ManagedDeviceMobileAppConfigurationAssignment managedDeviceMobileAppConfigurationAssignmentToCreate);

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationAssignment using POST and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationAssignmentToCreate">The ManagedDeviceMobileAppConfigurationAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationAssignment>> CreateResponseAsync(ManagedDeviceMobileAppConfigurationAssignment managedDeviceMobileAppConfigurationAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationAssignment.
        /// </summary>
        /// <returns>The ManagedDeviceMobileAppConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationAssignment> GetAsync();

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDeviceMobileAppConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationAssignment and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationAssignment>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationAssignment and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationAssignment>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationAssignment using PATCH.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationAssignmentToUpdate">The ManagedDeviceMobileAppConfigurationAssignment to update.</param>
        /// <returns>The updated ManagedDeviceMobileAppConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationAssignment> UpdateAsync(ManagedDeviceMobileAppConfigurationAssignment managedDeviceMobileAppConfigurationAssignmentToUpdate);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationAssignment using PATCH.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationAssignmentToUpdate">The ManagedDeviceMobileAppConfigurationAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDeviceMobileAppConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationAssignment> UpdateAsync(ManagedDeviceMobileAppConfigurationAssignment managedDeviceMobileAppConfigurationAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationAssignment using PATCH and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationAssignmentToUpdate">The ManagedDeviceMobileAppConfigurationAssignment to update.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationAssignment>> UpdateResponseAsync(ManagedDeviceMobileAppConfigurationAssignment managedDeviceMobileAppConfigurationAssignmentToUpdate);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationAssignment using PATCH and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationAssignmentToUpdate">The ManagedDeviceMobileAppConfigurationAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationAssignment>> UpdateResponseAsync(ManagedDeviceMobileAppConfigurationAssignment managedDeviceMobileAppConfigurationAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationAssignmentRequest Expand(Expression<Func<ManagedDeviceMobileAppConfigurationAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationAssignmentRequest Select(Expression<Func<ManagedDeviceMobileAppConfigurationAssignment, object>> selectExpression);

    }
}
