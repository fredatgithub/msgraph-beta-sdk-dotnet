// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum OrganizationalMessageFrequency.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrganizationalMessageFrequency
    {
    
        /// <summary>
        /// Weekly Once
        /// </summary>
        WeeklyOnce = 0,
	
        /// <summary>
        /// Monthly Once
        /// </summary>
        MonthlyOnce = 1,
	
        /// <summary>
        /// Monthly Twice
        /// </summary>
        MonthlyTwice = 2,
	
    }
}
