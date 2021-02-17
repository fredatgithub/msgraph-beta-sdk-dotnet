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
    /// The interface ICompanyUnitsOfMeasureCollectionRequest.
    /// </summary>
    public partial interface ICompanyUnitsOfMeasureCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified UnitOfMeasure to the collection via POST.
        /// </summary>
        /// <param name="unitOfMeasure">The UnitOfMeasure to add.</param>
        /// <returns>The created UnitOfMeasure.</returns>
        System.Threading.Tasks.Task<UnitOfMeasure> AddAsync(UnitOfMeasure unitOfMeasure);

        /// <summary>
        /// Adds the specified UnitOfMeasure to the collection via POST.
        /// </summary>
        /// <param name="unitOfMeasure">The UnitOfMeasure to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnitOfMeasure.</returns>
        System.Threading.Tasks.Task<UnitOfMeasure> AddAsync(UnitOfMeasure unitOfMeasure, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified UnitOfMeasure to the collection via POST and returns a <see cref="GraphResponse{UnitOfMeasure}"/> object of the request.
        /// </summary>
        /// <param name="unitOfMeasure">The UnitOfMeasure to add.</param>
        /// <returns>The <see cref="GraphResponse{UnitOfMeasure}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnitOfMeasure>> AddResponseAsync(UnitOfMeasure unitOfMeasure);

        /// <summary>
        /// Adds the specified UnitOfMeasure to the collection via POST and returns a <see cref="GraphResponse{UnitOfMeasure}"/> object of the request.
        /// </summary>
        /// <param name="unitOfMeasure">The UnitOfMeasure to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnitOfMeasure}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnitOfMeasure>> AddResponseAsync(UnitOfMeasure unitOfMeasure, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICompanyUnitsOfMeasureCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICompanyUnitsOfMeasureCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CompanyUnitsOfMeasureCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{CompanyUnitsOfMeasureCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CompanyUnitsOfMeasureCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CompanyUnitsOfMeasureCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CompanyUnitsOfMeasureCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CompanyUnitsOfMeasureCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyUnitsOfMeasureCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyUnitsOfMeasureCollectionRequest Expand(Expression<Func<UnitOfMeasure, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyUnitsOfMeasureCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyUnitsOfMeasureCollectionRequest Select(Expression<Func<UnitOfMeasure, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyUnitsOfMeasureCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyUnitsOfMeasureCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyUnitsOfMeasureCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyUnitsOfMeasureCollectionRequest OrderBy(string value);
    }
}
