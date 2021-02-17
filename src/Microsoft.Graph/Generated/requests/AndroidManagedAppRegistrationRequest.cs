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
    /// The type AndroidManagedAppRegistrationRequest.
    /// </summary>
    public partial class AndroidManagedAppRegistrationRequest : BaseRequest, IAndroidManagedAppRegistrationRequest
    {
        /// <summary>
        /// Constructs a new AndroidManagedAppRegistrationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidManagedAppRegistrationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidManagedAppRegistration using POST.
        /// </summary>
        /// <param name="androidManagedAppRegistrationToCreate">The AndroidManagedAppRegistration to create.</param>
        /// <returns>The created AndroidManagedAppRegistration.</returns>
        public System.Threading.Tasks.Task<AndroidManagedAppRegistration> CreateAsync(AndroidManagedAppRegistration androidManagedAppRegistrationToCreate)
        {
            return this.CreateAsync(androidManagedAppRegistrationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidManagedAppRegistration using POST.
        /// </summary>
        /// <param name="androidManagedAppRegistrationToCreate">The AndroidManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<AndroidManagedAppRegistration> CreateAsync(AndroidManagedAppRegistration androidManagedAppRegistrationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AndroidManagedAppRegistration>(androidManagedAppRegistrationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AndroidManagedAppRegistration using POST and returns a <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="androidManagedAppRegistrationToCreate">The AndroidManagedAppRegistration to create.</param>
        /// <returns>The <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidManagedAppRegistration>> CreateResponseAsync(AndroidManagedAppRegistration androidManagedAppRegistrationToCreate)
        {
            return this.CreateResponseAsync(androidManagedAppRegistrationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidManagedAppRegistration using POST and returns a <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="androidManagedAppRegistrationToCreate">The AndroidManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidManagedAppRegistration>> CreateResponseAsync(AndroidManagedAppRegistration androidManagedAppRegistrationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<AndroidManagedAppRegistration>(androidManagedAppRegistrationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidManagedAppRegistration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AndroidManagedAppRegistration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidManagedAppRegistration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidManagedAppRegistration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AndroidManagedAppRegistration.
        /// </summary>
        /// <returns>The AndroidManagedAppRegistration.</returns>
        public System.Threading.Tasks.Task<AndroidManagedAppRegistration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<AndroidManagedAppRegistration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AndroidManagedAppRegistration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AndroidManagedAppRegistration and returns a <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidManagedAppRegistration>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidManagedAppRegistration and returns a <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidManagedAppRegistration>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<AndroidManagedAppRegistration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified AndroidManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="androidManagedAppRegistrationToUpdate">The AndroidManagedAppRegistration to update.</param>
        /// <returns>The updated AndroidManagedAppRegistration.</returns>
        public System.Threading.Tasks.Task<AndroidManagedAppRegistration> UpdateAsync(AndroidManagedAppRegistration androidManagedAppRegistrationToUpdate)
        {
            return this.UpdateAsync(androidManagedAppRegistrationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="androidManagedAppRegistrationToUpdate">The AndroidManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<AndroidManagedAppRegistration> UpdateAsync(AndroidManagedAppRegistration androidManagedAppRegistrationToUpdate, CancellationToken cancellationToken)
        {
			if (androidManagedAppRegistrationToUpdate.AdditionalData != null)
			{
				if (androidManagedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					androidManagedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidManagedAppRegistrationToUpdate.GetType().Name)
						});
				}
			}
            if (androidManagedAppRegistrationToUpdate.AdditionalData != null)
            {
                if (androidManagedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    androidManagedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidManagedAppRegistrationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AndroidManagedAppRegistration>(androidManagedAppRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidManagedAppRegistration using PATCH and returns a <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="androidManagedAppRegistrationToUpdate">The AndroidManagedAppRegistration to update.</param>
        /// <returns>The <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidManagedAppRegistration>> UpdateResponseAsync(AndroidManagedAppRegistration androidManagedAppRegistrationToUpdate)
        {
            return this.UpdateResponseAsync(androidManagedAppRegistrationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidManagedAppRegistration using PATCH and returns a <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="androidManagedAppRegistrationToUpdate">The AndroidManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidManagedAppRegistration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidManagedAppRegistration>> UpdateResponseAsync(AndroidManagedAppRegistration androidManagedAppRegistrationToUpdate, CancellationToken cancellationToken)
        {
			if (androidManagedAppRegistrationToUpdate.AdditionalData != null)
			{
				if (androidManagedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					androidManagedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidManagedAppRegistrationToUpdate.GetType().Name)
						});
				}
			}
            if (androidManagedAppRegistrationToUpdate.AdditionalData != null)
            {
                if (androidManagedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    androidManagedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidManagedAppRegistrationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<AndroidManagedAppRegistration>(androidManagedAppRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidManagedAppRegistrationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidManagedAppRegistrationRequest Expand(Expression<Func<AndroidManagedAppRegistration, object>> expandExpression)
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
        public IAndroidManagedAppRegistrationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidManagedAppRegistrationRequest Select(Expression<Func<AndroidManagedAppRegistration, object>> selectExpression)
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
        /// <param name="androidManagedAppRegistrationToInitialize">The <see cref="AndroidManagedAppRegistration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidManagedAppRegistration androidManagedAppRegistrationToInitialize)
        {

        }
    }
}
