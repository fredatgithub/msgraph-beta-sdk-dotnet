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
    /// The type UserPFXCertificateRequest.
    /// </summary>
    public partial class UserPFXCertificateRequest : BaseRequest, IUserPFXCertificateRequest
    {
        /// <summary>
        /// Constructs a new UserPFXCertificateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserPFXCertificateRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UserPFXCertificate using POST.
        /// </summary>
        /// <param name="userPFXCertificateToCreate">The UserPFXCertificate to create.</param>
        /// <returns>The created UserPFXCertificate.</returns>
        public System.Threading.Tasks.Task<UserPFXCertificate> CreateAsync(UserPFXCertificate userPFXCertificateToCreate)
        {
            return this.CreateAsync(userPFXCertificateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UserPFXCertificate using POST.
        /// </summary>
        /// <param name="userPFXCertificateToCreate">The UserPFXCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserPFXCertificate.</returns>
        public async System.Threading.Tasks.Task<UserPFXCertificate> CreateAsync(UserPFXCertificate userPFXCertificateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<UserPFXCertificate>(userPFXCertificateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UserPFXCertificate using POST and returns a <see cref="GraphResponse{UserPFXCertificate}"/> object.
        /// </summary>
        /// <param name="userPFXCertificateToCreate">The UserPFXCertificate to create.</param>
        /// <returns>The <see cref="GraphResponse{UserPFXCertificate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserPFXCertificate>> CreateResponseAsync(UserPFXCertificate userPFXCertificateToCreate)
        {
            return this.CreateResponseAsync(userPFXCertificateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UserPFXCertificate using POST and returns a <see cref="GraphResponse{UserPFXCertificate}"/> object.
        /// </summary>
        /// <param name="userPFXCertificateToCreate">The UserPFXCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserPFXCertificate}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UserPFXCertificate>> CreateResponseAsync(UserPFXCertificate userPFXCertificateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<UserPFXCertificate>(userPFXCertificateToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UserPFXCertificate.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UserPFXCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<UserPFXCertificate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UserPFXCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UserPFXCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified UserPFXCertificate.
        /// </summary>
        /// <returns>The UserPFXCertificate.</returns>
        public System.Threading.Tasks.Task<UserPFXCertificate> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UserPFXCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserPFXCertificate.</returns>
        public async System.Threading.Tasks.Task<UserPFXCertificate> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<UserPFXCertificate>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UserPFXCertificate and returns a <see cref="GraphResponse{UserPFXCertificate}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UserPFXCertificate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserPFXCertificate>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UserPFXCertificate and returns a <see cref="GraphResponse{UserPFXCertificate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserPFXCertificate}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UserPFXCertificate>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<UserPFXCertificate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified UserPFXCertificate using PATCH.
        /// </summary>
        /// <param name="userPFXCertificateToUpdate">The UserPFXCertificate to update.</param>
        /// <returns>The updated UserPFXCertificate.</returns>
        public System.Threading.Tasks.Task<UserPFXCertificate> UpdateAsync(UserPFXCertificate userPFXCertificateToUpdate)
        {
            return this.UpdateAsync(userPFXCertificateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UserPFXCertificate using PATCH.
        /// </summary>
        /// <param name="userPFXCertificateToUpdate">The UserPFXCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserPFXCertificate.</returns>
        public async System.Threading.Tasks.Task<UserPFXCertificate> UpdateAsync(UserPFXCertificate userPFXCertificateToUpdate, CancellationToken cancellationToken)
        {
			if (userPFXCertificateToUpdate.AdditionalData != null)
			{
				if (userPFXCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					userPFXCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userPFXCertificateToUpdate.GetType().Name)
						});
				}
			}
            if (userPFXCertificateToUpdate.AdditionalData != null)
            {
                if (userPFXCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    userPFXCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userPFXCertificateToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<UserPFXCertificate>(userPFXCertificateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserPFXCertificate using PATCH and returns a <see cref="GraphResponse{UserPFXCertificate}"/> object.
        /// </summary>
        /// <param name="userPFXCertificateToUpdate">The UserPFXCertificate to update.</param>
        /// <returns>The <see cref="GraphResponse{UserPFXCertificate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserPFXCertificate>> UpdateResponseAsync(UserPFXCertificate userPFXCertificateToUpdate)
        {
            return this.UpdateResponseAsync(userPFXCertificateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UserPFXCertificate using PATCH and returns a <see cref="GraphResponse{UserPFXCertificate}"/> object.
        /// </summary>
        /// <param name="userPFXCertificateToUpdate">The UserPFXCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserPFXCertificate}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UserPFXCertificate>> UpdateResponseAsync(UserPFXCertificate userPFXCertificateToUpdate, CancellationToken cancellationToken)
        {
			if (userPFXCertificateToUpdate.AdditionalData != null)
			{
				if (userPFXCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					userPFXCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userPFXCertificateToUpdate.GetType().Name)
						});
				}
			}
            if (userPFXCertificateToUpdate.AdditionalData != null)
            {
                if (userPFXCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    userPFXCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userPFXCertificateToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<UserPFXCertificate>(userPFXCertificateToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserPFXCertificateRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserPFXCertificateRequest Expand(Expression<Func<UserPFXCertificate, object>> expandExpression)
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
        public IUserPFXCertificateRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserPFXCertificateRequest Select(Expression<Func<UserPFXCertificate, object>> selectExpression)
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
        /// <param name="userPFXCertificateToInitialize">The <see cref="UserPFXCertificate"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UserPFXCertificate userPFXCertificateToInitialize)
        {

        }
    }
}
