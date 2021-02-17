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
    /// The type Office365ActivationsUserCountsRequest.
    /// </summary>
    public partial class Office365ActivationsUserCountsRequest : BaseRequest, IOffice365ActivationsUserCountsRequest
    {
        /// <summary>
        /// Constructs a new Office365ActivationsUserCountsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Office365ActivationsUserCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Office365ActivationsUserCounts using POST.
        /// </summary>
        /// <param name="office365ActivationsUserCountsToCreate">The Office365ActivationsUserCounts to create.</param>
        /// <returns>The created Office365ActivationsUserCounts.</returns>
        public System.Threading.Tasks.Task<Office365ActivationsUserCounts> CreateAsync(Office365ActivationsUserCounts office365ActivationsUserCountsToCreate)
        {
            return this.CreateAsync(office365ActivationsUserCountsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Office365ActivationsUserCounts using POST.
        /// </summary>
        /// <param name="office365ActivationsUserCountsToCreate">The Office365ActivationsUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Office365ActivationsUserCounts.</returns>
        public async System.Threading.Tasks.Task<Office365ActivationsUserCounts> CreateAsync(Office365ActivationsUserCounts office365ActivationsUserCountsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Office365ActivationsUserCounts>(office365ActivationsUserCountsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Office365ActivationsUserCounts using POST and returns a <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object.
        /// </summary>
        /// <param name="office365ActivationsUserCountsToCreate">The Office365ActivationsUserCounts to create.</param>
        /// <returns>The <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365ActivationsUserCounts>> CreateResponseAsync(Office365ActivationsUserCounts office365ActivationsUserCountsToCreate)
        {
            return this.CreateResponseAsync(office365ActivationsUserCountsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Office365ActivationsUserCounts using POST and returns a <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object.
        /// </summary>
        /// <param name="office365ActivationsUserCountsToCreate">The Office365ActivationsUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Office365ActivationsUserCounts>> CreateResponseAsync(Office365ActivationsUserCounts office365ActivationsUserCountsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Office365ActivationsUserCounts>(office365ActivationsUserCountsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Office365ActivationsUserCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Office365ActivationsUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Office365ActivationsUserCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Office365ActivationsUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Office365ActivationsUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Office365ActivationsUserCounts.
        /// </summary>
        /// <returns>The Office365ActivationsUserCounts.</returns>
        public System.Threading.Tasks.Task<Office365ActivationsUserCounts> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Office365ActivationsUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Office365ActivationsUserCounts.</returns>
        public async System.Threading.Tasks.Task<Office365ActivationsUserCounts> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Office365ActivationsUserCounts>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Office365ActivationsUserCounts and returns a <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365ActivationsUserCounts>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Office365ActivationsUserCounts and returns a <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Office365ActivationsUserCounts>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<Office365ActivationsUserCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified Office365ActivationsUserCounts using PATCH.
        /// </summary>
        /// <param name="office365ActivationsUserCountsToUpdate">The Office365ActivationsUserCounts to update.</param>
        /// <returns>The updated Office365ActivationsUserCounts.</returns>
        public System.Threading.Tasks.Task<Office365ActivationsUserCounts> UpdateAsync(Office365ActivationsUserCounts office365ActivationsUserCountsToUpdate)
        {
            return this.UpdateAsync(office365ActivationsUserCountsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Office365ActivationsUserCounts using PATCH.
        /// </summary>
        /// <param name="office365ActivationsUserCountsToUpdate">The Office365ActivationsUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Office365ActivationsUserCounts.</returns>
        public async System.Threading.Tasks.Task<Office365ActivationsUserCounts> UpdateAsync(Office365ActivationsUserCounts office365ActivationsUserCountsToUpdate, CancellationToken cancellationToken)
        {
			if (office365ActivationsUserCountsToUpdate.AdditionalData != null)
			{
				if (office365ActivationsUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					office365ActivationsUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, office365ActivationsUserCountsToUpdate.GetType().Name)
						});
				}
			}
            if (office365ActivationsUserCountsToUpdate.AdditionalData != null)
            {
                if (office365ActivationsUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    office365ActivationsUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, office365ActivationsUserCountsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Office365ActivationsUserCounts>(office365ActivationsUserCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Office365ActivationsUserCounts using PATCH and returns a <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object.
        /// </summary>
        /// <param name="office365ActivationsUserCountsToUpdate">The Office365ActivationsUserCounts to update.</param>
        /// <returns>The <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365ActivationsUserCounts>> UpdateResponseAsync(Office365ActivationsUserCounts office365ActivationsUserCountsToUpdate)
        {
            return this.UpdateResponseAsync(office365ActivationsUserCountsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Office365ActivationsUserCounts using PATCH and returns a <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object.
        /// </summary>
        /// <param name="office365ActivationsUserCountsToUpdate">The Office365ActivationsUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Office365ActivationsUserCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Office365ActivationsUserCounts>> UpdateResponseAsync(Office365ActivationsUserCounts office365ActivationsUserCountsToUpdate, CancellationToken cancellationToken)
        {
			if (office365ActivationsUserCountsToUpdate.AdditionalData != null)
			{
				if (office365ActivationsUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					office365ActivationsUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, office365ActivationsUserCountsToUpdate.GetType().Name)
						});
				}
			}
            if (office365ActivationsUserCountsToUpdate.AdditionalData != null)
            {
                if (office365ActivationsUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    office365ActivationsUserCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, office365ActivationsUserCountsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<Office365ActivationsUserCounts>(office365ActivationsUserCountsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365ActivationsUserCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365ActivationsUserCountsRequest Expand(Expression<Func<Office365ActivationsUserCounts, object>> expandExpression)
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
        public IOffice365ActivationsUserCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365ActivationsUserCountsRequest Select(Expression<Func<Office365ActivationsUserCounts, object>> selectExpression)
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
        /// <param name="office365ActivationsUserCountsToInitialize">The <see cref="Office365ActivationsUserCounts"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Office365ActivationsUserCounts office365ActivationsUserCountsToInitialize)
        {

        }
    }
}
