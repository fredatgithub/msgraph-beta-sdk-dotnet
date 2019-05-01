// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder.
    /// </summary>
    public partial class AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder : EntityRequestBuilder, IAndroidManagedStoreAccountEnterpriseSettingsRequestBuilder
    {

        /// <summary>
        /// Constructs a new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAndroidManagedStoreAccountEnterpriseSettingsRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAndroidManagedStoreAccountEnterpriseSettingsRequest Request(IEnumerable<Option> options)
        {
            return new AndroidManagedStoreAccountEnterpriseSettingsRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AndroidManagedStoreAccountEnterpriseSettingsRequestSignupUrl.
        /// </summary>
        /// <returns>The <see cref="IAndroidManagedStoreAccountEnterpriseSettingsRequestSignupUrlRequestBuilder"/>.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsRequestSignupUrlRequestBuilder RequestSignupUrl(
            string hostName = null)
        {
            return new AndroidManagedStoreAccountEnterpriseSettingsRequestSignupUrlRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.requestSignupUrl"),
                this.Client,
                hostName);
        }

        /// <summary>
        /// Gets the request builder for AndroidManagedStoreAccountEnterpriseSettingsCompleteSignup.
        /// </summary>
        /// <returns>The <see cref="IAndroidManagedStoreAccountEnterpriseSettingsCompleteSignupRequestBuilder"/>.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsCompleteSignupRequestBuilder CompleteSignup(
            string enterpriseToken = null)
        {
            return new AndroidManagedStoreAccountEnterpriseSettingsCompleteSignupRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.completeSignup"),
                this.Client,
                enterpriseToken);
        }

        /// <summary>
        /// Gets the request builder for AndroidManagedStoreAccountEnterpriseSettingsSyncApps.
        /// </summary>
        /// <returns>The <see cref="IAndroidManagedStoreAccountEnterpriseSettingsSyncAppsRequestBuilder"/>.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsSyncAppsRequestBuilder SyncApps()
        {
            return new AndroidManagedStoreAccountEnterpriseSettingsSyncAppsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.syncApps"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AndroidManagedStoreAccountEnterpriseSettingsUnbind.
        /// </summary>
        /// <returns>The <see cref="IAndroidManagedStoreAccountEnterpriseSettingsUnbindRequestBuilder"/>.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsUnbindRequestBuilder Unbind()
        {
            return new AndroidManagedStoreAccountEnterpriseSettingsUnbindRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unbind"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AndroidManagedStoreAccountEnterpriseSettingsCreateGooglePlayWebToken.
        /// </summary>
        /// <returns>The <see cref="IAndroidManagedStoreAccountEnterpriseSettingsCreateGooglePlayWebTokenRequestBuilder"/>.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsCreateGooglePlayWebTokenRequestBuilder CreateGooglePlayWebToken(
            string parentUri = null)
        {
            return new AndroidManagedStoreAccountEnterpriseSettingsCreateGooglePlayWebTokenRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createGooglePlayWebToken"),
                this.Client,
                parentUri);
        }

        /// <summary>
        /// Gets the request builder for AndroidManagedStoreAccountEnterpriseSettingsSetAndroidDeviceOwnerFullyManagedEnrollmentState.
        /// </summary>
        /// <returns>The <see cref="IAndroidManagedStoreAccountEnterpriseSettingsSetAndroidDeviceOwnerFullyManagedEnrollmentStateRequestBuilder"/>.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsSetAndroidDeviceOwnerFullyManagedEnrollmentStateRequestBuilder SetAndroidDeviceOwnerFullyManagedEnrollmentState(
            bool enabled)
        {
            return new AndroidManagedStoreAccountEnterpriseSettingsSetAndroidDeviceOwnerFullyManagedEnrollmentStateRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setAndroidDeviceOwnerFullyManagedEnrollmentState"),
                this.Client,
                enabled);
        }
    
    }
}