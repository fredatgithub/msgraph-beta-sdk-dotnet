// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type IosLobAppProvisioningConfigurationRequest.
    /// </summary>
    public partial class IosLobAppProvisioningConfigurationRequest : BaseRequest, IIosLobAppProvisioningConfigurationRequest
    {
        /// <summary>
        /// Constructs a new IosLobAppProvisioningConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosLobAppProvisioningConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosLobAppProvisioningConfiguration using POST.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationToCreate">The IosLobAppProvisioningConfiguration to create.</param>
        /// <returns>The created IosLobAppProvisioningConfiguration.</returns>
        public System.Threading.Tasks.Task<IosLobAppProvisioningConfiguration> CreateAsync(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToCreate)
        {
            return this.CreateAsync(iosLobAppProvisioningConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IosLobAppProvisioningConfiguration using POST.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationToCreate">The IosLobAppProvisioningConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosLobAppProvisioningConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosLobAppProvisioningConfiguration> CreateAsync(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<IosLobAppProvisioningConfiguration>(iosLobAppProvisioningConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified IosLobAppProvisioningConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IosLobAppProvisioningConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<IosLobAppProvisioningConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified IosLobAppProvisioningConfiguration.
        /// </summary>
        /// <returns>The IosLobAppProvisioningConfiguration.</returns>
        public System.Threading.Tasks.Task<IosLobAppProvisioningConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IosLobAppProvisioningConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosLobAppProvisioningConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosLobAppProvisioningConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<IosLobAppProvisioningConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified IosLobAppProvisioningConfiguration using PATCH.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationToUpdate">The IosLobAppProvisioningConfiguration to update.</param>
        /// <returns>The updated IosLobAppProvisioningConfiguration.</returns>
        public System.Threading.Tasks.Task<IosLobAppProvisioningConfiguration> UpdateAsync(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToUpdate)
        {
            return this.UpdateAsync(iosLobAppProvisioningConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IosLobAppProvisioningConfiguration using PATCH.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationToUpdate">The IosLobAppProvisioningConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosLobAppProvisioningConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosLobAppProvisioningConfiguration> UpdateAsync(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (iosLobAppProvisioningConfigurationToUpdate.AdditionalData != null)
			{
				if (iosLobAppProvisioningConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					iosLobAppProvisioningConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosLobAppProvisioningConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (iosLobAppProvisioningConfigurationToUpdate.AdditionalData != null)
            {
                if (iosLobAppProvisioningConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    iosLobAppProvisioningConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosLobAppProvisioningConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<IosLobAppProvisioningConfiguration>(iosLobAppProvisioningConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosLobAppProvisioningConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosLobAppProvisioningConfigurationRequest Expand(Expression<Func<IosLobAppProvisioningConfiguration, object>> expandExpression)
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
        public IIosLobAppProvisioningConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosLobAppProvisioningConfigurationRequest Select(Expression<Func<IosLobAppProvisioningConfiguration, object>> selectExpression)
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
        /// <param name="iosLobAppProvisioningConfigurationToInitialize">The <see cref="IosLobAppProvisioningConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToInitialize)
        {

            if (iosLobAppProvisioningConfigurationToInitialize != null && iosLobAppProvisioningConfigurationToInitialize.AdditionalData != null)
            {

                if (iosLobAppProvisioningConfigurationToInitialize.Assignments != null && iosLobAppProvisioningConfigurationToInitialize.Assignments.CurrentPage != null)
                {
                    iosLobAppProvisioningConfigurationToInitialize.Assignments.AdditionalData = iosLobAppProvisioningConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    iosLobAppProvisioningConfigurationToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        iosLobAppProvisioningConfigurationToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (iosLobAppProvisioningConfigurationToInitialize.DeviceStatuses != null && iosLobAppProvisioningConfigurationToInitialize.DeviceStatuses.CurrentPage != null)
                {
                    iosLobAppProvisioningConfigurationToInitialize.DeviceStatuses.AdditionalData = iosLobAppProvisioningConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    iosLobAppProvisioningConfigurationToInitialize.AdditionalData.TryGetValue("deviceStatuses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        iosLobAppProvisioningConfigurationToInitialize.DeviceStatuses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (iosLobAppProvisioningConfigurationToInitialize.GroupAssignments != null && iosLobAppProvisioningConfigurationToInitialize.GroupAssignments.CurrentPage != null)
                {
                    iosLobAppProvisioningConfigurationToInitialize.GroupAssignments.AdditionalData = iosLobAppProvisioningConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    iosLobAppProvisioningConfigurationToInitialize.AdditionalData.TryGetValue("groupAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        iosLobAppProvisioningConfigurationToInitialize.GroupAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (iosLobAppProvisioningConfigurationToInitialize.UserStatuses != null && iosLobAppProvisioningConfigurationToInitialize.UserStatuses.CurrentPage != null)
                {
                    iosLobAppProvisioningConfigurationToInitialize.UserStatuses.AdditionalData = iosLobAppProvisioningConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    iosLobAppProvisioningConfigurationToInitialize.AdditionalData.TryGetValue("userStatuses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        iosLobAppProvisioningConfigurationToInitialize.UserStatuses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}