// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type PasswordAuthenticationMethodRequest.
    /// </summary>
    public partial class PasswordAuthenticationMethodRequest : BaseRequest, IPasswordAuthenticationMethodRequest
    {
        /// <summary>
        /// Constructs a new PasswordAuthenticationMethodRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PasswordAuthenticationMethodRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PasswordAuthenticationMethod using POST.
        /// </summary>
        /// <param name="passwordAuthenticationMethodToCreate">The PasswordAuthenticationMethod to create.</param>
        /// <returns>The created PasswordAuthenticationMethod.</returns>
        public System.Threading.Tasks.Task<PasswordAuthenticationMethod> CreateAsync(PasswordAuthenticationMethod passwordAuthenticationMethodToCreate)
        {
            return this.CreateAsync(passwordAuthenticationMethodToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PasswordAuthenticationMethod using POST.
        /// </summary>
        /// <param name="passwordAuthenticationMethodToCreate">The PasswordAuthenticationMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PasswordAuthenticationMethod.</returns>
        public async System.Threading.Tasks.Task<PasswordAuthenticationMethod> CreateAsync(PasswordAuthenticationMethod passwordAuthenticationMethodToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<PasswordAuthenticationMethod>(passwordAuthenticationMethodToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified PasswordAuthenticationMethod.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PasswordAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<PasswordAuthenticationMethod>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified PasswordAuthenticationMethod.
        /// </summary>
        /// <returns>The PasswordAuthenticationMethod.</returns>
        public System.Threading.Tasks.Task<PasswordAuthenticationMethod> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PasswordAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PasswordAuthenticationMethod.</returns>
        public async System.Threading.Tasks.Task<PasswordAuthenticationMethod> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<PasswordAuthenticationMethod>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified PasswordAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="passwordAuthenticationMethodToUpdate">The PasswordAuthenticationMethod to update.</param>
        /// <returns>The updated PasswordAuthenticationMethod.</returns>
        public System.Threading.Tasks.Task<PasswordAuthenticationMethod> UpdateAsync(PasswordAuthenticationMethod passwordAuthenticationMethodToUpdate)
        {
            return this.UpdateAsync(passwordAuthenticationMethodToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PasswordAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="passwordAuthenticationMethodToUpdate">The PasswordAuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PasswordAuthenticationMethod.</returns>
        public async System.Threading.Tasks.Task<PasswordAuthenticationMethod> UpdateAsync(PasswordAuthenticationMethod passwordAuthenticationMethodToUpdate, CancellationToken cancellationToken)
        {
			if (passwordAuthenticationMethodToUpdate.AdditionalData != null)
			{
				if (passwordAuthenticationMethodToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					passwordAuthenticationMethodToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, passwordAuthenticationMethodToUpdate.GetType().Name)
						});
				}
			}
            if (passwordAuthenticationMethodToUpdate.AdditionalData != null)
            {
                if (passwordAuthenticationMethodToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    passwordAuthenticationMethodToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, passwordAuthenticationMethodToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<PasswordAuthenticationMethod>(passwordAuthenticationMethodToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPasswordAuthenticationMethodRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPasswordAuthenticationMethodRequest Expand(Expression<Func<PasswordAuthenticationMethod, object>> expandExpression)
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
        public IPasswordAuthenticationMethodRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPasswordAuthenticationMethodRequest Select(Expression<Func<PasswordAuthenticationMethod, object>> selectExpression)
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
        /// <param name="passwordAuthenticationMethodToInitialize">The <see cref="PasswordAuthenticationMethod"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PasswordAuthenticationMethod passwordAuthenticationMethodToInitialize)
        {

        }
    }
}