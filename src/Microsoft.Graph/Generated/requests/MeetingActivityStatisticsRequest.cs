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
    /// The type MeetingActivityStatisticsRequest.
    /// </summary>
    public partial class MeetingActivityStatisticsRequest : BaseRequest, IMeetingActivityStatisticsRequest
    {
        /// <summary>
        /// Constructs a new MeetingActivityStatisticsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MeetingActivityStatisticsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MeetingActivityStatistics using POST.
        /// </summary>
        /// <param name="meetingActivityStatisticsToCreate">The MeetingActivityStatistics to create.</param>
        /// <returns>The created MeetingActivityStatistics.</returns>
        public System.Threading.Tasks.Task<MeetingActivityStatistics> CreateAsync(MeetingActivityStatistics meetingActivityStatisticsToCreate)
        {
            return this.CreateAsync(meetingActivityStatisticsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MeetingActivityStatistics using POST.
        /// </summary>
        /// <param name="meetingActivityStatisticsToCreate">The MeetingActivityStatistics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MeetingActivityStatistics.</returns>
        public async System.Threading.Tasks.Task<MeetingActivityStatistics> CreateAsync(MeetingActivityStatistics meetingActivityStatisticsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MeetingActivityStatistics>(meetingActivityStatisticsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MeetingActivityStatistics using POST and returns a <see cref="GraphResponse{MeetingActivityStatistics}"/> object.
        /// </summary>
        /// <param name="meetingActivityStatisticsToCreate">The MeetingActivityStatistics to create.</param>
        /// <returns>The <see cref="GraphResponse{MeetingActivityStatistics}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MeetingActivityStatistics>> CreateResponseAsync(MeetingActivityStatistics meetingActivityStatisticsToCreate)
        {
            return this.CreateResponseAsync(meetingActivityStatisticsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MeetingActivityStatistics using POST and returns a <see cref="GraphResponse{MeetingActivityStatistics}"/> object.
        /// </summary>
        /// <param name="meetingActivityStatisticsToCreate">The MeetingActivityStatistics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MeetingActivityStatistics}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MeetingActivityStatistics>> CreateResponseAsync(MeetingActivityStatistics meetingActivityStatisticsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MeetingActivityStatistics>(meetingActivityStatisticsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MeetingActivityStatistics.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MeetingActivityStatistics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MeetingActivityStatistics>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MeetingActivityStatistics and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MeetingActivityStatistics and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MeetingActivityStatistics.
        /// </summary>
        /// <returns>The MeetingActivityStatistics.</returns>
        public System.Threading.Tasks.Task<MeetingActivityStatistics> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MeetingActivityStatistics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MeetingActivityStatistics.</returns>
        public async System.Threading.Tasks.Task<MeetingActivityStatistics> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MeetingActivityStatistics>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MeetingActivityStatistics and returns a <see cref="GraphResponse{MeetingActivityStatistics}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MeetingActivityStatistics}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MeetingActivityStatistics>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MeetingActivityStatistics and returns a <see cref="GraphResponse{MeetingActivityStatistics}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MeetingActivityStatistics}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MeetingActivityStatistics>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<MeetingActivityStatistics>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified MeetingActivityStatistics using PATCH.
        /// </summary>
        /// <param name="meetingActivityStatisticsToUpdate">The MeetingActivityStatistics to update.</param>
        /// <returns>The updated MeetingActivityStatistics.</returns>
        public System.Threading.Tasks.Task<MeetingActivityStatistics> UpdateAsync(MeetingActivityStatistics meetingActivityStatisticsToUpdate)
        {
            return this.UpdateAsync(meetingActivityStatisticsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MeetingActivityStatistics using PATCH.
        /// </summary>
        /// <param name="meetingActivityStatisticsToUpdate">The MeetingActivityStatistics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MeetingActivityStatistics.</returns>
        public async System.Threading.Tasks.Task<MeetingActivityStatistics> UpdateAsync(MeetingActivityStatistics meetingActivityStatisticsToUpdate, CancellationToken cancellationToken)
        {
			if (meetingActivityStatisticsToUpdate.AdditionalData != null)
			{
				if (meetingActivityStatisticsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					meetingActivityStatisticsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, meetingActivityStatisticsToUpdate.GetType().Name)
						});
				}
			}
            if (meetingActivityStatisticsToUpdate.AdditionalData != null)
            {
                if (meetingActivityStatisticsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    meetingActivityStatisticsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, meetingActivityStatisticsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MeetingActivityStatistics>(meetingActivityStatisticsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MeetingActivityStatistics using PATCH and returns a <see cref="GraphResponse{MeetingActivityStatistics}"/> object.
        /// </summary>
        /// <param name="meetingActivityStatisticsToUpdate">The MeetingActivityStatistics to update.</param>
        /// <returns>The <see cref="GraphResponse{MeetingActivityStatistics}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MeetingActivityStatistics>> UpdateResponseAsync(MeetingActivityStatistics meetingActivityStatisticsToUpdate)
        {
            return this.UpdateResponseAsync(meetingActivityStatisticsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MeetingActivityStatistics using PATCH and returns a <see cref="GraphResponse{MeetingActivityStatistics}"/> object.
        /// </summary>
        /// <param name="meetingActivityStatisticsToUpdate">The MeetingActivityStatistics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MeetingActivityStatistics}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MeetingActivityStatistics>> UpdateResponseAsync(MeetingActivityStatistics meetingActivityStatisticsToUpdate, CancellationToken cancellationToken)
        {
			if (meetingActivityStatisticsToUpdate.AdditionalData != null)
			{
				if (meetingActivityStatisticsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					meetingActivityStatisticsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, meetingActivityStatisticsToUpdate.GetType().Name)
						});
				}
			}
            if (meetingActivityStatisticsToUpdate.AdditionalData != null)
            {
                if (meetingActivityStatisticsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    meetingActivityStatisticsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, meetingActivityStatisticsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MeetingActivityStatistics>(meetingActivityStatisticsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMeetingActivityStatisticsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMeetingActivityStatisticsRequest Expand(Expression<Func<MeetingActivityStatistics, object>> expandExpression)
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
        public IMeetingActivityStatisticsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMeetingActivityStatisticsRequest Select(Expression<Func<MeetingActivityStatistics, object>> selectExpression)
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
        /// <param name="meetingActivityStatisticsToInitialize">The <see cref="MeetingActivityStatistics"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MeetingActivityStatistics meetingActivityStatisticsToInitialize)
        {

        }
    }
}
