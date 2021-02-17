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
    /// The type SkypeForBusinessParticipantActivityUserCountsRequest.
    /// </summary>
    public partial class SkypeForBusinessParticipantActivityUserCountsRequest : BaseRequest, ISkypeForBusinessParticipantActivityUserCountsRequest
    {
        /// <summary>
        /// Constructs a new SkypeForBusinessParticipantActivityUserCountsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SkypeForBusinessParticipantActivityUserCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SkypeForBusinessParticipantActivityUserCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessParticipantActivityUserCountsToCreate">The SkypeForBusinessParticipantActivityUserCounts to create.</param>
        /// <returns>The created SkypeForBusinessParticipantActivityUserCounts.</returns>
        public System.Threading.Tasks.Task<SkypeForBusinessParticipantActivityUserCounts> CreateAsync(SkypeForBusinessParticipantActivityUserCounts skypeForBusinessParticipantActivityUserCountsToCreate)
        {
            return this.CreateAsync(skypeForBusinessParticipantActivityUserCountsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SkypeForBusinessParticipantActivityUserCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessParticipantActivityUserCountsToCreate">The SkypeForBusinessParticipantActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessParticipantActivityUserCounts.</returns>
        public async System.Threading.Tasks.Task<SkypeForBusinessParticipantActivityUserCounts> CreateAsync(SkypeForBusinessParticipantActivityUserCounts skypeForBusinessParticipantActivityUserCountsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SkypeForBusinessParticipantActivityUserCounts>(skypeForBusinessParticipantActivityUserCountsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SkypeForBusinessParticipantActivityUserCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessParticipantActivityUserCountsToCreate">The SkypeForBusinessParticipantActivityUserCounts to create.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessParticipantActivityUserCounts>> CreateResponseAsync(SkypeForBusinessParticipantActivityUserCounts skypeForBusinessParticipantActivityUserCountsToCreate)
        {
            return this.CreateResponseAsync(skypeForBusinessParticipantActivityUserCountsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SkypeForBusinessParticipantActivityUserCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessParticipantActivityUserCountsToCreate">The SkypeForBusinessParticipantActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessParticipantActivityUserCounts>> CreateResponseAsync(SkypeForBusinessParticipantActivityUserCounts skypeForBusinessParticipantActivityUserCountsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<SkypeForBusinessParticipantActivityUserCounts>(skypeForBusinessParticipantActivityUserCountsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SkypeForBusinessParticipantActivityUserCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SkypeForBusinessParticipantActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<SkypeForBusinessParticipantActivityUserCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SkypeForBusinessParticipantActivityUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SkypeForBusinessParticipantActivityUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SkypeForBusinessParticipantActivityUserCounts.
        /// </summary>
        /// <returns>The SkypeForBusinessParticipantActivityUserCounts.</returns>
        public System.Threading.Tasks.Task<SkypeForBusinessParticipantActivityUserCounts> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SkypeForBusinessParticipantActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessParticipantActivityUserCounts.</returns>
        public async System.Threading.Tasks.Task<SkypeForBusinessParticipantActivityUserCounts> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SkypeForBusinessParticipantActivityUserCounts>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SkypeForBusinessParticipantActivityUserCounts and returns a <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessParticipantActivityUserCounts>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SkypeForBusinessParticipantActivityUserCounts and returns a <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessParticipantActivityUserCounts>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<SkypeForBusinessParticipantActivityUserCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified SkypeForBusinessParticipantActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessParticipantActivityUserCountsToUpdate">The SkypeForBusinessParticipantActivityUserCounts to update.</param>
        /// <returns>The updated SkypeForBusinessParticipantActivityUserCounts.</returns>
        public System.Threading.Tasks.Task<SkypeForBusinessParticipantActivityUserCounts> UpdateAsync(SkypeForBusinessParticipantActivityUserCounts skypeForBusinessParticipantActivityUserCountsToUpdate)
        {
            return this.UpdateAsync(skypeForBusinessParticipantActivityUserCountsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SkypeForBusinessParticipantActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessParticipantActivityUserCountsToUpdate">The SkypeForBusinessParticipantActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeForBusinessParticipantActivityUserCounts.</returns>
        public async System.Threading.Tasks.Task<SkypeForBusinessParticipantActivityUserCounts> UpdateAsync(SkypeForBusinessParticipantActivityUserCounts skypeForBusinessParticipantActivityUserCountsToUpdate, CancellationToken cancellationToken)
        {
			if (skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData != null)
			{
				if (skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, skypeForBusinessParticipantActivityUserCountsToUpdate.GetType().Name)
						});
				}
			}
            if (skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData != null)
            {
                if (skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, skypeForBusinessParticipantActivityUserCountsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SkypeForBusinessParticipantActivityUserCounts>(skypeForBusinessParticipantActivityUserCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SkypeForBusinessParticipantActivityUserCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessParticipantActivityUserCountsToUpdate">The SkypeForBusinessParticipantActivityUserCounts to update.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessParticipantActivityUserCounts>> UpdateResponseAsync(SkypeForBusinessParticipantActivityUserCounts skypeForBusinessParticipantActivityUserCountsToUpdate)
        {
            return this.UpdateResponseAsync(skypeForBusinessParticipantActivityUserCountsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SkypeForBusinessParticipantActivityUserCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessParticipantActivityUserCountsToUpdate">The SkypeForBusinessParticipantActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessParticipantActivityUserCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessParticipantActivityUserCounts>> UpdateResponseAsync(SkypeForBusinessParticipantActivityUserCounts skypeForBusinessParticipantActivityUserCountsToUpdate, CancellationToken cancellationToken)
        {
			if (skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData != null)
			{
				if (skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, skypeForBusinessParticipantActivityUserCountsToUpdate.GetType().Name)
						});
				}
			}
            if (skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData != null)
            {
                if (skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    skypeForBusinessParticipantActivityUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, skypeForBusinessParticipantActivityUserCountsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<SkypeForBusinessParticipantActivityUserCounts>(skypeForBusinessParticipantActivityUserCountsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeForBusinessParticipantActivityUserCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeForBusinessParticipantActivityUserCountsRequest Expand(Expression<Func<SkypeForBusinessParticipantActivityUserCounts, object>> expandExpression)
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
        public ISkypeForBusinessParticipantActivityUserCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeForBusinessParticipantActivityUserCountsRequest Select(Expression<Func<SkypeForBusinessParticipantActivityUserCounts, object>> selectExpression)
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
        /// <param name="skypeForBusinessParticipantActivityUserCountsToInitialize">The <see cref="SkypeForBusinessParticipantActivityUserCounts"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SkypeForBusinessParticipantActivityUserCounts skypeForBusinessParticipantActivityUserCountsToInitialize)
        {

        }
    }
}
