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
    /// The type SecureScoreControlProfileRequest.
    /// </summary>
    public partial class SecureScoreControlProfileRequest : BaseRequest, ISecureScoreControlProfileRequest
    {
        /// <summary>
        /// Constructs a new SecureScoreControlProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SecureScoreControlProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SecureScoreControlProfile using POST.
        /// </summary>
        /// <param name="secureScoreControlProfileToCreate">The SecureScoreControlProfile to create.</param>
        /// <returns>The created SecureScoreControlProfile.</returns>
        public System.Threading.Tasks.Task<SecureScoreControlProfile> CreateAsync(SecureScoreControlProfile secureScoreControlProfileToCreate)
        {
            return this.CreateAsync(secureScoreControlProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SecureScoreControlProfile using POST.
        /// </summary>
        /// <param name="secureScoreControlProfileToCreate">The SecureScoreControlProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecureScoreControlProfile.</returns>
        public async System.Threading.Tasks.Task<SecureScoreControlProfile> CreateAsync(SecureScoreControlProfile secureScoreControlProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SecureScoreControlProfile>(secureScoreControlProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SecureScoreControlProfile using POST and returns a <see cref="GraphResponse{SecureScoreControlProfile}"/> object.
        /// </summary>
        /// <param name="secureScoreControlProfileToCreate">The SecureScoreControlProfile to create.</param>
        /// <returns>The <see cref="GraphResponse{SecureScoreControlProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SecureScoreControlProfile>> CreateResponseAsync(SecureScoreControlProfile secureScoreControlProfileToCreate)
        {
            return this.CreateResponseAsync(secureScoreControlProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SecureScoreControlProfile using POST and returns a <see cref="GraphResponse{SecureScoreControlProfile}"/> object.
        /// </summary>
        /// <param name="secureScoreControlProfileToCreate">The SecureScoreControlProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecureScoreControlProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SecureScoreControlProfile>> CreateResponseAsync(SecureScoreControlProfile secureScoreControlProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<SecureScoreControlProfile>(secureScoreControlProfileToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SecureScoreControlProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SecureScoreControlProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<SecureScoreControlProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SecureScoreControlProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SecureScoreControlProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SecureScoreControlProfile.
        /// </summary>
        /// <returns>The SecureScoreControlProfile.</returns>
        public System.Threading.Tasks.Task<SecureScoreControlProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SecureScoreControlProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecureScoreControlProfile.</returns>
        public async System.Threading.Tasks.Task<SecureScoreControlProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SecureScoreControlProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SecureScoreControlProfile and returns a <see cref="GraphResponse{SecureScoreControlProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SecureScoreControlProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SecureScoreControlProfile>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SecureScoreControlProfile and returns a <see cref="GraphResponse{SecureScoreControlProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecureScoreControlProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SecureScoreControlProfile>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<SecureScoreControlProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified SecureScoreControlProfile using PATCH.
        /// </summary>
        /// <param name="secureScoreControlProfileToUpdate">The SecureScoreControlProfile to update.</param>
        /// <returns>The updated SecureScoreControlProfile.</returns>
        public System.Threading.Tasks.Task<SecureScoreControlProfile> UpdateAsync(SecureScoreControlProfile secureScoreControlProfileToUpdate)
        {
            return this.UpdateAsync(secureScoreControlProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SecureScoreControlProfile using PATCH.
        /// </summary>
        /// <param name="secureScoreControlProfileToUpdate">The SecureScoreControlProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecureScoreControlProfile.</returns>
        public async System.Threading.Tasks.Task<SecureScoreControlProfile> UpdateAsync(SecureScoreControlProfile secureScoreControlProfileToUpdate, CancellationToken cancellationToken)
        {
			if (secureScoreControlProfileToUpdate.AdditionalData != null)
			{
				if (secureScoreControlProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					secureScoreControlProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, secureScoreControlProfileToUpdate.GetType().Name)
						});
				}
			}
            if (secureScoreControlProfileToUpdate.AdditionalData != null)
            {
                if (secureScoreControlProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    secureScoreControlProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, secureScoreControlProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SecureScoreControlProfile>(secureScoreControlProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SecureScoreControlProfile using PATCH and returns a <see cref="GraphResponse{SecureScoreControlProfile}"/> object.
        /// </summary>
        /// <param name="secureScoreControlProfileToUpdate">The SecureScoreControlProfile to update.</param>
        /// <returns>The <see cref="GraphResponse{SecureScoreControlProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SecureScoreControlProfile>> UpdateResponseAsync(SecureScoreControlProfile secureScoreControlProfileToUpdate)
        {
            return this.UpdateResponseAsync(secureScoreControlProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SecureScoreControlProfile using PATCH and returns a <see cref="GraphResponse{SecureScoreControlProfile}"/> object.
        /// </summary>
        /// <param name="secureScoreControlProfileToUpdate">The SecureScoreControlProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SecureScoreControlProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SecureScoreControlProfile>> UpdateResponseAsync(SecureScoreControlProfile secureScoreControlProfileToUpdate, CancellationToken cancellationToken)
        {
			if (secureScoreControlProfileToUpdate.AdditionalData != null)
			{
				if (secureScoreControlProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					secureScoreControlProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, secureScoreControlProfileToUpdate.GetType().Name)
						});
				}
			}
            if (secureScoreControlProfileToUpdate.AdditionalData != null)
            {
                if (secureScoreControlProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    secureScoreControlProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, secureScoreControlProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<SecureScoreControlProfile>(secureScoreControlProfileToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISecureScoreControlProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISecureScoreControlProfileRequest Expand(Expression<Func<SecureScoreControlProfile, object>> expandExpression)
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
        public ISecureScoreControlProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISecureScoreControlProfileRequest Select(Expression<Func<SecureScoreControlProfile, object>> selectExpression)
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
        /// <param name="secureScoreControlProfileToInitialize">The <see cref="SecureScoreControlProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SecureScoreControlProfile secureScoreControlProfileToInitialize)
        {

        }
    }
}
