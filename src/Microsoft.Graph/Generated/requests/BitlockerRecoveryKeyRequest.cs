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
    /// The type BitlockerRecoveryKeyRequest.
    /// </summary>
    public partial class BitlockerRecoveryKeyRequest : BaseRequest, IBitlockerRecoveryKeyRequest
    {
        /// <summary>
        /// Constructs a new BitlockerRecoveryKeyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public BitlockerRecoveryKeyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified BitlockerRecoveryKey using POST.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToCreate">The BitlockerRecoveryKey to create.</param>
        /// <returns>The created BitlockerRecoveryKey.</returns>
        public System.Threading.Tasks.Task<BitlockerRecoveryKey> CreateAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToCreate)
        {
            return this.CreateAsync(bitlockerRecoveryKeyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified BitlockerRecoveryKey using POST.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToCreate">The BitlockerRecoveryKey to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BitlockerRecoveryKey.</returns>
        public async System.Threading.Tasks.Task<BitlockerRecoveryKey> CreateAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<BitlockerRecoveryKey>(bitlockerRecoveryKeyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified BitlockerRecoveryKey using POST and returns a <see cref="GraphResponse{BitlockerRecoveryKey}"/> object.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToCreate">The BitlockerRecoveryKey to create.</param>
        /// <returns>The <see cref="GraphResponse{BitlockerRecoveryKey}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BitlockerRecoveryKey>> CreateResponseAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToCreate)
        {
            return this.CreateResponseAsync(bitlockerRecoveryKeyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified BitlockerRecoveryKey using POST and returns a <see cref="GraphResponse{BitlockerRecoveryKey}"/> object.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToCreate">The BitlockerRecoveryKey to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BitlockerRecoveryKey}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<BitlockerRecoveryKey>> CreateResponseAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<BitlockerRecoveryKey>(bitlockerRecoveryKeyToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified BitlockerRecoveryKey.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified BitlockerRecoveryKey.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<BitlockerRecoveryKey>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified BitlockerRecoveryKey and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified BitlockerRecoveryKey and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified BitlockerRecoveryKey.
        /// </summary>
        /// <returns>The BitlockerRecoveryKey.</returns>
        public System.Threading.Tasks.Task<BitlockerRecoveryKey> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified BitlockerRecoveryKey.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BitlockerRecoveryKey.</returns>
        public async System.Threading.Tasks.Task<BitlockerRecoveryKey> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<BitlockerRecoveryKey>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified BitlockerRecoveryKey and returns a <see cref="GraphResponse{BitlockerRecoveryKey}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{BitlockerRecoveryKey}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BitlockerRecoveryKey>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified BitlockerRecoveryKey and returns a <see cref="GraphResponse{BitlockerRecoveryKey}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BitlockerRecoveryKey}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<BitlockerRecoveryKey>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<BitlockerRecoveryKey>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified BitlockerRecoveryKey using PATCH.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToUpdate">The BitlockerRecoveryKey to update.</param>
        /// <returns>The updated BitlockerRecoveryKey.</returns>
        public System.Threading.Tasks.Task<BitlockerRecoveryKey> UpdateAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToUpdate)
        {
            return this.UpdateAsync(bitlockerRecoveryKeyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified BitlockerRecoveryKey using PATCH.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToUpdate">The BitlockerRecoveryKey to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BitlockerRecoveryKey.</returns>
        public async System.Threading.Tasks.Task<BitlockerRecoveryKey> UpdateAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToUpdate, CancellationToken cancellationToken)
        {
			if (bitlockerRecoveryKeyToUpdate.AdditionalData != null)
			{
				if (bitlockerRecoveryKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					bitlockerRecoveryKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, bitlockerRecoveryKeyToUpdate.GetType().Name)
						});
				}
			}
            if (bitlockerRecoveryKeyToUpdate.AdditionalData != null)
            {
                if (bitlockerRecoveryKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    bitlockerRecoveryKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, bitlockerRecoveryKeyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<BitlockerRecoveryKey>(bitlockerRecoveryKeyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified BitlockerRecoveryKey using PATCH and returns a <see cref="GraphResponse{BitlockerRecoveryKey}"/> object.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToUpdate">The BitlockerRecoveryKey to update.</param>
        /// <returns>The <see cref="GraphResponse{BitlockerRecoveryKey}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BitlockerRecoveryKey>> UpdateResponseAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToUpdate)
        {
            return this.UpdateResponseAsync(bitlockerRecoveryKeyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified BitlockerRecoveryKey using PATCH and returns a <see cref="GraphResponse{BitlockerRecoveryKey}"/> object.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToUpdate">The BitlockerRecoveryKey to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BitlockerRecoveryKey}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<BitlockerRecoveryKey>> UpdateResponseAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToUpdate, CancellationToken cancellationToken)
        {
			if (bitlockerRecoveryKeyToUpdate.AdditionalData != null)
			{
				if (bitlockerRecoveryKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					bitlockerRecoveryKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, bitlockerRecoveryKeyToUpdate.GetType().Name)
						});
				}
			}
            if (bitlockerRecoveryKeyToUpdate.AdditionalData != null)
            {
                if (bitlockerRecoveryKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    bitlockerRecoveryKeyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, bitlockerRecoveryKeyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<BitlockerRecoveryKey>(bitlockerRecoveryKeyToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBitlockerRecoveryKeyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBitlockerRecoveryKeyRequest Expand(Expression<Func<BitlockerRecoveryKey, object>> expandExpression)
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
        public IBitlockerRecoveryKeyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IBitlockerRecoveryKeyRequest Select(Expression<Func<BitlockerRecoveryKey, object>> selectExpression)
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
        /// <param name="bitlockerRecoveryKeyToInitialize">The <see cref="BitlockerRecoveryKey"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(BitlockerRecoveryKey bitlockerRecoveryKeyToInitialize)
        {

        }
    }
}
