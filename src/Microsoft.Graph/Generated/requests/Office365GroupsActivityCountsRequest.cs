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
    /// The type Office365GroupsActivityCountsRequest.
    /// </summary>
    public partial class Office365GroupsActivityCountsRequest : BaseRequest, IOffice365GroupsActivityCountsRequest
    {
        /// <summary>
        /// Constructs a new Office365GroupsActivityCountsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Office365GroupsActivityCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Office365GroupsActivityCounts using POST.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToCreate">The Office365GroupsActivityCounts to create.</param>
        /// <returns>The created Office365GroupsActivityCounts.</returns>
        public System.Threading.Tasks.Task<Office365GroupsActivityCounts> CreateAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToCreate)
        {
            return this.CreateAsync(office365GroupsActivityCountsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Office365GroupsActivityCounts using POST.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToCreate">The Office365GroupsActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Office365GroupsActivityCounts.</returns>
        public async System.Threading.Tasks.Task<Office365GroupsActivityCounts> CreateAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Office365GroupsActivityCounts>(office365GroupsActivityCountsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Office365GroupsActivityCounts using POST and returns a <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToCreate">The Office365GroupsActivityCounts to create.</param>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityCounts>> CreateResponseAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToCreate)
        {
            return this.CreateResponseAsync(office365GroupsActivityCountsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Office365GroupsActivityCounts using POST and returns a <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToCreate">The Office365GroupsActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityCounts>> CreateResponseAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Office365GroupsActivityCounts>(office365GroupsActivityCountsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Office365GroupsActivityCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Office365GroupsActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Office365GroupsActivityCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Office365GroupsActivityCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Office365GroupsActivityCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Office365GroupsActivityCounts.
        /// </summary>
        /// <returns>The Office365GroupsActivityCounts.</returns>
        public System.Threading.Tasks.Task<Office365GroupsActivityCounts> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Office365GroupsActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Office365GroupsActivityCounts.</returns>
        public async System.Threading.Tasks.Task<Office365GroupsActivityCounts> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Office365GroupsActivityCounts>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Office365GroupsActivityCounts and returns a <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityCounts>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Office365GroupsActivityCounts and returns a <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityCounts>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<Office365GroupsActivityCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified Office365GroupsActivityCounts using PATCH.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToUpdate">The Office365GroupsActivityCounts to update.</param>
        /// <returns>The updated Office365GroupsActivityCounts.</returns>
        public System.Threading.Tasks.Task<Office365GroupsActivityCounts> UpdateAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToUpdate)
        {
            return this.UpdateAsync(office365GroupsActivityCountsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Office365GroupsActivityCounts using PATCH.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToUpdate">The Office365GroupsActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Office365GroupsActivityCounts.</returns>
        public async System.Threading.Tasks.Task<Office365GroupsActivityCounts> UpdateAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToUpdate, CancellationToken cancellationToken)
        {
			if (office365GroupsActivityCountsToUpdate.AdditionalData != null)
			{
				if (office365GroupsActivityCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					office365GroupsActivityCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, office365GroupsActivityCountsToUpdate.GetType().Name)
						});
				}
			}
            if (office365GroupsActivityCountsToUpdate.AdditionalData != null)
            {
                if (office365GroupsActivityCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    office365GroupsActivityCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, office365GroupsActivityCountsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Office365GroupsActivityCounts>(office365GroupsActivityCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Office365GroupsActivityCounts using PATCH and returns a <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToUpdate">The Office365GroupsActivityCounts to update.</param>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityCounts>> UpdateResponseAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToUpdate)
        {
            return this.UpdateResponseAsync(office365GroupsActivityCountsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Office365GroupsActivityCounts using PATCH and returns a <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToUpdate">The Office365GroupsActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityCounts>> UpdateResponseAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToUpdate, CancellationToken cancellationToken)
        {
			if (office365GroupsActivityCountsToUpdate.AdditionalData != null)
			{
				if (office365GroupsActivityCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					office365GroupsActivityCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, office365GroupsActivityCountsToUpdate.GetType().Name)
						});
				}
			}
            if (office365GroupsActivityCountsToUpdate.AdditionalData != null)
            {
                if (office365GroupsActivityCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    office365GroupsActivityCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, office365GroupsActivityCountsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<Office365GroupsActivityCounts>(office365GroupsActivityCountsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365GroupsActivityCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365GroupsActivityCountsRequest Expand(Expression<Func<Office365GroupsActivityCounts, object>> expandExpression)
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
        public IOffice365GroupsActivityCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365GroupsActivityCountsRequest Select(Expression<Func<Office365GroupsActivityCounts, object>> selectExpression)
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
        /// <param name="office365GroupsActivityCountsToInitialize">The <see cref="Office365GroupsActivityCounts"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Office365GroupsActivityCounts office365GroupsActivityCountsToInitialize)
        {

        }
    }
}
