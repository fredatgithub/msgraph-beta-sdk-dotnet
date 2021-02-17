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
    /// The type IosVpnConfigurationRequest.
    /// </summary>
    public partial class IosVpnConfigurationRequest : BaseRequest, IIosVpnConfigurationRequest
    {
        /// <summary>
        /// Constructs a new IosVpnConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosVpnConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosVpnConfiguration using POST.
        /// </summary>
        /// <param name="iosVpnConfigurationToCreate">The IosVpnConfiguration to create.</param>
        /// <returns>The created IosVpnConfiguration.</returns>
        public System.Threading.Tasks.Task<IosVpnConfiguration> CreateAsync(IosVpnConfiguration iosVpnConfigurationToCreate)
        {
            return this.CreateAsync(iosVpnConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IosVpnConfiguration using POST.
        /// </summary>
        /// <param name="iosVpnConfigurationToCreate">The IosVpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosVpnConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosVpnConfiguration> CreateAsync(IosVpnConfiguration iosVpnConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<IosVpnConfiguration>(iosVpnConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IosVpnConfiguration using POST and returns a <see cref="GraphResponse{IosVpnConfiguration}"/> object.
        /// </summary>
        /// <param name="iosVpnConfigurationToCreate">The IosVpnConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{IosVpnConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosVpnConfiguration>> CreateResponseAsync(IosVpnConfiguration iosVpnConfigurationToCreate)
        {
            return this.CreateResponseAsync(iosVpnConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IosVpnConfiguration using POST and returns a <see cref="GraphResponse{IosVpnConfiguration}"/> object.
        /// </summary>
        /// <param name="iosVpnConfigurationToCreate">The IosVpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosVpnConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<IosVpnConfiguration>> CreateResponseAsync(IosVpnConfiguration iosVpnConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<IosVpnConfiguration>(iosVpnConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosVpnConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IosVpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<IosVpnConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosVpnConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IosVpnConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified IosVpnConfiguration.
        /// </summary>
        /// <returns>The IosVpnConfiguration.</returns>
        public System.Threading.Tasks.Task<IosVpnConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IosVpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosVpnConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosVpnConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<IosVpnConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IosVpnConfiguration and returns a <see cref="GraphResponse{IosVpnConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{IosVpnConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosVpnConfiguration>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IosVpnConfiguration and returns a <see cref="GraphResponse{IosVpnConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosVpnConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<IosVpnConfiguration>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<IosVpnConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified IosVpnConfiguration using PATCH.
        /// </summary>
        /// <param name="iosVpnConfigurationToUpdate">The IosVpnConfiguration to update.</param>
        /// <returns>The updated IosVpnConfiguration.</returns>
        public System.Threading.Tasks.Task<IosVpnConfiguration> UpdateAsync(IosVpnConfiguration iosVpnConfigurationToUpdate)
        {
            return this.UpdateAsync(iosVpnConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IosVpnConfiguration using PATCH.
        /// </summary>
        /// <param name="iosVpnConfigurationToUpdate">The IosVpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosVpnConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosVpnConfiguration> UpdateAsync(IosVpnConfiguration iosVpnConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (iosVpnConfigurationToUpdate.AdditionalData != null)
			{
				if (iosVpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					iosVpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosVpnConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (iosVpnConfigurationToUpdate.AdditionalData != null)
            {
                if (iosVpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    iosVpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosVpnConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<IosVpnConfiguration>(iosVpnConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosVpnConfiguration using PATCH and returns a <see cref="GraphResponse{IosVpnConfiguration}"/> object.
        /// </summary>
        /// <param name="iosVpnConfigurationToUpdate">The IosVpnConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{IosVpnConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosVpnConfiguration>> UpdateResponseAsync(IosVpnConfiguration iosVpnConfigurationToUpdate)
        {
            return this.UpdateResponseAsync(iosVpnConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IosVpnConfiguration using PATCH and returns a <see cref="GraphResponse{IosVpnConfiguration}"/> object.
        /// </summary>
        /// <param name="iosVpnConfigurationToUpdate">The IosVpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosVpnConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<IosVpnConfiguration>> UpdateResponseAsync(IosVpnConfiguration iosVpnConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (iosVpnConfigurationToUpdate.AdditionalData != null)
			{
				if (iosVpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					iosVpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosVpnConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (iosVpnConfigurationToUpdate.AdditionalData != null)
            {
                if (iosVpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    iosVpnConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosVpnConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<IosVpnConfiguration>(iosVpnConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosVpnConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosVpnConfigurationRequest Expand(Expression<Func<IosVpnConfiguration, object>> expandExpression)
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
        public IIosVpnConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosVpnConfigurationRequest Select(Expression<Func<IosVpnConfiguration, object>> selectExpression)
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
        /// <param name="iosVpnConfigurationToInitialize">The <see cref="IosVpnConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosVpnConfiguration iosVpnConfigurationToInitialize)
        {

        }
    }
}
