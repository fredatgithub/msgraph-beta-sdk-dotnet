// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type GroupPolicyDefinitionFileDefinitionsCollectionReferencesRequest.
    /// </summary>
    public partial class GroupPolicyDefinitionFileDefinitionsCollectionReferencesRequest : BaseRequest, IGroupPolicyDefinitionFileDefinitionsCollectionReferencesRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyDefinitionFileDefinitionsCollectionReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyDefinitionFileDefinitionsCollectionReferencesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        
        /// <summary>
        /// Adds the specified GroupPolicyDefinition to the collection via POST.
        /// </summary>
        /// <param name="groupPolicyDefinition">The GroupPolicyDefinition to add.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(GroupPolicyDefinition groupPolicyDefinition)
        {
            return this.AddAsync(groupPolicyDefinition, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified GroupPolicyDefinition to the collection via POST.
        /// </summary>
        /// <param name="groupPolicyDefinition">The GroupPolicyDefinition to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(GroupPolicyDefinition groupPolicyDefinition, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";

            if (string.IsNullOrEmpty(groupPolicyDefinition.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/deviceManagement/definitions/{1}", this.Client.BaseUrl, groupPolicyDefinition.Id) };
            return this.SendAsync(requestBody, cancellationToken);
        }

    }
}