// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [Flags]
    #pragma warning disable CS1591
    public enum DataSourceScopes
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "allTenantMailboxes")]
        #pragma warning disable CS1591
        AllTenantMailboxes = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "allTenantSites")]
        #pragma warning disable CS1591
        AllTenantSites = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "allCaseCustodians")]
        #pragma warning disable CS1591
        AllCaseCustodians = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "allCaseNoncustodialDataSources")]
        #pragma warning disable CS1591
        AllCaseNoncustodialDataSources = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 32,
        #pragma warning restore CS1591
    }
}
