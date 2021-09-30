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
    /// The enum SubjectRightsRequestStageStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SubjectRightsRequestStageStatus
    {
    
        /// <summary>
        /// Not Started
        /// </summary>
        NotStarted = 0,
	
        /// <summary>
        /// Current
        /// </summary>
        Current = 1,
	
        /// <summary>
        /// Completed
        /// </summary>
        Completed = 3,
	
        /// <summary>
        /// Failed
        /// </summary>
        Failed = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
