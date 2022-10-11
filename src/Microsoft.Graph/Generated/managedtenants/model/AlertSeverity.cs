// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.ManagedTenants
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum AlertSeverity.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AlertSeverity
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Informational
        /// </summary>
        Informational = 1,
	
        /// <summary>
        /// Low
        /// </summary>
        Low = 2,
	
        /// <summary>
        /// Medium
        /// </summary>
        Medium = 3,
	
        /// <summary>
        /// High
        /// </summary>
        High = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
