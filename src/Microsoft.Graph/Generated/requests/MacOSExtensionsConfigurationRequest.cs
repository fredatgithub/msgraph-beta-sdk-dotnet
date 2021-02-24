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
    /// The type MacOSExtensionsConfigurationRequest.
    /// </summary>
    public partial class MacOSExtensionsConfigurationRequest : BaseRequest, IMacOSExtensionsConfigurationRequest
    {
        /// <summary>
        /// Constructs a new MacOSExtensionsConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSExtensionsConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSExtensionsConfiguration using POST.
        /// </summary>
        /// <param name="macOSExtensionsConfigurationToCreate">The MacOSExtensionsConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSExtensionsConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSExtensionsConfiguration> CreateAsync(MacOSExtensionsConfiguration macOSExtensionsConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<MacOSExtensionsConfiguration>(macOSExtensionsConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MacOSExtensionsConfiguration using POST and returns a <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSExtensionsConfigurationToCreate">The MacOSExtensionsConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSExtensionsConfiguration>> CreateResponseAsync(MacOSExtensionsConfiguration macOSExtensionsConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<MacOSExtensionsConfiguration>(macOSExtensionsConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MacOSExtensionsConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<MacOSExtensionsConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSExtensionsConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MacOSExtensionsConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSExtensionsConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSExtensionsConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<MacOSExtensionsConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MacOSExtensionsConfiguration and returns a <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSExtensionsConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<MacOSExtensionsConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MacOSExtensionsConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSExtensionsConfigurationToUpdate">The MacOSExtensionsConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSExtensionsConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSExtensionsConfiguration> UpdateAsync(MacOSExtensionsConfiguration macOSExtensionsConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<MacOSExtensionsConfiguration>(macOSExtensionsConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSExtensionsConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSExtensionsConfigurationToUpdate">The MacOSExtensionsConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSExtensionsConfiguration>> UpdateResponseAsync(MacOSExtensionsConfiguration macOSExtensionsConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<MacOSExtensionsConfiguration>(macOSExtensionsConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSExtensionsConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSExtensionsConfigurationRequest Expand(Expression<Func<MacOSExtensionsConfiguration, object>> expandExpression)
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
        public IMacOSExtensionsConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSExtensionsConfigurationRequest Select(Expression<Func<MacOSExtensionsConfiguration, object>> selectExpression)
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
        /// <param name="macOSExtensionsConfigurationToInitialize">The <see cref="MacOSExtensionsConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSExtensionsConfiguration macOSExtensionsConfigurationToInitialize)
        {

        }
    }
}
