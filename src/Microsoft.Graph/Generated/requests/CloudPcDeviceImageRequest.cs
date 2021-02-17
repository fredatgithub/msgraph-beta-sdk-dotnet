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
    /// The type CloudPcDeviceImageRequest.
    /// </summary>
    public partial class CloudPcDeviceImageRequest : BaseRequest, ICloudPcDeviceImageRequest
    {
        /// <summary>
        /// Constructs a new CloudPcDeviceImageRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CloudPcDeviceImageRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CloudPcDeviceImage using POST.
        /// </summary>
        /// <param name="cloudPcDeviceImageToCreate">The CloudPcDeviceImage to create.</param>
        /// <returns>The created CloudPcDeviceImage.</returns>
        public System.Threading.Tasks.Task<CloudPcDeviceImage> CreateAsync(CloudPcDeviceImage cloudPcDeviceImageToCreate)
        {
            return this.CreateAsync(cloudPcDeviceImageToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified CloudPcDeviceImage using POST.
        /// </summary>
        /// <param name="cloudPcDeviceImageToCreate">The CloudPcDeviceImage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcDeviceImage.</returns>
        public async System.Threading.Tasks.Task<CloudPcDeviceImage> CreateAsync(CloudPcDeviceImage cloudPcDeviceImageToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<CloudPcDeviceImage>(cloudPcDeviceImageToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified CloudPcDeviceImage using POST and returns a <see cref="GraphResponse{CloudPcDeviceImage}"/> object.
        /// </summary>
        /// <param name="cloudPcDeviceImageToCreate">The CloudPcDeviceImage to create.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcDeviceImage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcDeviceImage>> CreateResponseAsync(CloudPcDeviceImage cloudPcDeviceImageToCreate)
        {
            return this.CreateResponseAsync(cloudPcDeviceImageToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified CloudPcDeviceImage using POST and returns a <see cref="GraphResponse{CloudPcDeviceImage}"/> object.
        /// </summary>
        /// <param name="cloudPcDeviceImageToCreate">The CloudPcDeviceImage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcDeviceImage}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<CloudPcDeviceImage>> CreateResponseAsync(CloudPcDeviceImage cloudPcDeviceImageToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<CloudPcDeviceImage>(cloudPcDeviceImageToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CloudPcDeviceImage.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified CloudPcDeviceImage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<CloudPcDeviceImage>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CloudPcDeviceImage and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified CloudPcDeviceImage and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified CloudPcDeviceImage.
        /// </summary>
        /// <returns>The CloudPcDeviceImage.</returns>
        public System.Threading.Tasks.Task<CloudPcDeviceImage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified CloudPcDeviceImage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcDeviceImage.</returns>
        public async System.Threading.Tasks.Task<CloudPcDeviceImage> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<CloudPcDeviceImage>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified CloudPcDeviceImage and returns a <see cref="GraphResponse{CloudPcDeviceImage}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{CloudPcDeviceImage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcDeviceImage>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified CloudPcDeviceImage and returns a <see cref="GraphResponse{CloudPcDeviceImage}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcDeviceImage}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<CloudPcDeviceImage>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<CloudPcDeviceImage>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified CloudPcDeviceImage using PATCH.
        /// </summary>
        /// <param name="cloudPcDeviceImageToUpdate">The CloudPcDeviceImage to update.</param>
        /// <returns>The updated CloudPcDeviceImage.</returns>
        public System.Threading.Tasks.Task<CloudPcDeviceImage> UpdateAsync(CloudPcDeviceImage cloudPcDeviceImageToUpdate)
        {
            return this.UpdateAsync(cloudPcDeviceImageToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified CloudPcDeviceImage using PATCH.
        /// </summary>
        /// <param name="cloudPcDeviceImageToUpdate">The CloudPcDeviceImage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcDeviceImage.</returns>
        public async System.Threading.Tasks.Task<CloudPcDeviceImage> UpdateAsync(CloudPcDeviceImage cloudPcDeviceImageToUpdate, CancellationToken cancellationToken)
        {
			if (cloudPcDeviceImageToUpdate.AdditionalData != null)
			{
				if (cloudPcDeviceImageToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					cloudPcDeviceImageToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, cloudPcDeviceImageToUpdate.GetType().Name)
						});
				}
			}
            if (cloudPcDeviceImageToUpdate.AdditionalData != null)
            {
                if (cloudPcDeviceImageToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    cloudPcDeviceImageToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, cloudPcDeviceImageToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<CloudPcDeviceImage>(cloudPcDeviceImageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CloudPcDeviceImage using PATCH and returns a <see cref="GraphResponse{CloudPcDeviceImage}"/> object.
        /// </summary>
        /// <param name="cloudPcDeviceImageToUpdate">The CloudPcDeviceImage to update.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcDeviceImage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcDeviceImage>> UpdateResponseAsync(CloudPcDeviceImage cloudPcDeviceImageToUpdate)
        {
            return this.UpdateResponseAsync(cloudPcDeviceImageToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified CloudPcDeviceImage using PATCH and returns a <see cref="GraphResponse{CloudPcDeviceImage}"/> object.
        /// </summary>
        /// <param name="cloudPcDeviceImageToUpdate">The CloudPcDeviceImage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CloudPcDeviceImage}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<CloudPcDeviceImage>> UpdateResponseAsync(CloudPcDeviceImage cloudPcDeviceImageToUpdate, CancellationToken cancellationToken)
        {
			if (cloudPcDeviceImageToUpdate.AdditionalData != null)
			{
				if (cloudPcDeviceImageToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					cloudPcDeviceImageToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, cloudPcDeviceImageToUpdate.GetType().Name)
						});
				}
			}
            if (cloudPcDeviceImageToUpdate.AdditionalData != null)
            {
                if (cloudPcDeviceImageToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    cloudPcDeviceImageToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, cloudPcDeviceImageToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<CloudPcDeviceImage>(cloudPcDeviceImageToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcDeviceImageRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcDeviceImageRequest Expand(Expression<Func<CloudPcDeviceImage, object>> expandExpression)
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
        public ICloudPcDeviceImageRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcDeviceImageRequest Select(Expression<Func<CloudPcDeviceImage, object>> selectExpression)
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
        /// <param name="cloudPcDeviceImageToInitialize">The <see cref="CloudPcDeviceImage"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CloudPcDeviceImage cloudPcDeviceImageToInitialize)
        {

        }
    }
}
