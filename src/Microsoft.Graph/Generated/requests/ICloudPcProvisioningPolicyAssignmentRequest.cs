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
    /// The interface ICloudPcProvisioningPolicyAssignmentRequest.
    /// </summary>
    public partial interface ICloudPcProvisioningPolicyAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CloudPcProvisioningPolicyAssignment using POST.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyAssignmentToCreate">The CloudPcProvisioningPolicyAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcProvisioningPolicyAssignment.</returns>
        System.Threading.Tasks.Task<CloudPcProvisioningPolicyAssignment> CreateAsync(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified CloudPcProvisioningPolicyAssignment using POST and returns a <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyAssignmentToCreate">The CloudPcProvisioningPolicyAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicyAssignment>> CreateResponseAsync(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CloudPcProvisioningPolicyAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CloudPcProvisioningPolicyAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicyAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcProvisioningPolicyAssignment.</returns>
        System.Threading.Tasks.Task<CloudPcProvisioningPolicyAssignment> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicyAssignment and returns a <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicyAssignment>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified CloudPcProvisioningPolicyAssignment using PATCH.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyAssignmentToUpdate">The CloudPcProvisioningPolicyAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcProvisioningPolicyAssignment.</returns>
        System.Threading.Tasks.Task<CloudPcProvisioningPolicyAssignment> UpdateAsync(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified CloudPcProvisioningPolicyAssignment using PATCH and returns a <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyAssignmentToUpdate">The CloudPcProvisioningPolicyAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicyAssignment>> UpdateResponseAsync(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcProvisioningPolicyAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcProvisioningPolicyAssignmentRequest Expand(Expression<Func<CloudPcProvisioningPolicyAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcProvisioningPolicyAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcProvisioningPolicyAssignmentRequest Select(Expression<Func<CloudPcProvisioningPolicyAssignment, object>> selectExpression);

    }
}
