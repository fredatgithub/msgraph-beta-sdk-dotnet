// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICompanyInformationRequest.
    /// </summary>
    public partial interface ICompanyInformationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CompanyInformation using POST.
        /// </summary>
        /// <param name="companyInformationToCreate">The CompanyInformation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CompanyInformation.</returns>
        System.Threading.Tasks.Task<CompanyInformation> CreateAsync(CompanyInformation companyInformationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified CompanyInformation using POST and returns a <see cref="GraphResponse{CompanyInformation}"/> object.
        /// </summary>
        /// <param name="companyInformationToCreate">The CompanyInformation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CompanyInformation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CompanyInformation>> CreateResponseAsync(CompanyInformation companyInformationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CompanyInformation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CompanyInformation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified CompanyInformation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CompanyInformation.</returns>
        System.Threading.Tasks.Task<CompanyInformation> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified CompanyInformation and returns a <see cref="GraphResponse{CompanyInformation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CompanyInformation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CompanyInformation>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified CompanyInformation using PATCH.
        /// </summary>
        /// <param name="companyInformationToUpdate">The CompanyInformation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CompanyInformation.</returns>
        System.Threading.Tasks.Task<CompanyInformation> UpdateAsync(CompanyInformation companyInformationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified CompanyInformation using PATCH and returns a <see cref="GraphResponse{CompanyInformation}"/> object.
        /// </summary>
        /// <param name="companyInformationToUpdate">The CompanyInformation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CompanyInformation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CompanyInformation>> UpdateResponseAsync(CompanyInformation companyInformationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyInformationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyInformationRequest Expand(Expression<Func<CompanyInformation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyInformationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyInformationRequest Select(Expression<Func<CompanyInformation, object>> selectExpression);

    }
}
