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
    /// The interface IAndroidManagedStoreAppConfigurationSchemaRequest.
    /// </summary>
    public partial interface IAndroidManagedStoreAppConfigurationSchemaRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidManagedStoreAppConfigurationSchema using POST.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationSchemaToCreate">The AndroidManagedStoreAppConfigurationSchema to create.</param>
        /// <returns>The created AndroidManagedStoreAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfigurationSchema> CreateAsync(AndroidManagedStoreAppConfigurationSchema androidManagedStoreAppConfigurationSchemaToCreate);

        /// <summary>
        /// Creates the specified AndroidManagedStoreAppConfigurationSchema using POST.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationSchemaToCreate">The AndroidManagedStoreAppConfigurationSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidManagedStoreAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfigurationSchema> CreateAsync(AndroidManagedStoreAppConfigurationSchema androidManagedStoreAppConfigurationSchemaToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified AndroidManagedStoreAppConfigurationSchema using POST and returns a <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationSchemaToCreate">The AndroidManagedStoreAppConfigurationSchema to create.</param>
        /// <returns>The <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidManagedStoreAppConfigurationSchema>> CreateResponseAsync(AndroidManagedStoreAppConfigurationSchema androidManagedStoreAppConfigurationSchemaToCreate);

        /// <summary>
        /// Creates the specified AndroidManagedStoreAppConfigurationSchema using POST and returns a <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationSchemaToCreate">The AndroidManagedStoreAppConfigurationSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidManagedStoreAppConfigurationSchema>> CreateResponseAsync(AndroidManagedStoreAppConfigurationSchema androidManagedStoreAppConfigurationSchemaToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAppConfigurationSchema.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAppConfigurationSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAppConfigurationSchema and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAppConfigurationSchema and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidManagedStoreAppConfigurationSchema.
        /// </summary>
        /// <returns>The AndroidManagedStoreAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfigurationSchema> GetAsync();

        /// <summary>
        /// Gets the specified AndroidManagedStoreAppConfigurationSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidManagedStoreAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfigurationSchema> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidManagedStoreAppConfigurationSchema and returns a <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidManagedStoreAppConfigurationSchema>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AndroidManagedStoreAppConfigurationSchema and returns a <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidManagedStoreAppConfigurationSchema>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidManagedStoreAppConfigurationSchema using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationSchemaToUpdate">The AndroidManagedStoreAppConfigurationSchema to update.</param>
        /// <returns>The updated AndroidManagedStoreAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfigurationSchema> UpdateAsync(AndroidManagedStoreAppConfigurationSchema androidManagedStoreAppConfigurationSchemaToUpdate);

        /// <summary>
        /// Updates the specified AndroidManagedStoreAppConfigurationSchema using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationSchemaToUpdate">The AndroidManagedStoreAppConfigurationSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidManagedStoreAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfigurationSchema> UpdateAsync(AndroidManagedStoreAppConfigurationSchema androidManagedStoreAppConfigurationSchemaToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidManagedStoreAppConfigurationSchema using PATCH and returns a <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationSchemaToUpdate">The AndroidManagedStoreAppConfigurationSchema to update.</param>
        /// <returns>The <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidManagedStoreAppConfigurationSchema>> UpdateResponseAsync(AndroidManagedStoreAppConfigurationSchema androidManagedStoreAppConfigurationSchemaToUpdate);

        /// <summary>
        /// Updates the specified AndroidManagedStoreAppConfigurationSchema using PATCH and returns a <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationSchemaToUpdate">The AndroidManagedStoreAppConfigurationSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidManagedStoreAppConfigurationSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidManagedStoreAppConfigurationSchema>> UpdateResponseAsync(AndroidManagedStoreAppConfigurationSchema androidManagedStoreAppConfigurationSchemaToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAppConfigurationSchemaRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAppConfigurationSchemaRequest Expand(Expression<Func<AndroidManagedStoreAppConfigurationSchema, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAppConfigurationSchemaRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAppConfigurationSchemaRequest Select(Expression<Func<AndroidManagedStoreAppConfigurationSchema, object>> selectExpression);

    }
}
