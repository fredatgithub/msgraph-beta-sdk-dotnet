// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITeamsUserActivityUserDetailRequest.
    /// </summary>
    public partial interface ITeamsUserActivityUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamsUserActivityUserDetail using PUT.
        /// </summary>
        /// <param name="teamsUserActivityUserDetailToCreate">The TeamsUserActivityUserDetail to create.</param>
        /// <returns>The created TeamsUserActivityUserDetail.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserDetail> CreateAsync(TeamsUserActivityUserDetail teamsUserActivityUserDetailToCreate);        /// <summary>
        /// Creates the specified TeamsUserActivityUserDetail using PUT.
        /// </summary>
        /// <param name="teamsUserActivityUserDetailToCreate">The TeamsUserActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsUserActivityUserDetail.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserDetail> CreateAsync(TeamsUserActivityUserDetail teamsUserActivityUserDetailToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TeamsUserActivityUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TeamsUserActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TeamsUserActivityUserDetail.
        /// </summary>
        /// <returns>The TeamsUserActivityUserDetail.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserDetail> GetAsync();

        /// <summary>
        /// Gets the specified TeamsUserActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsUserActivityUserDetail.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserDetail> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TeamsUserActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="teamsUserActivityUserDetailToUpdate">The TeamsUserActivityUserDetail to update.</param>
        /// <returns>The updated TeamsUserActivityUserDetail.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserDetail> UpdateAsync(TeamsUserActivityUserDetail teamsUserActivityUserDetailToUpdate);

        /// <summary>
        /// Updates the specified TeamsUserActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="teamsUserActivityUserDetailToUpdate">The TeamsUserActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TeamsUserActivityUserDetail.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserDetail> UpdateAsync(TeamsUserActivityUserDetail teamsUserActivityUserDetailToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityUserDetailRequest Expand(Expression<Func<TeamsUserActivityUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityUserDetailRequest Select(Expression<Func<TeamsUserActivityUserDetail, object>> selectExpression);

    }
}