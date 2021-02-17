// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type MobileAppCategoryWithReferenceRequest.
    /// </summary>
    public partial class MobileAppCategoryWithReferenceRequest : BaseRequest, IMobileAppCategoryWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new MobileAppCategoryWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MobileAppCategoryWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified MobileAppCategory.
        /// </summary>
        /// <returns>The MobileAppCategory.</returns>
        public System.Threading.Tasks.Task<MobileAppCategory> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MobileAppCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppCategory.</returns>
        public async System.Threading.Tasks.Task<MobileAppCategory> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MobileAppCategory>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MobileAppCategory and returns a <see cref="GraphResponse{MobileAppCategory}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MobileAppCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppCategory>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MobileAppCategory and returns a <see cref="GraphResponse{MobileAppCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppCategory}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MobileAppCategory>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<MobileAppCategory>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Creates the specified MobileAppCategory using POST.
        /// </summary>
        /// <param name="mobileAppCategoryToCreate">The MobileAppCategory to create.</param>
        /// <returns>The created MobileAppCategory.</returns>
        public System.Threading.Tasks.Task<MobileAppCategory> CreateAsync(MobileAppCategory mobileAppCategoryToCreate)
        {
            return this.CreateAsync(mobileAppCategoryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MobileAppCategory using POST.
        /// </summary>
        /// <param name="mobileAppCategoryToCreate">The MobileAppCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppCategory.</returns>
        public async System.Threading.Tasks.Task<MobileAppCategory> CreateAsync(MobileAppCategory mobileAppCategoryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MobileAppCategory>(mobileAppCategoryToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified MobileAppCategory using POST and returns a <see cref="GraphResponse{MobileAppCategory}"/> object.
        /// </summary>
        /// <param name="mobileAppCategoryToCreate">The MobileAppCategory to create.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppCategory>> CreateResponseAsync(MobileAppCategory mobileAppCategoryToCreate)
        {
            return this.CreateResponseAsync(mobileAppCategoryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MobileAppCategory using POST and returns a <see cref="GraphResponse{MobileAppCategory}"/> object.
        /// </summary>
        /// <param name="mobileAppCategoryToCreate">The MobileAppCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppCategory}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MobileAppCategory>> CreateResponseAsync(MobileAppCategory mobileAppCategoryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MobileAppCategory>(mobileAppCategoryToCreate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Updates the specified MobileAppCategory using PATCH.
        /// </summary>
        /// <param name="mobileAppCategoryToUpdate">The MobileAppCategory to update.</param>
        /// <returns>The updated MobileAppCategory.</returns>
        public System.Threading.Tasks.Task<MobileAppCategory> UpdateAsync(MobileAppCategory mobileAppCategoryToUpdate)
        {
            return this.UpdateAsync(mobileAppCategoryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MobileAppCategory using PATCH.
        /// </summary>
        /// <param name="mobileAppCategoryToUpdate">The MobileAppCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppCategory.</returns>
        public async System.Threading.Tasks.Task<MobileAppCategory> UpdateAsync(MobileAppCategory mobileAppCategoryToUpdate, CancellationToken cancellationToken)
        {
			if (mobileAppCategoryToUpdate.AdditionalData != null)
			{
				if (mobileAppCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					mobileAppCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppCategoryToUpdate.GetType().Name)
						});
				}
			}
            if (mobileAppCategoryToUpdate.AdditionalData != null)
            {
                if (mobileAppCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    mobileAppCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppCategoryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MobileAppCategory>(mobileAppCategoryToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified MobileAppCategory using PATCH and returns a <see cref="GraphResponse{MobileAppCategory}"/> object.
        /// </summary>
        /// <param name="mobileAppCategoryToUpdate">The MobileAppCategory to update.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppCategory>> UpdateResponseAsync(MobileAppCategory mobileAppCategoryToUpdate)
        {
            return this.UpdateResponseAsync(mobileAppCategoryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MobileAppCategory using PATCH and returns a <see cref="GraphResponse{MobileAppCategory}"/> object.
        /// </summary>
        /// <param name="mobileAppCategoryToUpdate">The MobileAppCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MobileAppCategory}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MobileAppCategory>> UpdateResponseAsync(MobileAppCategory mobileAppCategoryToUpdate, CancellationToken cancellationToken)
        {
			if (mobileAppCategoryToUpdate.AdditionalData != null)
			{
				if (mobileAppCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					mobileAppCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppCategoryToUpdate.GetType().Name)
						});
				}
			}
            if (mobileAppCategoryToUpdate.AdditionalData != null)
            {
                if (mobileAppCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    mobileAppCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppCategoryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MobileAppCategory>(mobileAppCategoryToUpdate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified MobileAppCategory.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MobileAppCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MobileAppCategory>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified MobileAppCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MobileAppCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppCategoryWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppCategoryWithReferenceRequest Expand(Expression<Func<MobileAppCategory, object>> expandExpression)
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
        public IMobileAppCategoryWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppCategoryWithReferenceRequest Select(Expression<Func<MobileAppCategory, object>> selectExpression)
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

    }
}
