// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface INoncustodialDataSourceRequestBuilder.
    /// </summary>
    public partial interface INoncustodialDataSourceRequestBuilder : IDataSourceContainerRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new INoncustodialDataSourceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new INoncustodialDataSourceRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for DataSource.
        /// </summary>
        /// <returns>The <see cref="IDataSourceRequestBuilder"/>.</returns>
        IDataSourceRequestBuilder DataSource { get; }
    
        /// <summary>
        /// Gets the request builder for NoncustodialDataSourceRelease.
        /// </summary>
        /// <returns>The <see cref="INoncustodialDataSourceReleaseRequestBuilder"/>.</returns>
        INoncustodialDataSourceReleaseRequestBuilder Release();

        /// <summary>
        /// Gets the request builder for NoncustodialDataSourceUpdateIndex.
        /// </summary>
        /// <returns>The <see cref="INoncustodialDataSourceUpdateIndexRequestBuilder"/>.</returns>
        INoncustodialDataSourceUpdateIndexRequestBuilder UpdateIndex();
    
    }
}
