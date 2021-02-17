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
    /// The type AgreementFileRequest.
    /// </summary>
    public partial class AgreementFileRequest : BaseRequest, IAgreementFileRequest
    {
        /// <summary>
        /// Constructs a new AgreementFileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AgreementFileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AgreementFile using POST.
        /// </summary>
        /// <param name="agreementFileToCreate">The AgreementFile to create.</param>
        /// <returns>The created AgreementFile.</returns>
        public System.Threading.Tasks.Task<AgreementFile> CreateAsync(AgreementFile agreementFileToCreate)
        {
            return this.CreateAsync(agreementFileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AgreementFile using POST.
        /// </summary>
        /// <param name="agreementFileToCreate">The AgreementFile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AgreementFile.</returns>
        public async System.Threading.Tasks.Task<AgreementFile> CreateAsync(AgreementFile agreementFileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AgreementFile>(agreementFileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AgreementFile using POST and returns a <see cref="GraphResponse{AgreementFile}"/> object.
        /// </summary>
        /// <param name="agreementFileToCreate">The AgreementFile to create.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AgreementFile>> CreateResponseAsync(AgreementFile agreementFileToCreate)
        {
            return this.CreateResponseAsync(agreementFileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AgreementFile using POST and returns a <see cref="GraphResponse{AgreementFile}"/> object.
        /// </summary>
        /// <param name="agreementFileToCreate">The AgreementFile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AgreementFile>> CreateResponseAsync(AgreementFile agreementFileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<AgreementFile>(agreementFileToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AgreementFile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AgreementFile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AgreementFile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AgreementFile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AgreementFile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AgreementFile.
        /// </summary>
        /// <returns>The AgreementFile.</returns>
        public System.Threading.Tasks.Task<AgreementFile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AgreementFile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AgreementFile.</returns>
        public async System.Threading.Tasks.Task<AgreementFile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AgreementFile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AgreementFile and returns a <see cref="GraphResponse{AgreementFile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AgreementFile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AgreementFile>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AgreementFile and returns a <see cref="GraphResponse{AgreementFile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AgreementFile>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<AgreementFile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified AgreementFile using PATCH.
        /// </summary>
        /// <param name="agreementFileToUpdate">The AgreementFile to update.</param>
        /// <returns>The updated AgreementFile.</returns>
        public System.Threading.Tasks.Task<AgreementFile> UpdateAsync(AgreementFile agreementFileToUpdate)
        {
            return this.UpdateAsync(agreementFileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AgreementFile using PATCH.
        /// </summary>
        /// <param name="agreementFileToUpdate">The AgreementFile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AgreementFile.</returns>
        public async System.Threading.Tasks.Task<AgreementFile> UpdateAsync(AgreementFile agreementFileToUpdate, CancellationToken cancellationToken)
        {
			if (agreementFileToUpdate.AdditionalData != null)
			{
				if (agreementFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					agreementFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, agreementFileToUpdate.GetType().Name)
						});
				}
			}
            if (agreementFileToUpdate.AdditionalData != null)
            {
                if (agreementFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    agreementFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, agreementFileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AgreementFile>(agreementFileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AgreementFile using PATCH and returns a <see cref="GraphResponse{AgreementFile}"/> object.
        /// </summary>
        /// <param name="agreementFileToUpdate">The AgreementFile to update.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AgreementFile>> UpdateResponseAsync(AgreementFile agreementFileToUpdate)
        {
            return this.UpdateResponseAsync(agreementFileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AgreementFile using PATCH and returns a <see cref="GraphResponse{AgreementFile}"/> object.
        /// </summary>
        /// <param name="agreementFileToUpdate">The AgreementFile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AgreementFile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AgreementFile>> UpdateResponseAsync(AgreementFile agreementFileToUpdate, CancellationToken cancellationToken)
        {
			if (agreementFileToUpdate.AdditionalData != null)
			{
				if (agreementFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					agreementFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, agreementFileToUpdate.GetType().Name)
						});
				}
			}
            if (agreementFileToUpdate.AdditionalData != null)
            {
                if (agreementFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    agreementFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, agreementFileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<AgreementFile>(agreementFileToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAgreementFileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAgreementFileRequest Expand(Expression<Func<AgreementFile, object>> expandExpression)
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
        public IAgreementFileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAgreementFileRequest Select(Expression<Func<AgreementFile, object>> selectExpression)
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
        /// <param name="agreementFileToInitialize">The <see cref="AgreementFile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AgreementFile agreementFileToInitialize)
        {

            if (agreementFileToInitialize != null && agreementFileToInitialize.AdditionalData != null)
            {

                if (agreementFileToInitialize.Localizations != null && agreementFileToInitialize.Localizations.CurrentPage != null)
                {
                    agreementFileToInitialize.Localizations.AdditionalData = agreementFileToInitialize.AdditionalData;

                    object nextPageLink;
                    agreementFileToInitialize.AdditionalData.TryGetValue("localizations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        agreementFileToInitialize.Localizations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
