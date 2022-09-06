// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IAuthenticationStrengthPolicyRequestBuilder.
    /// </summary>
    public partial interface IAuthenticationStrengthPolicyRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IAuthenticationStrengthPolicyRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IAuthenticationStrengthPolicyRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for CombinationConfigurations.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationStrengthPolicyCombinationConfigurationsCollectionRequestBuilder"/>.</returns>
        IAuthenticationStrengthPolicyCombinationConfigurationsCollectionRequestBuilder CombinationConfigurations { get; }
    
        /// <summary>
        /// Gets the request builder for AuthenticationStrengthPolicyUpdateAllowedCombinations.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationStrengthPolicyUpdateAllowedCombinationsRequestBuilder"/>.</returns>
        IAuthenticationStrengthPolicyUpdateAllowedCombinationsRequestBuilder UpdateAllowedCombinations(
            IEnumerable<AuthenticationMethodModes> allowedCombinations = null);

        /// <summary>
        /// Gets the request builder for AuthenticationStrengthPolicyUsage.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationStrengthPolicyUsageRequestBuilder"/>.</returns>
        IAuthenticationStrengthPolicyUsageRequestBuilder Usage();
    
    }
}
