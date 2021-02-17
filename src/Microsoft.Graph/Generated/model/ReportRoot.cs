// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Report Root.
    /// </summary>
    public partial class ReportRoot : Entity
    {
    
		///<summary>
		/// The ReportRoot constructor
		///</summary>
        public ReportRoot()
        {
            this.ODataType = "microsoft.graph.reportRoot";
        }
	
        /// <summary>
        /// Gets or sets application sign in detailed summary.
        /// </summary>
        [JsonPropertyName("applicationSignInDetailedSummary")]
        public IReportRootApplicationSignInDetailedSummaryCollectionPage ApplicationSignInDetailedSummary { get; set; }
    
        /// <summary>
        /// Gets or sets authentication methods.
        /// </summary>
        [JsonPropertyName("authenticationMethods")]
        public AuthenticationMethodsRoot AuthenticationMethods { get; set; }
    
        /// <summary>
        /// Gets or sets credential user registration details.
        /// </summary>
        [JsonPropertyName("credentialUserRegistrationDetails")]
        public IReportRootCredentialUserRegistrationDetailsCollectionPage CredentialUserRegistrationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets user credential usage details.
        /// </summary>
        [JsonPropertyName("userCredentialUsageDetails")]
        public IReportRootUserCredentialUsageDetailsCollectionPage UserCredentialUsageDetails { get; set; }
    
        /// <summary>
        /// Gets or sets daily print usage by printer.
        /// </summary>
        [JsonPropertyName("dailyPrintUsageByPrinter")]
        public IReportRootDailyPrintUsageByPrinterCollectionPage DailyPrintUsageByPrinter { get; set; }
    
        /// <summary>
        /// Gets or sets daily print usage by user.
        /// </summary>
        [JsonPropertyName("dailyPrintUsageByUser")]
        public IReportRootDailyPrintUsageByUserCollectionPage DailyPrintUsageByUser { get; set; }
    
        /// <summary>
        /// Gets or sets daily print usage summaries by printer.
        /// </summary>
        [JsonPropertyName("dailyPrintUsageSummariesByPrinter")]
        public IReportRootDailyPrintUsageSummariesByPrinterCollectionPage DailyPrintUsageSummariesByPrinter { get; set; }
    
        /// <summary>
        /// Gets or sets daily print usage summaries by user.
        /// </summary>
        [JsonPropertyName("dailyPrintUsageSummariesByUser")]
        public IReportRootDailyPrintUsageSummariesByUserCollectionPage DailyPrintUsageSummariesByUser { get; set; }
    
        /// <summary>
        /// Gets or sets monthly print usage by printer.
        /// </summary>
        [JsonPropertyName("monthlyPrintUsageByPrinter")]
        public IReportRootMonthlyPrintUsageByPrinterCollectionPage MonthlyPrintUsageByPrinter { get; set; }
    
        /// <summary>
        /// Gets or sets monthly print usage by user.
        /// </summary>
        [JsonPropertyName("monthlyPrintUsageByUser")]
        public IReportRootMonthlyPrintUsageByUserCollectionPage MonthlyPrintUsageByUser { get; set; }
    
        /// <summary>
        /// Gets or sets monthly print usage summaries by printer.
        /// </summary>
        [JsonPropertyName("monthlyPrintUsageSummariesByPrinter")]
        public IReportRootMonthlyPrintUsageSummariesByPrinterCollectionPage MonthlyPrintUsageSummariesByPrinter { get; set; }
    
        /// <summary>
        /// Gets or sets monthly print usage summaries by user.
        /// </summary>
        [JsonPropertyName("monthlyPrintUsageSummariesByUser")]
        public IReportRootMonthlyPrintUsageSummariesByUserCollectionPage MonthlyPrintUsageSummariesByUser { get; set; }
    
    }
}

