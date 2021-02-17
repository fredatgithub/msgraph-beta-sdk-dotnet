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
    /// The type MacOSCustomAppConfigurationRequest.
    /// </summary>
    public partial class MacOSCustomAppConfigurationRequest : BaseRequest, IMacOSCustomAppConfigurationRequest
    {
        /// <summary>
        /// Constructs a new MacOSCustomAppConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSCustomAppConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSCustomAppConfiguration using POST.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToCreate">The MacOSCustomAppConfiguration to create.</param>
        /// <returns>The created MacOSCustomAppConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSCustomAppConfiguration> CreateAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToCreate)
        {
            return this.CreateAsync(macOSCustomAppConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MacOSCustomAppConfiguration using POST.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToCreate">The MacOSCustomAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSCustomAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSCustomAppConfiguration> CreateAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MacOSCustomAppConfiguration>(macOSCustomAppConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MacOSCustomAppConfiguration using POST and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToCreate">The MacOSCustomAppConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> CreateResponseAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToCreate)
        {
            return this.CreateResponseAsync(macOSCustomAppConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MacOSCustomAppConfiguration using POST and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToCreate">The MacOSCustomAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> CreateResponseAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MacOSCustomAppConfiguration>(macOSCustomAppConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSCustomAppConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MacOSCustomAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MacOSCustomAppConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSCustomAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MacOSCustomAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MacOSCustomAppConfiguration.
        /// </summary>
        /// <returns>The MacOSCustomAppConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSCustomAppConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSCustomAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSCustomAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSCustomAppConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MacOSCustomAppConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MacOSCustomAppConfiguration and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSCustomAppConfiguration and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<MacOSCustomAppConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified MacOSCustomAppConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToUpdate">The MacOSCustomAppConfiguration to update.</param>
        /// <returns>The updated MacOSCustomAppConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSCustomAppConfiguration> UpdateAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToUpdate)
        {
            return this.UpdateAsync(macOSCustomAppConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MacOSCustomAppConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToUpdate">The MacOSCustomAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSCustomAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSCustomAppConfiguration> UpdateAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (macOSCustomAppConfigurationToUpdate.AdditionalData != null)
			{
				if (macOSCustomAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					macOSCustomAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSCustomAppConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (macOSCustomAppConfigurationToUpdate.AdditionalData != null)
            {
                if (macOSCustomAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    macOSCustomAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSCustomAppConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MacOSCustomAppConfiguration>(macOSCustomAppConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSCustomAppConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToUpdate">The MacOSCustomAppConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> UpdateResponseAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToUpdate)
        {
            return this.UpdateResponseAsync(macOSCustomAppConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MacOSCustomAppConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSCustomAppConfigurationToUpdate">The MacOSCustomAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSCustomAppConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSCustomAppConfiguration>> UpdateResponseAsync(MacOSCustomAppConfiguration macOSCustomAppConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (macOSCustomAppConfigurationToUpdate.AdditionalData != null)
			{
				if (macOSCustomAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					macOSCustomAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSCustomAppConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (macOSCustomAppConfigurationToUpdate.AdditionalData != null)
            {
                if (macOSCustomAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    macOSCustomAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSCustomAppConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MacOSCustomAppConfiguration>(macOSCustomAppConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSCustomAppConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSCustomAppConfigurationRequest Expand(Expression<Func<MacOSCustomAppConfiguration, object>> expandExpression)
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
        public IMacOSCustomAppConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSCustomAppConfigurationRequest Select(Expression<Func<MacOSCustomAppConfiguration, object>> selectExpression)
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
        /// <param name="macOSCustomAppConfigurationToInitialize">The <see cref="MacOSCustomAppConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSCustomAppConfiguration macOSCustomAppConfigurationToInitialize)
        {

        }
    }
}
