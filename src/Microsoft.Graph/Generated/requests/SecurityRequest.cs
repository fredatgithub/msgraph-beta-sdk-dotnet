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
    /// The type SecurityRequest.
    /// </summary>
    public partial class SecurityRequest : BaseRequest, ISecurityRequest
    {
        /// <summary>
        /// Constructs a new SecurityRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SecurityRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Security using POST.
        /// </summary>
        /// <param name="securityToCreate">The Security to create.</param>
        /// <returns>The created Security.</returns>
        public System.Threading.Tasks.Task<Security> CreateAsync(Security securityToCreate)
        {
            return this.CreateAsync(securityToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Security using POST.
        /// </summary>
        /// <param name="securityToCreate">The Security to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Security.</returns>
        public async System.Threading.Tasks.Task<Security> CreateAsync(Security securityToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Security>(securityToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Security using POST and returns a <see cref="GraphResponse{Security}"/> object.
        /// </summary>
        /// <param name="securityToCreate">The Security to create.</param>
        /// <returns>The <see cref="GraphResponse{Security}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Security>> CreateResponseAsync(Security securityToCreate)
        {
            return this.CreateResponseAsync(securityToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Security using POST and returns a <see cref="GraphResponse{Security}"/> object.
        /// </summary>
        /// <param name="securityToCreate">The Security to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Security}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Security>> CreateResponseAsync(Security securityToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Security>(securityToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Security.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Security.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Security>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Security and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Security and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Security.
        /// </summary>
        /// <returns>The Security.</returns>
        public System.Threading.Tasks.Task<Security> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Security.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Security.</returns>
        public async System.Threading.Tasks.Task<Security> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Security>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Security and returns a <see cref="GraphResponse{Security}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Security}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Security>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Security and returns a <see cref="GraphResponse{Security}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Security}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Security>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<Security>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified Security using PATCH.
        /// </summary>
        /// <param name="securityToUpdate">The Security to update.</param>
        /// <returns>The updated Security.</returns>
        public System.Threading.Tasks.Task<Security> UpdateAsync(Security securityToUpdate)
        {
            return this.UpdateAsync(securityToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Security using PATCH.
        /// </summary>
        /// <param name="securityToUpdate">The Security to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Security.</returns>
        public async System.Threading.Tasks.Task<Security> UpdateAsync(Security securityToUpdate, CancellationToken cancellationToken)
        {
			if (securityToUpdate.AdditionalData != null)
			{
				if (securityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					securityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, securityToUpdate.GetType().Name)
						});
				}
			}
            if (securityToUpdate.AdditionalData != null)
            {
                if (securityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    securityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, securityToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Security>(securityToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Security using PATCH and returns a <see cref="GraphResponse{Security}"/> object.
        /// </summary>
        /// <param name="securityToUpdate">The Security to update.</param>
        /// <returns>The <see cref="GraphResponse{Security}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Security>> UpdateResponseAsync(Security securityToUpdate)
        {
            return this.UpdateResponseAsync(securityToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Security using PATCH and returns a <see cref="GraphResponse{Security}"/> object.
        /// </summary>
        /// <param name="securityToUpdate">The Security to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Security}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Security>> UpdateResponseAsync(Security securityToUpdate, CancellationToken cancellationToken)
        {
			if (securityToUpdate.AdditionalData != null)
			{
				if (securityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					securityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, securityToUpdate.GetType().Name)
						});
				}
			}
            if (securityToUpdate.AdditionalData != null)
            {
                if (securityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    securityToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, securityToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<Security>(securityToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISecurityRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISecurityRequest Expand(Expression<Func<Security, object>> expandExpression)
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
        public ISecurityRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISecurityRequest Select(Expression<Func<Security, object>> selectExpression)
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
        /// <param name="securityToInitialize">The <see cref="Security"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Security securityToInitialize)
        {

            if (securityToInitialize != null && securityToInitialize.AdditionalData != null)
            {

                if (securityToInitialize.Alerts != null && securityToInitialize.Alerts.CurrentPage != null)
                {
                    securityToInitialize.Alerts.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("alerts@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.Alerts.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.CloudAppSecurityProfiles != null && securityToInitialize.CloudAppSecurityProfiles.CurrentPage != null)
                {
                    securityToInitialize.CloudAppSecurityProfiles.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("cloudAppSecurityProfiles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.CloudAppSecurityProfiles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.DomainSecurityProfiles != null && securityToInitialize.DomainSecurityProfiles.CurrentPage != null)
                {
                    securityToInitialize.DomainSecurityProfiles.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("domainSecurityProfiles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.DomainSecurityProfiles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.FileSecurityProfiles != null && securityToInitialize.FileSecurityProfiles.CurrentPage != null)
                {
                    securityToInitialize.FileSecurityProfiles.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("fileSecurityProfiles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.FileSecurityProfiles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.HostSecurityProfiles != null && securityToInitialize.HostSecurityProfiles.CurrentPage != null)
                {
                    securityToInitialize.HostSecurityProfiles.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("hostSecurityProfiles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.HostSecurityProfiles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.IpSecurityProfiles != null && securityToInitialize.IpSecurityProfiles.CurrentPage != null)
                {
                    securityToInitialize.IpSecurityProfiles.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("ipSecurityProfiles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.IpSecurityProfiles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.ProviderTenantSettings != null && securityToInitialize.ProviderTenantSettings.CurrentPage != null)
                {
                    securityToInitialize.ProviderTenantSettings.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("providerTenantSettings@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.ProviderTenantSettings.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.SecureScoreControlProfiles != null && securityToInitialize.SecureScoreControlProfiles.CurrentPage != null)
                {
                    securityToInitialize.SecureScoreControlProfiles.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("secureScoreControlProfiles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.SecureScoreControlProfiles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.SecureScores != null && securityToInitialize.SecureScores.CurrentPage != null)
                {
                    securityToInitialize.SecureScores.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("secureScores@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.SecureScores.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.SecurityActions != null && securityToInitialize.SecurityActions.CurrentPage != null)
                {
                    securityToInitialize.SecurityActions.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("securityActions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.SecurityActions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.TiIndicators != null && securityToInitialize.TiIndicators.CurrentPage != null)
                {
                    securityToInitialize.TiIndicators.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("tiIndicators@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.TiIndicators.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (securityToInitialize.UserSecurityProfiles != null && securityToInitialize.UserSecurityProfiles.CurrentPage != null)
                {
                    securityToInitialize.UserSecurityProfiles.AdditionalData = securityToInitialize.AdditionalData;

                    object nextPageLink;
                    securityToInitialize.AdditionalData.TryGetValue("userSecurityProfiles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        securityToInitialize.UserSecurityProfiles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
