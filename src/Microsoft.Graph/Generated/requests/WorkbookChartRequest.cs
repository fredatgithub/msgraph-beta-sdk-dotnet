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
    /// The type WorkbookChartRequest.
    /// </summary>
    public partial class WorkbookChartRequest : BaseRequest, IWorkbookChartRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChart using POST.
        /// </summary>
        /// <param name="workbookChartToCreate">The WorkbookChart to create.</param>
        /// <returns>The created WorkbookChart.</returns>
        public System.Threading.Tasks.Task<WorkbookChart> CreateAsync(WorkbookChart workbookChartToCreate)
        {
            return this.CreateAsync(workbookChartToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChart using POST.
        /// </summary>
        /// <param name="workbookChartToCreate">The WorkbookChart to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChart.</returns>
        public async System.Threading.Tasks.Task<WorkbookChart> CreateAsync(WorkbookChart workbookChartToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookChart>(workbookChartToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WorkbookChart using POST and returns a <see cref="GraphResponse{WorkbookChart}"/> object.
        /// </summary>
        /// <param name="workbookChartToCreate">The WorkbookChart to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChart}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChart>> CreateResponseAsync(WorkbookChart workbookChartToCreate)
        {
            return this.CreateResponseAsync(workbookChartToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChart using POST and returns a <see cref="GraphResponse{WorkbookChart}"/> object.
        /// </summary>
        /// <param name="workbookChartToCreate">The WorkbookChart to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChart}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChart>> CreateResponseAsync(WorkbookChart workbookChartToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WorkbookChart>(workbookChartToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookChart.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChart.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChart>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookChart and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChart and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChart.
        /// </summary>
        /// <returns>The WorkbookChart.</returns>
        public System.Threading.Tasks.Task<WorkbookChart> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChart.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChart.</returns>
        public async System.Threading.Tasks.Task<WorkbookChart> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChart>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WorkbookChart and returns a <see cref="GraphResponse{WorkbookChart}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WorkbookChart}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChart>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChart and returns a <see cref="GraphResponse{WorkbookChart}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChart}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChart>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<WorkbookChart>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified WorkbookChart using PATCH.
        /// </summary>
        /// <param name="workbookChartToUpdate">The WorkbookChart to update.</param>
        /// <returns>The updated WorkbookChart.</returns>
        public System.Threading.Tasks.Task<WorkbookChart> UpdateAsync(WorkbookChart workbookChartToUpdate)
        {
            return this.UpdateAsync(workbookChartToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChart using PATCH.
        /// </summary>
        /// <param name="workbookChartToUpdate">The WorkbookChart to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChart.</returns>
        public async System.Threading.Tasks.Task<WorkbookChart> UpdateAsync(WorkbookChart workbookChartToUpdate, CancellationToken cancellationToken)
        {
			if (workbookChartToUpdate.AdditionalData != null)
			{
				if (workbookChartToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookChartToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartToUpdate.GetType().Name)
						});
				}
			}
            if (workbookChartToUpdate.AdditionalData != null)
            {
                if (workbookChartToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookChartToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChart>(workbookChartToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChart using PATCH and returns a <see cref="GraphResponse{WorkbookChart}"/> object.
        /// </summary>
        /// <param name="workbookChartToUpdate">The WorkbookChart to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChart}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChart>> UpdateResponseAsync(WorkbookChart workbookChartToUpdate)
        {
            return this.UpdateResponseAsync(workbookChartToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChart using PATCH and returns a <see cref="GraphResponse{WorkbookChart}"/> object.
        /// </summary>
        /// <param name="workbookChartToUpdate">The WorkbookChart to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChart}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChart>> UpdateResponseAsync(WorkbookChart workbookChartToUpdate, CancellationToken cancellationToken)
        {
			if (workbookChartToUpdate.AdditionalData != null)
			{
				if (workbookChartToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookChartToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartToUpdate.GetType().Name)
						});
				}
			}
            if (workbookChartToUpdate.AdditionalData != null)
            {
                if (workbookChartToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookChartToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WorkbookChart>(workbookChartToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartRequest Expand(Expression<Func<WorkbookChart, object>> expandExpression)
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
        public IWorkbookChartRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartRequest Select(Expression<Func<WorkbookChart, object>> selectExpression)
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
        /// <param name="workbookChartToInitialize">The <see cref="WorkbookChart"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChart workbookChartToInitialize)
        {

            if (workbookChartToInitialize != null && workbookChartToInitialize.AdditionalData != null)
            {

                if (workbookChartToInitialize.Series != null && workbookChartToInitialize.Series.CurrentPage != null)
                {
                    workbookChartToInitialize.Series.AdditionalData = workbookChartToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookChartToInitialize.AdditionalData.TryGetValue("series@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookChartToInitialize.Series.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
