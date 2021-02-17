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
    /// The type GroupLifecyclePolicyRequest.
    /// </summary>
    public partial class GroupLifecyclePolicyRequest : BaseRequest, IGroupLifecyclePolicyRequest
    {
        /// <summary>
        /// Constructs a new GroupLifecyclePolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupLifecyclePolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupLifecyclePolicy using POST.
        /// </summary>
        /// <param name="groupLifecyclePolicyToCreate">The GroupLifecyclePolicy to create.</param>
        /// <returns>The created GroupLifecyclePolicy.</returns>
        public System.Threading.Tasks.Task<GroupLifecyclePolicy> CreateAsync(GroupLifecyclePolicy groupLifecyclePolicyToCreate)
        {
            return this.CreateAsync(groupLifecyclePolicyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GroupLifecyclePolicy using POST.
        /// </summary>
        /// <param name="groupLifecyclePolicyToCreate">The GroupLifecyclePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupLifecyclePolicy.</returns>
        public async System.Threading.Tasks.Task<GroupLifecyclePolicy> CreateAsync(GroupLifecyclePolicy groupLifecyclePolicyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<GroupLifecyclePolicy>(groupLifecyclePolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GroupLifecyclePolicy using POST and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="groupLifecyclePolicyToCreate">The GroupLifecyclePolicy to create.</param>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> CreateResponseAsync(GroupLifecyclePolicy groupLifecyclePolicyToCreate)
        {
            return this.CreateResponseAsync(groupLifecyclePolicyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GroupLifecyclePolicy using POST and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="groupLifecyclePolicyToCreate">The GroupLifecyclePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> CreateResponseAsync(GroupLifecyclePolicy groupLifecyclePolicyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<GroupLifecyclePolicy>(groupLifecyclePolicyToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupLifecyclePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GroupLifecyclePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<GroupLifecyclePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupLifecyclePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GroupLifecyclePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified GroupLifecyclePolicy.
        /// </summary>
        /// <returns>The GroupLifecyclePolicy.</returns>
        public System.Threading.Tasks.Task<GroupLifecyclePolicy> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GroupLifecyclePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupLifecyclePolicy.</returns>
        public async System.Threading.Tasks.Task<GroupLifecyclePolicy> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<GroupLifecyclePolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupLifecyclePolicy and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GroupLifecyclePolicy and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<GroupLifecyclePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PATCH.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy to update.</param>
        /// <returns>The updated GroupLifecyclePolicy.</returns>
        public System.Threading.Tasks.Task<GroupLifecyclePolicy> UpdateAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate)
        {
            return this.UpdateAsync(groupLifecyclePolicyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PATCH.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupLifecyclePolicy.</returns>
        public async System.Threading.Tasks.Task<GroupLifecyclePolicy> UpdateAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate, CancellationToken cancellationToken)
        {
			if (groupLifecyclePolicyToUpdate.AdditionalData != null)
			{
				if (groupLifecyclePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					groupLifecyclePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupLifecyclePolicyToUpdate.GetType().Name)
						});
				}
			}
            if (groupLifecyclePolicyToUpdate.AdditionalData != null)
            {
                if (groupLifecyclePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    groupLifecyclePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupLifecyclePolicyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<GroupLifecyclePolicy>(groupLifecyclePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PATCH and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy to update.</param>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> UpdateResponseAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate)
        {
            return this.UpdateResponseAsync(groupLifecyclePolicyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PATCH and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> UpdateResponseAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate, CancellationToken cancellationToken)
        {
			if (groupLifecyclePolicyToUpdate.AdditionalData != null)
			{
				if (groupLifecyclePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					groupLifecyclePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupLifecyclePolicyToUpdate.GetType().Name)
						});
				}
			}
            if (groupLifecyclePolicyToUpdate.AdditionalData != null)
            {
                if (groupLifecyclePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    groupLifecyclePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupLifecyclePolicyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<GroupLifecyclePolicy>(groupLifecyclePolicyToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupLifecyclePolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupLifecyclePolicyRequest Expand(Expression<Func<GroupLifecyclePolicy, object>> expandExpression)
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
        public IGroupLifecyclePolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupLifecyclePolicyRequest Select(Expression<Func<GroupLifecyclePolicy, object>> selectExpression)
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
        /// <param name="groupLifecyclePolicyToInitialize">The <see cref="GroupLifecyclePolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupLifecyclePolicy groupLifecyclePolicyToInitialize)
        {

        }
    }
}
