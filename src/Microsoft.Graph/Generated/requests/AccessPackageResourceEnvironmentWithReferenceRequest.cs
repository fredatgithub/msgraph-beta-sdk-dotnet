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
    /// The type AccessPackageResourceEnvironmentWithReferenceRequest.
    /// </summary>
    public partial class AccessPackageResourceEnvironmentWithReferenceRequest : BaseRequest, IAccessPackageResourceEnvironmentWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new AccessPackageResourceEnvironmentWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AccessPackageResourceEnvironmentWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified AccessPackageResourceEnvironment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageResourceEnvironment.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResourceEnvironment> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<AccessPackageResourceEnvironment>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AccessPackageResourceEnvironment and returns a <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceEnvironment>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<AccessPackageResourceEnvironment>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified AccessPackageResourceEnvironment using POST.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToCreate">The AccessPackageResourceEnvironment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageResourceEnvironment.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResourceEnvironment> CreateAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<AccessPackageResourceEnvironment>(accessPackageResourceEnvironmentToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified AccessPackageResourceEnvironment using POST and returns a <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToCreate">The AccessPackageResourceEnvironment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceEnvironment>> CreateResponseAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<AccessPackageResourceEnvironment>(accessPackageResourceEnvironmentToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified AccessPackageResourceEnvironment using PATCH.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToUpdate">The AccessPackageResourceEnvironment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageResourceEnvironment.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResourceEnvironment> UpdateAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<AccessPackageResourceEnvironment>(accessPackageResourceEnvironmentToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified AccessPackageResourceEnvironment using PATCH and returns a <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceEnvironmentToUpdate">The AccessPackageResourceEnvironment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceEnvironment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceEnvironment>> UpdateResponseAsync(AccessPackageResourceEnvironment accessPackageResourceEnvironmentToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<AccessPackageResourceEnvironment>(accessPackageResourceEnvironmentToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified AccessPackageResourceEnvironment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<AccessPackageResourceEnvironment>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified AccessPackageResourceEnvironment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageResourceEnvironmentWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageResourceEnvironmentWithReferenceRequest Expand(Expression<Func<AccessPackageResourceEnvironment, object>> expandExpression)
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
        public IAccessPackageResourceEnvironmentWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageResourceEnvironmentWithReferenceRequest Select(Expression<Func<AccessPackageResourceEnvironment, object>> selectExpression)
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
