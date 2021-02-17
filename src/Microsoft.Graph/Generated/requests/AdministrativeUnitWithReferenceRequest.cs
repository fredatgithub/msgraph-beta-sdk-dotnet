// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AdministrativeUnitWithReferenceRequest.
    /// </summary>
    public partial class AdministrativeUnitWithReferenceRequest : BaseRequest, IAdministrativeUnitWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new AdministrativeUnitWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AdministrativeUnitWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified AdministrativeUnit.
        /// </summary>
        /// <returns>The AdministrativeUnit.</returns>
        public System.Threading.Tasks.Task<AdministrativeUnit> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AdministrativeUnit.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AdministrativeUnit.</returns>
        public async System.Threading.Tasks.Task<AdministrativeUnit> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AdministrativeUnit>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AdministrativeUnit and returns a <see cref="GraphResponse{AdministrativeUnit}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AdministrativeUnit}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AdministrativeUnit>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AdministrativeUnit and returns a <see cref="GraphResponse{AdministrativeUnit}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AdministrativeUnit}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AdministrativeUnit>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<AdministrativeUnit>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Creates the specified AdministrativeUnit using POST.
        /// </summary>
        /// <param name="administrativeUnitToCreate">The AdministrativeUnit to create.</param>
        /// <returns>The created AdministrativeUnit.</returns>
        public System.Threading.Tasks.Task<AdministrativeUnit> CreateAsync(AdministrativeUnit administrativeUnitToCreate)
        {
            return this.CreateAsync(administrativeUnitToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AdministrativeUnit using POST.
        /// </summary>
        /// <param name="administrativeUnitToCreate">The AdministrativeUnit to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AdministrativeUnit.</returns>
        public async System.Threading.Tasks.Task<AdministrativeUnit> CreateAsync(AdministrativeUnit administrativeUnitToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AdministrativeUnit>(administrativeUnitToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified AdministrativeUnit using POST and returns a <see cref="GraphResponse{AdministrativeUnit}"/> object.
        /// </summary>
        /// <param name="administrativeUnitToCreate">The AdministrativeUnit to create.</param>
        /// <returns>The <see cref="GraphResponse{AdministrativeUnit}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AdministrativeUnit>> CreateResponseAsync(AdministrativeUnit administrativeUnitToCreate)
        {
            return this.CreateResponseAsync(administrativeUnitToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AdministrativeUnit using POST and returns a <see cref="GraphResponse{AdministrativeUnit}"/> object.
        /// </summary>
        /// <param name="administrativeUnitToCreate">The AdministrativeUnit to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AdministrativeUnit}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AdministrativeUnit>> CreateResponseAsync(AdministrativeUnit administrativeUnitToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<AdministrativeUnit>(administrativeUnitToCreate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Updates the specified AdministrativeUnit using PATCH.
        /// </summary>
        /// <param name="administrativeUnitToUpdate">The AdministrativeUnit to update.</param>
        /// <returns>The updated AdministrativeUnit.</returns>
        public System.Threading.Tasks.Task<AdministrativeUnit> UpdateAsync(AdministrativeUnit administrativeUnitToUpdate)
        {
            return this.UpdateAsync(administrativeUnitToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AdministrativeUnit using PATCH.
        /// </summary>
        /// <param name="administrativeUnitToUpdate">The AdministrativeUnit to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AdministrativeUnit.</returns>
        public async System.Threading.Tasks.Task<AdministrativeUnit> UpdateAsync(AdministrativeUnit administrativeUnitToUpdate, CancellationToken cancellationToken)
        {
			if (administrativeUnitToUpdate.AdditionalData != null)
			{
				if (administrativeUnitToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					administrativeUnitToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, administrativeUnitToUpdate.GetType().Name)
						});
				}
			}
            if (administrativeUnitToUpdate.AdditionalData != null)
            {
                if (administrativeUnitToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    administrativeUnitToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, administrativeUnitToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AdministrativeUnit>(administrativeUnitToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified AdministrativeUnit using PATCH and returns a <see cref="GraphResponse{AdministrativeUnit}"/> object.
        /// </summary>
        /// <param name="administrativeUnitToUpdate">The AdministrativeUnit to update.</param>
        /// <returns>The <see cref="GraphResponse{AdministrativeUnit}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AdministrativeUnit>> UpdateResponseAsync(AdministrativeUnit administrativeUnitToUpdate)
        {
            return this.UpdateResponseAsync(administrativeUnitToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AdministrativeUnit using PATCH and returns a <see cref="GraphResponse{AdministrativeUnit}"/> object.
        /// </summary>
        /// <param name="administrativeUnitToUpdate">The AdministrativeUnit to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AdministrativeUnit}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AdministrativeUnit>> UpdateResponseAsync(AdministrativeUnit administrativeUnitToUpdate, CancellationToken cancellationToken)
        {
			if (administrativeUnitToUpdate.AdditionalData != null)
			{
				if (administrativeUnitToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					administrativeUnitToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, administrativeUnitToUpdate.GetType().Name)
						});
				}
			}
            if (administrativeUnitToUpdate.AdditionalData != null)
            {
                if (administrativeUnitToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    administrativeUnitToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, administrativeUnitToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<AdministrativeUnit>(administrativeUnitToUpdate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified AdministrativeUnit.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AdministrativeUnit.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AdministrativeUnit>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified AdministrativeUnit and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AdministrativeUnit and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAdministrativeUnitWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAdministrativeUnitWithReferenceRequest Expand(Expression<Func<AdministrativeUnit, object>> expandExpression)
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
        public IAdministrativeUnitWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAdministrativeUnitWithReferenceRequest Select(Expression<Func<AdministrativeUnit, object>> selectExpression)
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

    }
}
