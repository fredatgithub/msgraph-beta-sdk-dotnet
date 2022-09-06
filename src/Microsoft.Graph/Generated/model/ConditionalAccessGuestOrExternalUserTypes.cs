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
    /// The enum ConditionalAccessGuestOrExternalUserTypes.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum ConditionalAccessGuestOrExternalUserTypes
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Internal Guest
        /// </summary>
        InternalGuest = 1,
	
        /// <summary>
        /// B2b Collaboration Guest
        /// </summary>
        B2bCollaborationGuest = 2,
	
        /// <summary>
        /// B2b Collaboration Member
        /// </summary>
        B2bCollaborationMember = 4,
	
        /// <summary>
        /// B2b Direct Connect User
        /// </summary>
        B2bDirectConnectUser = 8,
	
        /// <summary>
        /// Other External User
        /// </summary>
        OtherExternalUser = 16,
	
        /// <summary>
        /// Service Provider
        /// </summary>
        ServiceProvider = 32,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 64,
	
    }
}
