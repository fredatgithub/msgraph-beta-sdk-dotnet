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
    /// The interface IEmployeeRequest.
    /// </summary>
    public partial interface IEmployeeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Employee using POST.
        /// </summary>
        /// <param name="employeeToCreate">The Employee to create.</param>
        /// <returns>The created Employee.</returns>
        System.Threading.Tasks.Task<Employee> CreateAsync(Employee employeeToCreate);

        /// <summary>
        /// Creates the specified Employee using POST.
        /// </summary>
        /// <param name="employeeToCreate">The Employee to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Employee.</returns>
        System.Threading.Tasks.Task<Employee> CreateAsync(Employee employeeToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Employee using POST and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <param name="employeeToCreate">The Employee to create.</param>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Employee>> CreateResponseAsync(Employee employeeToCreate);

        /// <summary>
        /// Creates the specified Employee using POST and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <param name="employeeToCreate">The Employee to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Employee>> CreateResponseAsync(Employee employeeToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Employee.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Employee.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Employee and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Employee and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Employee.
        /// </summary>
        /// <returns>The Employee.</returns>
        System.Threading.Tasks.Task<Employee> GetAsync();

        /// <summary>
        /// Gets the specified Employee.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Employee.</returns>
        System.Threading.Tasks.Task<Employee> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Employee and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Employee>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Employee and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Employee>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Employee using PATCH.
        /// </summary>
        /// <param name="employeeToUpdate">The Employee to update.</param>
        /// <returns>The updated Employee.</returns>
        System.Threading.Tasks.Task<Employee> UpdateAsync(Employee employeeToUpdate);

        /// <summary>
        /// Updates the specified Employee using PATCH.
        /// </summary>
        /// <param name="employeeToUpdate">The Employee to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Employee.</returns>
        System.Threading.Tasks.Task<Employee> UpdateAsync(Employee employeeToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Employee using PATCH and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <param name="employeeToUpdate">The Employee to update.</param>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Employee>> UpdateResponseAsync(Employee employeeToUpdate);

        /// <summary>
        /// Updates the specified Employee using PATCH and returns a <see cref="GraphResponse{Employee}"/> object.
        /// </summary>
        /// <param name="employeeToUpdate">The Employee to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Employee}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Employee>> UpdateResponseAsync(Employee employeeToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmployeeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmployeeRequest Expand(Expression<Func<Employee, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEmployeeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEmployeeRequest Select(Expression<Func<Employee, object>> selectExpression);

    }
}
