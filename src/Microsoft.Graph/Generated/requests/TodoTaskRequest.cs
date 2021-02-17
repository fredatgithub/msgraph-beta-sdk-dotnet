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
    /// The type TodoTaskRequest.
    /// </summary>
    public partial class TodoTaskRequest : BaseRequest, ITodoTaskRequest
    {
        /// <summary>
        /// Constructs a new TodoTaskRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TodoTaskRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TodoTask using POST.
        /// </summary>
        /// <param name="todoTaskToCreate">The TodoTask to create.</param>
        /// <returns>The created TodoTask.</returns>
        public System.Threading.Tasks.Task<TodoTask> CreateAsync(TodoTask todoTaskToCreate)
        {
            return this.CreateAsync(todoTaskToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TodoTask using POST.
        /// </summary>
        /// <param name="todoTaskToCreate">The TodoTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TodoTask.</returns>
        public async System.Threading.Tasks.Task<TodoTask> CreateAsync(TodoTask todoTaskToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<TodoTask>(todoTaskToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TodoTask using POST and returns a <see cref="GraphResponse{TodoTask}"/> object.
        /// </summary>
        /// <param name="todoTaskToCreate">The TodoTask to create.</param>
        /// <returns>The <see cref="GraphResponse{TodoTask}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TodoTask>> CreateResponseAsync(TodoTask todoTaskToCreate)
        {
            return this.CreateResponseAsync(todoTaskToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TodoTask using POST and returns a <see cref="GraphResponse{TodoTask}"/> object.
        /// </summary>
        /// <param name="todoTaskToCreate">The TodoTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TodoTask}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TodoTask>> CreateResponseAsync(TodoTask todoTaskToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<TodoTask>(todoTaskToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TodoTask.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TodoTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<TodoTask>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TodoTask and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TodoTask and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified TodoTask.
        /// </summary>
        /// <returns>The TodoTask.</returns>
        public System.Threading.Tasks.Task<TodoTask> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TodoTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TodoTask.</returns>
        public async System.Threading.Tasks.Task<TodoTask> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<TodoTask>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified TodoTask and returns a <see cref="GraphResponse{TodoTask}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TodoTask}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TodoTask>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TodoTask and returns a <see cref="GraphResponse{TodoTask}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TodoTask}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TodoTask>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<TodoTask>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified TodoTask using PATCH.
        /// </summary>
        /// <param name="todoTaskToUpdate">The TodoTask to update.</param>
        /// <returns>The updated TodoTask.</returns>
        public System.Threading.Tasks.Task<TodoTask> UpdateAsync(TodoTask todoTaskToUpdate)
        {
            return this.UpdateAsync(todoTaskToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TodoTask using PATCH.
        /// </summary>
        /// <param name="todoTaskToUpdate">The TodoTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TodoTask.</returns>
        public async System.Threading.Tasks.Task<TodoTask> UpdateAsync(TodoTask todoTaskToUpdate, CancellationToken cancellationToken)
        {
			if (todoTaskToUpdate.AdditionalData != null)
			{
				if (todoTaskToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					todoTaskToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, todoTaskToUpdate.GetType().Name)
						});
				}
			}
            if (todoTaskToUpdate.AdditionalData != null)
            {
                if (todoTaskToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    todoTaskToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, todoTaskToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<TodoTask>(todoTaskToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TodoTask using PATCH and returns a <see cref="GraphResponse{TodoTask}"/> object.
        /// </summary>
        /// <param name="todoTaskToUpdate">The TodoTask to update.</param>
        /// <returns>The <see cref="GraphResponse{TodoTask}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TodoTask>> UpdateResponseAsync(TodoTask todoTaskToUpdate)
        {
            return this.UpdateResponseAsync(todoTaskToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TodoTask using PATCH and returns a <see cref="GraphResponse{TodoTask}"/> object.
        /// </summary>
        /// <param name="todoTaskToUpdate">The TodoTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TodoTask}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TodoTask>> UpdateResponseAsync(TodoTask todoTaskToUpdate, CancellationToken cancellationToken)
        {
			if (todoTaskToUpdate.AdditionalData != null)
			{
				if (todoTaskToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					todoTaskToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, todoTaskToUpdate.GetType().Name)
						});
				}
			}
            if (todoTaskToUpdate.AdditionalData != null)
            {
                if (todoTaskToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    todoTaskToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, todoTaskToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<TodoTask>(todoTaskToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITodoTaskRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITodoTaskRequest Expand(Expression<Func<TodoTask, object>> expandExpression)
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
        public ITodoTaskRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITodoTaskRequest Select(Expression<Func<TodoTask, object>> selectExpression)
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
        /// <param name="todoTaskToInitialize">The <see cref="TodoTask"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TodoTask todoTaskToInitialize)
        {

            if (todoTaskToInitialize != null && todoTaskToInitialize.AdditionalData != null)
            {

                if (todoTaskToInitialize.Extensions != null && todoTaskToInitialize.Extensions.CurrentPage != null)
                {
                    todoTaskToInitialize.Extensions.AdditionalData = todoTaskToInitialize.AdditionalData;

                    object nextPageLink;
                    todoTaskToInitialize.AdditionalData.TryGetValue("extensions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        todoTaskToInitialize.Extensions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (todoTaskToInitialize.LinkedResources != null && todoTaskToInitialize.LinkedResources.CurrentPage != null)
                {
                    todoTaskToInitialize.LinkedResources.AdditionalData = todoTaskToInitialize.AdditionalData;

                    object nextPageLink;
                    todoTaskToInitialize.AdditionalData.TryGetValue("linkedResources@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        todoTaskToInitialize.LinkedResources.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
