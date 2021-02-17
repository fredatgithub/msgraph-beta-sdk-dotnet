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
    /// The type PersonAnniversaryRequest.
    /// </summary>
    public partial class PersonAnniversaryRequest : BaseRequest, IPersonAnniversaryRequest
    {
        /// <summary>
        /// Constructs a new PersonAnniversaryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PersonAnniversaryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PersonAnniversary using POST.
        /// </summary>
        /// <param name="personAnniversaryToCreate">The PersonAnniversary to create.</param>
        /// <returns>The created PersonAnniversary.</returns>
        public System.Threading.Tasks.Task<PersonAnniversary> CreateAsync(PersonAnniversary personAnniversaryToCreate)
        {
            return this.CreateAsync(personAnniversaryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PersonAnniversary using POST.
        /// </summary>
        /// <param name="personAnniversaryToCreate">The PersonAnniversary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PersonAnniversary.</returns>
        public async System.Threading.Tasks.Task<PersonAnniversary> CreateAsync(PersonAnniversary personAnniversaryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<PersonAnniversary>(personAnniversaryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PersonAnniversary using POST and returns a <see cref="GraphResponse{PersonAnniversary}"/> object.
        /// </summary>
        /// <param name="personAnniversaryToCreate">The PersonAnniversary to create.</param>
        /// <returns>The <see cref="GraphResponse{PersonAnniversary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PersonAnniversary>> CreateResponseAsync(PersonAnniversary personAnniversaryToCreate)
        {
            return this.CreateResponseAsync(personAnniversaryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PersonAnniversary using POST and returns a <see cref="GraphResponse{PersonAnniversary}"/> object.
        /// </summary>
        /// <param name="personAnniversaryToCreate">The PersonAnniversary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PersonAnniversary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PersonAnniversary>> CreateResponseAsync(PersonAnniversary personAnniversaryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<PersonAnniversary>(personAnniversaryToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PersonAnniversary.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PersonAnniversary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<PersonAnniversary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PersonAnniversary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PersonAnniversary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified PersonAnniversary.
        /// </summary>
        /// <returns>The PersonAnniversary.</returns>
        public System.Threading.Tasks.Task<PersonAnniversary> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PersonAnniversary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PersonAnniversary.</returns>
        public async System.Threading.Tasks.Task<PersonAnniversary> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<PersonAnniversary>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PersonAnniversary and returns a <see cref="GraphResponse{PersonAnniversary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PersonAnniversary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PersonAnniversary>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PersonAnniversary and returns a <see cref="GraphResponse{PersonAnniversary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PersonAnniversary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PersonAnniversary>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<PersonAnniversary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified PersonAnniversary using PATCH.
        /// </summary>
        /// <param name="personAnniversaryToUpdate">The PersonAnniversary to update.</param>
        /// <returns>The updated PersonAnniversary.</returns>
        public System.Threading.Tasks.Task<PersonAnniversary> UpdateAsync(PersonAnniversary personAnniversaryToUpdate)
        {
            return this.UpdateAsync(personAnniversaryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PersonAnniversary using PATCH.
        /// </summary>
        /// <param name="personAnniversaryToUpdate">The PersonAnniversary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PersonAnniversary.</returns>
        public async System.Threading.Tasks.Task<PersonAnniversary> UpdateAsync(PersonAnniversary personAnniversaryToUpdate, CancellationToken cancellationToken)
        {
			if (personAnniversaryToUpdate.AdditionalData != null)
			{
				if (personAnniversaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					personAnniversaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, personAnniversaryToUpdate.GetType().Name)
						});
				}
			}
            if (personAnniversaryToUpdate.AdditionalData != null)
            {
                if (personAnniversaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    personAnniversaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, personAnniversaryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<PersonAnniversary>(personAnniversaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PersonAnniversary using PATCH and returns a <see cref="GraphResponse{PersonAnniversary}"/> object.
        /// </summary>
        /// <param name="personAnniversaryToUpdate">The PersonAnniversary to update.</param>
        /// <returns>The <see cref="GraphResponse{PersonAnniversary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PersonAnniversary>> UpdateResponseAsync(PersonAnniversary personAnniversaryToUpdate)
        {
            return this.UpdateResponseAsync(personAnniversaryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PersonAnniversary using PATCH and returns a <see cref="GraphResponse{PersonAnniversary}"/> object.
        /// </summary>
        /// <param name="personAnniversaryToUpdate">The PersonAnniversary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PersonAnniversary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PersonAnniversary>> UpdateResponseAsync(PersonAnniversary personAnniversaryToUpdate, CancellationToken cancellationToken)
        {
			if (personAnniversaryToUpdate.AdditionalData != null)
			{
				if (personAnniversaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					personAnniversaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, personAnniversaryToUpdate.GetType().Name)
						});
				}
			}
            if (personAnniversaryToUpdate.AdditionalData != null)
            {
                if (personAnniversaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    personAnniversaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, personAnniversaryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<PersonAnniversary>(personAnniversaryToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPersonAnniversaryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPersonAnniversaryRequest Expand(Expression<Func<PersonAnniversary, object>> expandExpression)
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
        public IPersonAnniversaryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPersonAnniversaryRequest Select(Expression<Func<PersonAnniversary, object>> selectExpression)
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
        /// <param name="personAnniversaryToInitialize">The <see cref="PersonAnniversary"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PersonAnniversary personAnniversaryToInitialize)
        {

        }
    }
}
