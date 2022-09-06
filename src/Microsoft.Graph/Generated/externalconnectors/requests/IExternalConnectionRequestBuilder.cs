// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IExternalConnectionRequestBuilder.
    /// </summary>
    public partial interface IExternalConnectionRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IExternalConnectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IExternalConnectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for Groups.
        /// </summary>
        /// <returns>The <see cref="IExternalConnectionGroupsCollectionRequestBuilder"/>.</returns>
        IExternalConnectionGroupsCollectionRequestBuilder Groups { get; }

        /// <summary>
        /// Gets the request builder for Items.
        /// </summary>
        /// <returns>The <see cref="IExternalConnectionItemsCollectionRequestBuilder"/>.</returns>
        IExternalConnectionItemsCollectionRequestBuilder Items { get; }

        /// <summary>
        /// Gets the request builder for Operations.
        /// </summary>
        /// <returns>The <see cref="IExternalConnectionOperationsCollectionRequestBuilder"/>.</returns>
        IExternalConnectionOperationsCollectionRequestBuilder Operations { get; }

        /// <summary>
        /// Gets the request builder for Quota.
        /// </summary>
        /// <returns>The <see cref="IConnectionQuotaRequestBuilder"/>.</returns>
        IConnectionQuotaRequestBuilder Quota { get; }

        /// <summary>
        /// Gets the request builder for Schema.
        /// </summary>
        /// <returns>The <see cref="ISchemaRequestBuilder"/>.</returns>
        ISchemaRequestBuilder Schema { get; }
    
    }
}
