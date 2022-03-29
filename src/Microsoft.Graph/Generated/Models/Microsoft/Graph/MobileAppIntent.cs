namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum MobileAppIntent {
        Available,
        NotAvailable,
        RequiredInstall,
        RequiredUninstall,
        RequiredAndAvailableInstall,
        AvailableInstallWithoutEnrollment,
        Exclude,
    }
}
