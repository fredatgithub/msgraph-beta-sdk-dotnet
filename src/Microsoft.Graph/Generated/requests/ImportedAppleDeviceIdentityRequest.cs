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
    /// The type ImportedAppleDeviceIdentityRequest.
    /// </summary>
    public partial class ImportedAppleDeviceIdentityRequest : BaseRequest, IImportedAppleDeviceIdentityRequest
    {
        /// <summary>
        /// Constructs a new ImportedAppleDeviceIdentityRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ImportedAppleDeviceIdentityRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ImportedAppleDeviceIdentity using POST.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityToCreate">The ImportedAppleDeviceIdentity to create.</param>
        /// <returns>The created ImportedAppleDeviceIdentity.</returns>
        public System.Threading.Tasks.Task<ImportedAppleDeviceIdentity> CreateAsync(ImportedAppleDeviceIdentity importedAppleDeviceIdentityToCreate)
        {
            return this.CreateAsync(importedAppleDeviceIdentityToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ImportedAppleDeviceIdentity using POST.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityToCreate">The ImportedAppleDeviceIdentity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ImportedAppleDeviceIdentity.</returns>
        public async System.Threading.Tasks.Task<ImportedAppleDeviceIdentity> CreateAsync(ImportedAppleDeviceIdentity importedAppleDeviceIdentityToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ImportedAppleDeviceIdentity>(importedAppleDeviceIdentityToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ImportedAppleDeviceIdentity using POST and returns a <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityToCreate">The ImportedAppleDeviceIdentity to create.</param>
        /// <returns>The <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ImportedAppleDeviceIdentity>> CreateResponseAsync(ImportedAppleDeviceIdentity importedAppleDeviceIdentityToCreate)
        {
            return this.CreateResponseAsync(importedAppleDeviceIdentityToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ImportedAppleDeviceIdentity using POST and returns a <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityToCreate">The ImportedAppleDeviceIdentity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ImportedAppleDeviceIdentity>> CreateResponseAsync(ImportedAppleDeviceIdentity importedAppleDeviceIdentityToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<ImportedAppleDeviceIdentity>(importedAppleDeviceIdentityToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ImportedAppleDeviceIdentity.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ImportedAppleDeviceIdentity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ImportedAppleDeviceIdentity>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ImportedAppleDeviceIdentity and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ImportedAppleDeviceIdentity and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ImportedAppleDeviceIdentity.
        /// </summary>
        /// <returns>The ImportedAppleDeviceIdentity.</returns>
        public System.Threading.Tasks.Task<ImportedAppleDeviceIdentity> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ImportedAppleDeviceIdentity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ImportedAppleDeviceIdentity.</returns>
        public async System.Threading.Tasks.Task<ImportedAppleDeviceIdentity> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ImportedAppleDeviceIdentity>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ImportedAppleDeviceIdentity and returns a <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ImportedAppleDeviceIdentity>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ImportedAppleDeviceIdentity and returns a <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ImportedAppleDeviceIdentity>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<ImportedAppleDeviceIdentity>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified ImportedAppleDeviceIdentity using PATCH.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityToUpdate">The ImportedAppleDeviceIdentity to update.</param>
        /// <returns>The updated ImportedAppleDeviceIdentity.</returns>
        public System.Threading.Tasks.Task<ImportedAppleDeviceIdentity> UpdateAsync(ImportedAppleDeviceIdentity importedAppleDeviceIdentityToUpdate)
        {
            return this.UpdateAsync(importedAppleDeviceIdentityToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ImportedAppleDeviceIdentity using PATCH.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityToUpdate">The ImportedAppleDeviceIdentity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ImportedAppleDeviceIdentity.</returns>
        public async System.Threading.Tasks.Task<ImportedAppleDeviceIdentity> UpdateAsync(ImportedAppleDeviceIdentity importedAppleDeviceIdentityToUpdate, CancellationToken cancellationToken)
        {
			if (importedAppleDeviceIdentityToUpdate.AdditionalData != null)
			{
				if (importedAppleDeviceIdentityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					importedAppleDeviceIdentityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, importedAppleDeviceIdentityToUpdate.GetType().Name)
						});
				}
			}
            if (importedAppleDeviceIdentityToUpdate.AdditionalData != null)
            {
                if (importedAppleDeviceIdentityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    importedAppleDeviceIdentityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, importedAppleDeviceIdentityToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ImportedAppleDeviceIdentity>(importedAppleDeviceIdentityToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ImportedAppleDeviceIdentity using PATCH and returns a <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityToUpdate">The ImportedAppleDeviceIdentity to update.</param>
        /// <returns>The <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ImportedAppleDeviceIdentity>> UpdateResponseAsync(ImportedAppleDeviceIdentity importedAppleDeviceIdentityToUpdate)
        {
            return this.UpdateResponseAsync(importedAppleDeviceIdentityToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ImportedAppleDeviceIdentity using PATCH and returns a <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityToUpdate">The ImportedAppleDeviceIdentity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ImportedAppleDeviceIdentity}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ImportedAppleDeviceIdentity>> UpdateResponseAsync(ImportedAppleDeviceIdentity importedAppleDeviceIdentityToUpdate, CancellationToken cancellationToken)
        {
			if (importedAppleDeviceIdentityToUpdate.AdditionalData != null)
			{
				if (importedAppleDeviceIdentityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					importedAppleDeviceIdentityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, importedAppleDeviceIdentityToUpdate.GetType().Name)
						});
				}
			}
            if (importedAppleDeviceIdentityToUpdate.AdditionalData != null)
            {
                if (importedAppleDeviceIdentityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    importedAppleDeviceIdentityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, importedAppleDeviceIdentityToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<ImportedAppleDeviceIdentity>(importedAppleDeviceIdentityToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IImportedAppleDeviceIdentityRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IImportedAppleDeviceIdentityRequest Expand(Expression<Func<ImportedAppleDeviceIdentity, object>> expandExpression)
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
        public IImportedAppleDeviceIdentityRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IImportedAppleDeviceIdentityRequest Select(Expression<Func<ImportedAppleDeviceIdentity, object>> selectExpression)
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
        /// <param name="importedAppleDeviceIdentityToInitialize">The <see cref="ImportedAppleDeviceIdentity"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ImportedAppleDeviceIdentity importedAppleDeviceIdentityToInitialize)
        {

        }
    }
}
