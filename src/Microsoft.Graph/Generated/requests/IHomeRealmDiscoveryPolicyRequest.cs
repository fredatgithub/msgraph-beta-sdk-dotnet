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
    /// The interface IHomeRealmDiscoveryPolicyRequest.
    /// </summary>
    public partial interface IHomeRealmDiscoveryPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified HomeRealmDiscoveryPolicy using POST.
        /// </summary>
        /// <param name="homeRealmDiscoveryPolicyToCreate">The HomeRealmDiscoveryPolicy to create.</param>
        /// <returns>The created HomeRealmDiscoveryPolicy.</returns>
        System.Threading.Tasks.Task<HomeRealmDiscoveryPolicy> CreateAsync(HomeRealmDiscoveryPolicy homeRealmDiscoveryPolicyToCreate);

        /// <summary>
        /// Creates the specified HomeRealmDiscoveryPolicy using POST.
        /// </summary>
        /// <param name="homeRealmDiscoveryPolicyToCreate">The HomeRealmDiscoveryPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created HomeRealmDiscoveryPolicy.</returns>
        System.Threading.Tasks.Task<HomeRealmDiscoveryPolicy> CreateAsync(HomeRealmDiscoveryPolicy homeRealmDiscoveryPolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified HomeRealmDiscoveryPolicy using POST and returns a <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object.
        /// </summary>
        /// <param name="homeRealmDiscoveryPolicyToCreate">The HomeRealmDiscoveryPolicy to create.</param>
        /// <returns>The <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HomeRealmDiscoveryPolicy>> CreateResponseAsync(HomeRealmDiscoveryPolicy homeRealmDiscoveryPolicyToCreate);

        /// <summary>
        /// Creates the specified HomeRealmDiscoveryPolicy using POST and returns a <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object.
        /// </summary>
        /// <param name="homeRealmDiscoveryPolicyToCreate">The HomeRealmDiscoveryPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HomeRealmDiscoveryPolicy>> CreateResponseAsync(HomeRealmDiscoveryPolicy homeRealmDiscoveryPolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified HomeRealmDiscoveryPolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified HomeRealmDiscoveryPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified HomeRealmDiscoveryPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified HomeRealmDiscoveryPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified HomeRealmDiscoveryPolicy.
        /// </summary>
        /// <returns>The HomeRealmDiscoveryPolicy.</returns>
        System.Threading.Tasks.Task<HomeRealmDiscoveryPolicy> GetAsync();

        /// <summary>
        /// Gets the specified HomeRealmDiscoveryPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The HomeRealmDiscoveryPolicy.</returns>
        System.Threading.Tasks.Task<HomeRealmDiscoveryPolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified HomeRealmDiscoveryPolicy and returns a <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HomeRealmDiscoveryPolicy>> GetResponseAsync();

        /// <summary>
        /// Gets the specified HomeRealmDiscoveryPolicy and returns a <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HomeRealmDiscoveryPolicy>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified HomeRealmDiscoveryPolicy using PATCH.
        /// </summary>
        /// <param name="homeRealmDiscoveryPolicyToUpdate">The HomeRealmDiscoveryPolicy to update.</param>
        /// <returns>The updated HomeRealmDiscoveryPolicy.</returns>
        System.Threading.Tasks.Task<HomeRealmDiscoveryPolicy> UpdateAsync(HomeRealmDiscoveryPolicy homeRealmDiscoveryPolicyToUpdate);

        /// <summary>
        /// Updates the specified HomeRealmDiscoveryPolicy using PATCH.
        /// </summary>
        /// <param name="homeRealmDiscoveryPolicyToUpdate">The HomeRealmDiscoveryPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated HomeRealmDiscoveryPolicy.</returns>
        System.Threading.Tasks.Task<HomeRealmDiscoveryPolicy> UpdateAsync(HomeRealmDiscoveryPolicy homeRealmDiscoveryPolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified HomeRealmDiscoveryPolicy using PATCH and returns a <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object.
        /// </summary>
        /// <param name="homeRealmDiscoveryPolicyToUpdate">The HomeRealmDiscoveryPolicy to update.</param>
        /// <returns>The <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HomeRealmDiscoveryPolicy>> UpdateResponseAsync(HomeRealmDiscoveryPolicy homeRealmDiscoveryPolicyToUpdate);

        /// <summary>
        /// Updates the specified HomeRealmDiscoveryPolicy using PATCH and returns a <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object.
        /// </summary>
        /// <param name="homeRealmDiscoveryPolicyToUpdate">The HomeRealmDiscoveryPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{HomeRealmDiscoveryPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HomeRealmDiscoveryPolicy>> UpdateResponseAsync(HomeRealmDiscoveryPolicy homeRealmDiscoveryPolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IHomeRealmDiscoveryPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IHomeRealmDiscoveryPolicyRequest Expand(Expression<Func<HomeRealmDiscoveryPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IHomeRealmDiscoveryPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IHomeRealmDiscoveryPolicyRequest Select(Expression<Func<HomeRealmDiscoveryPolicy, object>> selectExpression);

    }
}
