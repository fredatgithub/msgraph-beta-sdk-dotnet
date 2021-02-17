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
    /// The interface IUserRequestBuilder.
    /// </summary>
    public partial interface IUserRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IUserRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IUserRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Analytics.
        /// </summary>
        /// <returns>The <see cref="IUserAnalyticsRequestBuilder"/>.</returns>
        IUserAnalyticsRequestBuilder Analytics { get; }

        /// <summary>
        /// Gets the request builder for UsageRights.
        /// </summary>
        /// <returns>The <see cref="IUserUsageRightsCollectionRequestBuilder"/>.</returns>
        IUserUsageRightsCollectionRequestBuilder UsageRights { get; }

        /// <summary>
        /// Gets the request builder for InformationProtection.
        /// </summary>
        /// <returns>The <see cref="IInformationProtectionRequestBuilder"/>.</returns>
        IInformationProtectionRequestBuilder InformationProtection { get; }

        /// <summary>
        /// Gets the request builder for AppRoleAssignments.
        /// </summary>
        /// <returns>The <see cref="IUserAppRoleAssignmentsCollectionRequestBuilder"/>.</returns>
        IUserAppRoleAssignmentsCollectionRequestBuilder AppRoleAssignments { get; }

        /// <summary>
        /// Gets the request builder for CreatedObjects.
        /// </summary>
        /// <returns>The <see cref="IUserCreatedObjectsCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserCreatedObjectsCollectionWithReferencesRequestBuilder CreatedObjects { get; }

        /// <summary>
        /// Gets the request builder for DirectReports.
        /// </summary>
        /// <returns>The <see cref="IUserDirectReportsCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserDirectReportsCollectionWithReferencesRequestBuilder DirectReports { get; }

        /// <summary>
        /// Gets the request builder for LicenseDetails.
        /// </summary>
        /// <returns>The <see cref="IUserLicenseDetailsCollectionRequestBuilder"/>.</returns>
        IUserLicenseDetailsCollectionRequestBuilder LicenseDetails { get; }

        /// <summary>
        /// Gets the request builder for Manager.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        IDirectoryObjectWithReferenceRequestBuilder Manager { get; }

        /// <summary>
        /// Gets the request builder for MemberOf.
        /// </summary>
        /// <returns>The <see cref="IUserMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserMemberOfCollectionWithReferencesRequestBuilder MemberOf { get; }

        /// <summary>
        /// Gets the request builder for OwnedDevices.
        /// </summary>
        /// <returns>The <see cref="IUserOwnedDevicesCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserOwnedDevicesCollectionWithReferencesRequestBuilder OwnedDevices { get; }

        /// <summary>
        /// Gets the request builder for OwnedObjects.
        /// </summary>
        /// <returns>The <see cref="IUserOwnedObjectsCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserOwnedObjectsCollectionWithReferencesRequestBuilder OwnedObjects { get; }

        /// <summary>
        /// Gets the request builder for RegisteredDevices.
        /// </summary>
        /// <returns>The <see cref="IUserRegisteredDevicesCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserRegisteredDevicesCollectionWithReferencesRequestBuilder RegisteredDevices { get; }

        /// <summary>
        /// Gets the request builder for ScopedRoleMemberOf.
        /// </summary>
        /// <returns>The <see cref="IUserScopedRoleMemberOfCollectionRequestBuilder"/>.</returns>
        IUserScopedRoleMemberOfCollectionRequestBuilder ScopedRoleMemberOf { get; }

        /// <summary>
        /// Gets the request builder for TransitiveMemberOf.
        /// </summary>
        /// <returns>The <see cref="IUserTransitiveMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserTransitiveMemberOfCollectionWithReferencesRequestBuilder TransitiveMemberOf { get; }

        /// <summary>
        /// Gets the request builder for Calendar.
        /// </summary>
        /// <returns>The <see cref="ICalendarRequestBuilder"/>.</returns>
        ICalendarRequestBuilder Calendar { get; }

        /// <summary>
        /// Gets the request builder for CalendarGroups.
        /// </summary>
        /// <returns>The <see cref="IUserCalendarGroupsCollectionRequestBuilder"/>.</returns>
        IUserCalendarGroupsCollectionRequestBuilder CalendarGroups { get; }

        /// <summary>
        /// Gets the request builder for Calendars.
        /// </summary>
        /// <returns>The <see cref="IUserCalendarsCollectionRequestBuilder"/>.</returns>
        IUserCalendarsCollectionRequestBuilder Calendars { get; }

        /// <summary>
        /// Gets the request builder for CalendarView.
        /// </summary>
        /// <returns>The <see cref="IUserCalendarViewCollectionRequestBuilder"/>.</returns>
        IUserCalendarViewCollectionRequestBuilder CalendarView { get; }

        /// <summary>
        /// Gets the request builder for ContactFolders.
        /// </summary>
        /// <returns>The <see cref="IUserContactFoldersCollectionRequestBuilder"/>.</returns>
        IUserContactFoldersCollectionRequestBuilder ContactFolders { get; }

        /// <summary>
        /// Gets the request builder for Contacts.
        /// </summary>
        /// <returns>The <see cref="IUserContactsCollectionRequestBuilder"/>.</returns>
        IUserContactsCollectionRequestBuilder Contacts { get; }

        /// <summary>
        /// Gets the request builder for Events.
        /// </summary>
        /// <returns>The <see cref="IUserEventsCollectionRequestBuilder"/>.</returns>
        IUserEventsCollectionRequestBuilder Events { get; }

        /// <summary>
        /// Gets the request builder for InferenceClassification.
        /// </summary>
        /// <returns>The <see cref="IInferenceClassificationRequestBuilder"/>.</returns>
        IInferenceClassificationRequestBuilder InferenceClassification { get; }

        /// <summary>
        /// Gets the request builder for JoinedGroups.
        /// </summary>
        /// <returns>The <see cref="IUserJoinedGroupsCollectionRequestBuilder"/>.</returns>
        IUserJoinedGroupsCollectionRequestBuilder JoinedGroups { get; }

        /// <summary>
        /// Gets the request builder for MailFolders.
        /// </summary>
        /// <returns>The <see cref="IUserMailFoldersCollectionRequestBuilder"/>.</returns>
        IUserMailFoldersCollectionRequestBuilder MailFolders { get; }

        /// <summary>
        /// Gets the request builder for Messages.
        /// </summary>
        /// <returns>The <see cref="IUserMessagesCollectionRequestBuilder"/>.</returns>
        IUserMessagesCollectionRequestBuilder Messages { get; }

        /// <summary>
        /// Gets the request builder for Outlook.
        /// </summary>
        /// <returns>The <see cref="IOutlookUserRequestBuilder"/>.</returns>
        IOutlookUserRequestBuilder Outlook { get; }

        /// <summary>
        /// Gets the request builder for People.
        /// </summary>
        /// <returns>The <see cref="IUserPeopleCollectionRequestBuilder"/>.</returns>
        IUserPeopleCollectionRequestBuilder People { get; }

        /// <summary>
        /// Gets the request builder for Photo.
        /// </summary>
        /// <returns>The <see cref="IProfilePhotoRequestBuilder"/>.</returns>
        IProfilePhotoRequestBuilder Photo { get; }

        /// <summary>
        /// Gets the request builder for Photos.
        /// </summary>
        /// <returns>The <see cref="IUserPhotosCollectionRequestBuilder"/>.</returns>
        IUserPhotosCollectionRequestBuilder Photos { get; }

        /// <summary>
        /// Gets the request builder for Drive.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        IDriveRequestBuilder Drive { get; }

        /// <summary>
        /// Gets the request builder for Drives.
        /// </summary>
        /// <returns>The <see cref="IUserDrivesCollectionRequestBuilder"/>.</returns>
        IUserDrivesCollectionRequestBuilder Drives { get; }

        /// <summary>
        /// Gets the request builder for FollowedSites.
        /// </summary>
        /// <returns>The <see cref="IUserFollowedSitesCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserFollowedSitesCollectionWithReferencesRequestBuilder FollowedSites { get; }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IUserExtensionsCollectionRequestBuilder"/>.</returns>
        IUserExtensionsCollectionRequestBuilder Extensions { get; }

        /// <summary>
        /// Gets the request builder for AppConsentRequestsForApproval.
        /// </summary>
        /// <returns>The <see cref="IUserAppConsentRequestsForApprovalCollectionRequestBuilder"/>.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequestBuilder AppConsentRequestsForApproval { get; }

        /// <summary>
        /// Gets the request builder for Approvals.
        /// </summary>
        /// <returns>The <see cref="IUserApprovalsCollectionRequestBuilder"/>.</returns>
        IUserApprovalsCollectionRequestBuilder Approvals { get; }

        /// <summary>
        /// Gets the request builder for PendingAccessReviewInstances.
        /// </summary>
        /// <returns>The <see cref="IUserPendingAccessReviewInstancesCollectionRequestBuilder"/>.</returns>
        IUserPendingAccessReviewInstancesCollectionRequestBuilder PendingAccessReviewInstances { get; }

        /// <summary>
        /// Gets the request builder for AgreementAcceptances.
        /// </summary>
        /// <returns>The <see cref="IUserAgreementAcceptancesCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserAgreementAcceptancesCollectionWithReferencesRequestBuilder AgreementAcceptances { get; }

        /// <summary>
        /// Gets the request builder for DeviceEnrollmentConfigurations.
        /// </summary>
        /// <returns>The <see cref="IUserDeviceEnrollmentConfigurationsCollectionRequestBuilder"/>.</returns>
        IUserDeviceEnrollmentConfigurationsCollectionRequestBuilder DeviceEnrollmentConfigurations { get; }

        /// <summary>
        /// Gets the request builder for ManagedDevices.
        /// </summary>
        /// <returns>The <see cref="IUserManagedDevicesCollectionRequestBuilder"/>.</returns>
        IUserManagedDevicesCollectionRequestBuilder ManagedDevices { get; }

        /// <summary>
        /// Gets the request builder for ManagedAppRegistrations.
        /// </summary>
        /// <returns>The <see cref="IUserManagedAppRegistrationsCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserManagedAppRegistrationsCollectionWithReferencesRequestBuilder ManagedAppRegistrations { get; }

        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionDeviceRegistrations.
        /// </summary>
        /// <returns>The <see cref="IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequestBuilder WindowsInformationProtectionDeviceRegistrations { get; }

        /// <summary>
        /// Gets the request builder for DeviceManagementTroubleshootingEvents.
        /// </summary>
        /// <returns>The <see cref="IUserDeviceManagementTroubleshootingEventsCollectionRequestBuilder"/>.</returns>
        IUserDeviceManagementTroubleshootingEventsCollectionRequestBuilder DeviceManagementTroubleshootingEvents { get; }

        /// <summary>
        /// Gets the request builder for MobileAppIntentAndStates.
        /// </summary>
        /// <returns>The <see cref="IUserMobileAppIntentAndStatesCollectionRequestBuilder"/>.</returns>
        IUserMobileAppIntentAndStatesCollectionRequestBuilder MobileAppIntentAndStates { get; }

        /// <summary>
        /// Gets the request builder for MobileAppTroubleshootingEvents.
        /// </summary>
        /// <returns>The <see cref="IUserMobileAppTroubleshootingEventsCollectionRequestBuilder"/>.</returns>
        IUserMobileAppTroubleshootingEventsCollectionRequestBuilder MobileAppTroubleshootingEvents { get; }

        /// <summary>
        /// Gets the request builder for Notifications.
        /// </summary>
        /// <returns>The <see cref="IUserNotificationsCollectionRequestBuilder"/>.</returns>
        IUserNotificationsCollectionRequestBuilder Notifications { get; }

        /// <summary>
        /// Gets the request builder for Planner.
        /// </summary>
        /// <returns>The <see cref="IPlannerUserRequestBuilder"/>.</returns>
        IPlannerUserRequestBuilder Planner { get; }

        /// <summary>
        /// Gets the request builder for Insights.
        /// </summary>
        /// <returns>The <see cref="IItemInsightsRequestBuilder"/>.</returns>
        IItemInsightsRequestBuilder Insights { get; }

        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="IUserSettingsRequestBuilder"/>.</returns>
        IUserSettingsRequestBuilder Settings { get; }

        /// <summary>
        /// Gets the request builder for Onenote.
        /// </summary>
        /// <returns>The <see cref="IOnenoteRequestBuilder"/>.</returns>
        IOnenoteRequestBuilder Onenote { get; }

        /// <summary>
        /// Gets the request builder for Profile.
        /// </summary>
        /// <returns>The <see cref="IProfileRequestBuilder"/>.</returns>
        IProfileRequestBuilder Profile { get; }

        /// <summary>
        /// Gets the request builder for Activities.
        /// </summary>
        /// <returns>The <see cref="IUserActivitiesCollectionRequestBuilder"/>.</returns>
        IUserActivitiesCollectionRequestBuilder Activities { get; }

        /// <summary>
        /// Gets the request builder for Devices.
        /// </summary>
        /// <returns>The <see cref="IUserDevicesCollectionRequestBuilder"/>.</returns>
        IUserDevicesCollectionRequestBuilder Devices { get; }

        /// <summary>
        /// Gets the request builder for OnlineMeetings.
        /// </summary>
        /// <returns>The <see cref="IUserOnlineMeetingsCollectionRequestBuilder"/>.</returns>
        IUserOnlineMeetingsCollectionRequestBuilder OnlineMeetings { get; }

        /// <summary>
        /// Gets the request builder for Presence.
        /// </summary>
        /// <returns>The <see cref="IPresenceRequestBuilder"/>.</returns>
        IPresenceRequestBuilder Presence { get; }

        /// <summary>
        /// Gets the request builder for Authentication.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationRequestBuilder"/>.</returns>
        IAuthenticationRequestBuilder Authentication { get; }

        /// <summary>
        /// Gets the request builder for Chats.
        /// </summary>
        /// <returns>The <see cref="IUserChatsCollectionRequestBuilder"/>.</returns>
        IUserChatsCollectionRequestBuilder Chats { get; }

        /// <summary>
        /// Gets the request builder for JoinedTeams.
        /// </summary>
        /// <returns>The <see cref="IUserJoinedTeamsCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserJoinedTeamsCollectionWithReferencesRequestBuilder JoinedTeams { get; }

        /// <summary>
        /// Gets the request builder for Teamwork.
        /// </summary>
        /// <returns>The <see cref="IUserTeamworkRequestBuilder"/>.</returns>
        IUserTeamworkRequestBuilder Teamwork { get; }

        /// <summary>
        /// Gets the request builder for Todo.
        /// </summary>
        /// <returns>The <see cref="ITodoRequestBuilder"/>.</returns>
        ITodoRequestBuilder Todo { get; }
    
        /// <summary>
        /// Gets the request builder for UserActivateServicePlan.
        /// </summary>
        /// <returns>The <see cref="IUserActivateServicePlanRequestBuilder"/>.</returns>
        IUserActivateServicePlanRequestBuilder ActivateServicePlan(
            Guid servicePlanId,
            Guid skuId);

        /// <summary>
        /// Gets the request builder for UserAssignLicense.
        /// </summary>
        /// <returns>The <see cref="IUserAssignLicenseRequestBuilder"/>.</returns>
        IUserAssignLicenseRequestBuilder AssignLicense(
            IEnumerable<AssignedLicense> addLicenses,
            IEnumerable<Guid> removeLicenses);

        /// <summary>
        /// Gets the request builder for UserChangePassword.
        /// </summary>
        /// <returns>The <see cref="IUserChangePasswordRequestBuilder"/>.</returns>
        IUserChangePasswordRequestBuilder ChangePassword(
            string currentPassword = null,
            string newPassword = null);

        /// <summary>
        /// Gets the request builder for UserInvalidateAllRefreshTokens.
        /// </summary>
        /// <returns>The <see cref="IUserInvalidateAllRefreshTokensRequestBuilder"/>.</returns>
        IUserInvalidateAllRefreshTokensRequestBuilder InvalidateAllRefreshTokens();

        /// <summary>
        /// Gets the request builder for UserReprocessLicenseAssignment.
        /// </summary>
        /// <returns>The <see cref="IUserReprocessLicenseAssignmentRequestBuilder"/>.</returns>
        IUserReprocessLicenseAssignmentRequestBuilder ReprocessLicenseAssignment();

        /// <summary>
        /// Gets the request builder for UserRevokeSignInSessions.
        /// </summary>
        /// <returns>The <see cref="IUserRevokeSignInSessionsRequestBuilder"/>.</returns>
        IUserRevokeSignInSessionsRequestBuilder RevokeSignInSessions();

        /// <summary>
        /// Gets the request builder for UserFindMeetingTimes.
        /// </summary>
        /// <returns>The <see cref="IUserFindMeetingTimesRequestBuilder"/>.</returns>
        IUserFindMeetingTimesRequestBuilder FindMeetingTimes(
            IEnumerable<AttendeeBase> attendees = null,
            LocationConstraint locationConstraint = null,
            TimeConstraint timeConstraint = null,
            Duration meetingDuration = null,
            Int32? maxCandidates = null,
            bool? isOrganizerOptional = null,
            bool? returnSuggestionReasons = null,
            double? minimumAttendeePercentage = null);

        /// <summary>
        /// Gets the request builder for UserGetMailTips.
        /// </summary>
        /// <returns>The <see cref="IUserGetMailTipsRequestBuilder"/>.</returns>
        IUserGetMailTipsRequestBuilder GetMailTips(
            IEnumerable<string> EmailAddresses,
            MailTipsType? MailTipsOptions = null);

        /// <summary>
        /// Gets the request builder for UserSendMail.
        /// </summary>
        /// <returns>The <see cref="IUserSendMailRequestBuilder"/>.</returns>
        IUserSendMailRequestBuilder SendMail(
            Message Message,
            bool? SaveToSentItems = null);

        /// <summary>
        /// Gets the request builder for UserTranslateExchangeIds.
        /// </summary>
        /// <returns>The <see cref="IUserTranslateExchangeIdsRequestBuilder"/>.</returns>
        IUserTranslateExchangeIdsRequestBuilder TranslateExchangeIds(
            IEnumerable<string> InputIds,
            ExchangeIdFormat TargetIdType,
            ExchangeIdFormat SourceIdType);

        /// <summary>
        /// Gets the request builder for UserRemoveAllDevicesFromManagement.
        /// </summary>
        /// <returns>The <see cref="IUserRemoveAllDevicesFromManagementRequestBuilder"/>.</returns>
        IUserRemoveAllDevicesFromManagementRequestBuilder RemoveAllDevicesFromManagement();

        /// <summary>
        /// Gets the request builder for UserUnblockManagedApps.
        /// </summary>
        /// <returns>The <see cref="IUserUnblockManagedAppsRequestBuilder"/>.</returns>
        IUserUnblockManagedAppsRequestBuilder UnblockManagedApps();

        /// <summary>
        /// Gets the request builder for UserWipeAndBlockManagedApps.
        /// </summary>
        /// <returns>The <see cref="IUserWipeAndBlockManagedAppsRequestBuilder"/>.</returns>
        IUserWipeAndBlockManagedAppsRequestBuilder WipeAndBlockManagedApps();

        /// <summary>
        /// Gets the request builder for UserWipeManagedAppRegistrationByDeviceTag.
        /// </summary>
        /// <returns>The <see cref="IUserWipeManagedAppRegistrationByDeviceTagRequestBuilder"/>.</returns>
        IUserWipeManagedAppRegistrationByDeviceTagRequestBuilder WipeManagedAppRegistrationByDeviceTag(
            string deviceTag = null);

        /// <summary>
        /// Gets the request builder for UserWipeManagedAppRegistrationsByDeviceTag.
        /// </summary>
        /// <returns>The <see cref="IUserWipeManagedAppRegistrationsByDeviceTagRequestBuilder"/>.</returns>
        IUserWipeManagedAppRegistrationsByDeviceTagRequestBuilder WipeManagedAppRegistrationsByDeviceTag(
            string deviceTag = null);

        /// <summary>
        /// Gets the request builder for UserExportPersonalData.
        /// </summary>
        /// <returns>The <see cref="IUserExportPersonalDataRequestBuilder"/>.</returns>
        IUserExportPersonalDataRequestBuilder ExportPersonalData(
            string storageLocation = null);

        /// <summary>
        /// Gets the request builder for UserFindRoomLists.
        /// </summary>
        /// <returns>The <see cref="IUserFindRoomListsRequestBuilder"/>.</returns>
        IUserFindRoomListsRequestBuilder FindRoomLists();

        /// <summary>
        /// Gets the request builder for UserFindRooms.
        /// </summary>
        /// <returns>The <see cref="IUserFindRoomsRequestBuilder"/>.</returns>
        IUserFindRoomsRequestBuilder FindRooms();

        /// <summary>
        /// Gets the request builder for UserFindRooms.
        /// </summary>
        /// <returns>The <see cref="IUserFindRoomsRequestBuilder"/>.</returns>
        IUserFindRoomsRequestBuilder FindRooms(
            string RoomList);

        /// <summary>
        /// Gets the request builder for UserReminderView.
        /// </summary>
        /// <returns>The <see cref="IUserReminderViewRequestBuilder"/>.</returns>
        IUserReminderViewRequestBuilder ReminderView(
            string StartDateTime,
            string EndDateTime = null);

        /// <summary>
        /// Gets the request builder for UserExportDeviceAndAppManagementData.
        /// </summary>
        /// <returns>The <see cref="IUserExportDeviceAndAppManagementDataRequestBuilder"/>.</returns>
        IUserExportDeviceAndAppManagementDataRequestBuilder ExportDeviceAndAppManagementData();

        /// <summary>
        /// Gets the request builder for UserExportDeviceAndAppManagementData.
        /// </summary>
        /// <returns>The <see cref="IUserExportDeviceAndAppManagementDataRequestBuilder"/>.</returns>
        IUserExportDeviceAndAppManagementDataRequestBuilder ExportDeviceAndAppManagementData(
            Int32 skip,
            Int32 top);

        /// <summary>
        /// Gets the request builder for UserGetEffectiveDeviceEnrollmentConfigurations.
        /// </summary>
        /// <returns>The <see cref="IUserGetEffectiveDeviceEnrollmentConfigurationsRequestBuilder"/>.</returns>
        IUserGetEffectiveDeviceEnrollmentConfigurationsRequestBuilder GetEffectiveDeviceEnrollmentConfigurations();

        /// <summary>
        /// Gets the request builder for UserGetLoggedOnManagedDevices.
        /// </summary>
        /// <returns>The <see cref="IUserGetLoggedOnManagedDevicesRequestBuilder"/>.</returns>
        IUserGetLoggedOnManagedDevicesRequestBuilder GetLoggedOnManagedDevices();

        /// <summary>
        /// Gets the request builder for UserGetManagedAppDiagnosticStatuses.
        /// </summary>
        /// <returns>The <see cref="IUserGetManagedAppDiagnosticStatusesRequestBuilder"/>.</returns>
        IUserGetManagedAppDiagnosticStatusesRequestBuilder GetManagedAppDiagnosticStatuses();

        /// <summary>
        /// Gets the request builder for UserGetManagedAppPolicies.
        /// </summary>
        /// <returns>The <see cref="IUserGetManagedAppPoliciesRequestBuilder"/>.</returns>
        IUserGetManagedAppPoliciesRequestBuilder GetManagedAppPolicies();

        /// <summary>
        /// Gets the request builder for UserIsManagedAppUserBlocked.
        /// </summary>
        /// <returns>The <see cref="IUserIsManagedAppUserBlockedRequestBuilder"/>.</returns>
        IUserIsManagedAppUserBlockedRequestBuilder IsManagedAppUserBlocked();

        /// <summary>
        /// Gets the request builder for UserGetManagedDevicesWithAppFailures.
        /// </summary>
        /// <returns>The <see cref="IUserGetManagedDevicesWithAppFailuresRequestBuilder"/>.</returns>
        IUserGetManagedDevicesWithAppFailuresRequestBuilder GetManagedDevicesWithAppFailures();

        /// <summary>
        /// Gets the request builder for UserGetManagedDevicesWithFailedOrPendingApps.
        /// </summary>
        /// <returns>The <see cref="IUserGetManagedDevicesWithFailedOrPendingAppsRequestBuilder"/>.</returns>
        IUserGetManagedDevicesWithFailedOrPendingAppsRequestBuilder GetManagedDevicesWithFailedOrPendingApps();
    
    }
}
