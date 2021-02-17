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
    /// The type GovernanceRoleSettingRequest.
    /// </summary>
    public partial class GovernanceRoleSettingRequest : BaseRequest, IGovernanceRoleSettingRequest
    {
        /// <summary>
        /// Constructs a new GovernanceRoleSettingRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GovernanceRoleSettingRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GovernanceRoleSetting using POST.
        /// </summary>
        /// <param name="governanceRoleSettingToCreate">The GovernanceRoleSetting to create.</param>
        /// <returns>The created GovernanceRoleSetting.</returns>
        public System.Threading.Tasks.Task<GovernanceRoleSetting> CreateAsync(GovernanceRoleSetting governanceRoleSettingToCreate)
        {
            return this.CreateAsync(governanceRoleSettingToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GovernanceRoleSetting using POST.
        /// </summary>
        /// <param name="governanceRoleSettingToCreate">The GovernanceRoleSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernanceRoleSetting.</returns>
        public async System.Threading.Tasks.Task<GovernanceRoleSetting> CreateAsync(GovernanceRoleSetting governanceRoleSettingToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<GovernanceRoleSetting>(governanceRoleSettingToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GovernanceRoleSetting using POST and returns a <see cref="GraphResponse{GovernanceRoleSetting}"/> object.
        /// </summary>
        /// <param name="governanceRoleSettingToCreate">The GovernanceRoleSetting to create.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleSetting}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernanceRoleSetting>> CreateResponseAsync(GovernanceRoleSetting governanceRoleSettingToCreate)
        {
            return this.CreateResponseAsync(governanceRoleSettingToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GovernanceRoleSetting using POST and returns a <see cref="GraphResponse{GovernanceRoleSetting}"/> object.
        /// </summary>
        /// <param name="governanceRoleSettingToCreate">The GovernanceRoleSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleSetting}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GovernanceRoleSetting>> CreateResponseAsync(GovernanceRoleSetting governanceRoleSettingToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<GovernanceRoleSetting>(governanceRoleSettingToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GovernanceRoleSetting.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GovernanceRoleSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<GovernanceRoleSetting>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GovernanceRoleSetting and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GovernanceRoleSetting and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified GovernanceRoleSetting.
        /// </summary>
        /// <returns>The GovernanceRoleSetting.</returns>
        public System.Threading.Tasks.Task<GovernanceRoleSetting> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GovernanceRoleSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernanceRoleSetting.</returns>
        public async System.Threading.Tasks.Task<GovernanceRoleSetting> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<GovernanceRoleSetting>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GovernanceRoleSetting and returns a <see cref="GraphResponse{GovernanceRoleSetting}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleSetting}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernanceRoleSetting>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GovernanceRoleSetting and returns a <see cref="GraphResponse{GovernanceRoleSetting}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleSetting}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GovernanceRoleSetting>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<GovernanceRoleSetting>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified GovernanceRoleSetting using PATCH.
        /// </summary>
        /// <param name="governanceRoleSettingToUpdate">The GovernanceRoleSetting to update.</param>
        /// <returns>The updated GovernanceRoleSetting.</returns>
        public System.Threading.Tasks.Task<GovernanceRoleSetting> UpdateAsync(GovernanceRoleSetting governanceRoleSettingToUpdate)
        {
            return this.UpdateAsync(governanceRoleSettingToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GovernanceRoleSetting using PATCH.
        /// </summary>
        /// <param name="governanceRoleSettingToUpdate">The GovernanceRoleSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GovernanceRoleSetting.</returns>
        public async System.Threading.Tasks.Task<GovernanceRoleSetting> UpdateAsync(GovernanceRoleSetting governanceRoleSettingToUpdate, CancellationToken cancellationToken)
        {
			if (governanceRoleSettingToUpdate.AdditionalData != null)
			{
				if (governanceRoleSettingToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					governanceRoleSettingToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governanceRoleSettingToUpdate.GetType().Name)
						});
				}
			}
            if (governanceRoleSettingToUpdate.AdditionalData != null)
            {
                if (governanceRoleSettingToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    governanceRoleSettingToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governanceRoleSettingToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<GovernanceRoleSetting>(governanceRoleSettingToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GovernanceRoleSetting using PATCH and returns a <see cref="GraphResponse{GovernanceRoleSetting}"/> object.
        /// </summary>
        /// <param name="governanceRoleSettingToUpdate">The GovernanceRoleSetting to update.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleSetting}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernanceRoleSetting>> UpdateResponseAsync(GovernanceRoleSetting governanceRoleSettingToUpdate)
        {
            return this.UpdateResponseAsync(governanceRoleSettingToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GovernanceRoleSetting using PATCH and returns a <see cref="GraphResponse{GovernanceRoleSetting}"/> object.
        /// </summary>
        /// <param name="governanceRoleSettingToUpdate">The GovernanceRoleSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleSetting}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GovernanceRoleSetting>> UpdateResponseAsync(GovernanceRoleSetting governanceRoleSettingToUpdate, CancellationToken cancellationToken)
        {
			if (governanceRoleSettingToUpdate.AdditionalData != null)
			{
				if (governanceRoleSettingToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					governanceRoleSettingToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governanceRoleSettingToUpdate.GetType().Name)
						});
				}
			}
            if (governanceRoleSettingToUpdate.AdditionalData != null)
            {
                if (governanceRoleSettingToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    governanceRoleSettingToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governanceRoleSettingToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<GovernanceRoleSetting>(governanceRoleSettingToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernanceRoleSettingRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernanceRoleSettingRequest Expand(Expression<Func<GovernanceRoleSetting, object>> expandExpression)
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
        public IGovernanceRoleSettingRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernanceRoleSettingRequest Select(Expression<Func<GovernanceRoleSetting, object>> selectExpression)
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
        /// <param name="governanceRoleSettingToInitialize">The <see cref="GovernanceRoleSetting"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GovernanceRoleSetting governanceRoleSettingToInitialize)
        {

        }
    }
}
