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
    /// The type AdvancedThreatProtectionOnboardingStateSummaryRequest.
    /// </summary>
    public partial class AdvancedThreatProtectionOnboardingStateSummaryRequest : BaseRequest, IAdvancedThreatProtectionOnboardingStateSummaryRequest
    {
        /// <summary>
        /// Constructs a new AdvancedThreatProtectionOnboardingStateSummaryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AdvancedThreatProtectionOnboardingStateSummaryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AdvancedThreatProtectionOnboardingStateSummary using POST.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToCreate">The AdvancedThreatProtectionOnboardingStateSummary to create.</param>
        /// <returns>The created AdvancedThreatProtectionOnboardingStateSummary.</returns>
        public System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> CreateAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToCreate)
        {
            return this.CreateAsync(advancedThreatProtectionOnboardingStateSummaryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AdvancedThreatProtectionOnboardingStateSummary using POST.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToCreate">The AdvancedThreatProtectionOnboardingStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AdvancedThreatProtectionOnboardingStateSummary.</returns>
        public async System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> CreateAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AdvancedThreatProtectionOnboardingStateSummary>(advancedThreatProtectionOnboardingStateSummaryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified AdvancedThreatProtectionOnboardingStateSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AdvancedThreatProtectionOnboardingStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AdvancedThreatProtectionOnboardingStateSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AdvancedThreatProtectionOnboardingStateSummary.
        /// </summary>
        /// <returns>The AdvancedThreatProtectionOnboardingStateSummary.</returns>
        public System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AdvancedThreatProtectionOnboardingStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AdvancedThreatProtectionOnboardingStateSummary.</returns>
        public async System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AdvancedThreatProtectionOnboardingStateSummary>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingStateSummary using PATCH.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToUpdate">The AdvancedThreatProtectionOnboardingStateSummary to update.</param>
        /// <returns>The updated AdvancedThreatProtectionOnboardingStateSummary.</returns>
        public System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> UpdateAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToUpdate)
        {
            return this.UpdateAsync(advancedThreatProtectionOnboardingStateSummaryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingStateSummary using PATCH.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToUpdate">The AdvancedThreatProtectionOnboardingStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AdvancedThreatProtectionOnboardingStateSummary.</returns>
        public async System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> UpdateAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AdvancedThreatProtectionOnboardingStateSummary>(advancedThreatProtectionOnboardingStateSummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAdvancedThreatProtectionOnboardingStateSummaryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAdvancedThreatProtectionOnboardingStateSummaryRequest Expand(Expression<Func<AdvancedThreatProtectionOnboardingStateSummary, object>> expandExpression)
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
        public IAdvancedThreatProtectionOnboardingStateSummaryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAdvancedThreatProtectionOnboardingStateSummaryRequest Select(Expression<Func<AdvancedThreatProtectionOnboardingStateSummary, object>> selectExpression)
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
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToInitialize">The <see cref="AdvancedThreatProtectionOnboardingStateSummary"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToInitialize)
        {

            if (advancedThreatProtectionOnboardingStateSummaryToInitialize != null && advancedThreatProtectionOnboardingStateSummaryToInitialize.AdditionalData != null)
            {

                if (advancedThreatProtectionOnboardingStateSummaryToInitialize.AdvancedThreatProtectionOnboardingDeviceSettingStates != null && advancedThreatProtectionOnboardingStateSummaryToInitialize.AdvancedThreatProtectionOnboardingDeviceSettingStates.CurrentPage != null)
                {
                    advancedThreatProtectionOnboardingStateSummaryToInitialize.AdvancedThreatProtectionOnboardingDeviceSettingStates.AdditionalData = advancedThreatProtectionOnboardingStateSummaryToInitialize.AdditionalData;

                    object nextPageLink;
                    advancedThreatProtectionOnboardingStateSummaryToInitialize.AdditionalData.TryGetValue("advancedThreatProtectionOnboardingDeviceSettingStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        advancedThreatProtectionOnboardingStateSummaryToInitialize.AdvancedThreatProtectionOnboardingDeviceSettingStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}