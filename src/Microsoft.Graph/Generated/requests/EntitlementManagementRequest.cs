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
    /// The type EntitlementManagementRequest.
    /// </summary>
    public partial class EntitlementManagementRequest : BaseRequest, IEntitlementManagementRequest
    {
        /// <summary>
        /// Constructs a new EntitlementManagementRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EntitlementManagementRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EntitlementManagement using POST.
        /// </summary>
        /// <param name="entitlementManagementToCreate">The EntitlementManagement to create.</param>
        /// <returns>The created EntitlementManagement.</returns>
        public System.Threading.Tasks.Task<EntitlementManagement> CreateAsync(EntitlementManagement entitlementManagementToCreate)
        {
            return this.CreateAsync(entitlementManagementToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EntitlementManagement using POST.
        /// </summary>
        /// <param name="entitlementManagementToCreate">The EntitlementManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EntitlementManagement.</returns>
        public async System.Threading.Tasks.Task<EntitlementManagement> CreateAsync(EntitlementManagement entitlementManagementToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EntitlementManagement>(entitlementManagementToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EntitlementManagement using POST and returns a <see cref="GraphResponse{EntitlementManagement}"/> object.
        /// </summary>
        /// <param name="entitlementManagementToCreate">The EntitlementManagement to create.</param>
        /// <returns>The <see cref="GraphResponse{EntitlementManagement}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EntitlementManagement>> CreateResponseAsync(EntitlementManagement entitlementManagementToCreate)
        {
            return this.CreateResponseAsync(entitlementManagementToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EntitlementManagement using POST and returns a <see cref="GraphResponse{EntitlementManagement}"/> object.
        /// </summary>
        /// <param name="entitlementManagementToCreate">The EntitlementManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EntitlementManagement}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EntitlementManagement>> CreateResponseAsync(EntitlementManagement entitlementManagementToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<EntitlementManagement>(entitlementManagementToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EntitlementManagement.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EntitlementManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EntitlementManagement>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EntitlementManagement and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EntitlementManagement and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EntitlementManagement.
        /// </summary>
        /// <returns>The EntitlementManagement.</returns>
        public System.Threading.Tasks.Task<EntitlementManagement> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EntitlementManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EntitlementManagement.</returns>
        public async System.Threading.Tasks.Task<EntitlementManagement> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EntitlementManagement>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EntitlementManagement and returns a <see cref="GraphResponse{EntitlementManagement}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{EntitlementManagement}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EntitlementManagement>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EntitlementManagement and returns a <see cref="GraphResponse{EntitlementManagement}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EntitlementManagement}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EntitlementManagement>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<EntitlementManagement>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified EntitlementManagement using PATCH.
        /// </summary>
        /// <param name="entitlementManagementToUpdate">The EntitlementManagement to update.</param>
        /// <returns>The updated EntitlementManagement.</returns>
        public System.Threading.Tasks.Task<EntitlementManagement> UpdateAsync(EntitlementManagement entitlementManagementToUpdate)
        {
            return this.UpdateAsync(entitlementManagementToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EntitlementManagement using PATCH.
        /// </summary>
        /// <param name="entitlementManagementToUpdate">The EntitlementManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EntitlementManagement.</returns>
        public async System.Threading.Tasks.Task<EntitlementManagement> UpdateAsync(EntitlementManagement entitlementManagementToUpdate, CancellationToken cancellationToken)
        {
			if (entitlementManagementToUpdate.AdditionalData != null)
			{
				if (entitlementManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					entitlementManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, entitlementManagementToUpdate.GetType().Name)
						});
				}
			}
            if (entitlementManagementToUpdate.AdditionalData != null)
            {
                if (entitlementManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    entitlementManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, entitlementManagementToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EntitlementManagement>(entitlementManagementToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EntitlementManagement using PATCH and returns a <see cref="GraphResponse{EntitlementManagement}"/> object.
        /// </summary>
        /// <param name="entitlementManagementToUpdate">The EntitlementManagement to update.</param>
        /// <returns>The <see cref="GraphResponse{EntitlementManagement}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EntitlementManagement>> UpdateResponseAsync(EntitlementManagement entitlementManagementToUpdate)
        {
            return this.UpdateResponseAsync(entitlementManagementToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EntitlementManagement using PATCH and returns a <see cref="GraphResponse{EntitlementManagement}"/> object.
        /// </summary>
        /// <param name="entitlementManagementToUpdate">The EntitlementManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EntitlementManagement}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EntitlementManagement>> UpdateResponseAsync(EntitlementManagement entitlementManagementToUpdate, CancellationToken cancellationToken)
        {
			if (entitlementManagementToUpdate.AdditionalData != null)
			{
				if (entitlementManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					entitlementManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, entitlementManagementToUpdate.GetType().Name)
						});
				}
			}
            if (entitlementManagementToUpdate.AdditionalData != null)
            {
                if (entitlementManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    entitlementManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, entitlementManagementToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<EntitlementManagement>(entitlementManagementToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEntitlementManagementRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEntitlementManagementRequest Expand(Expression<Func<EntitlementManagement, object>> expandExpression)
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
        public IEntitlementManagementRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEntitlementManagementRequest Select(Expression<Func<EntitlementManagement, object>> selectExpression)
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
        /// <param name="entitlementManagementToInitialize">The <see cref="EntitlementManagement"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EntitlementManagement entitlementManagementToInitialize)
        {

            if (entitlementManagementToInitialize != null && entitlementManagementToInitialize.AdditionalData != null)
            {

                if (entitlementManagementToInitialize.AccessPackageAssignmentPolicies != null && entitlementManagementToInitialize.AccessPackageAssignmentPolicies.CurrentPage != null)
                {
                    entitlementManagementToInitialize.AccessPackageAssignmentPolicies.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("accessPackageAssignmentPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.AccessPackageAssignmentPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (entitlementManagementToInitialize.AccessPackageAssignmentRequests != null && entitlementManagementToInitialize.AccessPackageAssignmentRequests.CurrentPage != null)
                {
                    entitlementManagementToInitialize.AccessPackageAssignmentRequests.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("accessPackageAssignmentRequests@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.AccessPackageAssignmentRequests.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (entitlementManagementToInitialize.AccessPackageAssignmentResourceRoles != null && entitlementManagementToInitialize.AccessPackageAssignmentResourceRoles.CurrentPage != null)
                {
                    entitlementManagementToInitialize.AccessPackageAssignmentResourceRoles.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("accessPackageAssignmentResourceRoles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.AccessPackageAssignmentResourceRoles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (entitlementManagementToInitialize.AccessPackageAssignments != null && entitlementManagementToInitialize.AccessPackageAssignments.CurrentPage != null)
                {
                    entitlementManagementToInitialize.AccessPackageAssignments.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("accessPackageAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.AccessPackageAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (entitlementManagementToInitialize.AccessPackageCatalogs != null && entitlementManagementToInitialize.AccessPackageCatalogs.CurrentPage != null)
                {
                    entitlementManagementToInitialize.AccessPackageCatalogs.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("accessPackageCatalogs@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.AccessPackageCatalogs.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (entitlementManagementToInitialize.AccessPackageResourceEnvironments != null && entitlementManagementToInitialize.AccessPackageResourceEnvironments.CurrentPage != null)
                {
                    entitlementManagementToInitialize.AccessPackageResourceEnvironments.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("accessPackageResourceEnvironments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.AccessPackageResourceEnvironments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (entitlementManagementToInitialize.AccessPackageResourceRequests != null && entitlementManagementToInitialize.AccessPackageResourceRequests.CurrentPage != null)
                {
                    entitlementManagementToInitialize.AccessPackageResourceRequests.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("accessPackageResourceRequests@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.AccessPackageResourceRequests.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (entitlementManagementToInitialize.AccessPackageResourceRoleScopes != null && entitlementManagementToInitialize.AccessPackageResourceRoleScopes.CurrentPage != null)
                {
                    entitlementManagementToInitialize.AccessPackageResourceRoleScopes.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("accessPackageResourceRoleScopes@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.AccessPackageResourceRoleScopes.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (entitlementManagementToInitialize.AccessPackageResources != null && entitlementManagementToInitialize.AccessPackageResources.CurrentPage != null)
                {
                    entitlementManagementToInitialize.AccessPackageResources.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("accessPackageResources@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.AccessPackageResources.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (entitlementManagementToInitialize.AccessPackages != null && entitlementManagementToInitialize.AccessPackages.CurrentPage != null)
                {
                    entitlementManagementToInitialize.AccessPackages.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("accessPackages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.AccessPackages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (entitlementManagementToInitialize.ConnectedOrganizations != null && entitlementManagementToInitialize.ConnectedOrganizations.CurrentPage != null)
                {
                    entitlementManagementToInitialize.ConnectedOrganizations.AdditionalData = entitlementManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    entitlementManagementToInitialize.AdditionalData.TryGetValue("connectedOrganizations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        entitlementManagementToInitialize.ConnectedOrganizations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
