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
    /// The type MacOSSoftwareUpdateConfigurationRequest.
    /// </summary>
    public partial class MacOSSoftwareUpdateConfigurationRequest : BaseRequest, IMacOSSoftwareUpdateConfigurationRequest
    {
        /// <summary>
        /// Constructs a new MacOSSoftwareUpdateConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSSoftwareUpdateConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateConfiguration using POST.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToCreate">The MacOSSoftwareUpdateConfiguration to create.</param>
        /// <returns>The created MacOSSoftwareUpdateConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> CreateAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToCreate)
        {
            return this.CreateAsync(macOSSoftwareUpdateConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateConfiguration using POST.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToCreate">The MacOSSoftwareUpdateConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSSoftwareUpdateConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> CreateAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MacOSSoftwareUpdateConfiguration>(macOSSoftwareUpdateConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateConfiguration using POST and returns a <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToCreate">The MacOSSoftwareUpdateConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateConfiguration>> CreateResponseAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToCreate)
        {
            return this.CreateResponseAsync(macOSSoftwareUpdateConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateConfiguration using POST and returns a <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToCreate">The MacOSSoftwareUpdateConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateConfiguration>> CreateResponseAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MacOSSoftwareUpdateConfiguration>(macOSSoftwareUpdateConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MacOSSoftwareUpdateConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateConfiguration.
        /// </summary>
        /// <returns>The MacOSSoftwareUpdateConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSSoftwareUpdateConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MacOSSoftwareUpdateConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateConfiguration and returns a <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateConfiguration>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateConfiguration and returns a <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateConfiguration>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<MacOSSoftwareUpdateConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToUpdate">The MacOSSoftwareUpdateConfiguration to update.</param>
        /// <returns>The updated MacOSSoftwareUpdateConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> UpdateAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToUpdate)
        {
            return this.UpdateAsync(macOSSoftwareUpdateConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToUpdate">The MacOSSoftwareUpdateConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSSoftwareUpdateConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> UpdateAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (macOSSoftwareUpdateConfigurationToUpdate.AdditionalData != null)
			{
				if (macOSSoftwareUpdateConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					macOSSoftwareUpdateConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSSoftwareUpdateConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (macOSSoftwareUpdateConfigurationToUpdate.AdditionalData != null)
            {
                if (macOSSoftwareUpdateConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    macOSSoftwareUpdateConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSSoftwareUpdateConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MacOSSoftwareUpdateConfiguration>(macOSSoftwareUpdateConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToUpdate">The MacOSSoftwareUpdateConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateConfiguration>> UpdateResponseAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToUpdate)
        {
            return this.UpdateResponseAsync(macOSSoftwareUpdateConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToUpdate">The MacOSSoftwareUpdateConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateConfiguration>> UpdateResponseAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (macOSSoftwareUpdateConfigurationToUpdate.AdditionalData != null)
			{
				if (macOSSoftwareUpdateConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					macOSSoftwareUpdateConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSSoftwareUpdateConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (macOSSoftwareUpdateConfigurationToUpdate.AdditionalData != null)
            {
                if (macOSSoftwareUpdateConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    macOSSoftwareUpdateConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSSoftwareUpdateConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MacOSSoftwareUpdateConfiguration>(macOSSoftwareUpdateConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSSoftwareUpdateConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSSoftwareUpdateConfigurationRequest Expand(Expression<Func<MacOSSoftwareUpdateConfiguration, object>> expandExpression)
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
        public IMacOSSoftwareUpdateConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSSoftwareUpdateConfigurationRequest Select(Expression<Func<MacOSSoftwareUpdateConfiguration, object>> selectExpression)
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
        /// <param name="macOSSoftwareUpdateConfigurationToInitialize">The <see cref="MacOSSoftwareUpdateConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToInitialize)
        {

        }
    }
}
