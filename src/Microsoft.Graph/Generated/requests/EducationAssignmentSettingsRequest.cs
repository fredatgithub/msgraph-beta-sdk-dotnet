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
    /// The type EducationAssignmentSettingsRequest.
    /// </summary>
    public partial class EducationAssignmentSettingsRequest : BaseRequest, IEducationAssignmentSettingsRequest
    {
        /// <summary>
        /// Constructs a new EducationAssignmentSettingsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EducationAssignmentSettingsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EducationAssignmentSettings using POST.
        /// </summary>
        /// <param name="educationAssignmentSettingsToCreate">The EducationAssignmentSettings to create.</param>
        /// <returns>The created EducationAssignmentSettings.</returns>
        public System.Threading.Tasks.Task<EducationAssignmentSettings> CreateAsync(EducationAssignmentSettings educationAssignmentSettingsToCreate)
        {
            return this.CreateAsync(educationAssignmentSettingsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EducationAssignmentSettings using POST.
        /// </summary>
        /// <param name="educationAssignmentSettingsToCreate">The EducationAssignmentSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationAssignmentSettings.</returns>
        public async System.Threading.Tasks.Task<EducationAssignmentSettings> CreateAsync(EducationAssignmentSettings educationAssignmentSettingsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EducationAssignmentSettings>(educationAssignmentSettingsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EducationAssignmentSettings using POST and returns a <see cref="GraphResponse{EducationAssignmentSettings}"/> object.
        /// </summary>
        /// <param name="educationAssignmentSettingsToCreate">The EducationAssignmentSettings to create.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationAssignmentSettings>> CreateResponseAsync(EducationAssignmentSettings educationAssignmentSettingsToCreate)
        {
            return this.CreateResponseAsync(educationAssignmentSettingsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EducationAssignmentSettings using POST and returns a <see cref="GraphResponse{EducationAssignmentSettings}"/> object.
        /// </summary>
        /// <param name="educationAssignmentSettingsToCreate">The EducationAssignmentSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentSettings}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationAssignmentSettings>> CreateResponseAsync(EducationAssignmentSettings educationAssignmentSettingsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<EducationAssignmentSettings>(educationAssignmentSettingsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EducationAssignmentSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EducationAssignmentSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EducationAssignmentSettings>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EducationAssignmentSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EducationAssignmentSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EducationAssignmentSettings.
        /// </summary>
        /// <returns>The EducationAssignmentSettings.</returns>
        public System.Threading.Tasks.Task<EducationAssignmentSettings> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EducationAssignmentSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationAssignmentSettings.</returns>
        public async System.Threading.Tasks.Task<EducationAssignmentSettings> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EducationAssignmentSettings>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EducationAssignmentSettings and returns a <see cref="GraphResponse{EducationAssignmentSettings}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationAssignmentSettings>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EducationAssignmentSettings and returns a <see cref="GraphResponse{EducationAssignmentSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentSettings}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationAssignmentSettings>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<EducationAssignmentSettings>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified EducationAssignmentSettings using PATCH.
        /// </summary>
        /// <param name="educationAssignmentSettingsToUpdate">The EducationAssignmentSettings to update.</param>
        /// <returns>The updated EducationAssignmentSettings.</returns>
        public System.Threading.Tasks.Task<EducationAssignmentSettings> UpdateAsync(EducationAssignmentSettings educationAssignmentSettingsToUpdate)
        {
            return this.UpdateAsync(educationAssignmentSettingsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EducationAssignmentSettings using PATCH.
        /// </summary>
        /// <param name="educationAssignmentSettingsToUpdate">The EducationAssignmentSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationAssignmentSettings.</returns>
        public async System.Threading.Tasks.Task<EducationAssignmentSettings> UpdateAsync(EducationAssignmentSettings educationAssignmentSettingsToUpdate, CancellationToken cancellationToken)
        {
			if (educationAssignmentSettingsToUpdate.AdditionalData != null)
			{
				if (educationAssignmentSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					educationAssignmentSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationAssignmentSettingsToUpdate.GetType().Name)
						});
				}
			}
            if (educationAssignmentSettingsToUpdate.AdditionalData != null)
            {
                if (educationAssignmentSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    educationAssignmentSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationAssignmentSettingsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EducationAssignmentSettings>(educationAssignmentSettingsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EducationAssignmentSettings using PATCH and returns a <see cref="GraphResponse{EducationAssignmentSettings}"/> object.
        /// </summary>
        /// <param name="educationAssignmentSettingsToUpdate">The EducationAssignmentSettings to update.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationAssignmentSettings>> UpdateResponseAsync(EducationAssignmentSettings educationAssignmentSettingsToUpdate)
        {
            return this.UpdateResponseAsync(educationAssignmentSettingsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EducationAssignmentSettings using PATCH and returns a <see cref="GraphResponse{EducationAssignmentSettings}"/> object.
        /// </summary>
        /// <param name="educationAssignmentSettingsToUpdate">The EducationAssignmentSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentSettings}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationAssignmentSettings>> UpdateResponseAsync(EducationAssignmentSettings educationAssignmentSettingsToUpdate, CancellationToken cancellationToken)
        {
			if (educationAssignmentSettingsToUpdate.AdditionalData != null)
			{
				if (educationAssignmentSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					educationAssignmentSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationAssignmentSettingsToUpdate.GetType().Name)
						});
				}
			}
            if (educationAssignmentSettingsToUpdate.AdditionalData != null)
            {
                if (educationAssignmentSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    educationAssignmentSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationAssignmentSettingsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<EducationAssignmentSettings>(educationAssignmentSettingsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationAssignmentSettingsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationAssignmentSettingsRequest Expand(Expression<Func<EducationAssignmentSettings, object>> expandExpression)
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
        public IEducationAssignmentSettingsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationAssignmentSettingsRequest Select(Expression<Func<EducationAssignmentSettings, object>> selectExpression)
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
        /// <param name="educationAssignmentSettingsToInitialize">The <see cref="EducationAssignmentSettings"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EducationAssignmentSettings educationAssignmentSettingsToInitialize)
        {

        }
    }
}
