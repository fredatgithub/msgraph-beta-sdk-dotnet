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
    /// The type EmployeeRequest.
    /// </summary>
    public partial class EmployeeRequest : BaseRequest, IEmployeeRequest
    {
        /// <summary>
        /// Constructs a new EmployeeRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EmployeeRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Employee using POST.
        /// </summary>
        /// <param name="employeeToCreate">The Employee to create.</param>
        /// <returns>The created Employee.</returns>
        public System.Threading.Tasks.Task<Employee> CreateAsync(Employee employeeToCreate)
        {
            return this.CreateAsync(employeeToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Employee using POST.
        /// </summary>
        /// <param name="employeeToCreate">The Employee to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Employee.</returns>
        public async System.Threading.Tasks.Task<Employee> CreateAsync(Employee employeeToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Employee>(employeeToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Employee using POST and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <param name="employeeToCreate">The Employee to create.</param>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Employee>> CreateResponseAsync(Employee employeeToCreate)
        {
            return this.CreateResponseAsync(employeeToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Employee using POST and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <param name="employeeToCreate">The Employee to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Employee>> CreateResponseAsync(Employee employeeToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Employee>(employeeToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Employee.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Employee.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Employee>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Employee and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Employee and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Employee.
        /// </summary>
        /// <returns>The Employee.</returns>
        public System.Threading.Tasks.Task<Employee> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Employee.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Employee.</returns>
        public async System.Threading.Tasks.Task<Employee> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Employee>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Employee and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Employee>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Employee and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Employee>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<Employee>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified Employee using PATCH.
        /// </summary>
        /// <param name="employeeToUpdate">The Employee to update.</param>
        /// <returns>The updated Employee.</returns>
        public System.Threading.Tasks.Task<Employee> UpdateAsync(Employee employeeToUpdate)
        {
            return this.UpdateAsync(employeeToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Employee using PATCH.
        /// </summary>
        /// <param name="employeeToUpdate">The Employee to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Employee.</returns>
        public async System.Threading.Tasks.Task<Employee> UpdateAsync(Employee employeeToUpdate, CancellationToken cancellationToken)
        {
			if (employeeToUpdate.AdditionalData != null)
			{
				if (employeeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					employeeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, employeeToUpdate.GetType().Name)
						});
				}
			}
            if (employeeToUpdate.AdditionalData != null)
            {
                if (employeeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    employeeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, employeeToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Employee>(employeeToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Employee using PATCH and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <param name="employeeToUpdate">The Employee to update.</param>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Employee>> UpdateResponseAsync(Employee employeeToUpdate)
        {
            return this.UpdateResponseAsync(employeeToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Employee using PATCH and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <param name="employeeToUpdate">The Employee to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Employee>> UpdateResponseAsync(Employee employeeToUpdate, CancellationToken cancellationToken)
        {
			if (employeeToUpdate.AdditionalData != null)
			{
				if (employeeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					employeeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, employeeToUpdate.GetType().Name)
						});
				}
			}
            if (employeeToUpdate.AdditionalData != null)
            {
                if (employeeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    employeeToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, employeeToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<Employee>(employeeToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmployeeRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmployeeRequest Expand(Expression<Func<Employee, object>> expandExpression)
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
        public IEmployeeRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEmployeeRequest Select(Expression<Func<Employee, object>> selectExpression)
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
        /// <param name="employeeToInitialize">The <see cref="Employee"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Employee employeeToInitialize)
        {

            if (employeeToInitialize != null && employeeToInitialize.AdditionalData != null)
            {

                if (employeeToInitialize.Picture != null && employeeToInitialize.Picture.CurrentPage != null)
                {
                    employeeToInitialize.Picture.AdditionalData = employeeToInitialize.AdditionalData;

                    object nextPageLink;
                    employeeToInitialize.AdditionalData.TryGetValue("picture@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        employeeToInitialize.Picture.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
