// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type TermWithReferenceRequest.
    /// </summary>
    public partial class TermWithReferenceRequest : Microsoft.Graph.BaseRequest, ITermWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new TermWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TermWithReferenceRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified Term.
        /// </summary>
        /// <returns>The Term.</returns>
        public System.Threading.Tasks.Task<Term> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Term.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Term.</returns>
        public async System.Threading.Tasks.Task<Term> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Term>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Term and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Term>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Term and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Term>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<Term>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Creates the specified Term using POST.
        /// </summary>
        /// <param name="termToCreate">The Term to create.</param>
        /// <returns>The created Term.</returns>
        public System.Threading.Tasks.Task<Term> CreateAsync(Term termToCreate)
        {
            return this.CreateAsync(termToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Term using POST.
        /// </summary>
        /// <param name="termToCreate">The Term to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Term.</returns>
        public async System.Threading.Tasks.Task<Term> CreateAsync(Term termToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Term>(termToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified Term using POST and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <param name="termToCreate">The Term to create.</param>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Term>> CreateResponseAsync(Term termToCreate)
        {
            return this.CreateResponseAsync(termToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Term using POST and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <param name="termToCreate">The Term to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Term>> CreateResponseAsync(Term termToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Term>(termToCreate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Updates the specified Term using PATCH.
        /// </summary>
        /// <param name="termToUpdate">The Term to update.</param>
        /// <returns>The updated Term.</returns>
        public System.Threading.Tasks.Task<Term> UpdateAsync(Term termToUpdate)
        {
            return this.UpdateAsync(termToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Term using PATCH.
        /// </summary>
        /// <param name="termToUpdate">The Term to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Term.</returns>
        public async System.Threading.Tasks.Task<Term> UpdateAsync(Term termToUpdate, CancellationToken cancellationToken)
        {
			if (termToUpdate.AdditionalData != null)
			{
				if (termToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
					termToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
				{
					throw new Microsoft.Graph.ClientException(
						new Microsoft.Graph.Error
						{
							Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, termToUpdate.GetType().Name)
						});
				}
			}
            if (termToUpdate.AdditionalData != null)
            {
                if (termToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
                    termToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
                {
                    throw new Microsoft.Graph.ClientException(
                        new Microsoft.Graph.Error
                        {
                            Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, termToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Term>(termToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified Term using PATCH and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <param name="termToUpdate">The Term to update.</param>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Term>> UpdateResponseAsync(Term termToUpdate)
        {
            return this.UpdateResponseAsync(termToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Term using PATCH and returns a <see cref="GraphResponse{Term}"/> object.
        /// </summary>
        /// <param name="termToUpdate">The Term to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Term}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Term>> UpdateResponseAsync(Term termToUpdate, CancellationToken cancellationToken)
        {
			if (termToUpdate.AdditionalData != null)
			{
				if (termToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
					termToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
				{
					throw new Microsoft.Graph.ClientException(
						new Microsoft.Graph.Error
						{
							Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, termToUpdate.GetType().Name)
						});
				}
			}
            if (termToUpdate.AdditionalData != null)
            {
                if (termToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
                    termToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
                {
                    throw new Microsoft.Graph.ClientException(
                        new Microsoft.Graph.Error
                        {
                            Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, termToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<Term>(termToUpdate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified Term.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Term.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Term>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified Term and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Term and returns a <see cref="GraphResponse"/> object.
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
        public ITermWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITermWithReferenceRequest Expand(Expression<Func<Term, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ITermWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITermWithReferenceRequest Select(Expression<Func<Term, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

    }
}
