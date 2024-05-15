// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.Accept;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.Attachments;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.Calendar;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.Cancel;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.Decline;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.DismissReminder;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.Extensions;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.Forward;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.Instances;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.SnoozeReminder;
using Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item.TentativelyAccept;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Users.Item.Events.Item.ExceptionOccurrences.Item
{
    /// <summary>
    /// Provides operations to manage the exceptionOccurrences property of the microsoft.graph.event entity.
    /// </summary>
    public class EventItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the accept method.</summary>
        public AcceptRequestBuilder Accept
        {
            get => new AcceptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the attachments property of the microsoft.graph.event entity.</summary>
        public AttachmentsRequestBuilder Attachments
        {
            get => new AttachmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendar property of the microsoft.graph.event entity.</summary>
        public CalendarRequestBuilder Calendar
        {
            get => new CalendarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cancel method.</summary>
        public CancelRequestBuilder Cancel
        {
            get => new CancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the decline method.</summary>
        public DeclineRequestBuilder Decline
        {
            get => new DeclineRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the dismissReminder method.</summary>
        public DismissReminderRequestBuilder DismissReminder
        {
            get => new DismissReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the extensions property of the microsoft.graph.event entity.</summary>
        public ExtensionsRequestBuilder Extensions
        {
            get => new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the forward method.</summary>
        public ForwardRequestBuilder Forward
        {
            get => new ForwardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the instances property of the microsoft.graph.event entity.</summary>
        public InstancesRequestBuilder Instances
        {
            get => new InstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the snoozeReminder method.</summary>
        public SnoozeReminderRequestBuilder SnoozeReminder
        {
            get => new SnoozeReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the tentativelyAccept method.</summary>
        public TentativelyAcceptRequestBuilder TentativelyAccept
        {
            get => new TentativelyAcceptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="EventItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/events/{event%2Did}/exceptionOccurrences/{event%2Did1}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="EventItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/events/{event%2Did}/exceptionOccurrences/{event%2Did1}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get exceptionOccurrences from users
        /// </summary>
        /// <returns>A <see cref="Event"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Event?> GetAsync(Action<RequestConfiguration<EventItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Event> GetAsync(Action<RequestConfiguration<EventItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Event>(requestInfo, Event.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get exceptionOccurrences from users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EventItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EventItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="EventItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EventItemRequestBuilder WithUrl(string rawUrl)
        {
            return new EventItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get exceptionOccurrences from users
        /// </summary>
        public class EventItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EventItemRequestBuilderGetRequestConfiguration : RequestConfiguration<EventItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
