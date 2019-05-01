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
    /// The interface IMailboxUsageDetailRequest.
    /// </summary>
    public partial interface IMailboxUsageDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MailboxUsageDetail using PUT.
        /// </summary>
        /// <param name="mailboxUsageDetailToCreate">The MailboxUsageDetail to create.</param>
        /// <returns>The created MailboxUsageDetail.</returns>
        System.Threading.Tasks.Task<MailboxUsageDetail> CreateAsync(MailboxUsageDetail mailboxUsageDetailToCreate);        /// <summary>
        /// Creates the specified MailboxUsageDetail using PUT.
        /// </summary>
        /// <param name="mailboxUsageDetailToCreate">The MailboxUsageDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MailboxUsageDetail.</returns>
        System.Threading.Tasks.Task<MailboxUsageDetail> CreateAsync(MailboxUsageDetail mailboxUsageDetailToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MailboxUsageDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MailboxUsageDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MailboxUsageDetail.
        /// </summary>
        /// <returns>The MailboxUsageDetail.</returns>
        System.Threading.Tasks.Task<MailboxUsageDetail> GetAsync();

        /// <summary>
        /// Gets the specified MailboxUsageDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MailboxUsageDetail.</returns>
        System.Threading.Tasks.Task<MailboxUsageDetail> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MailboxUsageDetail using PATCH.
        /// </summary>
        /// <param name="mailboxUsageDetailToUpdate">The MailboxUsageDetail to update.</param>
        /// <returns>The updated MailboxUsageDetail.</returns>
        System.Threading.Tasks.Task<MailboxUsageDetail> UpdateAsync(MailboxUsageDetail mailboxUsageDetailToUpdate);

        /// <summary>
        /// Updates the specified MailboxUsageDetail using PATCH.
        /// </summary>
        /// <param name="mailboxUsageDetailToUpdate">The MailboxUsageDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MailboxUsageDetail.</returns>
        System.Threading.Tasks.Task<MailboxUsageDetail> UpdateAsync(MailboxUsageDetail mailboxUsageDetailToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageDetailRequest Expand(Expression<Func<MailboxUsageDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageDetailRequest Select(Expression<Func<MailboxUsageDetail, object>> selectExpression);

    }
}