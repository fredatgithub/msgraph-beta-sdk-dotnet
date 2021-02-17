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
    /// The type GovernancePolicyTemplateRequest.
    /// </summary>
    public partial class GovernancePolicyTemplateRequest : BaseRequest, IGovernancePolicyTemplateRequest
    {
        /// <summary>
        /// Constructs a new GovernancePolicyTemplateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GovernancePolicyTemplateRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GovernancePolicyTemplate using POST.
        /// </summary>
        /// <param name="governancePolicyTemplateToCreate">The GovernancePolicyTemplate to create.</param>
        /// <returns>The created GovernancePolicyTemplate.</returns>
        public System.Threading.Tasks.Task<GovernancePolicyTemplate> CreateAsync(GovernancePolicyTemplate governancePolicyTemplateToCreate)
        {
            return this.CreateAsync(governancePolicyTemplateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GovernancePolicyTemplate using POST.
        /// </summary>
        /// <param name="governancePolicyTemplateToCreate">The GovernancePolicyTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernancePolicyTemplate.</returns>
        public async System.Threading.Tasks.Task<GovernancePolicyTemplate> CreateAsync(GovernancePolicyTemplate governancePolicyTemplateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<GovernancePolicyTemplate>(governancePolicyTemplateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GovernancePolicyTemplate using POST and returns a <see cref="GraphResponse{GovernancePolicyTemplate}"/> object.
        /// </summary>
        /// <param name="governancePolicyTemplateToCreate">The GovernancePolicyTemplate to create.</param>
        /// <returns>The <see cref="GraphResponse{GovernancePolicyTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernancePolicyTemplate>> CreateResponseAsync(GovernancePolicyTemplate governancePolicyTemplateToCreate)
        {
            return this.CreateResponseAsync(governancePolicyTemplateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GovernancePolicyTemplate using POST and returns a <see cref="GraphResponse{GovernancePolicyTemplate}"/> object.
        /// </summary>
        /// <param name="governancePolicyTemplateToCreate">The GovernancePolicyTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernancePolicyTemplate}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GovernancePolicyTemplate>> CreateResponseAsync(GovernancePolicyTemplate governancePolicyTemplateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<GovernancePolicyTemplate>(governancePolicyTemplateToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GovernancePolicyTemplate.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GovernancePolicyTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<GovernancePolicyTemplate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GovernancePolicyTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GovernancePolicyTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified GovernancePolicyTemplate.
        /// </summary>
        /// <returns>The GovernancePolicyTemplate.</returns>
        public System.Threading.Tasks.Task<GovernancePolicyTemplate> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GovernancePolicyTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernancePolicyTemplate.</returns>
        public async System.Threading.Tasks.Task<GovernancePolicyTemplate> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<GovernancePolicyTemplate>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GovernancePolicyTemplate and returns a <see cref="GraphResponse{GovernancePolicyTemplate}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GovernancePolicyTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernancePolicyTemplate>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GovernancePolicyTemplate and returns a <see cref="GraphResponse{GovernancePolicyTemplate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernancePolicyTemplate}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GovernancePolicyTemplate>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<GovernancePolicyTemplate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified GovernancePolicyTemplate using PATCH.
        /// </summary>
        /// <param name="governancePolicyTemplateToUpdate">The GovernancePolicyTemplate to update.</param>
        /// <returns>The updated GovernancePolicyTemplate.</returns>
        public System.Threading.Tasks.Task<GovernancePolicyTemplate> UpdateAsync(GovernancePolicyTemplate governancePolicyTemplateToUpdate)
        {
            return this.UpdateAsync(governancePolicyTemplateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GovernancePolicyTemplate using PATCH.
        /// </summary>
        /// <param name="governancePolicyTemplateToUpdate">The GovernancePolicyTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GovernancePolicyTemplate.</returns>
        public async System.Threading.Tasks.Task<GovernancePolicyTemplate> UpdateAsync(GovernancePolicyTemplate governancePolicyTemplateToUpdate, CancellationToken cancellationToken)
        {
			if (governancePolicyTemplateToUpdate.AdditionalData != null)
			{
				if (governancePolicyTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					governancePolicyTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governancePolicyTemplateToUpdate.GetType().Name)
						});
				}
			}
            if (governancePolicyTemplateToUpdate.AdditionalData != null)
            {
                if (governancePolicyTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    governancePolicyTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governancePolicyTemplateToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<GovernancePolicyTemplate>(governancePolicyTemplateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GovernancePolicyTemplate using PATCH and returns a <see cref="GraphResponse{GovernancePolicyTemplate}"/> object.
        /// </summary>
        /// <param name="governancePolicyTemplateToUpdate">The GovernancePolicyTemplate to update.</param>
        /// <returns>The <see cref="GraphResponse{GovernancePolicyTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernancePolicyTemplate>> UpdateResponseAsync(GovernancePolicyTemplate governancePolicyTemplateToUpdate)
        {
            return this.UpdateResponseAsync(governancePolicyTemplateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GovernancePolicyTemplate using PATCH and returns a <see cref="GraphResponse{GovernancePolicyTemplate}"/> object.
        /// </summary>
        /// <param name="governancePolicyTemplateToUpdate">The GovernancePolicyTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GovernancePolicyTemplate}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GovernancePolicyTemplate>> UpdateResponseAsync(GovernancePolicyTemplate governancePolicyTemplateToUpdate, CancellationToken cancellationToken)
        {
			if (governancePolicyTemplateToUpdate.AdditionalData != null)
			{
				if (governancePolicyTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					governancePolicyTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governancePolicyTemplateToUpdate.GetType().Name)
						});
				}
			}
            if (governancePolicyTemplateToUpdate.AdditionalData != null)
            {
                if (governancePolicyTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    governancePolicyTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governancePolicyTemplateToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<GovernancePolicyTemplate>(governancePolicyTemplateToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernancePolicyTemplateRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernancePolicyTemplateRequest Expand(Expression<Func<GovernancePolicyTemplate, object>> expandExpression)
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
        public IGovernancePolicyTemplateRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernancePolicyTemplateRequest Select(Expression<Func<GovernancePolicyTemplate, object>> selectExpression)
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
        /// <param name="governancePolicyTemplateToInitialize">The <see cref="GovernancePolicyTemplate"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GovernancePolicyTemplate governancePolicyTemplateToInitialize)
        {

        }
    }
}
