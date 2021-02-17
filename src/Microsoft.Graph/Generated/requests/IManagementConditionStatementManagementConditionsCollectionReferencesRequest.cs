// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IManagementConditionStatementManagementConditionsCollectionReferencesRequest.
    /// </summary>
    public partial interface IManagementConditionStatementManagementConditionsCollectionReferencesRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified ManagementCondition to the collection via POST.
        /// </summary>
        /// <param name="managementCondition">The ManagementCondition to add.</param>
        System.Threading.Tasks.Task AddAsync(ManagementCondition managementCondition);

        /// <summary>
        /// Adds the specified ManagementCondition to the collection via POST.
        /// </summary>
        /// <param name="managementCondition">The ManagementCondition to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(ManagementCondition managementCondition, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified ManagementCondition to the collection via POST and returns a <see cref="GraphResponse{ManagementCondition}"/> object of the request.
        /// </summary>
        /// <param name="managementCondition">The ManagementCondition to add.</param>
        System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(ManagementCondition managementCondition);

        /// <summary>
        /// Adds the specified ManagementCondition to the collection via POST and returns a <see cref="GraphResponse{ManagementCondition}"/> object of the request.
        /// </summary>
        /// <param name="managementCondition">The ManagementCondition to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(ManagementCondition managementCondition, CancellationToken cancellationToken);
    }
}
