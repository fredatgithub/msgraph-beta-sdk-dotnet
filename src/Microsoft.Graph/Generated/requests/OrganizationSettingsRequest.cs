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
    /// The type OrganizationSettingsRequest.
    /// </summary>
    public partial class OrganizationSettingsRequest : BaseRequest, IOrganizationSettingsRequest
    {
        /// <summary>
        /// Constructs a new OrganizationSettingsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OrganizationSettingsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OrganizationSettings using POST.
        /// </summary>
        /// <param name="organizationSettingsToCreate">The OrganizationSettings to create.</param>
        /// <returns>The created OrganizationSettings.</returns>
        public System.Threading.Tasks.Task<OrganizationSettings> CreateAsync(OrganizationSettings organizationSettingsToCreate)
        {
            return this.CreateAsync(organizationSettingsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OrganizationSettings using POST.
        /// </summary>
        /// <param name="organizationSettingsToCreate">The OrganizationSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OrganizationSettings.</returns>
        public async System.Threading.Tasks.Task<OrganizationSettings> CreateAsync(OrganizationSettings organizationSettingsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OrganizationSettings>(organizationSettingsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OrganizationSettings using POST and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <param name="organizationSettingsToCreate">The OrganizationSettings to create.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> CreateResponseAsync(OrganizationSettings organizationSettingsToCreate)
        {
            return this.CreateResponseAsync(organizationSettingsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OrganizationSettings using POST and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <param name="organizationSettingsToCreate">The OrganizationSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> CreateResponseAsync(OrganizationSettings organizationSettingsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<OrganizationSettings>(organizationSettingsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OrganizationSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OrganizationSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OrganizationSettings>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OrganizationSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OrganizationSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OrganizationSettings.
        /// </summary>
        /// <returns>The OrganizationSettings.</returns>
        public System.Threading.Tasks.Task<OrganizationSettings> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OrganizationSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OrganizationSettings.</returns>
        public async System.Threading.Tasks.Task<OrganizationSettings> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OrganizationSettings>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified OrganizationSettings and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OrganizationSettings and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<OrganizationSettings>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified OrganizationSettings using PATCH.
        /// </summary>
        /// <param name="organizationSettingsToUpdate">The OrganizationSettings to update.</param>
        /// <returns>The updated OrganizationSettings.</returns>
        public System.Threading.Tasks.Task<OrganizationSettings> UpdateAsync(OrganizationSettings organizationSettingsToUpdate)
        {
            return this.UpdateAsync(organizationSettingsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OrganizationSettings using PATCH.
        /// </summary>
        /// <param name="organizationSettingsToUpdate">The OrganizationSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OrganizationSettings.</returns>
        public async System.Threading.Tasks.Task<OrganizationSettings> UpdateAsync(OrganizationSettings organizationSettingsToUpdate, CancellationToken cancellationToken)
        {
			if (organizationSettingsToUpdate.AdditionalData != null)
			{
				if (organizationSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					organizationSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, organizationSettingsToUpdate.GetType().Name)
						});
				}
			}
            if (organizationSettingsToUpdate.AdditionalData != null)
            {
                if (organizationSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    organizationSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, organizationSettingsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OrganizationSettings>(organizationSettingsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OrganizationSettings using PATCH and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <param name="organizationSettingsToUpdate">The OrganizationSettings to update.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> UpdateResponseAsync(OrganizationSettings organizationSettingsToUpdate)
        {
            return this.UpdateResponseAsync(organizationSettingsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OrganizationSettings using PATCH and returns a <see cref="GraphResponse{OrganizationSettings}"/> object.
        /// </summary>
        /// <param name="organizationSettingsToUpdate">The OrganizationSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OrganizationSettings}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OrganizationSettings>> UpdateResponseAsync(OrganizationSettings organizationSettingsToUpdate, CancellationToken cancellationToken)
        {
			if (organizationSettingsToUpdate.AdditionalData != null)
			{
				if (organizationSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					organizationSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, organizationSettingsToUpdate.GetType().Name)
						});
				}
			}
            if (organizationSettingsToUpdate.AdditionalData != null)
            {
                if (organizationSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    organizationSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, organizationSettingsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<OrganizationSettings>(organizationSettingsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationSettingsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationSettingsRequest Expand(Expression<Func<OrganizationSettings, object>> expandExpression)
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
        public IOrganizationSettingsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationSettingsRequest Select(Expression<Func<OrganizationSettings, object>> selectExpression)
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
        /// <param name="organizationSettingsToInitialize">The <see cref="OrganizationSettings"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OrganizationSettings organizationSettingsToInitialize)
        {

            if (organizationSettingsToInitialize != null && organizationSettingsToInitialize.AdditionalData != null)
            {

                if (organizationSettingsToInitialize.ProfileCardProperties != null && organizationSettingsToInitialize.ProfileCardProperties.CurrentPage != null)
                {
                    organizationSettingsToInitialize.ProfileCardProperties.AdditionalData = organizationSettingsToInitialize.AdditionalData;

                    object nextPageLink;
                    organizationSettingsToInitialize.AdditionalData.TryGetValue("profileCardProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        organizationSettingsToInitialize.ProfileCardProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
