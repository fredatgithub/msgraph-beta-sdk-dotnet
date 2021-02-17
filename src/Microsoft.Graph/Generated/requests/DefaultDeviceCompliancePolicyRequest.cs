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
    /// The type DefaultDeviceCompliancePolicyRequest.
    /// </summary>
    public partial class DefaultDeviceCompliancePolicyRequest : BaseRequest, IDefaultDeviceCompliancePolicyRequest
    {
        /// <summary>
        /// Constructs a new DefaultDeviceCompliancePolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DefaultDeviceCompliancePolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DefaultDeviceCompliancePolicy using POST.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToCreate">The DefaultDeviceCompliancePolicy to create.</param>
        /// <returns>The created DefaultDeviceCompliancePolicy.</returns>
        public System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> CreateAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToCreate)
        {
            return this.CreateAsync(defaultDeviceCompliancePolicyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DefaultDeviceCompliancePolicy using POST.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToCreate">The DefaultDeviceCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DefaultDeviceCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> CreateAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DefaultDeviceCompliancePolicy>(defaultDeviceCompliancePolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DefaultDeviceCompliancePolicy using POST and returns a <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToCreate">The DefaultDeviceCompliancePolicy to create.</param>
        /// <returns>The <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DefaultDeviceCompliancePolicy>> CreateResponseAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToCreate)
        {
            return this.CreateResponseAsync(defaultDeviceCompliancePolicyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DefaultDeviceCompliancePolicy using POST and returns a <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToCreate">The DefaultDeviceCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DefaultDeviceCompliancePolicy>> CreateResponseAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DefaultDeviceCompliancePolicy>(defaultDeviceCompliancePolicyToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DefaultDeviceCompliancePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DefaultDeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DefaultDeviceCompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DefaultDeviceCompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DefaultDeviceCompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DefaultDeviceCompliancePolicy.
        /// </summary>
        /// <returns>The DefaultDeviceCompliancePolicy.</returns>
        public System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DefaultDeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DefaultDeviceCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DefaultDeviceCompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DefaultDeviceCompliancePolicy and returns a <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DefaultDeviceCompliancePolicy>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DefaultDeviceCompliancePolicy and returns a <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DefaultDeviceCompliancePolicy>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DefaultDeviceCompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DefaultDeviceCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToUpdate">The DefaultDeviceCompliancePolicy to update.</param>
        /// <returns>The updated DefaultDeviceCompliancePolicy.</returns>
        public System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> UpdateAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToUpdate)
        {
            return this.UpdateAsync(defaultDeviceCompliancePolicyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DefaultDeviceCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToUpdate">The DefaultDeviceCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DefaultDeviceCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> UpdateAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToUpdate, CancellationToken cancellationToken)
        {
			if (defaultDeviceCompliancePolicyToUpdate.AdditionalData != null)
			{
				if (defaultDeviceCompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					defaultDeviceCompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, defaultDeviceCompliancePolicyToUpdate.GetType().Name)
						});
				}
			}
            if (defaultDeviceCompliancePolicyToUpdate.AdditionalData != null)
            {
                if (defaultDeviceCompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    defaultDeviceCompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, defaultDeviceCompliancePolicyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DefaultDeviceCompliancePolicy>(defaultDeviceCompliancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DefaultDeviceCompliancePolicy using PATCH and returns a <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToUpdate">The DefaultDeviceCompliancePolicy to update.</param>
        /// <returns>The <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DefaultDeviceCompliancePolicy>> UpdateResponseAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToUpdate)
        {
            return this.UpdateResponseAsync(defaultDeviceCompliancePolicyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DefaultDeviceCompliancePolicy using PATCH and returns a <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToUpdate">The DefaultDeviceCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DefaultDeviceCompliancePolicy>> UpdateResponseAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToUpdate, CancellationToken cancellationToken)
        {
			if (defaultDeviceCompliancePolicyToUpdate.AdditionalData != null)
			{
				if (defaultDeviceCompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					defaultDeviceCompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, defaultDeviceCompliancePolicyToUpdate.GetType().Name)
						});
				}
			}
            if (defaultDeviceCompliancePolicyToUpdate.AdditionalData != null)
            {
                if (defaultDeviceCompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    defaultDeviceCompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, defaultDeviceCompliancePolicyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DefaultDeviceCompliancePolicy>(defaultDeviceCompliancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDefaultDeviceCompliancePolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDefaultDeviceCompliancePolicyRequest Expand(Expression<Func<DefaultDeviceCompliancePolicy, object>> expandExpression)
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
        public IDefaultDeviceCompliancePolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDefaultDeviceCompliancePolicyRequest Select(Expression<Func<DefaultDeviceCompliancePolicy, object>> selectExpression)
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
        /// <param name="defaultDeviceCompliancePolicyToInitialize">The <see cref="DefaultDeviceCompliancePolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToInitialize)
        {

        }
    }
}
