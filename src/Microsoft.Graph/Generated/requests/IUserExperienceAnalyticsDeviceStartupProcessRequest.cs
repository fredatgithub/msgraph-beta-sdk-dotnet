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
    /// The interface IUserExperienceAnalyticsDeviceStartupProcessRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsDeviceStartupProcessRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDeviceStartupProcess using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessToCreate">The UserExperienceAnalyticsDeviceStartupProcess to create.</param>
        /// <returns>The created UserExperienceAnalyticsDeviceStartupProcess.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcess> CreateAsync(UserExperienceAnalyticsDeviceStartupProcess userExperienceAnalyticsDeviceStartupProcessToCreate);

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDeviceStartupProcess using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessToCreate">The UserExperienceAnalyticsDeviceStartupProcess to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsDeviceStartupProcess.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcess> CreateAsync(UserExperienceAnalyticsDeviceStartupProcess userExperienceAnalyticsDeviceStartupProcessToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDeviceStartupProcess using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessToCreate">The UserExperienceAnalyticsDeviceStartupProcess to create.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceStartupProcess>> CreateResponseAsync(UserExperienceAnalyticsDeviceStartupProcess userExperienceAnalyticsDeviceStartupProcessToCreate);

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDeviceStartupProcess using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessToCreate">The UserExperienceAnalyticsDeviceStartupProcess to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceStartupProcess>> CreateResponseAsync(UserExperienceAnalyticsDeviceStartupProcess userExperienceAnalyticsDeviceStartupProcessToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDeviceStartupProcess.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDeviceStartupProcess.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDeviceStartupProcess and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDeviceStartupProcess and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDeviceStartupProcess.
        /// </summary>
        /// <returns>The UserExperienceAnalyticsDeviceStartupProcess.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcess> GetAsync();

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDeviceStartupProcess.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsDeviceStartupProcess.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcess> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDeviceStartupProcess and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceStartupProcess>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDeviceStartupProcess and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceStartupProcess>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceStartupProcess using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessToUpdate">The UserExperienceAnalyticsDeviceStartupProcess to update.</param>
        /// <returns>The updated UserExperienceAnalyticsDeviceStartupProcess.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcess> UpdateAsync(UserExperienceAnalyticsDeviceStartupProcess userExperienceAnalyticsDeviceStartupProcessToUpdate);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceStartupProcess using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessToUpdate">The UserExperienceAnalyticsDeviceStartupProcess to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsDeviceStartupProcess.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcess> UpdateAsync(UserExperienceAnalyticsDeviceStartupProcess userExperienceAnalyticsDeviceStartupProcessToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceStartupProcess using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessToUpdate">The UserExperienceAnalyticsDeviceStartupProcess to update.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceStartupProcess>> UpdateResponseAsync(UserExperienceAnalyticsDeviceStartupProcess userExperienceAnalyticsDeviceStartupProcessToUpdate);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceStartupProcess using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessToUpdate">The UserExperienceAnalyticsDeviceStartupProcess to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceStartupProcess}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceStartupProcess>> UpdateResponseAsync(UserExperienceAnalyticsDeviceStartupProcess userExperienceAnalyticsDeviceStartupProcessToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDeviceStartupProcessRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDeviceStartupProcessRequest Expand(Expression<Func<UserExperienceAnalyticsDeviceStartupProcess, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDeviceStartupProcessRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDeviceStartupProcessRequest Select(Expression<Func<UserExperienceAnalyticsDeviceStartupProcess, object>> selectExpression);

    }
}
