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
    /// The type TeamsUserActivityUserCountsRequest.
    /// </summary>
    public partial class TeamsUserActivityUserCountsRequest : BaseRequest, ITeamsUserActivityUserCountsRequest
    {
        /// <summary>
        /// Constructs a new TeamsUserActivityUserCountsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TeamsUserActivityUserCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TeamsUserActivityUserCounts using POST.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToCreate">The TeamsUserActivityUserCounts to create.</param>
        /// <returns>The created TeamsUserActivityUserCounts.</returns>
        public System.Threading.Tasks.Task<TeamsUserActivityUserCounts> CreateAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToCreate)
        {
            return this.CreateAsync(teamsUserActivityUserCountsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TeamsUserActivityUserCounts using POST.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToCreate">The TeamsUserActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsUserActivityUserCounts.</returns>
        public async System.Threading.Tasks.Task<TeamsUserActivityUserCounts> CreateAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<TeamsUserActivityUserCounts>(teamsUserActivityUserCountsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TeamsUserActivityUserCounts using POST and returns a <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToCreate">The TeamsUserActivityUserCounts to create.</param>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityUserCounts>> CreateResponseAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToCreate)
        {
            return this.CreateResponseAsync(teamsUserActivityUserCountsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TeamsUserActivityUserCounts using POST and returns a <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToCreate">The TeamsUserActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityUserCounts>> CreateResponseAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<TeamsUserActivityUserCounts>(teamsUserActivityUserCountsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TeamsUserActivityUserCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TeamsUserActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<TeamsUserActivityUserCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TeamsUserActivityUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TeamsUserActivityUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified TeamsUserActivityUserCounts.
        /// </summary>
        /// <returns>The TeamsUserActivityUserCounts.</returns>
        public System.Threading.Tasks.Task<TeamsUserActivityUserCounts> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TeamsUserActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsUserActivityUserCounts.</returns>
        public async System.Threading.Tasks.Task<TeamsUserActivityUserCounts> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<TeamsUserActivityUserCounts>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified TeamsUserActivityUserCounts and returns a <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityUserCounts>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TeamsUserActivityUserCounts and returns a <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityUserCounts>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<TeamsUserActivityUserCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified TeamsUserActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToUpdate">The TeamsUserActivityUserCounts to update.</param>
        /// <returns>The updated TeamsUserActivityUserCounts.</returns>
        public System.Threading.Tasks.Task<TeamsUserActivityUserCounts> UpdateAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToUpdate)
        {
            return this.UpdateAsync(teamsUserActivityUserCountsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TeamsUserActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToUpdate">The TeamsUserActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsUserActivityUserCounts.</returns>
        public async System.Threading.Tasks.Task<TeamsUserActivityUserCounts> UpdateAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToUpdate, CancellationToken cancellationToken)
        {
			if (teamsUserActivityUserCountsToUpdate.AdditionalData != null)
			{
				if (teamsUserActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					teamsUserActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, teamsUserActivityUserCountsToUpdate.GetType().Name)
						});
				}
			}
            if (teamsUserActivityUserCountsToUpdate.AdditionalData != null)
            {
                if (teamsUserActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    teamsUserActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, teamsUserActivityUserCountsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<TeamsUserActivityUserCounts>(teamsUserActivityUserCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TeamsUserActivityUserCounts using PATCH and returns a <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToUpdate">The TeamsUserActivityUserCounts to update.</param>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityUserCounts>> UpdateResponseAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToUpdate)
        {
            return this.UpdateResponseAsync(teamsUserActivityUserCountsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TeamsUserActivityUserCounts using PATCH and returns a <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToUpdate">The TeamsUserActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityUserCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityUserCounts>> UpdateResponseAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToUpdate, CancellationToken cancellationToken)
        {
			if (teamsUserActivityUserCountsToUpdate.AdditionalData != null)
			{
				if (teamsUserActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					teamsUserActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, teamsUserActivityUserCountsToUpdate.GetType().Name)
						});
				}
			}
            if (teamsUserActivityUserCountsToUpdate.AdditionalData != null)
            {
                if (teamsUserActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    teamsUserActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, teamsUserActivityUserCountsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<TeamsUserActivityUserCounts>(teamsUserActivityUserCountsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsUserActivityUserCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsUserActivityUserCountsRequest Expand(Expression<Func<TeamsUserActivityUserCounts, object>> expandExpression)
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
        public ITeamsUserActivityUserCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsUserActivityUserCountsRequest Select(Expression<Func<TeamsUserActivityUserCounts, object>> selectExpression)
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
        /// <param name="teamsUserActivityUserCountsToInitialize">The <see cref="TeamsUserActivityUserCounts"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TeamsUserActivityUserCounts teamsUserActivityUserCountsToInitialize)
        {

        }
    }
}
