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
    /// The type EducationOutcomeRequest.
    /// </summary>
    public partial class EducationOutcomeRequest : BaseRequest, IEducationOutcomeRequest
    {
        /// <summary>
        /// Constructs a new EducationOutcomeRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EducationOutcomeRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EducationOutcome using POST.
        /// </summary>
        /// <param name="educationOutcomeToCreate">The EducationOutcome to create.</param>
        /// <returns>The created EducationOutcome.</returns>
        public System.Threading.Tasks.Task<EducationOutcome> CreateAsync(EducationOutcome educationOutcomeToCreate)
        {
            return this.CreateAsync(educationOutcomeToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EducationOutcome using POST.
        /// </summary>
        /// <param name="educationOutcomeToCreate">The EducationOutcome to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationOutcome.</returns>
        public async System.Threading.Tasks.Task<EducationOutcome> CreateAsync(EducationOutcome educationOutcomeToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EducationOutcome>(educationOutcomeToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EducationOutcome using POST and returns a <see cref="GraphResponse{EducationOutcome}"/> object.
        /// </summary>
        /// <param name="educationOutcomeToCreate">The EducationOutcome to create.</param>
        /// <returns>The <see cref="GraphResponse{EducationOutcome}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationOutcome>> CreateResponseAsync(EducationOutcome educationOutcomeToCreate)
        {
            return this.CreateResponseAsync(educationOutcomeToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EducationOutcome using POST and returns a <see cref="GraphResponse{EducationOutcome}"/> object.
        /// </summary>
        /// <param name="educationOutcomeToCreate">The EducationOutcome to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationOutcome}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationOutcome>> CreateResponseAsync(EducationOutcome educationOutcomeToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<EducationOutcome>(educationOutcomeToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EducationOutcome.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EducationOutcome.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EducationOutcome>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EducationOutcome and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EducationOutcome and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EducationOutcome.
        /// </summary>
        /// <returns>The EducationOutcome.</returns>
        public System.Threading.Tasks.Task<EducationOutcome> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EducationOutcome.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationOutcome.</returns>
        public async System.Threading.Tasks.Task<EducationOutcome> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EducationOutcome>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EducationOutcome and returns a <see cref="GraphResponse{EducationOutcome}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{EducationOutcome}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationOutcome>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EducationOutcome and returns a <see cref="GraphResponse{EducationOutcome}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationOutcome}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationOutcome>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<EducationOutcome>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified EducationOutcome using PATCH.
        /// </summary>
        /// <param name="educationOutcomeToUpdate">The EducationOutcome to update.</param>
        /// <returns>The updated EducationOutcome.</returns>
        public System.Threading.Tasks.Task<EducationOutcome> UpdateAsync(EducationOutcome educationOutcomeToUpdate)
        {
            return this.UpdateAsync(educationOutcomeToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EducationOutcome using PATCH.
        /// </summary>
        /// <param name="educationOutcomeToUpdate">The EducationOutcome to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationOutcome.</returns>
        public async System.Threading.Tasks.Task<EducationOutcome> UpdateAsync(EducationOutcome educationOutcomeToUpdate, CancellationToken cancellationToken)
        {
			if (educationOutcomeToUpdate.AdditionalData != null)
			{
				if (educationOutcomeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					educationOutcomeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationOutcomeToUpdate.GetType().Name)
						});
				}
			}
            if (educationOutcomeToUpdate.AdditionalData != null)
            {
                if (educationOutcomeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    educationOutcomeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationOutcomeToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EducationOutcome>(educationOutcomeToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EducationOutcome using PATCH and returns a <see cref="GraphResponse{EducationOutcome}"/> object.
        /// </summary>
        /// <param name="educationOutcomeToUpdate">The EducationOutcome to update.</param>
        /// <returns>The <see cref="GraphResponse{EducationOutcome}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationOutcome>> UpdateResponseAsync(EducationOutcome educationOutcomeToUpdate)
        {
            return this.UpdateResponseAsync(educationOutcomeToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EducationOutcome using PATCH and returns a <see cref="GraphResponse{EducationOutcome}"/> object.
        /// </summary>
        /// <param name="educationOutcomeToUpdate">The EducationOutcome to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationOutcome}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationOutcome>> UpdateResponseAsync(EducationOutcome educationOutcomeToUpdate, CancellationToken cancellationToken)
        {
			if (educationOutcomeToUpdate.AdditionalData != null)
			{
				if (educationOutcomeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					educationOutcomeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationOutcomeToUpdate.GetType().Name)
						});
				}
			}
            if (educationOutcomeToUpdate.AdditionalData != null)
            {
                if (educationOutcomeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    educationOutcomeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationOutcomeToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<EducationOutcome>(educationOutcomeToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationOutcomeRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationOutcomeRequest Expand(Expression<Func<EducationOutcome, object>> expandExpression)
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
        public IEducationOutcomeRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationOutcomeRequest Select(Expression<Func<EducationOutcome, object>> selectExpression)
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
        /// <param name="educationOutcomeToInitialize">The <see cref="EducationOutcome"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EducationOutcome educationOutcomeToInitialize)
        {

        }
    }
}
