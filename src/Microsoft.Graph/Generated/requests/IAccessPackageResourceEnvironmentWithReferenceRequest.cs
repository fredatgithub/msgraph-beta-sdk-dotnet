// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAccessPackageResourceEnvironmentWithReferenceRequest.
    /// </summary>
    public partial interface IAccessPackageResourceEnvironmentWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified AccessPackageResourceEnvironment.
        /// </summary>
        /// <returns>The AccessPackageResourceEnvironment.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceEnvironment> GetAsync();

        /// <summary>
        /// Gets the specified AccessPackageResourceEnvironment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageResourceEnvironment.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceEnvironment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AccessPackageResourceEnvironment and returns a <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceEnvironment>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AccessPackageResourceEnvironment and returns a <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceEnvironment>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified AccessPackageResourceEnvironment using POST.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToCreate">The AccessPackageResourceEnvironment to create.</param>
        /// <returns>The created AccessPackageResourceEnvironment.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceEnvironment> CreateAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToCreate);

        /// <summary>
        /// Creates the specified AccessPackageResourceEnvironment using POST.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToCreate">The AccessPackageResourceEnvironment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageResourceEnvironment.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceEnvironment> CreateAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified AccessPackageResourceEnvironment using POST and returns a <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToCreate">The AccessPackageResourceEnvironment to create.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceEnvironment>> CreateResponseAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToCreate);

        /// <summary>
        /// Creates the specified AccessPackageResourceEnvironment using POST and returns a <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToCreate">The AccessPackageResourceEnvironment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceEnvironment>> CreateResponseAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified AccessPackageResourceEnvironment using PATCH.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToUpdate">The AccessPackageResourceEnvironment to update.</param>
        /// <returns>The updated AccessPackageResourceEnvironment.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceEnvironment> UpdateAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToUpdate);

        /// <summary>
        /// Updates the specified AccessPackageResourceEnvironment using PATCH.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToUpdate">The AccessPackageResourceEnvironment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageResourceEnvironment.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceEnvironment> UpdateAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified AccessPackageResourceEnvironment using PATCH and returns a <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToUpdate">The AccessPackageResourceEnvironment to update.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceEnvironment>> UpdateResponseAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToUpdate);

        /// <summary>
        /// Updates the specified AccessPackageResourceEnvironment using PATCH and returns a <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToUpdate">The AccessPackageResourceEnvironment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceEnvironment>> UpdateResponseAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified AccessPackageResourceEnvironment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AccessPackageResourceEnvironment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified AccessPackageResourceEnvironment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified AccessPackageResourceEnvironment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceEnvironmentWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceEnvironmentWithReferenceRequest Expand(Expression<Func<AccessPackageResourceEnvironment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceEnvironmentWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceEnvironmentWithReferenceRequest Select(Expression<Func<AccessPackageResourceEnvironment, object>> selectExpression);

    }
}
