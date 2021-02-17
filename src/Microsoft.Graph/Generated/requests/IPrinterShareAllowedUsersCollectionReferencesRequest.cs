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
    /// The interface IPrinterShareAllowedUsersCollectionReferencesRequest.
    /// </summary>
    public partial interface IPrinterShareAllowedUsersCollectionReferencesRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified User to the collection via POST.
        /// </summary>
        /// <param name="user">The User to add.</param>
        System.Threading.Tasks.Task AddAsync(User user);

        /// <summary>
        /// Adds the specified User to the collection via POST.
        /// </summary>
        /// <param name="user">The User to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(User user, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified User to the collection via POST and returns a <see cref="GraphResponse{User}"/> object of the request.
        /// </summary>
        /// <param name="user">The User to add.</param>
        System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(User user);

        /// <summary>
        /// Adds the specified User to the collection via POST and returns a <see cref="GraphResponse{User}"/> object of the request.
        /// </summary>
        /// <param name="user">The User to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(User user, CancellationToken cancellationToken);
    }
}
