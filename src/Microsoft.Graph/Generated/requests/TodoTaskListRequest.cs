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
    /// The type TodoTaskListRequest.
    /// </summary>
    public partial class TodoTaskListRequest : BaseRequest, ITodoTaskListRequest
    {
        /// <summary>
        /// Constructs a new TodoTaskListRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TodoTaskListRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TodoTaskList using POST.
        /// </summary>
        /// <param name="todoTaskListToCreate">The TodoTaskList to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TodoTaskList.</returns>
        public async System.Threading.Tasks.Task<TodoTaskList> CreateAsync(TodoTaskList todoTaskListToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<TodoTaskList>(todoTaskListToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TodoTaskList using POST and returns a <see cref="GraphResponse{TodoTaskList}"/> object.
        /// </summary>
        /// <param name="todoTaskListToCreate">The TodoTaskList to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TodoTaskList}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TodoTaskList>> CreateResponseAsync(TodoTaskList todoTaskListToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<TodoTaskList>(todoTaskListToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified TodoTaskList.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<TodoTaskList>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TodoTaskList and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified TodoTaskList.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TodoTaskList.</returns>
        public async System.Threading.Tasks.Task<TodoTaskList> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<TodoTaskList>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified TodoTaskList and returns a <see cref="GraphResponse{TodoTaskList}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TodoTaskList}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TodoTaskList>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<TodoTaskList>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TodoTaskList using PATCH.
        /// </summary>
        /// <param name="todoTaskListToUpdate">The TodoTaskList to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TodoTaskList.</returns>
        public async System.Threading.Tasks.Task<TodoTaskList> UpdateAsync(TodoTaskList todoTaskListToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<TodoTaskList>(todoTaskListToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TodoTaskList using PATCH and returns a <see cref="GraphResponse{TodoTaskList}"/> object.
        /// </summary>
        /// <param name="todoTaskListToUpdate">The TodoTaskList to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TodoTaskList}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TodoTaskList>> UpdateResponseAsync(TodoTaskList todoTaskListToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<TodoTaskList>(todoTaskListToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITodoTaskListRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITodoTaskListRequest Expand(Expression<Func<TodoTaskList, object>> expandExpression)
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
        public ITodoTaskListRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITodoTaskListRequest Select(Expression<Func<TodoTaskList, object>> selectExpression)
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
        /// <param name="todoTaskListToInitialize">The <see cref="TodoTaskList"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TodoTaskList todoTaskListToInitialize)
        {

            if (todoTaskListToInitialize != null && todoTaskListToInitialize.AdditionalData != null)
            {

                if (todoTaskListToInitialize.Extensions != null && todoTaskListToInitialize.Extensions.CurrentPage != null)
                {
                    todoTaskListToInitialize.Extensions.AdditionalData = todoTaskListToInitialize.AdditionalData;

                    object nextPageLink;
                    todoTaskListToInitialize.AdditionalData.TryGetValue("extensions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        todoTaskListToInitialize.Extensions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (todoTaskListToInitialize.Tasks != null && todoTaskListToInitialize.Tasks.CurrentPage != null)
                {
                    todoTaskListToInitialize.Tasks.AdditionalData = todoTaskListToInitialize.AdditionalData;

                    object nextPageLink;
                    todoTaskListToInitialize.AdditionalData.TryGetValue("tasks@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        todoTaskListToInitialize.Tasks.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
