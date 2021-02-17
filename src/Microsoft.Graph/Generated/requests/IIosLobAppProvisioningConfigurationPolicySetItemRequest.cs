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
    /// The interface IIosLobAppProvisioningConfigurationPolicySetItemRequest.
    /// </summary>
    public partial interface IIosLobAppProvisioningConfigurationPolicySetItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosLobAppProvisioningConfigurationPolicySetItem using POST.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationPolicySetItemToCreate">The IosLobAppProvisioningConfigurationPolicySetItem to create.</param>
        /// <returns>The created IosLobAppProvisioningConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<IosLobAppProvisioningConfigurationPolicySetItem> CreateAsync(IosLobAppProvisioningConfigurationPolicySetItem iosLobAppProvisioningConfigurationPolicySetItemToCreate);

        /// <summary>
        /// Creates the specified IosLobAppProvisioningConfigurationPolicySetItem using POST.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationPolicySetItemToCreate">The IosLobAppProvisioningConfigurationPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosLobAppProvisioningConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<IosLobAppProvisioningConfigurationPolicySetItem> CreateAsync(IosLobAppProvisioningConfigurationPolicySetItem iosLobAppProvisioningConfigurationPolicySetItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified IosLobAppProvisioningConfigurationPolicySetItem using POST and returns a <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationPolicySetItemToCreate">The IosLobAppProvisioningConfigurationPolicySetItem to create.</param>
        /// <returns>The <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosLobAppProvisioningConfigurationPolicySetItem>> CreateResponseAsync(IosLobAppProvisioningConfigurationPolicySetItem iosLobAppProvisioningConfigurationPolicySetItemToCreate);

        /// <summary>
        /// Creates the specified IosLobAppProvisioningConfigurationPolicySetItem using POST and returns a <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationPolicySetItemToCreate">The IosLobAppProvisioningConfigurationPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosLobAppProvisioningConfigurationPolicySetItem>> CreateResponseAsync(IosLobAppProvisioningConfigurationPolicySetItem iosLobAppProvisioningConfigurationPolicySetItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosLobAppProvisioningConfigurationPolicySetItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosLobAppProvisioningConfigurationPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosLobAppProvisioningConfigurationPolicySetItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified IosLobAppProvisioningConfigurationPolicySetItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosLobAppProvisioningConfigurationPolicySetItem.
        /// </summary>
        /// <returns>The IosLobAppProvisioningConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<IosLobAppProvisioningConfigurationPolicySetItem> GetAsync();

        /// <summary>
        /// Gets the specified IosLobAppProvisioningConfigurationPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosLobAppProvisioningConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<IosLobAppProvisioningConfigurationPolicySetItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosLobAppProvisioningConfigurationPolicySetItem and returns a <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosLobAppProvisioningConfigurationPolicySetItem>> GetResponseAsync();

        /// <summary>
        /// Gets the specified IosLobAppProvisioningConfigurationPolicySetItem and returns a <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosLobAppProvisioningConfigurationPolicySetItem>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosLobAppProvisioningConfigurationPolicySetItem using PATCH.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationPolicySetItemToUpdate">The IosLobAppProvisioningConfigurationPolicySetItem to update.</param>
        /// <returns>The updated IosLobAppProvisioningConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<IosLobAppProvisioningConfigurationPolicySetItem> UpdateAsync(IosLobAppProvisioningConfigurationPolicySetItem iosLobAppProvisioningConfigurationPolicySetItemToUpdate);

        /// <summary>
        /// Updates the specified IosLobAppProvisioningConfigurationPolicySetItem using PATCH.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationPolicySetItemToUpdate">The IosLobAppProvisioningConfigurationPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosLobAppProvisioningConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<IosLobAppProvisioningConfigurationPolicySetItem> UpdateAsync(IosLobAppProvisioningConfigurationPolicySetItem iosLobAppProvisioningConfigurationPolicySetItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosLobAppProvisioningConfigurationPolicySetItem using PATCH and returns a <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationPolicySetItemToUpdate">The IosLobAppProvisioningConfigurationPolicySetItem to update.</param>
        /// <returns>The <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosLobAppProvisioningConfigurationPolicySetItem>> UpdateResponseAsync(IosLobAppProvisioningConfigurationPolicySetItem iosLobAppProvisioningConfigurationPolicySetItemToUpdate);

        /// <summary>
        /// Updates the specified IosLobAppProvisioningConfigurationPolicySetItem using PATCH and returns a <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationPolicySetItemToUpdate">The IosLobAppProvisioningConfigurationPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosLobAppProvisioningConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosLobAppProvisioningConfigurationPolicySetItem>> UpdateResponseAsync(IosLobAppProvisioningConfigurationPolicySetItem iosLobAppProvisioningConfigurationPolicySetItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosLobAppProvisioningConfigurationPolicySetItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosLobAppProvisioningConfigurationPolicySetItemRequest Expand(Expression<Func<IosLobAppProvisioningConfigurationPolicySetItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosLobAppProvisioningConfigurationPolicySetItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosLobAppProvisioningConfigurationPolicySetItemRequest Select(Expression<Func<IosLobAppProvisioningConfigurationPolicySetItem, object>> selectExpression);

    }
}
