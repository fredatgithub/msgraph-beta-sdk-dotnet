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
    /// The type CustomerPaymentJournalRequest.
    /// </summary>
    public partial class CustomerPaymentJournalRequest : BaseRequest, ICustomerPaymentJournalRequest
    {
        /// <summary>
        /// Constructs a new CustomerPaymentJournalRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CustomerPaymentJournalRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CustomerPaymentJournal using POST.
        /// </summary>
        /// <param name="customerPaymentJournalToCreate">The CustomerPaymentJournal to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CustomerPaymentJournal.</returns>
        public async System.Threading.Tasks.Task<CustomerPaymentJournal> CreateAsync(CustomerPaymentJournal customerPaymentJournalToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<CustomerPaymentJournal>(customerPaymentJournalToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified CustomerPaymentJournal using POST and returns a <see cref="GraphResponse{CustomerPaymentJournal}"/> object.
        /// </summary>
        /// <param name="customerPaymentJournalToCreate">The CustomerPaymentJournal to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CustomerPaymentJournal}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CustomerPaymentJournal>> CreateResponseAsync(CustomerPaymentJournal customerPaymentJournalToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<CustomerPaymentJournal>(customerPaymentJournalToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified CustomerPaymentJournal.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<CustomerPaymentJournal>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CustomerPaymentJournal and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified CustomerPaymentJournal.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CustomerPaymentJournal.</returns>
        public async System.Threading.Tasks.Task<CustomerPaymentJournal> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<CustomerPaymentJournal>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified CustomerPaymentJournal and returns a <see cref="GraphResponse{CustomerPaymentJournal}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CustomerPaymentJournal}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CustomerPaymentJournal>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<CustomerPaymentJournal>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CustomerPaymentJournal using PATCH.
        /// </summary>
        /// <param name="customerPaymentJournalToUpdate">The CustomerPaymentJournal to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CustomerPaymentJournal.</returns>
        public async System.Threading.Tasks.Task<CustomerPaymentJournal> UpdateAsync(CustomerPaymentJournal customerPaymentJournalToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<CustomerPaymentJournal>(customerPaymentJournalToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CustomerPaymentJournal using PATCH and returns a <see cref="GraphResponse{CustomerPaymentJournal}"/> object.
        /// </summary>
        /// <param name="customerPaymentJournalToUpdate">The CustomerPaymentJournal to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CustomerPaymentJournal}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CustomerPaymentJournal>> UpdateResponseAsync(CustomerPaymentJournal customerPaymentJournalToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<CustomerPaymentJournal>(customerPaymentJournalToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICustomerPaymentJournalRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICustomerPaymentJournalRequest Expand(Expression<Func<CustomerPaymentJournal, object>> expandExpression)
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
        public ICustomerPaymentJournalRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICustomerPaymentJournalRequest Select(Expression<Func<CustomerPaymentJournal, object>> selectExpression)
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
        /// <param name="customerPaymentJournalToInitialize">The <see cref="CustomerPaymentJournal"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CustomerPaymentJournal customerPaymentJournalToInitialize)
        {

            if (customerPaymentJournalToInitialize != null && customerPaymentJournalToInitialize.AdditionalData != null)
            {

                if (customerPaymentJournalToInitialize.CustomerPayments != null && customerPaymentJournalToInitialize.CustomerPayments.CurrentPage != null)
                {
                    customerPaymentJournalToInitialize.CustomerPayments.AdditionalData = customerPaymentJournalToInitialize.AdditionalData;

                    object nextPageLink;
                    customerPaymentJournalToInitialize.AdditionalData.TryGetValue("customerPayments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        customerPaymentJournalToInitialize.CustomerPayments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
