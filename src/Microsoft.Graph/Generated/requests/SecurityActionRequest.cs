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
    /// The type SecurityActionRequest.
    /// </summary>
    public partial class SecurityActionRequest : BaseRequest, ISecurityActionRequest
    {
        /// <summary>
        /// Constructs a new SecurityActionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SecurityActionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SecurityAction using POST.
        /// </summary>
        /// <param name="securityActionToCreate">The SecurityAction to create.</param>
        /// <returns>The created SecurityAction.</returns>
        public System.Threading.Tasks.Task<SecurityAction> CreateAsync(SecurityAction securityActionToCreate)
        {
            return this.CreateAsync(securityActionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SecurityAction using POST.
        /// </summary>
        /// <param name="securityActionToCreate">The SecurityAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecurityAction.</returns>
        public async System.Threading.Tasks.Task<SecurityAction> CreateAsync(SecurityAction securityActionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SecurityAction>(securityActionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SecurityAction using POST and returns a <see cref="GraphResponse{SecurityAction}"/> object.
        /// </summary>
        /// <param name="securityActionToCreate">The SecurityAction to create.</param>
        /// <returns>The <see cref="GraphResponse{SecurityAction}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SecurityAction>> CreateResponseAsync(SecurityAction securityActionToCreate)
        {
            return this.CreateResponseAsync(securityActionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SecurityAction using POST and returns a <see cref="GraphResponse{SecurityAction}"/> object.
        /// </summary>
        /// <param name="securityActionToCreate">The SecurityAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityAction}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SecurityAction>> CreateResponseAsync(SecurityAction securityActionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<SecurityAction>(securityActionToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SecurityAction.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SecurityAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<SecurityAction>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SecurityAction and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SecurityAction and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SecurityAction.
        /// </summary>
        /// <returns>The SecurityAction.</returns>
        public System.Threading.Tasks.Task<SecurityAction> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SecurityAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecurityAction.</returns>
        public async System.Threading.Tasks.Task<SecurityAction> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SecurityAction>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SecurityAction and returns a <see cref="GraphResponse{SecurityAction}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SecurityAction}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SecurityAction>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SecurityAction and returns a <see cref="GraphResponse{SecurityAction}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityAction}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SecurityAction>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<SecurityAction>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified SecurityAction using PATCH.
        /// </summary>
        /// <param name="securityActionToUpdate">The SecurityAction to update.</param>
        /// <returns>The updated SecurityAction.</returns>
        public System.Threading.Tasks.Task<SecurityAction> UpdateAsync(SecurityAction securityActionToUpdate)
        {
            return this.UpdateAsync(securityActionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SecurityAction using PATCH.
        /// </summary>
        /// <param name="securityActionToUpdate">The SecurityAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecurityAction.</returns>
        public async System.Threading.Tasks.Task<SecurityAction> UpdateAsync(SecurityAction securityActionToUpdate, CancellationToken cancellationToken)
        {
			if (securityActionToUpdate.AdditionalData != null)
			{
				if (securityActionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					securityActionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, securityActionToUpdate.GetType().Name)
						});
				}
			}
            if (securityActionToUpdate.AdditionalData != null)
            {
                if (securityActionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    securityActionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, securityActionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SecurityAction>(securityActionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SecurityAction using PATCH and returns a <see cref="GraphResponse{SecurityAction}"/> object.
        /// </summary>
        /// <param name="securityActionToUpdate">The SecurityAction to update.</param>
        /// <returns>The <see cref="GraphResponse{SecurityAction}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SecurityAction>> UpdateResponseAsync(SecurityAction securityActionToUpdate)
        {
            return this.UpdateResponseAsync(securityActionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SecurityAction using PATCH and returns a <see cref="GraphResponse{SecurityAction}"/> object.
        /// </summary>
        /// <param name="securityActionToUpdate">The SecurityAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SecurityAction}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SecurityAction>> UpdateResponseAsync(SecurityAction securityActionToUpdate, CancellationToken cancellationToken)
        {
			if (securityActionToUpdate.AdditionalData != null)
			{
				if (securityActionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					securityActionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, securityActionToUpdate.GetType().Name)
						});
				}
			}
            if (securityActionToUpdate.AdditionalData != null)
            {
                if (securityActionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    securityActionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, securityActionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<SecurityAction>(securityActionToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISecurityActionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISecurityActionRequest Expand(Expression<Func<SecurityAction, object>> expandExpression)
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
        public ISecurityActionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISecurityActionRequest Select(Expression<Func<SecurityAction, object>> selectExpression)
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
        /// <param name="securityActionToInitialize">The <see cref="SecurityAction"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SecurityAction securityActionToInitialize)
        {

        }
    }
}
