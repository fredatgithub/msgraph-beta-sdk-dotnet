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
    /// The type UnifiedRoleEligibilityScheduleWithReferenceRequest.
    /// </summary>
    public partial class UnifiedRoleEligibilityScheduleWithReferenceRequest : BaseRequest, IUnifiedRoleEligibilityScheduleWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new UnifiedRoleEligibilityScheduleWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnifiedRoleEligibilityScheduleWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilitySchedule.
        /// </summary>
        /// <returns>The UnifiedRoleEligibilitySchedule.</returns>
        public System.Threading.Tasks.Task<UnifiedRoleEligibilitySchedule> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilitySchedule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleEligibilitySchedule.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleEligibilitySchedule> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<UnifiedRoleEligibilitySchedule>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilitySchedule and returns a <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilitySchedule>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilitySchedule and returns a <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilitySchedule>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<UnifiedRoleEligibilitySchedule>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Creates the specified UnifiedRoleEligibilitySchedule using POST.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToCreate">The UnifiedRoleEligibilitySchedule to create.</param>
        /// <returns>The created UnifiedRoleEligibilitySchedule.</returns>
        public System.Threading.Tasks.Task<UnifiedRoleEligibilitySchedule> CreateAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToCreate)
        {
            return this.CreateAsync(unifiedRoleEligibilityScheduleToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UnifiedRoleEligibilitySchedule using POST.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToCreate">The UnifiedRoleEligibilitySchedule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleEligibilitySchedule.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleEligibilitySchedule> CreateAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<UnifiedRoleEligibilitySchedule>(unifiedRoleEligibilityScheduleToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified UnifiedRoleEligibilitySchedule using POST and returns a <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToCreate">The UnifiedRoleEligibilitySchedule to create.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilitySchedule>> CreateResponseAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToCreate)
        {
            return this.CreateResponseAsync(unifiedRoleEligibilityScheduleToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UnifiedRoleEligibilitySchedule using POST and returns a <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToCreate">The UnifiedRoleEligibilitySchedule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilitySchedule>> CreateResponseAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<UnifiedRoleEligibilitySchedule>(unifiedRoleEligibilityScheduleToCreate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Updates the specified UnifiedRoleEligibilitySchedule using PATCH.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToUpdate">The UnifiedRoleEligibilitySchedule to update.</param>
        /// <returns>The updated UnifiedRoleEligibilitySchedule.</returns>
        public System.Threading.Tasks.Task<UnifiedRoleEligibilitySchedule> UpdateAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToUpdate)
        {
            return this.UpdateAsync(unifiedRoleEligibilityScheduleToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilitySchedule using PATCH.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToUpdate">The UnifiedRoleEligibilitySchedule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleEligibilitySchedule.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleEligibilitySchedule> UpdateAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToUpdate, CancellationToken cancellationToken)
        {
			if (unifiedRoleEligibilityScheduleToUpdate.AdditionalData != null)
			{
				if (unifiedRoleEligibilityScheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					unifiedRoleEligibilityScheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unifiedRoleEligibilityScheduleToUpdate.GetType().Name)
						});
				}
			}
            if (unifiedRoleEligibilityScheduleToUpdate.AdditionalData != null)
            {
                if (unifiedRoleEligibilityScheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    unifiedRoleEligibilityScheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unifiedRoleEligibilityScheduleToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<UnifiedRoleEligibilitySchedule>(unifiedRoleEligibilityScheduleToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified UnifiedRoleEligibilitySchedule using PATCH and returns a <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToUpdate">The UnifiedRoleEligibilitySchedule to update.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilitySchedule>> UpdateResponseAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToUpdate)
        {
            return this.UpdateResponseAsync(unifiedRoleEligibilityScheduleToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilitySchedule using PATCH and returns a <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToUpdate">The UnifiedRoleEligibilitySchedule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilitySchedule>> UpdateResponseAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToUpdate, CancellationToken cancellationToken)
        {
			if (unifiedRoleEligibilityScheduleToUpdate.AdditionalData != null)
			{
				if (unifiedRoleEligibilityScheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					unifiedRoleEligibilityScheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unifiedRoleEligibilityScheduleToUpdate.GetType().Name)
						});
				}
			}
            if (unifiedRoleEligibilityScheduleToUpdate.AdditionalData != null)
            {
                if (unifiedRoleEligibilityScheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    unifiedRoleEligibilityScheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unifiedRoleEligibilityScheduleToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<UnifiedRoleEligibilitySchedule>(unifiedRoleEligibilityScheduleToUpdate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified UnifiedRoleEligibilitySchedule.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UnifiedRoleEligibilitySchedule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<UnifiedRoleEligibilitySchedule>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified UnifiedRoleEligibilitySchedule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UnifiedRoleEligibilitySchedule and returns a <see cref="GraphResponse"/> object.
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
        public IUnifiedRoleEligibilityScheduleWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleEligibilityScheduleWithReferenceRequest Expand(Expression<Func<UnifiedRoleEligibilitySchedule, object>> expandExpression)
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
        public IUnifiedRoleEligibilityScheduleWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleEligibilityScheduleWithReferenceRequest Select(Expression<Func<UnifiedRoleEligibilitySchedule, object>> selectExpression)
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
