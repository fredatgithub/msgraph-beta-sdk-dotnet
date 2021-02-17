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
    /// The type IdentityApiConnectorRequest.
    /// </summary>
    public partial class IdentityApiConnectorRequest : BaseRequest, IIdentityApiConnectorRequest
    {
        /// <summary>
        /// Constructs a new IdentityApiConnectorRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IdentityApiConnectorRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IdentityApiConnector using POST.
        /// </summary>
        /// <param name="identityApiConnectorToCreate">The IdentityApiConnector to create.</param>
        /// <returns>The created IdentityApiConnector.</returns>
        public System.Threading.Tasks.Task<IdentityApiConnector> CreateAsync(IdentityApiConnector identityApiConnectorToCreate)
        {
            return this.CreateAsync(identityApiConnectorToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IdentityApiConnector using POST.
        /// </summary>
        /// <param name="identityApiConnectorToCreate">The IdentityApiConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityApiConnector.</returns>
        public async System.Threading.Tasks.Task<IdentityApiConnector> CreateAsync(IdentityApiConnector identityApiConnectorToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<IdentityApiConnector>(identityApiConnectorToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IdentityApiConnector using POST and returns a <see cref="GraphResponse{IdentityApiConnector}"/> object.
        /// </summary>
        /// <param name="identityApiConnectorToCreate">The IdentityApiConnector to create.</param>
        /// <returns>The <see cref="GraphResponse{IdentityApiConnector}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityApiConnector>> CreateResponseAsync(IdentityApiConnector identityApiConnectorToCreate)
        {
            return this.CreateResponseAsync(identityApiConnectorToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IdentityApiConnector using POST and returns a <see cref="GraphResponse{IdentityApiConnector}"/> object.
        /// </summary>
        /// <param name="identityApiConnectorToCreate">The IdentityApiConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityApiConnector}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<IdentityApiConnector>> CreateResponseAsync(IdentityApiConnector identityApiConnectorToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<IdentityApiConnector>(identityApiConnectorToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IdentityApiConnector.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IdentityApiConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<IdentityApiConnector>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IdentityApiConnector and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IdentityApiConnector and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified IdentityApiConnector.
        /// </summary>
        /// <returns>The IdentityApiConnector.</returns>
        public System.Threading.Tasks.Task<IdentityApiConnector> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IdentityApiConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityApiConnector.</returns>
        public async System.Threading.Tasks.Task<IdentityApiConnector> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<IdentityApiConnector>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IdentityApiConnector and returns a <see cref="GraphResponse{IdentityApiConnector}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{IdentityApiConnector}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityApiConnector>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IdentityApiConnector and returns a <see cref="GraphResponse{IdentityApiConnector}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityApiConnector}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<IdentityApiConnector>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<IdentityApiConnector>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified IdentityApiConnector using PATCH.
        /// </summary>
        /// <param name="identityApiConnectorToUpdate">The IdentityApiConnector to update.</param>
        /// <returns>The updated IdentityApiConnector.</returns>
        public System.Threading.Tasks.Task<IdentityApiConnector> UpdateAsync(IdentityApiConnector identityApiConnectorToUpdate)
        {
            return this.UpdateAsync(identityApiConnectorToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IdentityApiConnector using PATCH.
        /// </summary>
        /// <param name="identityApiConnectorToUpdate">The IdentityApiConnector to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityApiConnector.</returns>
        public async System.Threading.Tasks.Task<IdentityApiConnector> UpdateAsync(IdentityApiConnector identityApiConnectorToUpdate, CancellationToken cancellationToken)
        {
			if (identityApiConnectorToUpdate.AdditionalData != null)
			{
				if (identityApiConnectorToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					identityApiConnectorToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, identityApiConnectorToUpdate.GetType().Name)
						});
				}
			}
            if (identityApiConnectorToUpdate.AdditionalData != null)
            {
                if (identityApiConnectorToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    identityApiConnectorToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, identityApiConnectorToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<IdentityApiConnector>(identityApiConnectorToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IdentityApiConnector using PATCH and returns a <see cref="GraphResponse{IdentityApiConnector}"/> object.
        /// </summary>
        /// <param name="identityApiConnectorToUpdate">The IdentityApiConnector to update.</param>
        /// <returns>The <see cref="GraphResponse{IdentityApiConnector}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityApiConnector>> UpdateResponseAsync(IdentityApiConnector identityApiConnectorToUpdate)
        {
            return this.UpdateResponseAsync(identityApiConnectorToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IdentityApiConnector using PATCH and returns a <see cref="GraphResponse{IdentityApiConnector}"/> object.
        /// </summary>
        /// <param name="identityApiConnectorToUpdate">The IdentityApiConnector to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IdentityApiConnector}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<IdentityApiConnector>> UpdateResponseAsync(IdentityApiConnector identityApiConnectorToUpdate, CancellationToken cancellationToken)
        {
			if (identityApiConnectorToUpdate.AdditionalData != null)
			{
				if (identityApiConnectorToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					identityApiConnectorToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, identityApiConnectorToUpdate.GetType().Name)
						});
				}
			}
            if (identityApiConnectorToUpdate.AdditionalData != null)
            {
                if (identityApiConnectorToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    identityApiConnectorToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, identityApiConnectorToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<IdentityApiConnector>(identityApiConnectorToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityApiConnectorRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityApiConnectorRequest Expand(Expression<Func<IdentityApiConnector, object>> expandExpression)
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
        public IIdentityApiConnectorRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityApiConnectorRequest Select(Expression<Func<IdentityApiConnector, object>> selectExpression)
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
        /// <param name="identityApiConnectorToInitialize">The <see cref="IdentityApiConnector"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IdentityApiConnector identityApiConnectorToInitialize)
        {

        }
    }
}
