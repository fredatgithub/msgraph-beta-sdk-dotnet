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
    /// The interface ISectionGroupRequest.
    /// </summary>
    public partial interface ISectionGroupRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SectionGroup using POST.
        /// </summary>
        /// <param name="sectionGroupToCreate">The SectionGroup to create.</param>
        /// <returns>The created SectionGroup.</returns>
        System.Threading.Tasks.Task<SectionGroup> CreateAsync(SectionGroup sectionGroupToCreate);

        /// <summary>
        /// Creates the specified SectionGroup using POST.
        /// </summary>
        /// <param name="sectionGroupToCreate">The SectionGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SectionGroup.</returns>
        System.Threading.Tasks.Task<SectionGroup> CreateAsync(SectionGroup sectionGroupToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified SectionGroup using POST and returns a <see cref="GraphResponse{SectionGroup}"/> object.
        /// </summary>
        /// <param name="sectionGroupToCreate">The SectionGroup to create.</param>
        /// <returns>The <see cref="GraphResponse{SectionGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SectionGroup>> CreateResponseAsync(SectionGroup sectionGroupToCreate);

        /// <summary>
        /// Creates the specified SectionGroup using POST and returns a <see cref="GraphResponse{SectionGroup}"/> object.
        /// </summary>
        /// <param name="sectionGroupToCreate">The SectionGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SectionGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SectionGroup>> CreateResponseAsync(SectionGroup sectionGroupToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SectionGroup.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SectionGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SectionGroup and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified SectionGroup and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SectionGroup.
        /// </summary>
        /// <returns>The SectionGroup.</returns>
        System.Threading.Tasks.Task<SectionGroup> GetAsync();

        /// <summary>
        /// Gets the specified SectionGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SectionGroup.</returns>
        System.Threading.Tasks.Task<SectionGroup> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SectionGroup and returns a <see cref="GraphResponse{SectionGroup}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SectionGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SectionGroup>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SectionGroup and returns a <see cref="GraphResponse{SectionGroup}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SectionGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SectionGroup>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SectionGroup using PATCH.
        /// </summary>
        /// <param name="sectionGroupToUpdate">The SectionGroup to update.</param>
        /// <returns>The updated SectionGroup.</returns>
        System.Threading.Tasks.Task<SectionGroup> UpdateAsync(SectionGroup sectionGroupToUpdate);

        /// <summary>
        /// Updates the specified SectionGroup using PATCH.
        /// </summary>
        /// <param name="sectionGroupToUpdate">The SectionGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SectionGroup.</returns>
        System.Threading.Tasks.Task<SectionGroup> UpdateAsync(SectionGroup sectionGroupToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SectionGroup using PATCH and returns a <see cref="GraphResponse{SectionGroup}"/> object.
        /// </summary>
        /// <param name="sectionGroupToUpdate">The SectionGroup to update.</param>
        /// <returns>The <see cref="GraphResponse{SectionGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SectionGroup>> UpdateResponseAsync(SectionGroup sectionGroupToUpdate);

        /// <summary>
        /// Updates the specified SectionGroup using PATCH and returns a <see cref="GraphResponse{SectionGroup}"/> object.
        /// </summary>
        /// <param name="sectionGroupToUpdate">The SectionGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SectionGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SectionGroup>> UpdateResponseAsync(SectionGroup sectionGroupToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISectionGroupRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISectionGroupRequest Expand(Expression<Func<SectionGroup, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISectionGroupRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISectionGroupRequest Select(Expression<Func<SectionGroup, object>> selectExpression);

    }
}
