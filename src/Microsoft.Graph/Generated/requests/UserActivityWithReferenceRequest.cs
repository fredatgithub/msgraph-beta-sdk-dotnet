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
    /// The type UserActivityWithReferenceRequest.
    /// </summary>
    public partial class UserActivityWithReferenceRequest : BaseRequest, IUserActivityWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new UserActivityWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserActivityWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified UserActivity.
        /// </summary>
        /// <returns>The UserActivity.</returns>
        public System.Threading.Tasks.Task<UserActivity> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UserActivity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserActivity.</returns>
        public async System.Threading.Tasks.Task<UserActivity> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<UserActivity>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UserActivity and returns a <see cref="GraphResponse{UserActivity}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UserActivity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserActivity>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UserActivity and returns a <see cref="GraphResponse{UserActivity}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserActivity}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UserActivity>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<UserActivity>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Creates the specified UserActivity using POST.
        /// </summary>
        /// <param name="userActivityToCreate">The UserActivity to create.</param>
        /// <returns>The created UserActivity.</returns>
        public System.Threading.Tasks.Task<UserActivity> CreateAsync(UserActivity userActivityToCreate)
        {
            return this.CreateAsync(userActivityToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UserActivity using POST.
        /// </summary>
        /// <param name="userActivityToCreate">The UserActivity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserActivity.</returns>
        public async System.Threading.Tasks.Task<UserActivity> CreateAsync(UserActivity userActivityToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<UserActivity>(userActivityToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified UserActivity using POST and returns a <see cref="GraphResponse{UserActivity}"/> object.
        /// </summary>
        /// <param name="userActivityToCreate">The UserActivity to create.</param>
        /// <returns>The <see cref="GraphResponse{UserActivity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserActivity>> CreateResponseAsync(UserActivity userActivityToCreate)
        {
            return this.CreateResponseAsync(userActivityToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UserActivity using POST and returns a <see cref="GraphResponse{UserActivity}"/> object.
        /// </summary>
        /// <param name="userActivityToCreate">The UserActivity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserActivity}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UserActivity>> CreateResponseAsync(UserActivity userActivityToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<UserActivity>(userActivityToCreate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Updates the specified UserActivity using PATCH.
        /// </summary>
        /// <param name="userActivityToUpdate">The UserActivity to update.</param>
        /// <returns>The updated UserActivity.</returns>
        public System.Threading.Tasks.Task<UserActivity> UpdateAsync(UserActivity userActivityToUpdate)
        {
            return this.UpdateAsync(userActivityToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UserActivity using PATCH.
        /// </summary>
        /// <param name="userActivityToUpdate">The UserActivity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserActivity.</returns>
        public async System.Threading.Tasks.Task<UserActivity> UpdateAsync(UserActivity userActivityToUpdate, CancellationToken cancellationToken)
        {
			if (userActivityToUpdate.AdditionalData != null)
			{
				if (userActivityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					userActivityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userActivityToUpdate.GetType().Name)
						});
				}
			}
            if (userActivityToUpdate.AdditionalData != null)
            {
                if (userActivityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    userActivityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userActivityToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<UserActivity>(userActivityToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified UserActivity using PATCH and returns a <see cref="GraphResponse{UserActivity}"/> object.
        /// </summary>
        /// <param name="userActivityToUpdate">The UserActivity to update.</param>
        /// <returns>The <see cref="GraphResponse{UserActivity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserActivity>> UpdateResponseAsync(UserActivity userActivityToUpdate)
        {
            return this.UpdateResponseAsync(userActivityToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UserActivity using PATCH and returns a <see cref="GraphResponse{UserActivity}"/> object.
        /// </summary>
        /// <param name="userActivityToUpdate">The UserActivity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserActivity}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UserActivity>> UpdateResponseAsync(UserActivity userActivityToUpdate, CancellationToken cancellationToken)
        {
			if (userActivityToUpdate.AdditionalData != null)
			{
				if (userActivityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					userActivityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userActivityToUpdate.GetType().Name)
						});
				}
			}
            if (userActivityToUpdate.AdditionalData != null)
            {
                if (userActivityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    userActivityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userActivityToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<UserActivity>(userActivityToUpdate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified UserActivity.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UserActivity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<UserActivity>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified UserActivity and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UserActivity and returns a <see cref="GraphResponse"/> object.
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
        public IUserActivityWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserActivityWithReferenceRequest Expand(Expression<Func<UserActivity, object>> expandExpression)
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
        public IUserActivityWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserActivityWithReferenceRequest Select(Expression<Func<UserActivity, object>> selectExpression)
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
