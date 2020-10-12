// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum EntityType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EntityType
    {
    
        /// <summary>
        /// Event
        /// </summary>
        Event = 0,
	
        /// <summary>
        /// Message
        /// </summary>
        Message = 1,
	
        /// <summary>
        /// Drive Item
        /// </summary>
        DriveItem = 2,
	
        /// <summary>
        /// External Item
        /// </summary>
        ExternalItem = 4,
	
        /// <summary>
        /// Site
        /// </summary>
        Site = 5,
	
        /// <summary>
        /// List
        /// </summary>
        List = 6,
	
        /// <summary>
        /// List Item
        /// </summary>
        ListItem = 7,
	
        /// <summary>
        /// Drive
        /// </summary>
        Drive = 8,
	
        /// <summary>
        /// Unknownfuturevalue
        /// </summary>
        Unknownfuturevalue = 9,
	
    }
}