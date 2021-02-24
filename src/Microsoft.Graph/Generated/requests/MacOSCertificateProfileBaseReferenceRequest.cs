// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type MacOSCertificateProfileBaseReferenceRequest.
    /// </summary>
    public partial class MacOSCertificateProfileBaseReferenceRequest : BaseRequest, IMacOSCertificateProfileBaseReferenceRequest
    {
        /// <summary>
        /// Constructs a new MacOSCertificateProfileBaseReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSCertificateProfileBaseReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Deletes the specified MacOSCertificateProfileBase reference.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<MacOSCertificateProfileBase>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSCertificateProfileBase reference and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Puts the specified MacOSCertificateProfileBase reference.
        /// </summary>
        /// <param name="id">The MacOSCertificateProfileBase reference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task PutAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var baseUrl = this.Client.BaseUrl;
            var objectUri = string.Format(@"{0}/users/{1}", baseUrl, id);
            var payload = string.Empty;
            using (var stream = new System.IO.MemoryStream())
            using (var writer = new System.Text.Json.Utf8JsonWriter(stream))
            {
                writer.WriteStartObject();
                writer.WriteString("@odata.id", objectUri);
                writer.WriteEndObject();
                await writer.FlushAsync();
                payload = System.Text.Encoding.UTF8.GetString(stream.ToArray());
            }
            this.Method = Constants.HttpMethods.PUT.ToString();
            this.ContentType = Constants.ContentTypes.JsonContentType;
            await this.SendAsync(payload, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Puts the specified MacOSCertificateProfileBase reference and returns <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="id">The MacOSCertificateProfileBase reference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse"/>.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> PutResponseAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var baseUrl = this.Client.BaseUrl;
            var objectUri = string.Format(@"{0}/users/{1}", baseUrl, id);
            var payload = string.Empty;
            using (var stream = new System.IO.MemoryStream())
            using (var writer = new System.Text.Json.Utf8JsonWriter(stream))
            {
                writer.WriteStartObject();
                writer.WriteString("@odata.id", objectUri);
                writer.WriteEndObject();
                await writer.FlushAsync();
                payload = System.Text.Encoding.UTF8.GetString(stream.ToArray());
            }
            this.Method = Constants.HttpMethods.PUT.ToString();
            this.ContentType = Constants.ContentTypes.JsonContentType;
            return await this.SendAsyncWithGraphResponse(payload, cancellationToken).ConfigureAwait(false);
        }
    }
}
