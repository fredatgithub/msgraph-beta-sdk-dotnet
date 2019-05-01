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
    /// The interface ISharePointSiteUsagePagesRequest.
    /// </summary>
    public partial interface ISharePointSiteUsagePagesRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharePointSiteUsagePages using PUT.
        /// </summary>
        /// <param name="sharePointSiteUsagePagesToCreate">The SharePointSiteUsagePages to create.</param>
        /// <returns>The created SharePointSiteUsagePages.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsagePages> CreateAsync(SharePointSiteUsagePages sharePointSiteUsagePagesToCreate);        /// <summary>
        /// Creates the specified SharePointSiteUsagePages using PUT.
        /// </summary>
        /// <param name="sharePointSiteUsagePagesToCreate">The SharePointSiteUsagePages to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharePointSiteUsagePages.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsagePages> CreateAsync(SharePointSiteUsagePages sharePointSiteUsagePagesToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SharePointSiteUsagePages.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SharePointSiteUsagePages.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SharePointSiteUsagePages.
        /// </summary>
        /// <returns>The SharePointSiteUsagePages.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsagePages> GetAsync();

        /// <summary>
        /// Gets the specified SharePointSiteUsagePages.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharePointSiteUsagePages.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsagePages> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SharePointSiteUsagePages using PATCH.
        /// </summary>
        /// <param name="sharePointSiteUsagePagesToUpdate">The SharePointSiteUsagePages to update.</param>
        /// <returns>The updated SharePointSiteUsagePages.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsagePages> UpdateAsync(SharePointSiteUsagePages sharePointSiteUsagePagesToUpdate);

        /// <summary>
        /// Updates the specified SharePointSiteUsagePages using PATCH.
        /// </summary>
        /// <param name="sharePointSiteUsagePagesToUpdate">The SharePointSiteUsagePages to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SharePointSiteUsagePages.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsagePages> UpdateAsync(SharePointSiteUsagePages sharePointSiteUsagePagesToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointSiteUsagePagesRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointSiteUsagePagesRequest Expand(Expression<Func<SharePointSiteUsagePages, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointSiteUsagePagesRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointSiteUsagePagesRequest Select(Expression<Func<SharePointSiteUsagePages, object>> selectExpression);

    }
}