// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITeamworkWorkforceIntegrationsCollectionRequest.
    /// </summary>
    public partial interface ITeamworkWorkforceIntegrationsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified WorkforceIntegration to the collection via POST.
        /// </summary>
        /// <param name="workforceIntegration">The WorkforceIntegration to add.</param>
        /// <returns>The created WorkforceIntegration.</returns>
        System.Threading.Tasks.Task<WorkforceIntegration> AddAsync(WorkforceIntegration workforceIntegration);

        /// <summary>
        /// Adds the specified WorkforceIntegration to the collection via POST.
        /// </summary>
        /// <param name="workforceIntegration">The WorkforceIntegration to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkforceIntegration.</returns>
        System.Threading.Tasks.Task<WorkforceIntegration> AddAsync(WorkforceIntegration workforceIntegration, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified WorkforceIntegration to the collection via POST and returns a <see cref="GraphResponse{WorkforceIntegration}"/> object of the request.
        /// </summary>
        /// <param name="workforceIntegration">The WorkforceIntegration to add.</param>
        /// <returns>The <see cref="GraphResponse{WorkforceIntegration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkforceIntegration>> AddResponseAsync(WorkforceIntegration workforceIntegration);

        /// <summary>
        /// Adds the specified WorkforceIntegration to the collection via POST and returns a <see cref="GraphResponse{WorkforceIntegration}"/> object of the request.
        /// </summary>
        /// <param name="workforceIntegration">The WorkforceIntegration to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkforceIntegration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkforceIntegration>> AddResponseAsync(WorkforceIntegration workforceIntegration, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ITeamworkWorkforceIntegrationsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ITeamworkWorkforceIntegrationsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{TeamworkWorkforceIntegrationsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TeamworkWorkforceIntegrationsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkWorkforceIntegrationsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{TeamworkWorkforceIntegrationsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamworkWorkforceIntegrationsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkWorkforceIntegrationsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkWorkforceIntegrationsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkWorkforceIntegrationsCollectionRequest Expand(Expression<Func<WorkforceIntegration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkWorkforceIntegrationsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkWorkforceIntegrationsCollectionRequest Select(Expression<Func<WorkforceIntegration, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkWorkforceIntegrationsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkWorkforceIntegrationsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkWorkforceIntegrationsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkWorkforceIntegrationsCollectionRequest OrderBy(string value);
    }
}
