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
    /// The type WindowsInformationProtectionRequest.
    /// </summary>
    public partial class WindowsInformationProtectionRequest : BaseRequest, IWindowsInformationProtectionRequest
    {
        /// <summary>
        /// Constructs a new WindowsInformationProtectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsInformationProtectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtection using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionToCreate">The WindowsInformationProtection to create.</param>
        /// <returns>The created WindowsInformationProtection.</returns>
        public System.Threading.Tasks.Task<WindowsInformationProtection> CreateAsync(WindowsInformationProtection windowsInformationProtectionToCreate)
        {
            return this.CreateAsync(windowsInformationProtectionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtection using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionToCreate">The WindowsInformationProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtection.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtection> CreateAsync(WindowsInformationProtection windowsInformationProtectionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsInformationProtection>(windowsInformationProtectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtection using POST and returns a <see cref="GraphResponse{WindowsInformationProtection}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionToCreate">The WindowsInformationProtection to create.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtection>> CreateResponseAsync(WindowsInformationProtection windowsInformationProtectionToCreate)
        {
            return this.CreateResponseAsync(windowsInformationProtectionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtection using POST and returns a <see cref="GraphResponse{WindowsInformationProtection}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionToCreate">The WindowsInformationProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtection}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtection>> CreateResponseAsync(WindowsInformationProtection windowsInformationProtectionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WindowsInformationProtection>(windowsInformationProtectionToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtection.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsInformationProtection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtection.
        /// </summary>
        /// <returns>The WindowsInformationProtection.</returns>
        public System.Threading.Tasks.Task<WindowsInformationProtection> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsInformationProtection.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtection> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsInformationProtection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtection and returns a <see cref="GraphResponse{WindowsInformationProtection}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtection>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtection and returns a <see cref="GraphResponse{WindowsInformationProtection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtection}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtection>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<WindowsInformationProtection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtection using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionToUpdate">The WindowsInformationProtection to update.</param>
        /// <returns>The updated WindowsInformationProtection.</returns>
        public System.Threading.Tasks.Task<WindowsInformationProtection> UpdateAsync(WindowsInformationProtection windowsInformationProtectionToUpdate)
        {
            return this.UpdateAsync(windowsInformationProtectionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtection using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionToUpdate">The WindowsInformationProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsInformationProtection.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtection> UpdateAsync(WindowsInformationProtection windowsInformationProtectionToUpdate, CancellationToken cancellationToken)
        {
			if (windowsInformationProtectionToUpdate.AdditionalData != null)
			{
				if (windowsInformationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windowsInformationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsInformationProtectionToUpdate.GetType().Name)
						});
				}
			}
            if (windowsInformationProtectionToUpdate.AdditionalData != null)
            {
                if (windowsInformationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windowsInformationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsInformationProtectionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsInformationProtection>(windowsInformationProtectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtection using PATCH and returns a <see cref="GraphResponse{WindowsInformationProtection}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionToUpdate">The WindowsInformationProtection to update.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtection>> UpdateResponseAsync(WindowsInformationProtection windowsInformationProtectionToUpdate)
        {
            return this.UpdateResponseAsync(windowsInformationProtectionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtection using PATCH and returns a <see cref="GraphResponse{WindowsInformationProtection}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionToUpdate">The WindowsInformationProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtection}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtection>> UpdateResponseAsync(WindowsInformationProtection windowsInformationProtectionToUpdate, CancellationToken cancellationToken)
        {
			if (windowsInformationProtectionToUpdate.AdditionalData != null)
			{
				if (windowsInformationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windowsInformationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsInformationProtectionToUpdate.GetType().Name)
						});
				}
			}
            if (windowsInformationProtectionToUpdate.AdditionalData != null)
            {
                if (windowsInformationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windowsInformationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsInformationProtectionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WindowsInformationProtection>(windowsInformationProtectionToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionRequest Expand(Expression<Func<WindowsInformationProtection, object>> expandExpression)
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
        public IWindowsInformationProtectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionRequest Select(Expression<Func<WindowsInformationProtection, object>> selectExpression)
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
        /// <param name="windowsInformationProtectionToInitialize">The <see cref="WindowsInformationProtection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsInformationProtection windowsInformationProtectionToInitialize)
        {

            if (windowsInformationProtectionToInitialize != null && windowsInformationProtectionToInitialize.AdditionalData != null)
            {

                if (windowsInformationProtectionToInitialize.Assignments != null && windowsInformationProtectionToInitialize.Assignments.CurrentPage != null)
                {
                    windowsInformationProtectionToInitialize.Assignments.AdditionalData = windowsInformationProtectionToInitialize.AdditionalData;

                    object nextPageLink;
                    windowsInformationProtectionToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        windowsInformationProtectionToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (windowsInformationProtectionToInitialize.ExemptAppLockerFiles != null && windowsInformationProtectionToInitialize.ExemptAppLockerFiles.CurrentPage != null)
                {
                    windowsInformationProtectionToInitialize.ExemptAppLockerFiles.AdditionalData = windowsInformationProtectionToInitialize.AdditionalData;

                    object nextPageLink;
                    windowsInformationProtectionToInitialize.AdditionalData.TryGetValue("exemptAppLockerFiles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        windowsInformationProtectionToInitialize.ExemptAppLockerFiles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (windowsInformationProtectionToInitialize.ProtectedAppLockerFiles != null && windowsInformationProtectionToInitialize.ProtectedAppLockerFiles.CurrentPage != null)
                {
                    windowsInformationProtectionToInitialize.ProtectedAppLockerFiles.AdditionalData = windowsInformationProtectionToInitialize.AdditionalData;

                    object nextPageLink;
                    windowsInformationProtectionToInitialize.AdditionalData.TryGetValue("protectedAppLockerFiles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        windowsInformationProtectionToInitialize.ProtectedAppLockerFiles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
