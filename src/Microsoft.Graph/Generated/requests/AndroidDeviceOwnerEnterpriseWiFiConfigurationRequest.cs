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
    /// The type AndroidDeviceOwnerEnterpriseWiFiConfigurationRequest.
    /// </summary>
    public partial class AndroidDeviceOwnerEnterpriseWiFiConfigurationRequest : BaseRequest, IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest
    {
        /// <summary>
        /// Constructs a new AndroidDeviceOwnerEnterpriseWiFiConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidDeviceOwnerEnterpriseWiFiConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToCreate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to create.</param>
        /// <returns>The created AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        public System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> CreateAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToCreate)
        {
            return this.CreateAsync(androidDeviceOwnerEnterpriseWiFiConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToCreate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> CreateAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AndroidDeviceOwnerEnterpriseWiFiConfiguration>(androidDeviceOwnerEnterpriseWiFiConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToCreate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> CreateResponseAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToCreate)
        {
            return this.CreateResponseAsync(androidDeviceOwnerEnterpriseWiFiConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToCreate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> CreateResponseAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>(androidDeviceOwnerEnterpriseWiFiConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AndroidDeviceOwnerEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        public System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AndroidDeviceOwnerEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to update.</param>
        /// <returns>The updated AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        public System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> UpdateAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate)
        {
            return this.UpdateAsync(androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<AndroidDeviceOwnerEnterpriseWiFiConfiguration> UpdateAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData != null)
			{
				if (androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData != null)
            {
                if (androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AndroidDeviceOwnerEnterpriseWiFiConfiguration>(androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> UpdateResponseAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate)
        {
            return this.UpdateResponseAsync(androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerEnterpriseWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AndroidDeviceOwnerEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>> UpdateResponseAsync(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData != null)
			{
				if (androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData != null)
            {
                if (androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<AndroidDeviceOwnerEnterpriseWiFiConfiguration>(androidDeviceOwnerEnterpriseWiFiConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest Expand(Expression<Func<AndroidDeviceOwnerEnterpriseWiFiConfiguration, object>> expandExpression)
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
        public IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidDeviceOwnerEnterpriseWiFiConfigurationRequest Select(Expression<Func<AndroidDeviceOwnerEnterpriseWiFiConfiguration, object>> selectExpression)
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
        /// <param name="androidDeviceOwnerEnterpriseWiFiConfigurationToInitialize">The <see cref="AndroidDeviceOwnerEnterpriseWiFiConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidDeviceOwnerEnterpriseWiFiConfiguration androidDeviceOwnerEnterpriseWiFiConfigurationToInitialize)
        {

        }
    }
}
