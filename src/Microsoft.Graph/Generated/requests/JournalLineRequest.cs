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
    /// The type JournalLineRequest.
    /// </summary>
    public partial class JournalLineRequest : BaseRequest, IJournalLineRequest
    {
        /// <summary>
        /// Constructs a new JournalLineRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public JournalLineRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified JournalLine using POST.
        /// </summary>
        /// <param name="journalLineToCreate">The JournalLine to create.</param>
        /// <returns>The created JournalLine.</returns>
        public System.Threading.Tasks.Task<JournalLine> CreateAsync(JournalLine journalLineToCreate)
        {
            return this.CreateAsync(journalLineToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified JournalLine using POST.
        /// </summary>
        /// <param name="journalLineToCreate">The JournalLine to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created JournalLine.</returns>
        public async System.Threading.Tasks.Task<JournalLine> CreateAsync(JournalLine journalLineToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<JournalLine>(journalLineToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified JournalLine using POST and returns a <see cref="GraphResponse{JournalLine}"/> object.
        /// </summary>
        /// <param name="journalLineToCreate">The JournalLine to create.</param>
        /// <returns>The <see cref="GraphResponse{JournalLine}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<JournalLine>> CreateResponseAsync(JournalLine journalLineToCreate)
        {
            return this.CreateResponseAsync(journalLineToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified JournalLine using POST and returns a <see cref="GraphResponse{JournalLine}"/> object.
        /// </summary>
        /// <param name="journalLineToCreate">The JournalLine to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{JournalLine}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<JournalLine>> CreateResponseAsync(JournalLine journalLineToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<JournalLine>(journalLineToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified JournalLine.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified JournalLine.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<JournalLine>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified JournalLine and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified JournalLine and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified JournalLine.
        /// </summary>
        /// <returns>The JournalLine.</returns>
        public System.Threading.Tasks.Task<JournalLine> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified JournalLine.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The JournalLine.</returns>
        public async System.Threading.Tasks.Task<JournalLine> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<JournalLine>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified JournalLine and returns a <see cref="GraphResponse{JournalLine}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{JournalLine}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<JournalLine>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified JournalLine and returns a <see cref="GraphResponse{JournalLine}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{JournalLine}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<JournalLine>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<JournalLine>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified JournalLine using PATCH.
        /// </summary>
        /// <param name="journalLineToUpdate">The JournalLine to update.</param>
        /// <returns>The updated JournalLine.</returns>
        public System.Threading.Tasks.Task<JournalLine> UpdateAsync(JournalLine journalLineToUpdate)
        {
            return this.UpdateAsync(journalLineToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified JournalLine using PATCH.
        /// </summary>
        /// <param name="journalLineToUpdate">The JournalLine to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated JournalLine.</returns>
        public async System.Threading.Tasks.Task<JournalLine> UpdateAsync(JournalLine journalLineToUpdate, CancellationToken cancellationToken)
        {
			if (journalLineToUpdate.AdditionalData != null)
			{
				if (journalLineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					journalLineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, journalLineToUpdate.GetType().Name)
						});
				}
			}
            if (journalLineToUpdate.AdditionalData != null)
            {
                if (journalLineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    journalLineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, journalLineToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<JournalLine>(journalLineToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified JournalLine using PATCH and returns a <see cref="GraphResponse{JournalLine}"/> object.
        /// </summary>
        /// <param name="journalLineToUpdate">The JournalLine to update.</param>
        /// <returns>The <see cref="GraphResponse{JournalLine}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<JournalLine>> UpdateResponseAsync(JournalLine journalLineToUpdate)
        {
            return this.UpdateResponseAsync(journalLineToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified JournalLine using PATCH and returns a <see cref="GraphResponse{JournalLine}"/> object.
        /// </summary>
        /// <param name="journalLineToUpdate">The JournalLine to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{JournalLine}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<JournalLine>> UpdateResponseAsync(JournalLine journalLineToUpdate, CancellationToken cancellationToken)
        {
			if (journalLineToUpdate.AdditionalData != null)
			{
				if (journalLineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					journalLineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, journalLineToUpdate.GetType().Name)
						});
				}
			}
            if (journalLineToUpdate.AdditionalData != null)
            {
                if (journalLineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    journalLineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, journalLineToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<JournalLine>(journalLineToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IJournalLineRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IJournalLineRequest Expand(Expression<Func<JournalLine, object>> expandExpression)
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
        public IJournalLineRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IJournalLineRequest Select(Expression<Func<JournalLine, object>> selectExpression)
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
        /// <param name="journalLineToInitialize">The <see cref="JournalLine"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(JournalLine journalLineToInitialize)
        {

        }
    }
}
