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
    /// The type OpenTypeExtensionRequest.
    /// </summary>
    public partial class OpenTypeExtensionRequest : BaseRequest, IOpenTypeExtensionRequest
    {
        /// <summary>
        /// Constructs a new OpenTypeExtensionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OpenTypeExtensionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OpenTypeExtension using POST.
        /// </summary>
        /// <param name="openTypeExtensionToCreate">The OpenTypeExtension to create.</param>
        /// <returns>The created OpenTypeExtension.</returns>
        public System.Threading.Tasks.Task<OpenTypeExtension> CreateAsync(OpenTypeExtension openTypeExtensionToCreate)
        {
            return this.CreateAsync(openTypeExtensionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OpenTypeExtension using POST.
        /// </summary>
        /// <param name="openTypeExtensionToCreate">The OpenTypeExtension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OpenTypeExtension.</returns>
        public async System.Threading.Tasks.Task<OpenTypeExtension> CreateAsync(OpenTypeExtension openTypeExtensionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OpenTypeExtension>(openTypeExtensionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OpenTypeExtension using POST and returns a <see cref="GraphResponse{OpenTypeExtension}"/> object.
        /// </summary>
        /// <param name="openTypeExtensionToCreate">The OpenTypeExtension to create.</param>
        /// <returns>The <see cref="GraphResponse{OpenTypeExtension}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OpenTypeExtension>> CreateResponseAsync(OpenTypeExtension openTypeExtensionToCreate)
        {
            return this.CreateResponseAsync(openTypeExtensionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OpenTypeExtension using POST and returns a <see cref="GraphResponse{OpenTypeExtension}"/> object.
        /// </summary>
        /// <param name="openTypeExtensionToCreate">The OpenTypeExtension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OpenTypeExtension}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OpenTypeExtension>> CreateResponseAsync(OpenTypeExtension openTypeExtensionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<OpenTypeExtension>(openTypeExtensionToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OpenTypeExtension.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OpenTypeExtension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OpenTypeExtension>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OpenTypeExtension and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OpenTypeExtension and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OpenTypeExtension.
        /// </summary>
        /// <returns>The OpenTypeExtension.</returns>
        public System.Threading.Tasks.Task<OpenTypeExtension> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OpenTypeExtension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OpenTypeExtension.</returns>
        public async System.Threading.Tasks.Task<OpenTypeExtension> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OpenTypeExtension>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified OpenTypeExtension and returns a <see cref="GraphResponse{OpenTypeExtension}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{OpenTypeExtension}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OpenTypeExtension>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OpenTypeExtension and returns a <see cref="GraphResponse{OpenTypeExtension}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OpenTypeExtension}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OpenTypeExtension>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<OpenTypeExtension>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified OpenTypeExtension using PATCH.
        /// </summary>
        /// <param name="openTypeExtensionToUpdate">The OpenTypeExtension to update.</param>
        /// <returns>The updated OpenTypeExtension.</returns>
        public System.Threading.Tasks.Task<OpenTypeExtension> UpdateAsync(OpenTypeExtension openTypeExtensionToUpdate)
        {
            return this.UpdateAsync(openTypeExtensionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OpenTypeExtension using PATCH.
        /// </summary>
        /// <param name="openTypeExtensionToUpdate">The OpenTypeExtension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OpenTypeExtension.</returns>
        public async System.Threading.Tasks.Task<OpenTypeExtension> UpdateAsync(OpenTypeExtension openTypeExtensionToUpdate, CancellationToken cancellationToken)
        {
			if (openTypeExtensionToUpdate.AdditionalData != null)
			{
				if (openTypeExtensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					openTypeExtensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, openTypeExtensionToUpdate.GetType().Name)
						});
				}
			}
            if (openTypeExtensionToUpdate.AdditionalData != null)
            {
                if (openTypeExtensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    openTypeExtensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, openTypeExtensionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OpenTypeExtension>(openTypeExtensionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OpenTypeExtension using PATCH and returns a <see cref="GraphResponse{OpenTypeExtension}"/> object.
        /// </summary>
        /// <param name="openTypeExtensionToUpdate">The OpenTypeExtension to update.</param>
        /// <returns>The <see cref="GraphResponse{OpenTypeExtension}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OpenTypeExtension>> UpdateResponseAsync(OpenTypeExtension openTypeExtensionToUpdate)
        {
            return this.UpdateResponseAsync(openTypeExtensionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OpenTypeExtension using PATCH and returns a <see cref="GraphResponse{OpenTypeExtension}"/> object.
        /// </summary>
        /// <param name="openTypeExtensionToUpdate">The OpenTypeExtension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OpenTypeExtension}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OpenTypeExtension>> UpdateResponseAsync(OpenTypeExtension openTypeExtensionToUpdate, CancellationToken cancellationToken)
        {
			if (openTypeExtensionToUpdate.AdditionalData != null)
			{
				if (openTypeExtensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					openTypeExtensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, openTypeExtensionToUpdate.GetType().Name)
						});
				}
			}
            if (openTypeExtensionToUpdate.AdditionalData != null)
            {
                if (openTypeExtensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    openTypeExtensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, openTypeExtensionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<OpenTypeExtension>(openTypeExtensionToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOpenTypeExtensionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOpenTypeExtensionRequest Expand(Expression<Func<OpenTypeExtension, object>> expandExpression)
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
        public IOpenTypeExtensionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOpenTypeExtensionRequest Select(Expression<Func<OpenTypeExtension, object>> selectExpression)
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
        /// <param name="openTypeExtensionToInitialize">The <see cref="OpenTypeExtension"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OpenTypeExtension openTypeExtensionToInitialize)
        {

        }
    }
}
