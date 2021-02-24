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
    /// The type AzureADWindowsAutopilotDeploymentProfileRequest.
    /// </summary>
    public partial class AzureADWindowsAutopilotDeploymentProfileRequest : BaseRequest, IAzureADWindowsAutopilotDeploymentProfileRequest
    {
        /// <summary>
        /// Constructs a new AzureADWindowsAutopilotDeploymentProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AzureADWindowsAutopilotDeploymentProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AzureADWindowsAutopilotDeploymentProfile using POST.
        /// </summary>
        /// <param name="azureADWindowsAutopilotDeploymentProfileToCreate">The AzureADWindowsAutopilotDeploymentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AzureADWindowsAutopilotDeploymentProfile.</returns>
        public async System.Threading.Tasks.Task<AzureADWindowsAutopilotDeploymentProfile> CreateAsync(AzureADWindowsAutopilotDeploymentProfile azureADWindowsAutopilotDeploymentProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<AzureADWindowsAutopilotDeploymentProfile>(azureADWindowsAutopilotDeploymentProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AzureADWindowsAutopilotDeploymentProfile using POST and returns a <see cref="GraphResponse{AzureADWindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="azureADWindowsAutopilotDeploymentProfileToCreate">The AzureADWindowsAutopilotDeploymentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AzureADWindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AzureADWindowsAutopilotDeploymentProfile>> CreateResponseAsync(AzureADWindowsAutopilotDeploymentProfile azureADWindowsAutopilotDeploymentProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<AzureADWindowsAutopilotDeploymentProfile>(azureADWindowsAutopilotDeploymentProfileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AzureADWindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<AzureADWindowsAutopilotDeploymentProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AzureADWindowsAutopilotDeploymentProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AzureADWindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AzureADWindowsAutopilotDeploymentProfile.</returns>
        public async System.Threading.Tasks.Task<AzureADWindowsAutopilotDeploymentProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<AzureADWindowsAutopilotDeploymentProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AzureADWindowsAutopilotDeploymentProfile and returns a <see cref="GraphResponse{AzureADWindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AzureADWindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AzureADWindowsAutopilotDeploymentProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<AzureADWindowsAutopilotDeploymentProfile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AzureADWindowsAutopilotDeploymentProfile using PATCH.
        /// </summary>
        /// <param name="azureADWindowsAutopilotDeploymentProfileToUpdate">The AzureADWindowsAutopilotDeploymentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AzureADWindowsAutopilotDeploymentProfile.</returns>
        public async System.Threading.Tasks.Task<AzureADWindowsAutopilotDeploymentProfile> UpdateAsync(AzureADWindowsAutopilotDeploymentProfile azureADWindowsAutopilotDeploymentProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<AzureADWindowsAutopilotDeploymentProfile>(azureADWindowsAutopilotDeploymentProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AzureADWindowsAutopilotDeploymentProfile using PATCH and returns a <see cref="GraphResponse{AzureADWindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="azureADWindowsAutopilotDeploymentProfileToUpdate">The AzureADWindowsAutopilotDeploymentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AzureADWindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AzureADWindowsAutopilotDeploymentProfile>> UpdateResponseAsync(AzureADWindowsAutopilotDeploymentProfile azureADWindowsAutopilotDeploymentProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<AzureADWindowsAutopilotDeploymentProfile>(azureADWindowsAutopilotDeploymentProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAzureADWindowsAutopilotDeploymentProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAzureADWindowsAutopilotDeploymentProfileRequest Expand(Expression<Func<AzureADWindowsAutopilotDeploymentProfile, object>> expandExpression)
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
        public IAzureADWindowsAutopilotDeploymentProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAzureADWindowsAutopilotDeploymentProfileRequest Select(Expression<Func<AzureADWindowsAutopilotDeploymentProfile, object>> selectExpression)
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
        /// <param name="azureADWindowsAutopilotDeploymentProfileToInitialize">The <see cref="AzureADWindowsAutopilotDeploymentProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AzureADWindowsAutopilotDeploymentProfile azureADWindowsAutopilotDeploymentProfileToInitialize)
        {

        }
    }
}
