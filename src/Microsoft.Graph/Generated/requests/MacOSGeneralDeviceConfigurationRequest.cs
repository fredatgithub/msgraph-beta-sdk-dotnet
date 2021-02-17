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
    /// The type MacOSGeneralDeviceConfigurationRequest.
    /// </summary>
    public partial class MacOSGeneralDeviceConfigurationRequest : BaseRequest, IMacOSGeneralDeviceConfigurationRequest
    {
        /// <summary>
        /// Constructs a new MacOSGeneralDeviceConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSGeneralDeviceConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSGeneralDeviceConfiguration using POST.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToCreate">The MacOSGeneralDeviceConfiguration to create.</param>
        /// <returns>The created MacOSGeneralDeviceConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSGeneralDeviceConfiguration> CreateAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToCreate)
        {
            return this.CreateAsync(macOSGeneralDeviceConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MacOSGeneralDeviceConfiguration using POST.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToCreate">The MacOSGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSGeneralDeviceConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSGeneralDeviceConfiguration> CreateAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MacOSGeneralDeviceConfiguration>(macOSGeneralDeviceConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MacOSGeneralDeviceConfiguration using POST and returns a <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToCreate">The MacOSGeneralDeviceConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSGeneralDeviceConfiguration>> CreateResponseAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToCreate)
        {
            return this.CreateResponseAsync(macOSGeneralDeviceConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MacOSGeneralDeviceConfiguration using POST and returns a <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToCreate">The MacOSGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSGeneralDeviceConfiguration>> CreateResponseAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MacOSGeneralDeviceConfiguration>(macOSGeneralDeviceConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSGeneralDeviceConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MacOSGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MacOSGeneralDeviceConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSGeneralDeviceConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MacOSGeneralDeviceConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MacOSGeneralDeviceConfiguration.
        /// </summary>
        /// <returns>The MacOSGeneralDeviceConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSGeneralDeviceConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSGeneralDeviceConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSGeneralDeviceConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MacOSGeneralDeviceConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MacOSGeneralDeviceConfiguration and returns a <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSGeneralDeviceConfiguration>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSGeneralDeviceConfiguration and returns a <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSGeneralDeviceConfiguration>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<MacOSGeneralDeviceConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified MacOSGeneralDeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToUpdate">The MacOSGeneralDeviceConfiguration to update.</param>
        /// <returns>The updated MacOSGeneralDeviceConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSGeneralDeviceConfiguration> UpdateAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToUpdate)
        {
            return this.UpdateAsync(macOSGeneralDeviceConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MacOSGeneralDeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToUpdate">The MacOSGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSGeneralDeviceConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSGeneralDeviceConfiguration> UpdateAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (macOSGeneralDeviceConfigurationToUpdate.AdditionalData != null)
			{
				if (macOSGeneralDeviceConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					macOSGeneralDeviceConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSGeneralDeviceConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (macOSGeneralDeviceConfigurationToUpdate.AdditionalData != null)
            {
                if (macOSGeneralDeviceConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    macOSGeneralDeviceConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSGeneralDeviceConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MacOSGeneralDeviceConfiguration>(macOSGeneralDeviceConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSGeneralDeviceConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToUpdate">The MacOSGeneralDeviceConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSGeneralDeviceConfiguration>> UpdateResponseAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToUpdate)
        {
            return this.UpdateResponseAsync(macOSGeneralDeviceConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MacOSGeneralDeviceConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToUpdate">The MacOSGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSGeneralDeviceConfiguration>> UpdateResponseAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (macOSGeneralDeviceConfigurationToUpdate.AdditionalData != null)
			{
				if (macOSGeneralDeviceConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					macOSGeneralDeviceConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSGeneralDeviceConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (macOSGeneralDeviceConfigurationToUpdate.AdditionalData != null)
            {
                if (macOSGeneralDeviceConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    macOSGeneralDeviceConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSGeneralDeviceConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MacOSGeneralDeviceConfiguration>(macOSGeneralDeviceConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSGeneralDeviceConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSGeneralDeviceConfigurationRequest Expand(Expression<Func<MacOSGeneralDeviceConfiguration, object>> expandExpression)
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
        public IMacOSGeneralDeviceConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSGeneralDeviceConfigurationRequest Select(Expression<Func<MacOSGeneralDeviceConfiguration, object>> selectExpression)
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
        /// <param name="macOSGeneralDeviceConfigurationToInitialize">The <see cref="MacOSGeneralDeviceConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToInitialize)
        {

        }
    }
}
