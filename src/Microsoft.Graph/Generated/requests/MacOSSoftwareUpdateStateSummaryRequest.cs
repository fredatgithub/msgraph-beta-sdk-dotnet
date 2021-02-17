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
    /// The type MacOSSoftwareUpdateStateSummaryRequest.
    /// </summary>
    public partial class MacOSSoftwareUpdateStateSummaryRequest : BaseRequest, IMacOSSoftwareUpdateStateSummaryRequest
    {
        /// <summary>
        /// Constructs a new MacOSSoftwareUpdateStateSummaryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSSoftwareUpdateStateSummaryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateStateSummary using POST.
        /// </summary>
        /// <param name="macOSSoftwareUpdateStateSummaryToCreate">The MacOSSoftwareUpdateStateSummary to create.</param>
        /// <returns>The created MacOSSoftwareUpdateStateSummary.</returns>
        public System.Threading.Tasks.Task<MacOSSoftwareUpdateStateSummary> CreateAsync(MacOSSoftwareUpdateStateSummary macOSSoftwareUpdateStateSummaryToCreate)
        {
            return this.CreateAsync(macOSSoftwareUpdateStateSummaryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateStateSummary using POST.
        /// </summary>
        /// <param name="macOSSoftwareUpdateStateSummaryToCreate">The MacOSSoftwareUpdateStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSSoftwareUpdateStateSummary.</returns>
        public async System.Threading.Tasks.Task<MacOSSoftwareUpdateStateSummary> CreateAsync(MacOSSoftwareUpdateStateSummary macOSSoftwareUpdateStateSummaryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MacOSSoftwareUpdateStateSummary>(macOSSoftwareUpdateStateSummaryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateStateSummary using POST and returns a <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateStateSummaryToCreate">The MacOSSoftwareUpdateStateSummary to create.</param>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateStateSummary>> CreateResponseAsync(MacOSSoftwareUpdateStateSummary macOSSoftwareUpdateStateSummaryToCreate)
        {
            return this.CreateResponseAsync(macOSSoftwareUpdateStateSummaryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateStateSummary using POST and returns a <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateStateSummaryToCreate">The MacOSSoftwareUpdateStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateStateSummary>> CreateResponseAsync(MacOSSoftwareUpdateStateSummary macOSSoftwareUpdateStateSummaryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MacOSSoftwareUpdateStateSummary>(macOSSoftwareUpdateStateSummaryToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateStateSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MacOSSoftwareUpdateStateSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateStateSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateStateSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateStateSummary.
        /// </summary>
        /// <returns>The MacOSSoftwareUpdateStateSummary.</returns>
        public System.Threading.Tasks.Task<MacOSSoftwareUpdateStateSummary> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSSoftwareUpdateStateSummary.</returns>
        public async System.Threading.Tasks.Task<MacOSSoftwareUpdateStateSummary> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MacOSSoftwareUpdateStateSummary>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateStateSummary and returns a <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateStateSummary>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateStateSummary and returns a <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateStateSummary>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<MacOSSoftwareUpdateStateSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateStateSummary using PATCH.
        /// </summary>
        /// <param name="macOSSoftwareUpdateStateSummaryToUpdate">The MacOSSoftwareUpdateStateSummary to update.</param>
        /// <returns>The updated MacOSSoftwareUpdateStateSummary.</returns>
        public System.Threading.Tasks.Task<MacOSSoftwareUpdateStateSummary> UpdateAsync(MacOSSoftwareUpdateStateSummary macOSSoftwareUpdateStateSummaryToUpdate)
        {
            return this.UpdateAsync(macOSSoftwareUpdateStateSummaryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateStateSummary using PATCH.
        /// </summary>
        /// <param name="macOSSoftwareUpdateStateSummaryToUpdate">The MacOSSoftwareUpdateStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSSoftwareUpdateStateSummary.</returns>
        public async System.Threading.Tasks.Task<MacOSSoftwareUpdateStateSummary> UpdateAsync(MacOSSoftwareUpdateStateSummary macOSSoftwareUpdateStateSummaryToUpdate, CancellationToken cancellationToken)
        {
			if (macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData != null)
			{
				if (macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSSoftwareUpdateStateSummaryToUpdate.GetType().Name)
						});
				}
			}
            if (macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData != null)
            {
                if (macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSSoftwareUpdateStateSummaryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MacOSSoftwareUpdateStateSummary>(macOSSoftwareUpdateStateSummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateStateSummary using PATCH and returns a <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateStateSummaryToUpdate">The MacOSSoftwareUpdateStateSummary to update.</param>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateStateSummary>> UpdateResponseAsync(MacOSSoftwareUpdateStateSummary macOSSoftwareUpdateStateSummaryToUpdate)
        {
            return this.UpdateResponseAsync(macOSSoftwareUpdateStateSummaryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateStateSummary using PATCH and returns a <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateStateSummaryToUpdate">The MacOSSoftwareUpdateStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateStateSummary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateStateSummary>> UpdateResponseAsync(MacOSSoftwareUpdateStateSummary macOSSoftwareUpdateStateSummaryToUpdate, CancellationToken cancellationToken)
        {
			if (macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData != null)
			{
				if (macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSSoftwareUpdateStateSummaryToUpdate.GetType().Name)
						});
				}
			}
            if (macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData != null)
            {
                if (macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    macOSSoftwareUpdateStateSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSSoftwareUpdateStateSummaryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MacOSSoftwareUpdateStateSummary>(macOSSoftwareUpdateStateSummaryToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSSoftwareUpdateStateSummaryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSSoftwareUpdateStateSummaryRequest Expand(Expression<Func<MacOSSoftwareUpdateStateSummary, object>> expandExpression)
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
        public IMacOSSoftwareUpdateStateSummaryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSSoftwareUpdateStateSummaryRequest Select(Expression<Func<MacOSSoftwareUpdateStateSummary, object>> selectExpression)
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
        /// <param name="macOSSoftwareUpdateStateSummaryToInitialize">The <see cref="MacOSSoftwareUpdateStateSummary"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSSoftwareUpdateStateSummary macOSSoftwareUpdateStateSummaryToInitialize)
        {

        }
    }
}
