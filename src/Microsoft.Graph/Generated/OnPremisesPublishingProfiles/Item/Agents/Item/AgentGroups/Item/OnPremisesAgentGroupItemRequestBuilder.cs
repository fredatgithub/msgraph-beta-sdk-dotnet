using Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.Agents.Item.AgentGroups.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.Agents.Item.AgentGroups.Item {
    /// <summary>
    /// Builds and executes requests for operations under \onPremisesPublishingProfiles\{onPremisesPublishingProfile-id}\agents\{onPremisesAgent-id}\agentGroups\{onPremisesAgentGroup-id}
    /// </summary>
    public class OnPremisesAgentGroupItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the collection of onPremisesPublishingProfile entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new OnPremisesAgentGroupItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnPremisesAgentGroupItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/agents/{onPremisesAgent%2Did}/agentGroups/{onPremisesAgentGroup%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new OnPremisesAgentGroupItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnPremisesAgentGroupItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/agents/{onPremisesAgent%2Did}/agentGroups/{onPremisesAgentGroup%2Did}", rawUrl) {
        }
    }
}
