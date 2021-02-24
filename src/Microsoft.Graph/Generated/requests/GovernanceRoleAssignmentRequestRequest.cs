// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type GovernanceRoleAssignmentRequestRequest.
    /// </summary>
    public partial class GovernanceRoleAssignmentRequestRequest : BaseRequest, IGovernanceRoleAssignmentRequestRequest
    {
        /// <summary>
        /// Constructs a new GovernanceRoleAssignmentRequestRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GovernanceRoleAssignmentRequestRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GovernanceRoleAssignmentRequestObject using POST.
        /// </summary>
        /// <param name="governanceRoleAssignmentRequestObjectToCreate">The GovernanceRoleAssignmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernanceRoleAssignmentRequestObject.</returns>
        public async System.Threading.Tasks.Task<GovernanceRoleAssignmentRequestObject> CreateAsync(GovernanceRoleAssignmentRequestObject governanceRoleAssignmentRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<GovernanceRoleAssignmentRequestObject>(governanceRoleAssignmentRequestObjectToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GovernanceRoleAssignmentRequestObject using POST and returns a <see cref="GraphResponse{GovernanceRoleAssignmentRequestObject}"/> object.
        /// </summary>
        /// <param name="governanceRoleAssignmentRequestObjectToCreate">The GovernanceRoleAssignmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignmentRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignmentRequestObject>> CreateResponseAsync(GovernanceRoleAssignmentRequestObject governanceRoleAssignmentRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<GovernanceRoleAssignmentRequestObject>(governanceRoleAssignmentRequestObjectToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified GovernanceRoleAssignmentRequest.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<GovernanceRoleAssignmentRequestObject>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GovernanceRoleAssignmentRequest and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified GovernanceRoleAssignmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernanceRoleAssignmentRequestObject.</returns>
        public async System.Threading.Tasks.Task<GovernanceRoleAssignmentRequestObject> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<GovernanceRoleAssignmentRequestObject>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GovernanceRoleAssignmentRequestObject and returns a <see cref="GraphResponse{GovernanceRoleAssignmentRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignmentRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignmentRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<GovernanceRoleAssignmentRequestObject>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GovernanceRoleAssignmentRequestObject using PATCH.
        /// </summary>
        /// <param name="governanceRoleAssignmentRequestObjectToUpdate">The GovernanceRoleAssignmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GovernanceRoleAssignmentRequestObject.</returns>
        public async System.Threading.Tasks.Task<GovernanceRoleAssignmentRequestObject> UpdateAsync(GovernanceRoleAssignmentRequestObject governanceRoleAssignmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<GovernanceRoleAssignmentRequestObject>(governanceRoleAssignmentRequestObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GovernanceRoleAssignmentRequestObject using PATCH and returns a <see cref="GraphResponse{GovernanceRoleAssignmentRequestObject}"/> object.
        /// </summary>
        /// <param name="governanceRoleAssignmentRequestObjectToUpdate">The GovernanceRoleAssignmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignmentRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignmentRequestObject>> UpdateResponseAsync(GovernanceRoleAssignmentRequestObject governanceRoleAssignmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<GovernanceRoleAssignmentRequestObject>(governanceRoleAssignmentRequestObjectToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernanceRoleAssignmentRequestRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernanceRoleAssignmentRequestRequest Expand(Expression<Func<GovernanceRoleAssignmentRequestObject, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernanceRoleAssignmentRequestRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernanceRoleAssignmentRequestRequest Select(Expression<Func<GovernanceRoleAssignmentRequestObject, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="governanceRoleAssignmentRequestObjectToInitialize">The <see cref="GovernanceRoleAssignmentRequestObject"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GovernanceRoleAssignmentRequestObject governanceRoleAssignmentRequestObjectToInitialize)
        {

        }
    }
}
