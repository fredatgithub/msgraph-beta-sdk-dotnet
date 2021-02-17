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
    /// The type DomainDnsRecordRequest.
    /// </summary>
    public partial class DomainDnsRecordRequest : BaseRequest, IDomainDnsRecordRequest
    {
        /// <summary>
        /// Constructs a new DomainDnsRecordRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DomainDnsRecordRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DomainDnsRecord using POST.
        /// </summary>
        /// <param name="domainDnsRecordToCreate">The DomainDnsRecord to create.</param>
        /// <returns>The created DomainDnsRecord.</returns>
        public System.Threading.Tasks.Task<DomainDnsRecord> CreateAsync(DomainDnsRecord domainDnsRecordToCreate)
        {
            return this.CreateAsync(domainDnsRecordToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DomainDnsRecord using POST.
        /// </summary>
        /// <param name="domainDnsRecordToCreate">The DomainDnsRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DomainDnsRecord.</returns>
        public async System.Threading.Tasks.Task<DomainDnsRecord> CreateAsync(DomainDnsRecord domainDnsRecordToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DomainDnsRecord>(domainDnsRecordToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DomainDnsRecord using POST and returns a <see cref="GraphResponse{DomainDnsRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsRecordToCreate">The DomainDnsRecord to create.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DomainDnsRecord>> CreateResponseAsync(DomainDnsRecord domainDnsRecordToCreate)
        {
            return this.CreateResponseAsync(domainDnsRecordToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DomainDnsRecord using POST and returns a <see cref="GraphResponse{DomainDnsRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsRecordToCreate">The DomainDnsRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsRecord}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DomainDnsRecord>> CreateResponseAsync(DomainDnsRecord domainDnsRecordToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DomainDnsRecord>(domainDnsRecordToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DomainDnsRecord.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DomainDnsRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DomainDnsRecord>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DomainDnsRecord and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DomainDnsRecord and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DomainDnsRecord.
        /// </summary>
        /// <returns>The DomainDnsRecord.</returns>
        public System.Threading.Tasks.Task<DomainDnsRecord> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DomainDnsRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DomainDnsRecord.</returns>
        public async System.Threading.Tasks.Task<DomainDnsRecord> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DomainDnsRecord>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DomainDnsRecord and returns a <see cref="GraphResponse{DomainDnsRecord}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DomainDnsRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DomainDnsRecord>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DomainDnsRecord and returns a <see cref="GraphResponse{DomainDnsRecord}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsRecord}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DomainDnsRecord>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DomainDnsRecord>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DomainDnsRecord using PATCH.
        /// </summary>
        /// <param name="domainDnsRecordToUpdate">The DomainDnsRecord to update.</param>
        /// <returns>The updated DomainDnsRecord.</returns>
        public System.Threading.Tasks.Task<DomainDnsRecord> UpdateAsync(DomainDnsRecord domainDnsRecordToUpdate)
        {
            return this.UpdateAsync(domainDnsRecordToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DomainDnsRecord using PATCH.
        /// </summary>
        /// <param name="domainDnsRecordToUpdate">The DomainDnsRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DomainDnsRecord.</returns>
        public async System.Threading.Tasks.Task<DomainDnsRecord> UpdateAsync(DomainDnsRecord domainDnsRecordToUpdate, CancellationToken cancellationToken)
        {
			if (domainDnsRecordToUpdate.AdditionalData != null)
			{
				if (domainDnsRecordToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					domainDnsRecordToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, domainDnsRecordToUpdate.GetType().Name)
						});
				}
			}
            if (domainDnsRecordToUpdate.AdditionalData != null)
            {
                if (domainDnsRecordToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    domainDnsRecordToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, domainDnsRecordToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DomainDnsRecord>(domainDnsRecordToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DomainDnsRecord using PATCH and returns a <see cref="GraphResponse{DomainDnsRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsRecordToUpdate">The DomainDnsRecord to update.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DomainDnsRecord>> UpdateResponseAsync(DomainDnsRecord domainDnsRecordToUpdate)
        {
            return this.UpdateResponseAsync(domainDnsRecordToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DomainDnsRecord using PATCH and returns a <see cref="GraphResponse{DomainDnsRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsRecordToUpdate">The DomainDnsRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DomainDnsRecord}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DomainDnsRecord>> UpdateResponseAsync(DomainDnsRecord domainDnsRecordToUpdate, CancellationToken cancellationToken)
        {
			if (domainDnsRecordToUpdate.AdditionalData != null)
			{
				if (domainDnsRecordToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					domainDnsRecordToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, domainDnsRecordToUpdate.GetType().Name)
						});
				}
			}
            if (domainDnsRecordToUpdate.AdditionalData != null)
            {
                if (domainDnsRecordToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    domainDnsRecordToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, domainDnsRecordToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DomainDnsRecord>(domainDnsRecordToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDomainDnsRecordRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDomainDnsRecordRequest Expand(Expression<Func<DomainDnsRecord, object>> expandExpression)
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
        public IDomainDnsRecordRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDomainDnsRecordRequest Select(Expression<Func<DomainDnsRecord, object>> selectExpression)
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
        /// <param name="domainDnsRecordToInitialize">The <see cref="DomainDnsRecord"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DomainDnsRecord domainDnsRecordToInitialize)
        {

        }
    }
}
