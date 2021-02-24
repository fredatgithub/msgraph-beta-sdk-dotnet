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
    /// The type ProfileRequest.
    /// </summary>
    public partial class ProfileRequest : BaseRequest, IProfileRequest
    {
        /// <summary>
        /// Constructs a new ProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Profile using POST.
        /// </summary>
        /// <param name="profileToCreate">The Profile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Profile.</returns>
        public async System.Threading.Tasks.Task<Profile> CreateAsync(Profile profileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<Profile>(profileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Profile using POST and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="profileToCreate">The Profile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Profile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Profile>> CreateResponseAsync(Profile profileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<Profile>(profileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Profile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<Profile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Profile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Profile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Profile.</returns>
        public async System.Threading.Tasks.Task<Profile> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<Profile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Profile and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Profile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Profile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<Profile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Profile using PATCH.
        /// </summary>
        /// <param name="profileToUpdate">The Profile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Profile.</returns>
        public async System.Threading.Tasks.Task<Profile> UpdateAsync(Profile profileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<Profile>(profileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Profile using PATCH and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="profileToUpdate">The Profile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Profile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Profile>> UpdateResponseAsync(Profile profileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<Profile>(profileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IProfileRequest Expand(Expression<Func<Profile, object>> expandExpression)
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
        public IProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IProfileRequest Select(Expression<Func<Profile, object>> selectExpression)
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
        /// <param name="profileToInitialize">The <see cref="Profile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Profile profileToInitialize)
        {

            if (profileToInitialize != null && profileToInitialize.AdditionalData != null)
            {

                if (profileToInitialize.Account != null && profileToInitialize.Account.CurrentPage != null)
                {
                    profileToInitialize.Account.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("account@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Account.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Addresses != null && profileToInitialize.Addresses.CurrentPage != null)
                {
                    profileToInitialize.Addresses.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("addresses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Addresses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Anniversaries != null && profileToInitialize.Anniversaries.CurrentPage != null)
                {
                    profileToInitialize.Anniversaries.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("anniversaries@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Anniversaries.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Awards != null && profileToInitialize.Awards.CurrentPage != null)
                {
                    profileToInitialize.Awards.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("awards@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Awards.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Certifications != null && profileToInitialize.Certifications.CurrentPage != null)
                {
                    profileToInitialize.Certifications.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("certifications@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Certifications.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.EducationalActivities != null && profileToInitialize.EducationalActivities.CurrentPage != null)
                {
                    profileToInitialize.EducationalActivities.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("educationalActivities@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.EducationalActivities.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Emails != null && profileToInitialize.Emails.CurrentPage != null)
                {
                    profileToInitialize.Emails.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("emails@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Emails.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Interests != null && profileToInitialize.Interests.CurrentPage != null)
                {
                    profileToInitialize.Interests.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("interests@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Interests.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Languages != null && profileToInitialize.Languages.CurrentPage != null)
                {
                    profileToInitialize.Languages.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("languages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Languages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Names != null && profileToInitialize.Names.CurrentPage != null)
                {
                    profileToInitialize.Names.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("names@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Names.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Notes != null && profileToInitialize.Notes.CurrentPage != null)
                {
                    profileToInitialize.Notes.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("notes@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Notes.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Patents != null && profileToInitialize.Patents.CurrentPage != null)
                {
                    profileToInitialize.Patents.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("patents@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Patents.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Phones != null && profileToInitialize.Phones.CurrentPage != null)
                {
                    profileToInitialize.Phones.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("phones@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Phones.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Positions != null && profileToInitialize.Positions.CurrentPage != null)
                {
                    profileToInitialize.Positions.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("positions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Positions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Projects != null && profileToInitialize.Projects.CurrentPage != null)
                {
                    profileToInitialize.Projects.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("projects@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Projects.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Publications != null && profileToInitialize.Publications.CurrentPage != null)
                {
                    profileToInitialize.Publications.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("publications@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Publications.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Skills != null && profileToInitialize.Skills.CurrentPage != null)
                {
                    profileToInitialize.Skills.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("skills@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Skills.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.WebAccounts != null && profileToInitialize.WebAccounts.CurrentPage != null)
                {
                    profileToInitialize.WebAccounts.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("webAccounts@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.WebAccounts.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (profileToInitialize.Websites != null && profileToInitialize.Websites.CurrentPage != null)
                {
                    profileToInitialize.Websites.AdditionalData = profileToInitialize.AdditionalData;

                    object nextPageLink;
                    profileToInitialize.AdditionalData.TryGetValue("websites@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        profileToInitialize.Websites.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
