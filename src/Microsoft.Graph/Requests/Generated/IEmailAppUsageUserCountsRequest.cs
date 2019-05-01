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
    /// The interface IEmailAppUsageUserCountsRequest.
    /// </summary>
    public partial interface IEmailAppUsageUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EmailAppUsageUserCounts using PUT.
        /// </summary>
        /// <param name="emailAppUsageUserCountsToCreate">The EmailAppUsageUserCounts to create.</param>
        /// <returns>The created EmailAppUsageUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageUserCounts> CreateAsync(EmailAppUsageUserCounts emailAppUsageUserCountsToCreate);        /// <summary>
        /// Creates the specified EmailAppUsageUserCounts using PUT.
        /// </summary>
        /// <param name="emailAppUsageUserCountsToCreate">The EmailAppUsageUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmailAppUsageUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageUserCounts> CreateAsync(EmailAppUsageUserCounts emailAppUsageUserCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EmailAppUsageUserCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EmailAppUsageUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EmailAppUsageUserCounts.
        /// </summary>
        /// <returns>The EmailAppUsageUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageUserCounts> GetAsync();

        /// <summary>
        /// Gets the specified EmailAppUsageUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmailAppUsageUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageUserCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EmailAppUsageUserCounts using PATCH.
        /// </summary>
        /// <param name="emailAppUsageUserCountsToUpdate">The EmailAppUsageUserCounts to update.</param>
        /// <returns>The updated EmailAppUsageUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageUserCounts> UpdateAsync(EmailAppUsageUserCounts emailAppUsageUserCountsToUpdate);

        /// <summary>
        /// Updates the specified EmailAppUsageUserCounts using PATCH.
        /// </summary>
        /// <param name="emailAppUsageUserCountsToUpdate">The EmailAppUsageUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EmailAppUsageUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageUserCounts> UpdateAsync(EmailAppUsageUserCounts emailAppUsageUserCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageUserCountsRequest Expand(Expression<Func<EmailAppUsageUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageUserCountsRequest Select(Expression<Func<EmailAppUsageUserCounts, object>> selectExpression);

    }
}