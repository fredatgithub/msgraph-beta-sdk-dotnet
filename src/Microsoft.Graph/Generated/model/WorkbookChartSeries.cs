// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Workbook Chart Series.
    /// </summary>
    public partial class WorkbookChartSeries : Entity
    {
    
        /// <summary>
        /// Gets or sets name.
        /// Represents the name of a series in a chart.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Represents the formatting of a chart series, which includes fill and line formatting. Read-only.
        /// </summary>
        [JsonPropertyName("format")]
        public WorkbookChartSeriesFormat Format { get; set; }
    
        /// <summary>
        /// Gets or sets points.
        /// Represents a collection of all points in the series. Read-only.
        /// </summary>
        [JsonPropertyName("points")]
        public IWorkbookChartSeriesPointsCollectionPage Points { get; set; }

        /// <summary>
        /// Gets or sets pointsNextLink.
        /// </summary>
        [JsonPropertyName("points@odata.nextLink")]
        public string PointsNextLink { get; set; }
    
    }
}

