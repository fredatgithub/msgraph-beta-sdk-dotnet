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
    /// The type Office365GroupsActivityStorageRequest.
    /// </summary>
    public partial class Office365GroupsActivityStorageRequest : BaseRequest, IOffice365GroupsActivityStorageRequest
    {
        /// <summary>
        /// Constructs a new Office365GroupsActivityStorageRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Office365GroupsActivityStorageRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Office365GroupsActivityStorage using POST.
        /// </summary>
        /// <param name="office365GroupsActivityStorageToCreate">The Office365GroupsActivityStorage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Office365GroupsActivityStorage.</returns>
        public async System.Threading.Tasks.Task<Office365GroupsActivityStorage> CreateAsync(Office365GroupsActivityStorage office365GroupsActivityStorageToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<Office365GroupsActivityStorage>(office365GroupsActivityStorageToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Office365GroupsActivityStorage using POST and returns a <see cref="GraphResponse{Office365GroupsActivityStorage}"/> object.
        /// </summary>
        /// <param name="office365GroupsActivityStorageToCreate">The Office365GroupsActivityStorage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityStorage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityStorage>> CreateResponseAsync(Office365GroupsActivityStorage office365GroupsActivityStorageToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<Office365GroupsActivityStorage>(office365GroupsActivityStorageToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Office365GroupsActivityStorage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<Office365GroupsActivityStorage>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Office365GroupsActivityStorage and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Office365GroupsActivityStorage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Office365GroupsActivityStorage.</returns>
        public async System.Threading.Tasks.Task<Office365GroupsActivityStorage> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<Office365GroupsActivityStorage>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Office365GroupsActivityStorage and returns a <see cref="GraphResponse{Office365GroupsActivityStorage}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityStorage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityStorage>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<Office365GroupsActivityStorage>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Office365GroupsActivityStorage using PATCH.
        /// </summary>
        /// <param name="office365GroupsActivityStorageToUpdate">The Office365GroupsActivityStorage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Office365GroupsActivityStorage.</returns>
        public async System.Threading.Tasks.Task<Office365GroupsActivityStorage> UpdateAsync(Office365GroupsActivityStorage office365GroupsActivityStorageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<Office365GroupsActivityStorage>(office365GroupsActivityStorageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Office365GroupsActivityStorage using PATCH and returns a <see cref="GraphResponse{Office365GroupsActivityStorage}"/> object.
        /// </summary>
        /// <param name="office365GroupsActivityStorageToUpdate">The Office365GroupsActivityStorage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityStorage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityStorage>> UpdateResponseAsync(Office365GroupsActivityStorage office365GroupsActivityStorageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<Office365GroupsActivityStorage>(office365GroupsActivityStorageToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365GroupsActivityStorageRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365GroupsActivityStorageRequest Expand(Expression<Func<Office365GroupsActivityStorage, object>> expandExpression)
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
        public IOffice365GroupsActivityStorageRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365GroupsActivityStorageRequest Select(Expression<Func<Office365GroupsActivityStorage, object>> selectExpression)
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
        /// <param name="office365GroupsActivityStorageToInitialize">The <see cref="Office365GroupsActivityStorage"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Office365GroupsActivityStorage office365GroupsActivityStorageToInitialize)
        {

        }
    }
}
