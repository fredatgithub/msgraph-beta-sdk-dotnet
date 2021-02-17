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
    /// The type ActiveDirectoryWindowsAutopilotDeploymentProfileRequest.
    /// </summary>
    public partial class ActiveDirectoryWindowsAutopilotDeploymentProfileRequest : BaseRequest, IActiveDirectoryWindowsAutopilotDeploymentProfileRequest
    {
        /// <summary>
        /// Constructs a new ActiveDirectoryWindowsAutopilotDeploymentProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ActiveDirectoryWindowsAutopilotDeploymentProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using POST.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToCreate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to create.</param>
        /// <returns>The created ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        public System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> CreateAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToCreate)
        {
            return this.CreateAsync(activeDirectoryWindowsAutopilotDeploymentProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using POST.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToCreate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        public async System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> CreateAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ActiveDirectoryWindowsAutopilotDeploymentProfile>(activeDirectoryWindowsAutopilotDeploymentProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using POST and returns a <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToCreate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to create.</param>
        /// <returns>The <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ActiveDirectoryWindowsAutopilotDeploymentProfile>> CreateResponseAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToCreate)
        {
            return this.CreateResponseAsync(activeDirectoryWindowsAutopilotDeploymentProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using POST and returns a <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToCreate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ActiveDirectoryWindowsAutopilotDeploymentProfile>> CreateResponseAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<ActiveDirectoryWindowsAutopilotDeploymentProfile>(activeDirectoryWindowsAutopilotDeploymentProfileToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ActiveDirectoryWindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ActiveDirectoryWindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ActiveDirectoryWindowsAutopilotDeploymentProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ActiveDirectoryWindowsAutopilotDeploymentProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ActiveDirectoryWindowsAutopilotDeploymentProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ActiveDirectoryWindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <returns>The ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        public System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ActiveDirectoryWindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        public async System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ActiveDirectoryWindowsAutopilotDeploymentProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ActiveDirectoryWindowsAutopilotDeploymentProfile and returns a <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ActiveDirectoryWindowsAutopilotDeploymentProfile>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ActiveDirectoryWindowsAutopilotDeploymentProfile and returns a <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ActiveDirectoryWindowsAutopilotDeploymentProfile>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<ActiveDirectoryWindowsAutopilotDeploymentProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using PATCH.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToUpdate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to update.</param>
        /// <returns>The updated ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        public System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> UpdateAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToUpdate)
        {
            return this.UpdateAsync(activeDirectoryWindowsAutopilotDeploymentProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using PATCH.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToUpdate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        public async System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> UpdateAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToUpdate, CancellationToken cancellationToken)
        {
			if (activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData != null)
			{
				if (activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.GetType().Name)
						});
				}
			}
            if (activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData != null)
            {
                if (activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ActiveDirectoryWindowsAutopilotDeploymentProfile>(activeDirectoryWindowsAutopilotDeploymentProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using PATCH and returns a <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToUpdate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to update.</param>
        /// <returns>The <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ActiveDirectoryWindowsAutopilotDeploymentProfile>> UpdateResponseAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToUpdate)
        {
            return this.UpdateResponseAsync(activeDirectoryWindowsAutopilotDeploymentProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using PATCH and returns a <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToUpdate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ActiveDirectoryWindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ActiveDirectoryWindowsAutopilotDeploymentProfile>> UpdateResponseAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToUpdate, CancellationToken cancellationToken)
        {
			if (activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData != null)
			{
				if (activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.GetType().Name)
						});
				}
			}
            if (activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData != null)
            {
                if (activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, activeDirectoryWindowsAutopilotDeploymentProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<ActiveDirectoryWindowsAutopilotDeploymentProfile>(activeDirectoryWindowsAutopilotDeploymentProfileToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IActiveDirectoryWindowsAutopilotDeploymentProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IActiveDirectoryWindowsAutopilotDeploymentProfileRequest Expand(Expression<Func<ActiveDirectoryWindowsAutopilotDeploymentProfile, object>> expandExpression)
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
        public IActiveDirectoryWindowsAutopilotDeploymentProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IActiveDirectoryWindowsAutopilotDeploymentProfileRequest Select(Expression<Func<ActiveDirectoryWindowsAutopilotDeploymentProfile, object>> selectExpression)
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
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToInitialize">The <see cref="ActiveDirectoryWindowsAutopilotDeploymentProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToInitialize)
        {

        }
    }
}
