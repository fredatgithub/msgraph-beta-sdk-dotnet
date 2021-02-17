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
    /// The interface IGroupPolicyCategoryDefinitionsCollectionReferencesRequest.
    /// </summary>
    public partial interface IGroupPolicyCategoryDefinitionsCollectionReferencesRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified GroupPolicyDefinition to the collection via POST.
        /// </summary>
        /// <param name="groupPolicyDefinition">The GroupPolicyDefinition to add.</param>
        System.Threading.Tasks.Task AddAsync(GroupPolicyDefinition groupPolicyDefinition);

        /// <summary>
        /// Adds the specified GroupPolicyDefinition to the collection via POST.
        /// </summary>
        /// <param name="groupPolicyDefinition">The GroupPolicyDefinition to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(GroupPolicyDefinition groupPolicyDefinition, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified GroupPolicyDefinition to the collection via POST and returns a <see cref="GraphResponse{GroupPolicyDefinition}"/> object of the request.
        /// </summary>
        /// <param name="groupPolicyDefinition">The GroupPolicyDefinition to add.</param>
        System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(GroupPolicyDefinition groupPolicyDefinition);

        /// <summary>
        /// Adds the specified GroupPolicyDefinition to the collection via POST and returns a <see cref="GraphResponse{GroupPolicyDefinition}"/> object of the request.
        /// </summary>
        /// <param name="groupPolicyDefinition">The GroupPolicyDefinition to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(GroupPolicyDefinition groupPolicyDefinition, CancellationToken cancellationToken);
    }
}
