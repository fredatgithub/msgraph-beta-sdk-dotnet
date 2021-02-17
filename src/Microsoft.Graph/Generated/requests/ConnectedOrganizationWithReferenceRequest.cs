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
    /// The type ConnectedOrganizationWithReferenceRequest.
    /// </summary>
    public partial class ConnectedOrganizationWithReferenceRequest : BaseRequest, IConnectedOrganizationWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new ConnectedOrganizationWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ConnectedOrganizationWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified ConnectedOrganization.
        /// </summary>
        /// <returns>The ConnectedOrganization.</returns>
        public System.Threading.Tasks.Task<ConnectedOrganization> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ConnectedOrganization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConnectedOrganization.</returns>
        public async System.Threading.Tasks.Task<ConnectedOrganization> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ConnectedOrganization>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ConnectedOrganization and returns a <see cref="GraphResponse{ConnectedOrganization}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ConnectedOrganization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConnectedOrganization>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ConnectedOrganization and returns a <see cref="GraphResponse{ConnectedOrganization}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConnectedOrganization}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ConnectedOrganization>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<ConnectedOrganization>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Creates the specified ConnectedOrganization using POST.
        /// </summary>
        /// <param name="connectedOrganizationToCreate">The ConnectedOrganization to create.</param>
        /// <returns>The created ConnectedOrganization.</returns>
        public System.Threading.Tasks.Task<ConnectedOrganization> CreateAsync(ConnectedOrganization connectedOrganizationToCreate)
        {
            return this.CreateAsync(connectedOrganizationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ConnectedOrganization using POST.
        /// </summary>
        /// <param name="connectedOrganizationToCreate">The ConnectedOrganization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConnectedOrganization.</returns>
        public async System.Threading.Tasks.Task<ConnectedOrganization> CreateAsync(ConnectedOrganization connectedOrganizationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ConnectedOrganization>(connectedOrganizationToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified ConnectedOrganization using POST and returns a <see cref="GraphResponse{ConnectedOrganization}"/> object.
        /// </summary>
        /// <param name="connectedOrganizationToCreate">The ConnectedOrganization to create.</param>
        /// <returns>The <see cref="GraphResponse{ConnectedOrganization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConnectedOrganization>> CreateResponseAsync(ConnectedOrganization connectedOrganizationToCreate)
        {
            return this.CreateResponseAsync(connectedOrganizationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ConnectedOrganization using POST and returns a <see cref="GraphResponse{ConnectedOrganization}"/> object.
        /// </summary>
        /// <param name="connectedOrganizationToCreate">The ConnectedOrganization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConnectedOrganization}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ConnectedOrganization>> CreateResponseAsync(ConnectedOrganization connectedOrganizationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<ConnectedOrganization>(connectedOrganizationToCreate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Updates the specified ConnectedOrganization using PATCH.
        /// </summary>
        /// <param name="connectedOrganizationToUpdate">The ConnectedOrganization to update.</param>
        /// <returns>The updated ConnectedOrganization.</returns>
        public System.Threading.Tasks.Task<ConnectedOrganization> UpdateAsync(ConnectedOrganization connectedOrganizationToUpdate)
        {
            return this.UpdateAsync(connectedOrganizationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ConnectedOrganization using PATCH.
        /// </summary>
        /// <param name="connectedOrganizationToUpdate">The ConnectedOrganization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConnectedOrganization.</returns>
        public async System.Threading.Tasks.Task<ConnectedOrganization> UpdateAsync(ConnectedOrganization connectedOrganizationToUpdate, CancellationToken cancellationToken)
        {
			if (connectedOrganizationToUpdate.AdditionalData != null)
			{
				if (connectedOrganizationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					connectedOrganizationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, connectedOrganizationToUpdate.GetType().Name)
						});
				}
			}
            if (connectedOrganizationToUpdate.AdditionalData != null)
            {
                if (connectedOrganizationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    connectedOrganizationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, connectedOrganizationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ConnectedOrganization>(connectedOrganizationToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified ConnectedOrganization using PATCH and returns a <see cref="GraphResponse{ConnectedOrganization}"/> object.
        /// </summary>
        /// <param name="connectedOrganizationToUpdate">The ConnectedOrganization to update.</param>
        /// <returns>The <see cref="GraphResponse{ConnectedOrganization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConnectedOrganization>> UpdateResponseAsync(ConnectedOrganization connectedOrganizationToUpdate)
        {
            return this.UpdateResponseAsync(connectedOrganizationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ConnectedOrganization using PATCH and returns a <see cref="GraphResponse{ConnectedOrganization}"/> object.
        /// </summary>
        /// <param name="connectedOrganizationToUpdate">The ConnectedOrganization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ConnectedOrganization}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ConnectedOrganization>> UpdateResponseAsync(ConnectedOrganization connectedOrganizationToUpdate, CancellationToken cancellationToken)
        {
			if (connectedOrganizationToUpdate.AdditionalData != null)
			{
				if (connectedOrganizationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					connectedOrganizationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, connectedOrganizationToUpdate.GetType().Name)
						});
				}
			}
            if (connectedOrganizationToUpdate.AdditionalData != null)
            {
                if (connectedOrganizationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    connectedOrganizationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, connectedOrganizationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<ConnectedOrganization>(connectedOrganizationToUpdate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified ConnectedOrganization.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ConnectedOrganization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ConnectedOrganization>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified ConnectedOrganization and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ConnectedOrganization and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConnectedOrganizationWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConnectedOrganizationWithReferenceRequest Expand(Expression<Func<ConnectedOrganization, object>> expandExpression)
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
        public IConnectedOrganizationWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IConnectedOrganizationWithReferenceRequest Select(Expression<Func<ConnectedOrganization, object>> selectExpression)
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
