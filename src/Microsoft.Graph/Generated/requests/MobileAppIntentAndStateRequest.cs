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
    /// The type MobileAppIntentAndStateRequest.
    /// </summary>
    public partial class MobileAppIntentAndStateRequest : BaseRequest, IMobileAppIntentAndStateRequest
    {
        /// <summary>
        /// Constructs a new MobileAppIntentAndStateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MobileAppIntentAndStateRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MobileAppIntentAndState using POST.
        /// </summary>
        /// <param name="mobileAppIntentAndStateToCreate">The MobileAppIntentAndState to create.</param>
        /// <returns>The created MobileAppIntentAndState.</returns>
        public System.Threading.Tasks.Task<MobileAppIntentAndState> CreateAsync(MobileAppIntentAndState mobileAppIntentAndStateToCreate)
        {
            return this.CreateAsync(mobileAppIntentAndStateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MobileAppIntentAndState using POST.
        /// </summary>
        /// <param name="mobileAppIntentAndStateToCreate">The MobileAppIntentAndState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppIntentAndState.</returns>
        public async System.Threading.Tasks.Task<MobileAppIntentAndState> CreateAsync(MobileAppIntentAndState mobileAppIntentAndStateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MobileAppIntentAndState>(mobileAppIntentAndStateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MobileAppIntentAndState using POST and returns a <see cref="GraphResponse{MobileAppIntentAndState}"/> object.
        /// </summary>
        /// <param name="mobileAppIntentAndStateToCreate">The MobileAppIntentAndState to create.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppIntentAndState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppIntentAndState>> CreateResponseAsync(MobileAppIntentAndState mobileAppIntentAndStateToCreate)
        {
            return this.CreateResponseAsync(mobileAppIntentAndStateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MobileAppIntentAndState using POST and returns a <see cref="GraphResponse{MobileAppIntentAndState}"/> object.
        /// </summary>
        /// <param name="mobileAppIntentAndStateToCreate">The MobileAppIntentAndState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppIntentAndState}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MobileAppIntentAndState>> CreateResponseAsync(MobileAppIntentAndState mobileAppIntentAndStateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MobileAppIntentAndState>(mobileAppIntentAndStateToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MobileAppIntentAndState.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MobileAppIntentAndState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MobileAppIntentAndState>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MobileAppIntentAndState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MobileAppIntentAndState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MobileAppIntentAndState.
        /// </summary>
        /// <returns>The MobileAppIntentAndState.</returns>
        public System.Threading.Tasks.Task<MobileAppIntentAndState> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MobileAppIntentAndState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppIntentAndState.</returns>
        public async System.Threading.Tasks.Task<MobileAppIntentAndState> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MobileAppIntentAndState>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MobileAppIntentAndState and returns a <see cref="GraphResponse{MobileAppIntentAndState}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MobileAppIntentAndState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppIntentAndState>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MobileAppIntentAndState and returns a <see cref="GraphResponse{MobileAppIntentAndState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppIntentAndState}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MobileAppIntentAndState>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<MobileAppIntentAndState>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified MobileAppIntentAndState using PATCH.
        /// </summary>
        /// <param name="mobileAppIntentAndStateToUpdate">The MobileAppIntentAndState to update.</param>
        /// <returns>The updated MobileAppIntentAndState.</returns>
        public System.Threading.Tasks.Task<MobileAppIntentAndState> UpdateAsync(MobileAppIntentAndState mobileAppIntentAndStateToUpdate)
        {
            return this.UpdateAsync(mobileAppIntentAndStateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MobileAppIntentAndState using PATCH.
        /// </summary>
        /// <param name="mobileAppIntentAndStateToUpdate">The MobileAppIntentAndState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppIntentAndState.</returns>
        public async System.Threading.Tasks.Task<MobileAppIntentAndState> UpdateAsync(MobileAppIntentAndState mobileAppIntentAndStateToUpdate, CancellationToken cancellationToken)
        {
			if (mobileAppIntentAndStateToUpdate.AdditionalData != null)
			{
				if (mobileAppIntentAndStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					mobileAppIntentAndStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppIntentAndStateToUpdate.GetType().Name)
						});
				}
			}
            if (mobileAppIntentAndStateToUpdate.AdditionalData != null)
            {
                if (mobileAppIntentAndStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    mobileAppIntentAndStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppIntentAndStateToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MobileAppIntentAndState>(mobileAppIntentAndStateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MobileAppIntentAndState using PATCH and returns a <see cref="GraphResponse{MobileAppIntentAndState}"/> object.
        /// </summary>
        /// <param name="mobileAppIntentAndStateToUpdate">The MobileAppIntentAndState to update.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppIntentAndState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppIntentAndState>> UpdateResponseAsync(MobileAppIntentAndState mobileAppIntentAndStateToUpdate)
        {
            return this.UpdateResponseAsync(mobileAppIntentAndStateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MobileAppIntentAndState using PATCH and returns a <see cref="GraphResponse{MobileAppIntentAndState}"/> object.
        /// </summary>
        /// <param name="mobileAppIntentAndStateToUpdate">The MobileAppIntentAndState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MobileAppIntentAndState}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MobileAppIntentAndState>> UpdateResponseAsync(MobileAppIntentAndState mobileAppIntentAndStateToUpdate, CancellationToken cancellationToken)
        {
			if (mobileAppIntentAndStateToUpdate.AdditionalData != null)
			{
				if (mobileAppIntentAndStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					mobileAppIntentAndStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppIntentAndStateToUpdate.GetType().Name)
						});
				}
			}
            if (mobileAppIntentAndStateToUpdate.AdditionalData != null)
            {
                if (mobileAppIntentAndStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    mobileAppIntentAndStateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppIntentAndStateToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MobileAppIntentAndState>(mobileAppIntentAndStateToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppIntentAndStateRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppIntentAndStateRequest Expand(Expression<Func<MobileAppIntentAndState, object>> expandExpression)
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
        public IMobileAppIntentAndStateRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppIntentAndStateRequest Select(Expression<Func<MobileAppIntentAndState, object>> selectExpression)
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
        /// <param name="mobileAppIntentAndStateToInitialize">The <see cref="MobileAppIntentAndState"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MobileAppIntentAndState mobileAppIntentAndStateToInitialize)
        {

        }
    }
}
