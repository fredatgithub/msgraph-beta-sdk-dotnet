// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type GovernanceRoleAssignmentWithReferenceRequest.
    /// </summary>
    public partial class GovernanceRoleAssignmentWithReferenceRequest : BaseRequest, IGovernanceRoleAssignmentWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new GovernanceRoleAssignmentWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GovernanceRoleAssignmentWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified GovernanceRoleAssignment.
        /// </summary>
        /// <returns>The GovernanceRoleAssignment.</returns>
        public System.Threading.Tasks.Task<GovernanceRoleAssignment> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GovernanceRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernanceRoleAssignment.</returns>
        public async System.Threading.Tasks.Task<GovernanceRoleAssignment> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<GovernanceRoleAssignment>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GovernanceRoleAssignment and returns a <see cref="GraphResponse{GovernanceRoleAssignment}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignment>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GovernanceRoleAssignment and returns a <see cref="GraphResponse{GovernanceRoleAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignment>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<GovernanceRoleAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Creates the specified GovernanceRoleAssignment using POST.
        /// </summary>
        /// <param name="governanceRoleAssignmentToCreate">The GovernanceRoleAssignment to create.</param>
        /// <returns>The created GovernanceRoleAssignment.</returns>
        public System.Threading.Tasks.Task<GovernanceRoleAssignment> CreateAsync(GovernanceRoleAssignment governanceRoleAssignmentToCreate)
        {
            return this.CreateAsync(governanceRoleAssignmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GovernanceRoleAssignment using POST.
        /// </summary>
        /// <param name="governanceRoleAssignmentToCreate">The GovernanceRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernanceRoleAssignment.</returns>
        public async System.Threading.Tasks.Task<GovernanceRoleAssignment> CreateAsync(GovernanceRoleAssignment governanceRoleAssignmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<GovernanceRoleAssignment>(governanceRoleAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified GovernanceRoleAssignment using POST and returns a <see cref="GraphResponse{GovernanceRoleAssignment}"/> object.
        /// </summary>
        /// <param name="governanceRoleAssignmentToCreate">The GovernanceRoleAssignment to create.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignment>> CreateResponseAsync(GovernanceRoleAssignment governanceRoleAssignmentToCreate)
        {
            return this.CreateResponseAsync(governanceRoleAssignmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GovernanceRoleAssignment using POST and returns a <see cref="GraphResponse{GovernanceRoleAssignment}"/> object.
        /// </summary>
        /// <param name="governanceRoleAssignmentToCreate">The GovernanceRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignment>> CreateResponseAsync(GovernanceRoleAssignment governanceRoleAssignmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<GovernanceRoleAssignment>(governanceRoleAssignmentToCreate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Updates the specified GovernanceRoleAssignment using PATCH.
        /// </summary>
        /// <param name="governanceRoleAssignmentToUpdate">The GovernanceRoleAssignment to update.</param>
        /// <returns>The updated GovernanceRoleAssignment.</returns>
        public System.Threading.Tasks.Task<GovernanceRoleAssignment> UpdateAsync(GovernanceRoleAssignment governanceRoleAssignmentToUpdate)
        {
            return this.UpdateAsync(governanceRoleAssignmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GovernanceRoleAssignment using PATCH.
        /// </summary>
        /// <param name="governanceRoleAssignmentToUpdate">The GovernanceRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GovernanceRoleAssignment.</returns>
        public async System.Threading.Tasks.Task<GovernanceRoleAssignment> UpdateAsync(GovernanceRoleAssignment governanceRoleAssignmentToUpdate, CancellationToken cancellationToken)
        {
			if (governanceRoleAssignmentToUpdate.AdditionalData != null)
			{
				if (governanceRoleAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					governanceRoleAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governanceRoleAssignmentToUpdate.GetType().Name)
						});
				}
			}
            if (governanceRoleAssignmentToUpdate.AdditionalData != null)
            {
                if (governanceRoleAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    governanceRoleAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governanceRoleAssignmentToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<GovernanceRoleAssignment>(governanceRoleAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified GovernanceRoleAssignment using PATCH and returns a <see cref="GraphResponse{GovernanceRoleAssignment}"/> object.
        /// </summary>
        /// <param name="governanceRoleAssignmentToUpdate">The GovernanceRoleAssignment to update.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignment>> UpdateResponseAsync(GovernanceRoleAssignment governanceRoleAssignmentToUpdate)
        {
            return this.UpdateResponseAsync(governanceRoleAssignmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GovernanceRoleAssignment using PATCH and returns a <see cref="GraphResponse{GovernanceRoleAssignment}"/> object.
        /// </summary>
        /// <param name="governanceRoleAssignmentToUpdate">The GovernanceRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignment>> UpdateResponseAsync(GovernanceRoleAssignment governanceRoleAssignmentToUpdate, CancellationToken cancellationToken)
        {
			if (governanceRoleAssignmentToUpdate.AdditionalData != null)
			{
				if (governanceRoleAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					governanceRoleAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governanceRoleAssignmentToUpdate.GetType().Name)
						});
				}
			}
            if (governanceRoleAssignmentToUpdate.AdditionalData != null)
            {
                if (governanceRoleAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    governanceRoleAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, governanceRoleAssignmentToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<GovernanceRoleAssignment>(governanceRoleAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified GovernanceRoleAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GovernanceRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<GovernanceRoleAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified GovernanceRoleAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GovernanceRoleAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernanceRoleAssignmentWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernanceRoleAssignmentWithReferenceRequest Expand(Expression<Func<GovernanceRoleAssignment, object>> expandExpression)
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
        public IGovernanceRoleAssignmentWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGovernanceRoleAssignmentWithReferenceRequest Select(Expression<Func<GovernanceRoleAssignment, object>> selectExpression)
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

    }
}
