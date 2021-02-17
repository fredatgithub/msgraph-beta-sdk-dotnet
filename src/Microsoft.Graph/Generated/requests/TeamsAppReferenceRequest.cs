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
    /// The type TeamsAppReferenceRequest.
    /// </summary>
    public partial class TeamsAppReferenceRequest : BaseRequest, ITeamsAppReferenceRequest
    {
        /// <summary>
        /// Constructs a new TeamsAppReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TeamsAppReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Deletes the specified TeamsApp reference.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TeamsApp reference.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<TeamsApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TeamsApp reference and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TeamsApp reference and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Puts the specified TeamsApp reference.
        /// </summary>
        /// <param name="id">The TeamsApp reference to update.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task PutAsync(string id)
        {
            return this.PutAsync(id, CancellationToken.None);
        }

        /// <summary>
        /// Puts the specified TeamsApp reference.
        /// </summary>
        /// <param name="id">The TeamsApp reference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task PutAsync(string id, CancellationToken cancellationToken)
        {
            var baseUrl = this.Client.BaseUrl;
            var objectUri = string.Format(@"{0}/users/{1}", baseUrl, id);
            var stream = new System.IO.MemoryStream();
            using (var writer = new System.Text.Json.Utf8JsonWriter(stream))
            {
                writer.WriteStartObject();
                writer.WriteString("@odata.id", objectUri);
                writer.WriteEndObject();
                await writer.FlushAsync();
            }
            var payload = System.Text.Encoding.UTF8.GetString(stream.ToArray());
            this.Method = "PUT";
            this.ContentType = "application/json";
            await this.SendAsync(payload, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Puts the specified TeamsApp reference and returns <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="id">The TeamsApp reference to update.</param>
        /// <returns>The task to await of <see cref="GraphResponse"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse> PutResponseAsync(string id)
        {
            return this.PutResponseAsync(id, CancellationToken.None);
        }

        /// <summary>
        /// Puts the specified TeamsApp reference and returns <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="id">The TeamsApp reference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse"/>.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> PutResponseAsync(string id, CancellationToken cancellationToken)
        {
            var baseUrl = this.Client.BaseUrl;
            var objectUri = string.Format(@"{0}/users/{1}", baseUrl, id);
            var stream = new System.IO.MemoryStream();
            using (var writer = new System.Text.Json.Utf8JsonWriter(stream))
            {
                writer.WriteStartObject();
                writer.WriteString("@odata.id", objectUri);
                writer.WriteEndObject();
                await writer.FlushAsync();
            }
            var payload = System.Text.Encoding.UTF8.GetString(stream.ToArray());
            this.Method = "PUT";
            this.ContentType = "application/json";
            return await this.SendAsyncWithGraphResponse(payload, cancellationToken).ConfigureAwait(false);
        }
    }
}
