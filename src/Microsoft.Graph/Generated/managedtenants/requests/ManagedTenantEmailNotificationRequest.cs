// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ManagedTenantEmailNotificationRequest.
    /// </summary>
    public partial class ManagedTenantEmailNotificationRequest : Microsoft.Graph.BaseRequest, IManagedTenantEmailNotificationRequest
    {
        /// <summary>
        /// Constructs a new ManagedTenantEmailNotificationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedTenantEmailNotificationRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ManagedTenantEmailNotification using POST.
        /// </summary>
        /// <param name="managedTenantEmailNotificationToCreate">The ManagedTenantEmailNotification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedTenantEmailNotification.</returns>
        public async System.Threading.Tasks.Task<ManagedTenantEmailNotification> CreateAsync(ManagedTenantEmailNotification managedTenantEmailNotificationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ManagedTenantEmailNotification>(managedTenantEmailNotificationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ManagedTenantEmailNotification using POST and returns a <see cref="GraphResponse{ManagedTenantEmailNotification}"/> object.
        /// </summary>
        /// <param name="managedTenantEmailNotificationToCreate">The ManagedTenantEmailNotification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantEmailNotification}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedTenantEmailNotification>> CreateResponseAsync(ManagedTenantEmailNotification managedTenantEmailNotificationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ManagedTenantEmailNotification>(managedTenantEmailNotificationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ManagedTenantEmailNotification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ManagedTenantEmailNotification>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ManagedTenantEmailNotification and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ManagedTenantEmailNotification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedTenantEmailNotification.</returns>
        public async System.Threading.Tasks.Task<ManagedTenantEmailNotification> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ManagedTenantEmailNotification>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ManagedTenantEmailNotification and returns a <see cref="GraphResponse{ManagedTenantEmailNotification}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantEmailNotification}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedTenantEmailNotification>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ManagedTenantEmailNotification>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagedTenantEmailNotification using PATCH.
        /// </summary>
        /// <param name="managedTenantEmailNotificationToUpdate">The ManagedTenantEmailNotification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedTenantEmailNotification.</returns>
        public async System.Threading.Tasks.Task<ManagedTenantEmailNotification> UpdateAsync(ManagedTenantEmailNotification managedTenantEmailNotificationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ManagedTenantEmailNotification>(managedTenantEmailNotificationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedTenantEmailNotification using PATCH and returns a <see cref="GraphResponse{ManagedTenantEmailNotification}"/> object.
        /// </summary>
        /// <param name="managedTenantEmailNotificationToUpdate">The ManagedTenantEmailNotification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedTenantEmailNotification}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedTenantEmailNotification>> UpdateResponseAsync(ManagedTenantEmailNotification managedTenantEmailNotificationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ManagedTenantEmailNotification>(managedTenantEmailNotificationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagedTenantEmailNotification using PUT.
        /// </summary>
        /// <param name="managedTenantEmailNotificationToUpdate">The ManagedTenantEmailNotification object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ManagedTenantEmailNotification> PutAsync(ManagedTenantEmailNotification managedTenantEmailNotificationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ManagedTenantEmailNotification>(managedTenantEmailNotificationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedTenantEmailNotification using PUT and returns a <see cref="GraphResponse{ManagedTenantEmailNotification}"/> object.
        /// </summary>
        /// <param name="managedTenantEmailNotificationToUpdate">The ManagedTenantEmailNotification object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ManagedTenantEmailNotification}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedTenantEmailNotification>> PutResponseAsync(ManagedTenantEmailNotification managedTenantEmailNotificationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ManagedTenantEmailNotification>(managedTenantEmailNotificationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantEmailNotificationRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantEmailNotificationRequest Expand(Expression<Func<ManagedTenantEmailNotification, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantEmailNotificationRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantEmailNotificationRequest Select(Expression<Func<ManagedTenantEmailNotification, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="managedTenantEmailNotificationToInitialize">The <see cref="ManagedTenantEmailNotification"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ManagedTenantEmailNotification managedTenantEmailNotificationToInitialize)
        {

        }
    }
}
