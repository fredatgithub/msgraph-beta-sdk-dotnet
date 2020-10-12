// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ITeamMembersCollectionRequestBuilder.
    /// </summary>
    public partial interface ITeamMembersCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ITeamMembersCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ITeamMembersCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IConversationMemberRequestBuilder"/> for the specified ConversationMember.
        /// </summary>
        /// <param name="id">The ID for the ConversationMember.</param>
        /// <returns>The <see cref="IConversationMemberRequestBuilder"/>.</returns>
        IConversationMemberRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for ConversationMemberAdd.
        /// </summary>
        /// <returns>The <see cref="IConversationMemberAddRequestBuilder"/>.</returns>
        IConversationMemberAddRequestBuilder Add(
            IEnumerable<ConversationMember> values = null);
    }
}