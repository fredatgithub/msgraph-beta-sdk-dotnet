// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDeviceShellScriptRequestBuilder.
    /// </summary>
    public partial interface IDeviceShellScriptRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceShellScriptRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceShellScriptRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceShellScriptAssignmentsCollectionRequestBuilder"/>.</returns>
        IDeviceShellScriptAssignmentsCollectionRequestBuilder Assignments { get; }

        /// <summary>
        /// Gets the request builder for DeviceRunStates.
        /// </summary>
        /// <returns>The <see cref="IDeviceShellScriptDeviceRunStatesCollectionRequestBuilder"/>.</returns>
        IDeviceShellScriptDeviceRunStatesCollectionRequestBuilder DeviceRunStates { get; }

        /// <summary>
        /// Gets the request builder for GroupAssignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceShellScriptGroupAssignmentsCollectionRequestBuilder"/>.</returns>
        IDeviceShellScriptGroupAssignmentsCollectionRequestBuilder GroupAssignments { get; }

        /// <summary>
        /// Gets the request builder for RunSummary.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptRunSummaryWithReferenceRequestBuilder"/>.</returns>
        IDeviceManagementScriptRunSummaryWithReferenceRequestBuilder RunSummary { get; }

        /// <summary>
        /// Gets the request builder for UserRunStates.
        /// </summary>
        /// <returns>The <see cref="IDeviceShellScriptUserRunStatesCollectionRequestBuilder"/>.</returns>
        IDeviceShellScriptUserRunStatesCollectionRequestBuilder UserRunStates { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceShellScriptAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceShellScriptAssignRequestBuilder"/>.</returns>
        IDeviceShellScriptAssignRequestBuilder Assign(
            IEnumerable<DeviceManagementScriptGroupAssignment> deviceManagementScriptGroupAssignments = null,
            IEnumerable<DeviceManagementScriptAssignment> deviceManagementScriptAssignments = null);
    
    }
}