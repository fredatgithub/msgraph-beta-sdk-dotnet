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
    /// The interface IUserExperienceAnalyticsResourcePerformanceRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsResourcePerformanceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsResourcePerformance using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsResourcePerformanceToCreate">The UserExperienceAnalyticsResourcePerformance to create.</param>
        /// <returns>The created UserExperienceAnalyticsResourcePerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsResourcePerformance> CreateAsync(UserExperienceAnalyticsResourcePerformance userExperienceAnalyticsResourcePerformanceToCreate);

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsResourcePerformance using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsResourcePerformanceToCreate">The UserExperienceAnalyticsResourcePerformance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsResourcePerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsResourcePerformance> CreateAsync(UserExperienceAnalyticsResourcePerformance userExperienceAnalyticsResourcePerformanceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsResourcePerformance using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsResourcePerformanceToCreate">The UserExperienceAnalyticsResourcePerformance to create.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsResourcePerformance>> CreateResponseAsync(UserExperienceAnalyticsResourcePerformance userExperienceAnalyticsResourcePerformanceToCreate);

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsResourcePerformance using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsResourcePerformanceToCreate">The UserExperienceAnalyticsResourcePerformance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsResourcePerformance>> CreateResponseAsync(UserExperienceAnalyticsResourcePerformance userExperienceAnalyticsResourcePerformanceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsResourcePerformance.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsResourcePerformance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsResourcePerformance and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsResourcePerformance and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsResourcePerformance.
        /// </summary>
        /// <returns>The UserExperienceAnalyticsResourcePerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsResourcePerformance> GetAsync();

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsResourcePerformance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsResourcePerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsResourcePerformance> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsResourcePerformance and returns a <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsResourcePerformance>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsResourcePerformance and returns a <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsResourcePerformance>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsResourcePerformance using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsResourcePerformanceToUpdate">The UserExperienceAnalyticsResourcePerformance to update.</param>
        /// <returns>The updated UserExperienceAnalyticsResourcePerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsResourcePerformance> UpdateAsync(UserExperienceAnalyticsResourcePerformance userExperienceAnalyticsResourcePerformanceToUpdate);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsResourcePerformance using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsResourcePerformanceToUpdate">The UserExperienceAnalyticsResourcePerformance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsResourcePerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsResourcePerformance> UpdateAsync(UserExperienceAnalyticsResourcePerformance userExperienceAnalyticsResourcePerformanceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsResourcePerformance using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsResourcePerformanceToUpdate">The UserExperienceAnalyticsResourcePerformance to update.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsResourcePerformance>> UpdateResponseAsync(UserExperienceAnalyticsResourcePerformance userExperienceAnalyticsResourcePerformanceToUpdate);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsResourcePerformance using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsResourcePerformanceToUpdate">The UserExperienceAnalyticsResourcePerformance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsResourcePerformance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsResourcePerformance>> UpdateResponseAsync(UserExperienceAnalyticsResourcePerformance userExperienceAnalyticsResourcePerformanceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsResourcePerformanceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsResourcePerformanceRequest Expand(Expression<Func<UserExperienceAnalyticsResourcePerformance, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsResourcePerformanceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsResourcePerformanceRequest Select(Expression<Func<UserExperienceAnalyticsResourcePerformance, object>> selectExpression);

    }
}
