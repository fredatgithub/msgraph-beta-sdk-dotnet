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
    /// The type MailboxUsageQuotaStatusMailboxCountsRequest.
    /// </summary>
    public partial class MailboxUsageQuotaStatusMailboxCountsRequest : BaseRequest, IMailboxUsageQuotaStatusMailboxCountsRequest
    {
        /// <summary>
        /// Constructs a new MailboxUsageQuotaStatusMailboxCountsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MailboxUsageQuotaStatusMailboxCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MailboxUsageQuotaStatusMailboxCounts using POST.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToCreate">The MailboxUsageQuotaStatusMailboxCounts to create.</param>
        /// <returns>The created MailboxUsageQuotaStatusMailboxCounts.</returns>
        public System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> CreateAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToCreate)
        {
            return this.CreateAsync(mailboxUsageQuotaStatusMailboxCountsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MailboxUsageQuotaStatusMailboxCounts using POST.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToCreate">The MailboxUsageQuotaStatusMailboxCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MailboxUsageQuotaStatusMailboxCounts.</returns>
        public async System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> CreateAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MailboxUsageQuotaStatusMailboxCounts>(mailboxUsageQuotaStatusMailboxCountsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MailboxUsageQuotaStatusMailboxCounts using POST and returns a <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToCreate">The MailboxUsageQuotaStatusMailboxCounts to create.</param>
        /// <returns>The <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MailboxUsageQuotaStatusMailboxCounts>> CreateResponseAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToCreate)
        {
            return this.CreateResponseAsync(mailboxUsageQuotaStatusMailboxCountsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MailboxUsageQuotaStatusMailboxCounts using POST and returns a <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToCreate">The MailboxUsageQuotaStatusMailboxCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MailboxUsageQuotaStatusMailboxCounts>> CreateResponseAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MailboxUsageQuotaStatusMailboxCounts>(mailboxUsageQuotaStatusMailboxCountsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MailboxUsageQuotaStatusMailboxCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MailboxUsageQuotaStatusMailboxCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MailboxUsageQuotaStatusMailboxCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MailboxUsageQuotaStatusMailboxCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MailboxUsageQuotaStatusMailboxCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MailboxUsageQuotaStatusMailboxCounts.
        /// </summary>
        /// <returns>The MailboxUsageQuotaStatusMailboxCounts.</returns>
        public System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MailboxUsageQuotaStatusMailboxCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MailboxUsageQuotaStatusMailboxCounts.</returns>
        public async System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MailboxUsageQuotaStatusMailboxCounts>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MailboxUsageQuotaStatusMailboxCounts and returns a <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MailboxUsageQuotaStatusMailboxCounts>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MailboxUsageQuotaStatusMailboxCounts and returns a <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MailboxUsageQuotaStatusMailboxCounts>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<MailboxUsageQuotaStatusMailboxCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified MailboxUsageQuotaStatusMailboxCounts using PATCH.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToUpdate">The MailboxUsageQuotaStatusMailboxCounts to update.</param>
        /// <returns>The updated MailboxUsageQuotaStatusMailboxCounts.</returns>
        public System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> UpdateAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToUpdate)
        {
            return this.UpdateAsync(mailboxUsageQuotaStatusMailboxCountsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MailboxUsageQuotaStatusMailboxCounts using PATCH.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToUpdate">The MailboxUsageQuotaStatusMailboxCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MailboxUsageQuotaStatusMailboxCounts.</returns>
        public async System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> UpdateAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToUpdate, CancellationToken cancellationToken)
        {
			if (mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData != null)
			{
				if (mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mailboxUsageQuotaStatusMailboxCountsToUpdate.GetType().Name)
						});
				}
			}
            if (mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData != null)
            {
                if (mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mailboxUsageQuotaStatusMailboxCountsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MailboxUsageQuotaStatusMailboxCounts>(mailboxUsageQuotaStatusMailboxCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MailboxUsageQuotaStatusMailboxCounts using PATCH and returns a <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToUpdate">The MailboxUsageQuotaStatusMailboxCounts to update.</param>
        /// <returns>The <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MailboxUsageQuotaStatusMailboxCounts>> UpdateResponseAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToUpdate)
        {
            return this.UpdateResponseAsync(mailboxUsageQuotaStatusMailboxCountsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MailboxUsageQuotaStatusMailboxCounts using PATCH and returns a <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToUpdate">The MailboxUsageQuotaStatusMailboxCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MailboxUsageQuotaStatusMailboxCounts}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MailboxUsageQuotaStatusMailboxCounts>> UpdateResponseAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToUpdate, CancellationToken cancellationToken)
        {
			if (mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData != null)
			{
				if (mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mailboxUsageQuotaStatusMailboxCountsToUpdate.GetType().Name)
						});
				}
			}
            if (mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData != null)
            {
                if (mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    mailboxUsageQuotaStatusMailboxCountsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mailboxUsageQuotaStatusMailboxCountsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MailboxUsageQuotaStatusMailboxCounts>(mailboxUsageQuotaStatusMailboxCountsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMailboxUsageQuotaStatusMailboxCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMailboxUsageQuotaStatusMailboxCountsRequest Expand(Expression<Func<MailboxUsageQuotaStatusMailboxCounts, object>> expandExpression)
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
        public IMailboxUsageQuotaStatusMailboxCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMailboxUsageQuotaStatusMailboxCountsRequest Select(Expression<Func<MailboxUsageQuotaStatusMailboxCounts, object>> selectExpression)
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
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToInitialize">The <see cref="MailboxUsageQuotaStatusMailboxCounts"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToInitialize)
        {

        }
    }
}
