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
    /// The type IosEnterpriseWiFiConfigurationRequest.
    /// </summary>
    public partial class IosEnterpriseWiFiConfigurationRequest : BaseRequest, IIosEnterpriseWiFiConfigurationRequest
    {
        /// <summary>
        /// Constructs a new IosEnterpriseWiFiConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosEnterpriseWiFiConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="iosEnterpriseWiFiConfigurationToCreate">The IosEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosEnterpriseWiFiConfiguration> CreateAsync(IosEnterpriseWiFiConfiguration iosEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<IosEnterpriseWiFiConfiguration>(iosEnterpriseWiFiConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IosEnterpriseWiFiConfiguration using POST and returns a <see cref="GraphResponse{IosEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="iosEnterpriseWiFiConfigurationToCreate">The IosEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosEnterpriseWiFiConfiguration>> CreateResponseAsync(IosEnterpriseWiFiConfiguration iosEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<IosEnterpriseWiFiConfiguration>(iosEnterpriseWiFiConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified IosEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<IosEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified IosEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosEnterpriseWiFiConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<IosEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IosEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse{IosEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosEnterpriseWiFiConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<IosEnterpriseWiFiConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IosEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="iosEnterpriseWiFiConfigurationToUpdate">The IosEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosEnterpriseWiFiConfiguration> UpdateAsync(IosEnterpriseWiFiConfiguration iosEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<IosEnterpriseWiFiConfiguration>(iosEnterpriseWiFiConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosEnterpriseWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{IosEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="iosEnterpriseWiFiConfigurationToUpdate">The IosEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosEnterpriseWiFiConfiguration>> UpdateResponseAsync(IosEnterpriseWiFiConfiguration iosEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<IosEnterpriseWiFiConfiguration>(iosEnterpriseWiFiConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosEnterpriseWiFiConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosEnterpriseWiFiConfigurationRequest Expand(Expression<Func<IosEnterpriseWiFiConfiguration, object>> expandExpression)
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
        public IIosEnterpriseWiFiConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosEnterpriseWiFiConfigurationRequest Select(Expression<Func<IosEnterpriseWiFiConfiguration, object>> selectExpression)
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
        /// <param name="iosEnterpriseWiFiConfigurationToInitialize">The <see cref="IosEnterpriseWiFiConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosEnterpriseWiFiConfiguration iosEnterpriseWiFiConfigurationToInitialize)
        {

            if (iosEnterpriseWiFiConfigurationToInitialize != null && iosEnterpriseWiFiConfigurationToInitialize.AdditionalData != null)
            {

                if (iosEnterpriseWiFiConfigurationToInitialize.RootCertificatesForServerValidation != null && iosEnterpriseWiFiConfigurationToInitialize.RootCertificatesForServerValidation.CurrentPage != null)
                {
                    iosEnterpriseWiFiConfigurationToInitialize.RootCertificatesForServerValidation.AdditionalData = iosEnterpriseWiFiConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    iosEnterpriseWiFiConfigurationToInitialize.AdditionalData.TryGetValue("rootCertificatesForServerValidation@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        iosEnterpriseWiFiConfigurationToInitialize.RootCertificatesForServerValidation.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
