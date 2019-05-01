// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IBookingCurrencyRequest.
    /// </summary>
    public partial interface IBookingCurrencyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BookingCurrency using PUT.
        /// </summary>
        /// <param name="bookingCurrencyToCreate">The BookingCurrency to create.</param>
        /// <returns>The created BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> CreateAsync(BookingCurrency bookingCurrencyToCreate);        /// <summary>
        /// Creates the specified BookingCurrency using PUT.
        /// </summary>
        /// <param name="bookingCurrencyToCreate">The BookingCurrency to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> CreateAsync(BookingCurrency bookingCurrencyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified BookingCurrency.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified BookingCurrency.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified BookingCurrency.
        /// </summary>
        /// <returns>The BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> GetAsync();

        /// <summary>
        /// Gets the specified BookingCurrency.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified BookingCurrency using PATCH.
        /// </summary>
        /// <param name="bookingCurrencyToUpdate">The BookingCurrency to update.</param>
        /// <returns>The updated BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> UpdateAsync(BookingCurrency bookingCurrencyToUpdate);

        /// <summary>
        /// Updates the specified BookingCurrency using PATCH.
        /// </summary>
        /// <param name="bookingCurrencyToUpdate">The BookingCurrency to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> UpdateAsync(BookingCurrency bookingCurrencyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingCurrencyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingCurrencyRequest Expand(Expression<Func<BookingCurrency, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingCurrencyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingCurrencyRequest Select(Expression<Func<BookingCurrency, object>> selectExpression);

    }
}