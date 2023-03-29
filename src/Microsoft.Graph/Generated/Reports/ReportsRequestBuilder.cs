using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Reports.ApplicationSignInDetailedSummary;
using Microsoft.Graph.Beta.Reports.AuthenticationMethods;
using Microsoft.Graph.Beta.Reports.CredentialUserRegistrationDetails;
using Microsoft.Graph.Beta.Reports.DailyPrintUsage;
using Microsoft.Graph.Beta.Reports.DailyPrintUsageByPrinter;
using Microsoft.Graph.Beta.Reports.DailyPrintUsageByUser;
using Microsoft.Graph.Beta.Reports.DailyPrintUsageSummariesByPrinter;
using Microsoft.Graph.Beta.Reports.DailyPrintUsageSummariesByUser;
using Microsoft.Graph.Beta.Reports.DeviceConfigurationDeviceActivity;
using Microsoft.Graph.Beta.Reports.DeviceConfigurationUserActivity;
using Microsoft.Graph.Beta.Reports.GetAttackSimulationRepeatOffenders;
using Microsoft.Graph.Beta.Reports.GetAttackSimulationSimulationUserCoverage;
using Microsoft.Graph.Beta.Reports.GetAttackSimulationTrainingUserCoverage;
using Microsoft.Graph.Beta.Reports.GetAzureADApplicationSignInSummaryWithPeriod;
using Microsoft.Graph.Beta.Reports.GetBrowserDistributionUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetBrowserUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetBrowserUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetCredentialUsageSummaryWithPeriod;
using Microsoft.Graph.Beta.Reports.GetCredentialUserRegistrationCount;
using Microsoft.Graph.Beta.Reports.GetEmailActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetEmailActivityUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetEmailActivityUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetEmailActivityUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetEmailAppUsageAppsUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetEmailAppUsageUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetEmailAppUsageUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetEmailAppUsageUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetEmailAppUsageVersionsUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetFormsUserActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetFormsUserActivityUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetFormsUserActivityUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetFormsUserActivityUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime;
using Microsoft.Graph.Beta.Reports.GetM365AppPlatformUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetM365AppUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetM365AppUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetM365AppUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetMailboxUsageDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetMailboxUsageMailboxCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetMailboxUsageQuotaStatusMailboxCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetMailboxUsageStorageWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOffice365ActivationCounts;
using Microsoft.Graph.Beta.Reports.GetOffice365ActivationsUserCounts;
using Microsoft.Graph.Beta.Reports.GetOffice365ActivationsUserDetail;
using Microsoft.Graph.Beta.Reports.GetOffice365ActiveUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOffice365ActiveUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetOffice365ActiveUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOffice365GroupsActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOffice365GroupsActivityDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetOffice365GroupsActivityDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOffice365GroupsActivityFileCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOffice365GroupsActivityGroupCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOffice365GroupsActivityStorageWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOffice365ServicesUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOneDriveActivityFileCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOneDriveActivityUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOneDriveActivityUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetOneDriveActivityUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOneDriveUsageAccountCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOneDriveUsageAccountDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetOneDriveUsageAccountDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOneDriveUsageFileCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetOneDriveUsageStorageWithPeriod;
using Microsoft.Graph.Beta.Reports.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime;
using Microsoft.Graph.Beta.Reports.GetRelyingPartyDetailedSummaryWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSharePointActivityFileCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSharePointActivityPagesWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSharePointActivityUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSharePointActivityUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetSharePointActivityUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSharePointSiteUsageDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetSharePointSiteUsageDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSharePointSiteUsageFileCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSharePointSiteUsagePagesWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSharePointSiteUsageSiteCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSharePointSiteUsageStorageWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessActivityUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessActivityUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessActivityUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessDeviceUsageUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessOrganizerActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessOrganizerActivityUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessParticipantActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessParticipantActivityUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessPeerToPeerActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsDeviceUsageDistributionTotalUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsDeviceUsageDistributionUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsDeviceUsageTotalUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsDeviceUsageUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsDeviceUsageUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetTeamsDeviceUsageUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsTeamActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsTeamActivityDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetTeamsTeamActivityDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsTeamActivityDistributionCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsTeamCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsUserActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsUserActivityDistributionTotalUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsUserActivityDistributionUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsUserActivityTotalCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsUserActivityTotalDistributionCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsUserActivityTotalUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsUserActivityUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetTeamsUserActivityUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetTeamsUserActivityUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime;
using Microsoft.Graph.Beta.Reports.GetYammerActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetYammerActivityUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetYammerActivityUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetYammerActivityUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetYammerDeviceUsageDistributionUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetYammerDeviceUsageUserCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetYammerDeviceUsageUserDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetYammerDeviceUsageUserDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetYammerGroupsActivityCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.GetYammerGroupsActivityDetailWithDate;
using Microsoft.Graph.Beta.Reports.GetYammerGroupsActivityDetailWithPeriod;
using Microsoft.Graph.Beta.Reports.GetYammerGroupsActivityGroupCountsWithPeriod;
using Microsoft.Graph.Beta.Reports.ManagedDeviceEnrollmentAbandonmentDetailsWithSkipWithTopWithFilterWithSkipToken;
using Microsoft.Graph.Beta.Reports.ManagedDeviceEnrollmentAbandonmentSummaryWithSkipWithTopWithFilterWithSkipToken;
using Microsoft.Graph.Beta.Reports.ManagedDeviceEnrollmentFailureDetails;
using Microsoft.Graph.Beta.Reports.ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken;
using Microsoft.Graph.Beta.Reports.ManagedDeviceEnrollmentFailureTrends;
using Microsoft.Graph.Beta.Reports.ManagedDeviceEnrollmentTopFailures;
using Microsoft.Graph.Beta.Reports.ManagedDeviceEnrollmentTopFailuresWithPeriod;
using Microsoft.Graph.Beta.Reports.MonthlyPrintUsageByPrinter;
using Microsoft.Graph.Beta.Reports.MonthlyPrintUsageByUser;
using Microsoft.Graph.Beta.Reports.MonthlyPrintUsageSummariesByPrinter;
using Microsoft.Graph.Beta.Reports.MonthlyPrintUsageSummariesByUser;
using Microsoft.Graph.Beta.Reports.Security;
using Microsoft.Graph.Beta.Reports.UserCredentialUsageDetails;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Reports {
    /// <summary>
    /// Provides operations to manage the reportRoot singleton.
    /// </summary>
    public class ReportsRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the applicationSignInDetailedSummary property of the microsoft.graph.reportRoot entity.</summary>
        public ApplicationSignInDetailedSummaryRequestBuilder ApplicationSignInDetailedSummary { get =>
            new ApplicationSignInDetailedSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authenticationMethods property of the microsoft.graph.reportRoot entity.</summary>
        public AuthenticationMethodsRequestBuilder AuthenticationMethods { get =>
            new AuthenticationMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the credentialUserRegistrationDetails property of the microsoft.graph.reportRoot entity.</summary>
        public CredentialUserRegistrationDetailsRequestBuilder CredentialUserRegistrationDetails { get =>
            new CredentialUserRegistrationDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dailyPrintUsage property of the microsoft.graph.reportRoot entity.</summary>
        public DailyPrintUsageRequestBuilder DailyPrintUsage { get =>
            new DailyPrintUsageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dailyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.</summary>
        public DailyPrintUsageByPrinterRequestBuilder DailyPrintUsageByPrinter { get =>
            new DailyPrintUsageByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dailyPrintUsageByUser property of the microsoft.graph.reportRoot entity.</summary>
        public DailyPrintUsageByUserRequestBuilder DailyPrintUsageByUser { get =>
            new DailyPrintUsageByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dailyPrintUsageSummariesByPrinter property of the microsoft.graph.reportRoot entity.</summary>
        public DailyPrintUsageSummariesByPrinterRequestBuilder DailyPrintUsageSummariesByPrinter { get =>
            new DailyPrintUsageSummariesByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dailyPrintUsageSummariesByUser property of the microsoft.graph.reportRoot entity.</summary>
        public DailyPrintUsageSummariesByUserRequestBuilder DailyPrintUsageSummariesByUser { get =>
            new DailyPrintUsageSummariesByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deviceConfigurationDeviceActivity method.</summary>
        public DeviceConfigurationDeviceActivityRequestBuilder DeviceConfigurationDeviceActivity { get =>
            new DeviceConfigurationDeviceActivityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deviceConfigurationUserActivity method.</summary>
        public DeviceConfigurationUserActivityRequestBuilder DeviceConfigurationUserActivity { get =>
            new DeviceConfigurationUserActivityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAttackSimulationRepeatOffenders method.</summary>
        public GetAttackSimulationRepeatOffendersRequestBuilder GetAttackSimulationRepeatOffenders { get =>
            new GetAttackSimulationRepeatOffendersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAttackSimulationSimulationUserCoverage method.</summary>
        public GetAttackSimulationSimulationUserCoverageRequestBuilder GetAttackSimulationSimulationUserCoverage { get =>
            new GetAttackSimulationSimulationUserCoverageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAttackSimulationTrainingUserCoverage method.</summary>
        public GetAttackSimulationTrainingUserCoverageRequestBuilder GetAttackSimulationTrainingUserCoverage { get =>
            new GetAttackSimulationTrainingUserCoverageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCredentialUserRegistrationCount method.</summary>
        public GetCredentialUserRegistrationCountRequestBuilder GetCredentialUserRegistrationCount { get =>
            new GetCredentialUserRegistrationCountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getOffice365ActivationCounts method.</summary>
        public GetOffice365ActivationCountsRequestBuilder GetOffice365ActivationCounts { get =>
            new GetOffice365ActivationCountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getOffice365ActivationsUserCounts method.</summary>
        public GetOffice365ActivationsUserCountsRequestBuilder GetOffice365ActivationsUserCounts { get =>
            new GetOffice365ActivationsUserCountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getOffice365ActivationsUserDetail method.</summary>
        public GetOffice365ActivationsUserDetailRequestBuilder GetOffice365ActivationsUserDetail { get =>
            new GetOffice365ActivationsUserDetailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the managedDeviceEnrollmentFailureDetails method.</summary>
        public ManagedDeviceEnrollmentFailureDetailsRequestBuilder ManagedDeviceEnrollmentFailureDetails { get =>
            new ManagedDeviceEnrollmentFailureDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the managedDeviceEnrollmentFailureTrends method.</summary>
        public ManagedDeviceEnrollmentFailureTrendsRequestBuilder ManagedDeviceEnrollmentFailureTrends { get =>
            new ManagedDeviceEnrollmentFailureTrendsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the managedDeviceEnrollmentTopFailures method.</summary>
        public ManagedDeviceEnrollmentTopFailuresRequestBuilder ManagedDeviceEnrollmentTopFailures { get =>
            new ManagedDeviceEnrollmentTopFailuresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the monthlyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.</summary>
        public MonthlyPrintUsageByPrinterRequestBuilder MonthlyPrintUsageByPrinter { get =>
            new MonthlyPrintUsageByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the monthlyPrintUsageByUser property of the microsoft.graph.reportRoot entity.</summary>
        public MonthlyPrintUsageByUserRequestBuilder MonthlyPrintUsageByUser { get =>
            new MonthlyPrintUsageByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the monthlyPrintUsageSummariesByPrinter property of the microsoft.graph.reportRoot entity.</summary>
        public MonthlyPrintUsageSummariesByPrinterRequestBuilder MonthlyPrintUsageSummariesByPrinter { get =>
            new MonthlyPrintUsageSummariesByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the monthlyPrintUsageSummariesByUser property of the microsoft.graph.reportRoot entity.</summary>
        public MonthlyPrintUsageSummariesByUserRequestBuilder MonthlyPrintUsageSummariesByUser { get =>
            new MonthlyPrintUsageSummariesByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the security property of the microsoft.graph.reportRoot entity.</summary>
        public SecurityRequestBuilder Security { get =>
            new SecurityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userCredentialUsageDetails property of the microsoft.graph.reportRoot entity.</summary>
        public UserCredentialUsageDetailsRequestBuilder UserCredentialUsageDetails { get =>
            new UserCredentialUsageDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get reports
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ReportRoot?> GetAsync(Action<ReportsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ReportRoot> GetAsync(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ReportRoot>(requestInfo, ReportRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getAzureADApplicationSignInSummary method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetAzureADApplicationSignInSummaryWithPeriodRequestBuilder GetAzureADApplicationSignInSummaryWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetAzureADApplicationSignInSummaryWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getBrowserDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetBrowserDistributionUserCountsWithPeriodRequestBuilder GetBrowserDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetBrowserDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getBrowserUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetBrowserUserCountsWithPeriodRequestBuilder GetBrowserUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetBrowserUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getBrowserUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetBrowserUserDetailWithPeriodRequestBuilder GetBrowserUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetBrowserUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getCredentialUsageSummary method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetCredentialUsageSummaryWithPeriodRequestBuilder GetCredentialUsageSummaryWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetCredentialUsageSummaryWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailActivityCountsWithPeriodRequestBuilder GetEmailActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailActivityUserCountsWithPeriodRequestBuilder GetEmailActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetEmailActivityUserDetailWithDateRequestBuilder GetEmailActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetEmailActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailActivityUserDetailWithPeriodRequestBuilder GetEmailActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageAppsUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder GetEmailAppUsageAppsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailAppUsageUserCountsWithPeriodRequestBuilder GetEmailAppUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetEmailAppUsageUserDetailWithDateRequestBuilder GetEmailAppUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetEmailAppUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailAppUsageUserDetailWithPeriodRequestBuilder GetEmailAppUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageVersionsUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder GetEmailAppUsageVersionsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getFormsUserActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetFormsUserActivityCountsWithPeriodRequestBuilder GetFormsUserActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetFormsUserActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getFormsUserActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetFormsUserActivityUserCountsWithPeriodRequestBuilder GetFormsUserActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetFormsUserActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getFormsUserActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetFormsUserActivityUserDetailWithDateRequestBuilder GetFormsUserActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetFormsUserActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getFormsUserActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetFormsUserActivityUserDetailWithPeriodRequestBuilder GetFormsUserActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetFormsUserActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getGroupArchivedPrintJobs method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="groupId">Usage: groupId=&apos;{groupId}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        public GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, string groupId, DateTimeOffset? startDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(groupId)) throw new ArgumentNullException(nameof(groupId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, groupId, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getM365AppPlatformUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetM365AppPlatformUserCountsWithPeriodRequestBuilder GetM365AppPlatformUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetM365AppPlatformUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetM365AppUserCountsWithPeriodRequestBuilder GetM365AppUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetM365AppUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetM365AppUserDetailWithDateRequestBuilder GetM365AppUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetM365AppUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetM365AppUserDetailWithPeriodRequestBuilder GetM365AppUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetM365AppUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetMailboxUsageDetailWithPeriodRequestBuilder GetMailboxUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageMailboxCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetMailboxUsageMailboxCountsWithPeriodRequestBuilder GetMailboxUsageMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageMailboxCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageQuotaStatusMailboxCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder GetMailboxUsageQuotaStatusMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetMailboxUsageStorageWithPeriodRequestBuilder GetMailboxUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365ActiveUserCountsWithPeriodRequestBuilder GetOffice365ActiveUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetOffice365ActiveUserDetailWithDateRequestBuilder GetOffice365ActiveUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOffice365ActiveUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365ActiveUserDetailWithPeriodRequestBuilder GetOffice365ActiveUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365GroupsActivityCountsWithPeriodRequestBuilder GetOffice365GroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetOffice365GroupsActivityDetailWithDateRequestBuilder GetOffice365GroupsActivityDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOffice365GroupsActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365GroupsActivityDetailWithPeriodRequestBuilder GetOffice365GroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder GetOffice365GroupsActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityGroupCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder GetOffice365GroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365GroupsActivityStorageWithPeriodRequestBuilder GetOffice365GroupsActivityStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ServicesUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOffice365ServicesUserCountsWithPeriodRequestBuilder GetOffice365ServicesUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ServicesUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveActivityFileCountsWithPeriodRequestBuilder GetOneDriveActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveActivityUserCountsWithPeriodRequestBuilder GetOneDriveActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetOneDriveActivityUserDetailWithDateRequestBuilder GetOneDriveActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOneDriveActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveActivityUserDetailWithPeriodRequestBuilder GetOneDriveActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveUsageAccountCountsWithPeriodRequestBuilder GetOneDriveUsageAccountCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetOneDriveUsageAccountDetailWithDateRequestBuilder GetOneDriveUsageAccountDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOneDriveUsageAccountDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveUsageAccountDetailWithPeriodRequestBuilder GetOneDriveUsageAccountDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveUsageFileCountsWithPeriodRequestBuilder GetOneDriveUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetOneDriveUsageStorageWithPeriodRequestBuilder GetOneDriveUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getPrinterArchivedPrintJobs method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="printerId">Usage: printerId=&apos;{printerId}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        public GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, string printerId, DateTimeOffset? startDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(printerId)) throw new ArgumentNullException(nameof(printerId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, printerId, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getRelyingPartyDetailedSummary method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetRelyingPartyDetailedSummaryWithPeriodRequestBuilder GetRelyingPartyDetailedSummaryWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetRelyingPartyDetailedSummaryWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointActivityFileCountsWithPeriodRequestBuilder GetSharePointActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityPages method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointActivityPagesWithPeriodRequestBuilder GetSharePointActivityPagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityPagesWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointActivityUserCountsWithPeriodRequestBuilder GetSharePointActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetSharePointActivityUserDetailWithDateRequestBuilder GetSharePointActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSharePointActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointActivityUserDetailWithPeriodRequestBuilder GetSharePointActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetSharePointSiteUsageDetailWithDateRequestBuilder GetSharePointSiteUsageDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSharePointSiteUsageDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointSiteUsageDetailWithPeriodRequestBuilder GetSharePointSiteUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder GetSharePointSiteUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsagePages method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointSiteUsagePagesWithPeriodRequestBuilder GetSharePointSiteUsagePagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsagePagesWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageSiteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder GetSharePointSiteUsageSiteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSharePointSiteUsageStorageWithPeriodRequestBuilder GetSharePointSiteUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder GetSkypeForBusinessActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder GetSkypeForBusinessActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder GetSkypeForBusinessDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityMinuteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityMinuteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityMinuteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageDistributionTotalUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsDeviceUsageDistributionTotalUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageDistributionTotalUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageDistributionTotalUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageTotalUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsDeviceUsageTotalUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageTotalUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageTotalUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetTeamsDeviceUsageUserDetailWithDateRequestBuilder GetTeamsDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetTeamsDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder GetTeamsDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsTeamActivityCountsWithPeriodRequestBuilder GetTeamsTeamActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsTeamActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetTeamsTeamActivityDetailWithDateRequestBuilder GetTeamsTeamActivityDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetTeamsTeamActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsTeamActivityDetailWithPeriodRequestBuilder GetTeamsTeamActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsTeamActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityDistributionCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsTeamActivityDistributionCountsWithPeriodRequestBuilder GetTeamsTeamActivityDistributionCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsTeamActivityDistributionCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsTeamCountsWithPeriodRequestBuilder GetTeamsTeamCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsTeamCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityCountsWithPeriodRequestBuilder GetTeamsUserActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityDistributionTotalUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityDistributionTotalUserCountsWithPeriodRequestBuilder GetTeamsUserActivityDistributionTotalUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityDistributionTotalUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityDistributionUserCountsWithPeriodRequestBuilder GetTeamsUserActivityDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityTotalCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityTotalCountsWithPeriodRequestBuilder GetTeamsUserActivityTotalCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityTotalCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityTotalDistributionCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityTotalDistributionCountsWithPeriodRequestBuilder GetTeamsUserActivityTotalDistributionCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityTotalDistributionCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityTotalUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityTotalUserCountsWithPeriodRequestBuilder GetTeamsUserActivityTotalUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityTotalUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityUserCountsWithPeriodRequestBuilder GetTeamsUserActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetTeamsUserActivityUserDetailWithDateRequestBuilder GetTeamsUserActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetTeamsUserActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetTeamsUserActivityUserDetailWithPeriodRequestBuilder GetTeamsUserActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getUserArchivedPrintJobs method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// <param name="userId">Usage: userId=&apos;{userId}&apos;</param>
        public GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, DateTimeOffset? startDateTime, string userId) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            if(string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));
            return new GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, startDateTime, userId);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerActivityCountsWithPeriodRequestBuilder GetYammerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerActivityUserCountsWithPeriodRequestBuilder GetYammerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetYammerActivityUserDetailWithDateRequestBuilder GetYammerActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerActivityUserDetailWithPeriodRequestBuilder GetYammerActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetYammerDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder GetYammerDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetYammerDeviceUsageUserDetailWithDateRequestBuilder GetYammerDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder GetYammerDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerGroupsActivityCountsWithPeriodRequestBuilder GetYammerGroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public GetYammerGroupsActivityDetailWithDateRequestBuilder GetYammerGroupsActivityDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerGroupsActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerGroupsActivityDetailWithPeriodRequestBuilder GetYammerGroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityGroupCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder GetYammerGroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentAbandonmentDetails method.
        /// </summary>
        /// <param name="filter">Usage: filter=&apos;{filter}&apos;</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="skipToken">Usage: skipToken=&apos;{skipToken}&apos;</param>
        /// <param name="top">Usage: top={top}</param>
        public ManagedDeviceEnrollmentAbandonmentDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder ManagedDeviceEnrollmentAbandonmentDetailsWithSkipWithTopWithFilterWithSkipToken(string filter, int? skip, string skipToken, int? top) {
            if(string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            if(string.IsNullOrEmpty(skipToken)) throw new ArgumentNullException(nameof(skipToken));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ManagedDeviceEnrollmentAbandonmentDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(PathParameters, RequestAdapter, filter, skip, skipToken, top);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentAbandonmentSummary method.
        /// </summary>
        /// <param name="filter">Usage: filter=&apos;{filter}&apos;</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="skipToken">Usage: skipToken=&apos;{skipToken}&apos;</param>
        /// <param name="top">Usage: top={top}</param>
        public ManagedDeviceEnrollmentAbandonmentSummaryWithSkipWithTopWithFilterWithSkipTokenRequestBuilder ManagedDeviceEnrollmentAbandonmentSummaryWithSkipWithTopWithFilterWithSkipToken(string filter, int? skip, string skipToken, int? top) {
            if(string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            if(string.IsNullOrEmpty(skipToken)) throw new ArgumentNullException(nameof(skipToken));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ManagedDeviceEnrollmentAbandonmentSummaryWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(PathParameters, RequestAdapter, filter, skip, skipToken, top);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentFailureDetails method.
        /// </summary>
        /// <param name="filter">Usage: filter=&apos;{filter}&apos;</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="skipToken">Usage: skipToken=&apos;{skipToken}&apos;</param>
        /// <param name="top">Usage: top={top}</param>
        public ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken(string filter, int? skip, string skipToken, int? top) {
            if(string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            if(string.IsNullOrEmpty(skipToken)) throw new ArgumentNullException(nameof(skipToken));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(PathParameters, RequestAdapter, filter, skip, skipToken, top);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentTopFailures method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder ManagedDeviceEnrollmentTopFailuresWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Update reports
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ReportRoot?> PatchAsync(ReportRoot body, Action<ReportsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ReportRoot> PatchAsync(ReportRoot body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ReportRoot>(requestInfo, ReportRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get reports
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update reports
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ReportRoot body, Action<ReportsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ReportRoot body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get reports
        /// </summary>
        public class ReportsRequestBuilderGetQueryParameters {
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
        public class ReportsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ReportsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ReportsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new reportsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReportsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reportsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
