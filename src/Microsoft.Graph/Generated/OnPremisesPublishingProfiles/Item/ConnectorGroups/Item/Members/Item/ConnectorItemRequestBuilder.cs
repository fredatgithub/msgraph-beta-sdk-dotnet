using Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.Members.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.Members.Item {
    /// <summary>
    /// Builds and executes requests for operations under \onPremisesPublishingProfiles\{onPremisesPublishingProfile-id}\connectorGroups\{connectorGroup-id}\members\{connector-id}
    /// </summary>
    public class ConnectorItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the collection of onPremisesPublishingProfile entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ConnectorItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConnectorItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/connectorGroups/{connectorGroup%2Did}/members/{connector%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ConnectorItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConnectorItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/connectorGroups/{connectorGroup%2Did}/members/{connector%2Did}", rawUrl) {
        }
    }
}
