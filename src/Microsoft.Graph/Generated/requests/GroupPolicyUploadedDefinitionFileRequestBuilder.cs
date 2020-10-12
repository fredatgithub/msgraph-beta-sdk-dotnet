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
    /// The type GroupPolicyUploadedDefinitionFileRequestBuilder.
    /// </summary>
    public partial class GroupPolicyUploadedDefinitionFileRequestBuilder : GroupPolicyDefinitionFileRequestBuilder, IGroupPolicyUploadedDefinitionFileRequestBuilder
    {

        /// <summary>
        /// Constructs a new GroupPolicyUploadedDefinitionFileRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupPolicyUploadedDefinitionFileRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IGroupPolicyUploadedDefinitionFileRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IGroupPolicyUploadedDefinitionFileRequest Request(IEnumerable<Option> options)
        {
            return new GroupPolicyUploadedDefinitionFileRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for GroupPolicyOperations.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyUploadedDefinitionFileGroupPolicyOperationsCollectionRequestBuilder"/>.</returns>
        public IGroupPolicyUploadedDefinitionFileGroupPolicyOperationsCollectionRequestBuilder GroupPolicyOperations
        {
            get
            {
                return new GroupPolicyUploadedDefinitionFileGroupPolicyOperationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("groupPolicyOperations"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for GroupPolicyUploadedDefinitionFileRemove.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyUploadedDefinitionFileRemoveRequestBuilder"/>.</returns>
        public IGroupPolicyUploadedDefinitionFileRemoveRequestBuilder Remove()
        {
            return new GroupPolicyUploadedDefinitionFileRemoveRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.remove"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for GroupPolicyUploadedDefinitionFileAddLanguageFiles.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyUploadedDefinitionFileAddLanguageFilesRequestBuilder"/>.</returns>
        public IGroupPolicyUploadedDefinitionFileAddLanguageFilesRequestBuilder AddLanguageFiles(
            IEnumerable<GroupPolicyUploadedLanguageFile> groupPolicyUploadedLanguageFiles = null)
        {
            return new GroupPolicyUploadedDefinitionFileAddLanguageFilesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.addLanguageFiles"),
                this.Client,
                groupPolicyUploadedLanguageFiles);
        }

        /// <summary>
        /// Gets the request builder for GroupPolicyUploadedDefinitionFileRemoveLanguageFiles.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyUploadedDefinitionFileRemoveLanguageFilesRequestBuilder"/>.</returns>
        public IGroupPolicyUploadedDefinitionFileRemoveLanguageFilesRequestBuilder RemoveLanguageFiles(
            IEnumerable<GroupPolicyUploadedLanguageFile> groupPolicyUploadedLanguageFiles = null)
        {
            return new GroupPolicyUploadedDefinitionFileRemoveLanguageFilesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.removeLanguageFiles"),
                this.Client,
                groupPolicyUploadedLanguageFiles);
        }

        /// <summary>
        /// Gets the request builder for GroupPolicyUploadedDefinitionFileUpdateLanguageFiles.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyUploadedDefinitionFileUpdateLanguageFilesRequestBuilder"/>.</returns>
        public IGroupPolicyUploadedDefinitionFileUpdateLanguageFilesRequestBuilder UpdateLanguageFiles(
            IEnumerable<GroupPolicyUploadedLanguageFile> groupPolicyUploadedLanguageFiles = null)
        {
            return new GroupPolicyUploadedDefinitionFileUpdateLanguageFilesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.updateLanguageFiles"),
                this.Client,
                groupPolicyUploadedLanguageFiles);
        }

        /// <summary>
        /// Gets the request builder for GroupPolicyUploadedDefinitionFileUploadNewVersion.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyUploadedDefinitionFileUploadNewVersionRequestBuilder"/>.</returns>
        public IGroupPolicyUploadedDefinitionFileUploadNewVersionRequestBuilder UploadNewVersion(
            byte[] content,
            IEnumerable<GroupPolicyUploadedLanguageFile> groupPolicyUploadedLanguageFiles = null)
        {
            return new GroupPolicyUploadedDefinitionFileUploadNewVersionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.uploadNewVersion"),
                this.Client,
                content,
                groupPolicyUploadedLanguageFiles);
        }
    
    }
}