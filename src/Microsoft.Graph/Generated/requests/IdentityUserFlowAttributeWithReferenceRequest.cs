// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type IdentityUserFlowAttributeWithReferenceRequest.
    /// </summary>
    public partial class IdentityUserFlowAttributeWithReferenceRequest : BaseRequest, IIdentityUserFlowAttributeWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new IdentityUserFlowAttributeWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IdentityUserFlowAttributeWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified IdentityUserFlowAttribute.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityUserFlowAttribute.</returns>
        public async System.Threading.Tasks.Task<IdentityUserFlowAttribute> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<IdentityUserFlowAttribute>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IdentityUserFlowAttribute and returns a <see cref="GraphResponse{IdentityUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityUserFlowAttribute}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityUserFlowAttribute>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<IdentityUserFlowAttribute>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified IdentityUserFlowAttribute using POST.
        /// </summary>
        /// <param name="identityUserFlowAttributeToCreate">The IdentityUserFlowAttribute to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityUserFlowAttribute.</returns>
        public async System.Threading.Tasks.Task<IdentityUserFlowAttribute> CreateAsync(IdentityUserFlowAttribute identityUserFlowAttributeToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<IdentityUserFlowAttribute>(identityUserFlowAttributeToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified IdentityUserFlowAttribute using POST and returns a <see cref="GraphResponse{IdentityUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="identityUserFlowAttributeToCreate">The IdentityUserFlowAttribute to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityUserFlowAttribute}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityUserFlowAttribute>> CreateResponseAsync(IdentityUserFlowAttribute identityUserFlowAttributeToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<IdentityUserFlowAttribute>(identityUserFlowAttributeToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified IdentityUserFlowAttribute using PATCH.
        /// </summary>
        /// <param name="identityUserFlowAttributeToUpdate">The IdentityUserFlowAttribute to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityUserFlowAttribute.</returns>
        public async System.Threading.Tasks.Task<IdentityUserFlowAttribute> UpdateAsync(IdentityUserFlowAttribute identityUserFlowAttributeToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<IdentityUserFlowAttribute>(identityUserFlowAttributeToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified IdentityUserFlowAttribute using PATCH and returns a <see cref="GraphResponse{IdentityUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="identityUserFlowAttributeToUpdate">The IdentityUserFlowAttribute to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IdentityUserFlowAttribute}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityUserFlowAttribute>> UpdateResponseAsync(IdentityUserFlowAttribute identityUserFlowAttributeToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<IdentityUserFlowAttribute>(identityUserFlowAttributeToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified IdentityUserFlowAttribute.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<IdentityUserFlowAttribute>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified IdentityUserFlowAttribute and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityUserFlowAttributeWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityUserFlowAttributeWithReferenceRequest Expand(Expression<Func<IdentityUserFlowAttribute, object>> expandExpression)
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
        public IIdentityUserFlowAttributeWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityUserFlowAttributeWithReferenceRequest Select(Expression<Func<IdentityUserFlowAttribute, object>> selectExpression)
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

    }
}
