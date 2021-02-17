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
    /// The interface IGroupPolicyPresentationValueListRequest.
    /// </summary>
    public partial interface IGroupPolicyPresentationValueListRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupPolicyPresentationValueList using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationValueListToCreate">The GroupPolicyPresentationValueList to create.</param>
        /// <returns>The created GroupPolicyPresentationValueList.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueList> CreateAsync(GroupPolicyPresentationValueList groupPolicyPresentationValueListToCreate);

        /// <summary>
        /// Creates the specified GroupPolicyPresentationValueList using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationValueListToCreate">The GroupPolicyPresentationValueList to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationValueList.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueList> CreateAsync(GroupPolicyPresentationValueList groupPolicyPresentationValueListToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified GroupPolicyPresentationValueList using POST and returns a <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationValueListToCreate">The GroupPolicyPresentationValueList to create.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationValueList>> CreateResponseAsync(GroupPolicyPresentationValueList groupPolicyPresentationValueListToCreate);

        /// <summary>
        /// Creates the specified GroupPolicyPresentationValueList using POST and returns a <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationValueListToCreate">The GroupPolicyPresentationValueList to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationValueList>> CreateResponseAsync(GroupPolicyPresentationValueList groupPolicyPresentationValueListToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationValueList.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationValueList.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationValueList and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationValueList and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupPolicyPresentationValueList.
        /// </summary>
        /// <returns>The GroupPolicyPresentationValueList.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueList> GetAsync();

        /// <summary>
        /// Gets the specified GroupPolicyPresentationValueList.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationValueList.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueList> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupPolicyPresentationValueList and returns a <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationValueList>> GetResponseAsync();

        /// <summary>
        /// Gets the specified GroupPolicyPresentationValueList and returns a <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationValueList>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValueList using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationValueListToUpdate">The GroupPolicyPresentationValueList to update.</param>
        /// <returns>The updated GroupPolicyPresentationValueList.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueList> UpdateAsync(GroupPolicyPresentationValueList groupPolicyPresentationValueListToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValueList using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationValueListToUpdate">The GroupPolicyPresentationValueList to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyPresentationValueList.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueList> UpdateAsync(GroupPolicyPresentationValueList groupPolicyPresentationValueListToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValueList using PATCH and returns a <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationValueListToUpdate">The GroupPolicyPresentationValueList to update.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationValueList>> UpdateResponseAsync(GroupPolicyPresentationValueList groupPolicyPresentationValueListToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValueList using PATCH and returns a <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationValueListToUpdate">The GroupPolicyPresentationValueList to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationValueList}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationValueList>> UpdateResponseAsync(GroupPolicyPresentationValueList groupPolicyPresentationValueListToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueListRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueListRequest Expand(Expression<Func<GroupPolicyPresentationValueList, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueListRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueListRequest Select(Expression<Func<GroupPolicyPresentationValueList, object>> selectExpression);

    }
}
