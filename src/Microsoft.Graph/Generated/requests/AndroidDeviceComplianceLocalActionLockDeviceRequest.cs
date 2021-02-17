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
    /// The type AndroidDeviceComplianceLocalActionLockDeviceRequest.
    /// </summary>
    public partial class AndroidDeviceComplianceLocalActionLockDeviceRequest : BaseRequest, IAndroidDeviceComplianceLocalActionLockDeviceRequest
    {
        /// <summary>
        /// Constructs a new AndroidDeviceComplianceLocalActionLockDeviceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidDeviceComplianceLocalActionLockDeviceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidDeviceComplianceLocalActionLockDevice using POST.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceToCreate">The AndroidDeviceComplianceLocalActionLockDevice to create.</param>
        /// <returns>The created AndroidDeviceComplianceLocalActionLockDevice.</returns>
        public System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDevice> CreateAsync(AndroidDeviceComplianceLocalActionLockDevice androidDeviceComplianceLocalActionLockDeviceToCreate)
        {
            return this.CreateAsync(androidDeviceComplianceLocalActionLockDeviceToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidDeviceComplianceLocalActionLockDevice using POST.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceToCreate">The AndroidDeviceComplianceLocalActionLockDevice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceComplianceLocalActionLockDevice.</returns>
        public async System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDevice> CreateAsync(AndroidDeviceComplianceLocalActionLockDevice androidDeviceComplianceLocalActionLockDeviceToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AndroidDeviceComplianceLocalActionLockDevice>(androidDeviceComplianceLocalActionLockDeviceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AndroidDeviceComplianceLocalActionLockDevice using POST and returns a <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceToCreate">The AndroidDeviceComplianceLocalActionLockDevice to create.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidDeviceComplianceLocalActionLockDevice>> CreateResponseAsync(AndroidDeviceComplianceLocalActionLockDevice androidDeviceComplianceLocalActionLockDeviceToCreate)
        {
            return this.CreateResponseAsync(androidDeviceComplianceLocalActionLockDeviceToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidDeviceComplianceLocalActionLockDevice using POST and returns a <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceToCreate">The AndroidDeviceComplianceLocalActionLockDevice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidDeviceComplianceLocalActionLockDevice>> CreateResponseAsync(AndroidDeviceComplianceLocalActionLockDevice androidDeviceComplianceLocalActionLockDeviceToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<AndroidDeviceComplianceLocalActionLockDevice>(androidDeviceComplianceLocalActionLockDeviceToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidDeviceComplianceLocalActionLockDevice.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidDeviceComplianceLocalActionLockDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AndroidDeviceComplianceLocalActionLockDevice>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidDeviceComplianceLocalActionLockDevice and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidDeviceComplianceLocalActionLockDevice and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AndroidDeviceComplianceLocalActionLockDevice.
        /// </summary>
        /// <returns>The AndroidDeviceComplianceLocalActionLockDevice.</returns>
        public System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDevice> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidDeviceComplianceLocalActionLockDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceComplianceLocalActionLockDevice.</returns>
        public async System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDevice> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AndroidDeviceComplianceLocalActionLockDevice>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AndroidDeviceComplianceLocalActionLockDevice and returns a <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidDeviceComplianceLocalActionLockDevice>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidDeviceComplianceLocalActionLockDevice and returns a <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidDeviceComplianceLocalActionLockDevice>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<AndroidDeviceComplianceLocalActionLockDevice>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified AndroidDeviceComplianceLocalActionLockDevice using PATCH.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceToUpdate">The AndroidDeviceComplianceLocalActionLockDevice to update.</param>
        /// <returns>The updated AndroidDeviceComplianceLocalActionLockDevice.</returns>
        public System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDevice> UpdateAsync(AndroidDeviceComplianceLocalActionLockDevice androidDeviceComplianceLocalActionLockDeviceToUpdate)
        {
            return this.UpdateAsync(androidDeviceComplianceLocalActionLockDeviceToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidDeviceComplianceLocalActionLockDevice using PATCH.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceToUpdate">The AndroidDeviceComplianceLocalActionLockDevice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceComplianceLocalActionLockDevice.</returns>
        public async System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDevice> UpdateAsync(AndroidDeviceComplianceLocalActionLockDevice androidDeviceComplianceLocalActionLockDeviceToUpdate, CancellationToken cancellationToken)
        {
			if (androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData != null)
			{
				if (androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidDeviceComplianceLocalActionLockDeviceToUpdate.GetType().Name)
						});
				}
			}
            if (androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData != null)
            {
                if (androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidDeviceComplianceLocalActionLockDeviceToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AndroidDeviceComplianceLocalActionLockDevice>(androidDeviceComplianceLocalActionLockDeviceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidDeviceComplianceLocalActionLockDevice using PATCH and returns a <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceToUpdate">The AndroidDeviceComplianceLocalActionLockDevice to update.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidDeviceComplianceLocalActionLockDevice>> UpdateResponseAsync(AndroidDeviceComplianceLocalActionLockDevice androidDeviceComplianceLocalActionLockDeviceToUpdate)
        {
            return this.UpdateResponseAsync(androidDeviceComplianceLocalActionLockDeviceToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidDeviceComplianceLocalActionLockDevice using PATCH and returns a <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceToUpdate">The AndroidDeviceComplianceLocalActionLockDevice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceComplianceLocalActionLockDevice}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidDeviceComplianceLocalActionLockDevice>> UpdateResponseAsync(AndroidDeviceComplianceLocalActionLockDevice androidDeviceComplianceLocalActionLockDeviceToUpdate, CancellationToken cancellationToken)
        {
			if (androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData != null)
			{
				if (androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidDeviceComplianceLocalActionLockDeviceToUpdate.GetType().Name)
						});
				}
			}
            if (androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData != null)
            {
                if (androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    androidDeviceComplianceLocalActionLockDeviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidDeviceComplianceLocalActionLockDeviceToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<AndroidDeviceComplianceLocalActionLockDevice>(androidDeviceComplianceLocalActionLockDeviceToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidDeviceComplianceLocalActionLockDeviceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidDeviceComplianceLocalActionLockDeviceRequest Expand(Expression<Func<AndroidDeviceComplianceLocalActionLockDevice, object>> expandExpression)
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
        public IAndroidDeviceComplianceLocalActionLockDeviceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidDeviceComplianceLocalActionLockDeviceRequest Select(Expression<Func<AndroidDeviceComplianceLocalActionLockDevice, object>> selectExpression)
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
        /// <param name="androidDeviceComplianceLocalActionLockDeviceToInitialize">The <see cref="AndroidDeviceComplianceLocalActionLockDevice"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidDeviceComplianceLocalActionLockDevice androidDeviceComplianceLocalActionLockDeviceToInitialize)
        {

        }
    }
}
