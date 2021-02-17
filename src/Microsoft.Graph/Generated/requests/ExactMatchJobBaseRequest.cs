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
    /// The type ExactMatchJobBaseRequest.
    /// </summary>
    public partial class ExactMatchJobBaseRequest : BaseRequest, IExactMatchJobBaseRequest
    {
        /// <summary>
        /// Constructs a new ExactMatchJobBaseRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ExactMatchJobBaseRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ExactMatchJobBase using POST.
        /// </summary>
        /// <param name="exactMatchJobBaseToCreate">The ExactMatchJobBase to create.</param>
        /// <returns>The created ExactMatchJobBase.</returns>
        public System.Threading.Tasks.Task<ExactMatchJobBase> CreateAsync(ExactMatchJobBase exactMatchJobBaseToCreate)
        {
            return this.CreateAsync(exactMatchJobBaseToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ExactMatchJobBase using POST.
        /// </summary>
        /// <param name="exactMatchJobBaseToCreate">The ExactMatchJobBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExactMatchJobBase.</returns>
        public async System.Threading.Tasks.Task<ExactMatchJobBase> CreateAsync(ExactMatchJobBase exactMatchJobBaseToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ExactMatchJobBase>(exactMatchJobBaseToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ExactMatchJobBase using POST and returns a <see cref="GraphResponse{ExactMatchJobBase}"/> object.
        /// </summary>
        /// <param name="exactMatchJobBaseToCreate">The ExactMatchJobBase to create.</param>
        /// <returns>The <see cref="GraphResponse{ExactMatchJobBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ExactMatchJobBase>> CreateResponseAsync(ExactMatchJobBase exactMatchJobBaseToCreate)
        {
            return this.CreateResponseAsync(exactMatchJobBaseToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ExactMatchJobBase using POST and returns a <see cref="GraphResponse{ExactMatchJobBase}"/> object.
        /// </summary>
        /// <param name="exactMatchJobBaseToCreate">The ExactMatchJobBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExactMatchJobBase}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ExactMatchJobBase>> CreateResponseAsync(ExactMatchJobBase exactMatchJobBaseToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<ExactMatchJobBase>(exactMatchJobBaseToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ExactMatchJobBase.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ExactMatchJobBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ExactMatchJobBase>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ExactMatchJobBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ExactMatchJobBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ExactMatchJobBase.
        /// </summary>
        /// <returns>The ExactMatchJobBase.</returns>
        public System.Threading.Tasks.Task<ExactMatchJobBase> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ExactMatchJobBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExactMatchJobBase.</returns>
        public async System.Threading.Tasks.Task<ExactMatchJobBase> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ExactMatchJobBase>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ExactMatchJobBase and returns a <see cref="GraphResponse{ExactMatchJobBase}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ExactMatchJobBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ExactMatchJobBase>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ExactMatchJobBase and returns a <see cref="GraphResponse{ExactMatchJobBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExactMatchJobBase}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ExactMatchJobBase>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<ExactMatchJobBase>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified ExactMatchJobBase using PATCH.
        /// </summary>
        /// <param name="exactMatchJobBaseToUpdate">The ExactMatchJobBase to update.</param>
        /// <returns>The updated ExactMatchJobBase.</returns>
        public System.Threading.Tasks.Task<ExactMatchJobBase> UpdateAsync(ExactMatchJobBase exactMatchJobBaseToUpdate)
        {
            return this.UpdateAsync(exactMatchJobBaseToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ExactMatchJobBase using PATCH.
        /// </summary>
        /// <param name="exactMatchJobBaseToUpdate">The ExactMatchJobBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ExactMatchJobBase.</returns>
        public async System.Threading.Tasks.Task<ExactMatchJobBase> UpdateAsync(ExactMatchJobBase exactMatchJobBaseToUpdate, CancellationToken cancellationToken)
        {
			if (exactMatchJobBaseToUpdate.AdditionalData != null)
			{
				if (exactMatchJobBaseToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					exactMatchJobBaseToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, exactMatchJobBaseToUpdate.GetType().Name)
						});
				}
			}
            if (exactMatchJobBaseToUpdate.AdditionalData != null)
            {
                if (exactMatchJobBaseToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    exactMatchJobBaseToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, exactMatchJobBaseToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ExactMatchJobBase>(exactMatchJobBaseToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ExactMatchJobBase using PATCH and returns a <see cref="GraphResponse{ExactMatchJobBase}"/> object.
        /// </summary>
        /// <param name="exactMatchJobBaseToUpdate">The ExactMatchJobBase to update.</param>
        /// <returns>The <see cref="GraphResponse{ExactMatchJobBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ExactMatchJobBase>> UpdateResponseAsync(ExactMatchJobBase exactMatchJobBaseToUpdate)
        {
            return this.UpdateResponseAsync(exactMatchJobBaseToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ExactMatchJobBase using PATCH and returns a <see cref="GraphResponse{ExactMatchJobBase}"/> object.
        /// </summary>
        /// <param name="exactMatchJobBaseToUpdate">The ExactMatchJobBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ExactMatchJobBase}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ExactMatchJobBase>> UpdateResponseAsync(ExactMatchJobBase exactMatchJobBaseToUpdate, CancellationToken cancellationToken)
        {
			if (exactMatchJobBaseToUpdate.AdditionalData != null)
			{
				if (exactMatchJobBaseToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					exactMatchJobBaseToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, exactMatchJobBaseToUpdate.GetType().Name)
						});
				}
			}
            if (exactMatchJobBaseToUpdate.AdditionalData != null)
            {
                if (exactMatchJobBaseToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    exactMatchJobBaseToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, exactMatchJobBaseToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<ExactMatchJobBase>(exactMatchJobBaseToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IExactMatchJobBaseRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IExactMatchJobBaseRequest Expand(Expression<Func<ExactMatchJobBase, object>> expandExpression)
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
        public IExactMatchJobBaseRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IExactMatchJobBaseRequest Select(Expression<Func<ExactMatchJobBase, object>> selectExpression)
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
        /// <param name="exactMatchJobBaseToInitialize">The <see cref="ExactMatchJobBase"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ExactMatchJobBase exactMatchJobBaseToInitialize)
        {

        }
    }
}
