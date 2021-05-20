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
    /// The type Ti Indicator.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TiIndicator>))]
    public partial class TiIndicator : Entity
    {
    
        /// <summary>
        /// Gets or sets action.
        /// The action to apply if the indicator is matched from within the targetProduct security tool. Possible values are: unknown, allow, block, alert. Required.
        /// </summary>
        [JsonPropertyName("action")]
        public TiAction? Action { get; set; }
    
        /// <summary>
        /// Gets or sets activity group names.
        /// The cyber threat intelligence name(s) for the parties responsible for the malicious activity covered by the threat indicator.
        /// </summary>
        [JsonPropertyName("activityGroupNames")]
        public IEnumerable<string> ActivityGroupNames { get; set; }
    
        /// <summary>
        /// Gets or sets additional information.
        /// A catchall area into which extra data from the indicator not covered by the other tiIndicator properties may be placed. Data placed into additionalInformation will typically not be utilized by the targetProduct security tool.
        /// </summary>
        [JsonPropertyName("additionalInformation")]
        public string AdditionalInformation { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// Stamped by the system when the indicator is ingested. The Azure Active Directory tenant id of submitting client. Required.
        /// </summary>
        [JsonPropertyName("azureTenantId")]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets confidence.
        /// An integer representing the confidence the data within the indicator accurately identifies malicious behavior. Acceptable values are 0 – 100 with 100 being the highest.
        /// </summary>
        [JsonPropertyName("confidence")]
        public Int32? Confidence { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Brief description (100 characters or less) of the threat represented by the indicator. Required.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets diamond model.
        /// The area of the Diamond Model in which this indicator exists. Possible values are: unknown, adversary, capability, infrastructure, victim.
        /// </summary>
        [JsonPropertyName("diamondModel")]
        public DiamondModel? DiamondModel { get; set; }
    
        /// <summary>
        /// Gets or sets domain name.
        /// </summary>
        [JsonPropertyName("domainName")]
        public string DomainName { get; set; }
    
        /// <summary>
        /// Gets or sets email encoding.
        /// </summary>
        [JsonPropertyName("emailEncoding")]
        public string EmailEncoding { get; set; }
    
        /// <summary>
        /// Gets or sets email language.
        /// </summary>
        [JsonPropertyName("emailLanguage")]
        public string EmailLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets email recipient.
        /// </summary>
        [JsonPropertyName("emailRecipient")]
        public string EmailRecipient { get; set; }
    
        /// <summary>
        /// Gets or sets email sender address.
        /// </summary>
        [JsonPropertyName("emailSenderAddress")]
        public string EmailSenderAddress { get; set; }
    
        /// <summary>
        /// Gets or sets email sender name.
        /// </summary>
        [JsonPropertyName("emailSenderName")]
        public string EmailSenderName { get; set; }
    
        /// <summary>
        /// Gets or sets email source domain.
        /// </summary>
        [JsonPropertyName("emailSourceDomain")]
        public string EmailSourceDomain { get; set; }
    
        /// <summary>
        /// Gets or sets email source ip address.
        /// </summary>
        [JsonPropertyName("emailSourceIpAddress")]
        public string EmailSourceIpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets email subject.
        /// </summary>
        [JsonPropertyName("emailSubject")]
        public string EmailSubject { get; set; }
    
        /// <summary>
        /// Gets or sets email xmailer.
        /// </summary>
        [JsonPropertyName("emailXMailer")]
        public string EmailXMailer { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// DateTime string indicating when the Indicator expires. All indicators must have an expiration date to avoid stale indicators persisting in the system. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// An identification number that ties the indicator back to the indicator provider’s system (e.g. a foreign key).
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets file compile date time.
        /// </summary>
        [JsonPropertyName("fileCompileDateTime")]
        public DateTimeOffset? FileCompileDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets file created date time.
        /// </summary>
        [JsonPropertyName("fileCreatedDateTime")]
        public DateTimeOffset? FileCreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets file hash type.
        /// </summary>
        [JsonPropertyName("fileHashType")]
        public FileHashType? FileHashType { get; set; }
    
        /// <summary>
        /// Gets or sets file hash value.
        /// </summary>
        [JsonPropertyName("fileHashValue")]
        public string FileHashValue { get; set; }
    
        /// <summary>
        /// Gets or sets file mutex name.
        /// </summary>
        [JsonPropertyName("fileMutexName")]
        public string FileMutexName { get; set; }
    
        /// <summary>
        /// Gets or sets file name.
        /// </summary>
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets file packer.
        /// </summary>
        [JsonPropertyName("filePacker")]
        public string FilePacker { get; set; }
    
        /// <summary>
        /// Gets or sets file path.
        /// </summary>
        [JsonPropertyName("filePath")]
        public string FilePath { get; set; }
    
        /// <summary>
        /// Gets or sets file size.
        /// </summary>
        [JsonPropertyName("fileSize")]
        public Int64? FileSize { get; set; }
    
        /// <summary>
        /// Gets or sets file type.
        /// </summary>
        [JsonPropertyName("fileType")]
        public string FileType { get; set; }
    
        /// <summary>
        /// Gets or sets ingested date time.
        /// Stamped by the system when the indicator is ingested. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("ingestedDateTime")]
        public DateTimeOffset? IngestedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets is active.
        /// Used to deactivate indicators within system. By default, any indicator submitted is set as active. However, providers may submit existing indicators with this set to ‘False’ to deactivate indicators in the system.
        /// </summary>
        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }
    
        /// <summary>
        /// Gets or sets kill chain.
        /// A JSON array of strings that describes which point or points on the Kill Chain this indicator targets. See ‘killChain values’ below for exact values.
        /// </summary>
        [JsonPropertyName("killChain")]
        public IEnumerable<string> KillChain { get; set; }
    
        /// <summary>
        /// Gets or sets known false positives.
        /// Scenarios in which the indicator may cause false positives. This should be human-readable text.
        /// </summary>
        [JsonPropertyName("knownFalsePositives")]
        public string KnownFalsePositives { get; set; }
    
        /// <summary>
        /// Gets or sets last reported date time.
        /// The last time the indicator was seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("lastReportedDateTime")]
        public DateTimeOffset? LastReportedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets malware family names.
        /// The malware family name associated with an indicator if it exists. Microsoft prefers the Microsoft malware family name if at all possible which can be found via the Windows Defender Security Intelligence threat encyclopedia.
        /// </summary>
        [JsonPropertyName("malwareFamilyNames")]
        public IEnumerable<string> MalwareFamilyNames { get; set; }
    
        /// <summary>
        /// Gets or sets network cidr block.
        /// </summary>
        [JsonPropertyName("networkCidrBlock")]
        public string NetworkCidrBlock { get; set; }
    
        /// <summary>
        /// Gets or sets network destination asn.
        /// </summary>
        [JsonPropertyName("networkDestinationAsn")]
        public Int64? NetworkDestinationAsn { get; set; }
    
        /// <summary>
        /// Gets or sets network destination cidr block.
        /// </summary>
        [JsonPropertyName("networkDestinationCidrBlock")]
        public string NetworkDestinationCidrBlock { get; set; }
    
        /// <summary>
        /// Gets or sets network destination ipv4.
        /// </summary>
        [JsonPropertyName("networkDestinationIPv4")]
        public string NetworkDestinationIPv4 { get; set; }
    
        /// <summary>
        /// Gets or sets network destination ipv6.
        /// </summary>
        [JsonPropertyName("networkDestinationIPv6")]
        public string NetworkDestinationIPv6 { get; set; }
    
        /// <summary>
        /// Gets or sets network destination port.
        /// </summary>
        [JsonPropertyName("networkDestinationPort")]
        public Int32? NetworkDestinationPort { get; set; }
    
        /// <summary>
        /// Gets or sets network ipv4.
        /// </summary>
        [JsonPropertyName("networkIPv4")]
        public string NetworkIPv4 { get; set; }
    
        /// <summary>
        /// Gets or sets network ipv6.
        /// </summary>
        [JsonPropertyName("networkIPv6")]
        public string NetworkIPv6 { get; set; }
    
        /// <summary>
        /// Gets or sets network port.
        /// </summary>
        [JsonPropertyName("networkPort")]
        public Int32? NetworkPort { get; set; }
    
        /// <summary>
        /// Gets or sets network protocol.
        /// </summary>
        [JsonPropertyName("networkProtocol")]
        public Int32? NetworkProtocol { get; set; }
    
        /// <summary>
        /// Gets or sets network source asn.
        /// </summary>
        [JsonPropertyName("networkSourceAsn")]
        public Int64? NetworkSourceAsn { get; set; }
    
        /// <summary>
        /// Gets or sets network source cidr block.
        /// </summary>
        [JsonPropertyName("networkSourceCidrBlock")]
        public string NetworkSourceCidrBlock { get; set; }
    
        /// <summary>
        /// Gets or sets network source ipv4.
        /// </summary>
        [JsonPropertyName("networkSourceIPv4")]
        public string NetworkSourceIPv4 { get; set; }
    
        /// <summary>
        /// Gets or sets network source ipv6.
        /// </summary>
        [JsonPropertyName("networkSourceIPv6")]
        public string NetworkSourceIPv6 { get; set; }
    
        /// <summary>
        /// Gets or sets network source port.
        /// </summary>
        [JsonPropertyName("networkSourcePort")]
        public Int32? NetworkSourcePort { get; set; }
    
        /// <summary>
        /// Gets or sets passive only.
        /// Determines if the indicator should trigger an event that is visible to an end-user. When set to ‘true,’ security tools will not notify the end user that a ‘hit’ has occurred. This is most often treated as audit or silent mode by security products where they will simply log that a match occurred but will not perform the action. Default value is false.
        /// </summary>
        [JsonPropertyName("passiveOnly")]
        public bool? PassiveOnly { get; set; }
    
        /// <summary>
        /// Gets or sets severity.
        /// An integer representing the severity of the malicious behavior identified by the data within the indicator. Acceptable values are 0 – 5 where 5 is the most severe and zero is not severe at all. Default value is 3.
        /// </summary>
        [JsonPropertyName("severity")]
        public Int32? Severity { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// A JSON array of strings that stores arbitrary tags/keywords.
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets target product.
        /// A string value representing a single security product to which the indicator should be applied. Acceptable values are: Azure Sentinel, Microsoft Defender ATP. Required
        /// </summary>
        [JsonPropertyName("targetProduct")]
        public string TargetProduct { get; set; }
    
        /// <summary>
        /// Gets or sets threat type.
        /// Each indicator must have a valid Indicator Threat Type. Possible values are: Botnet, C2, CryptoMining, Darknet, DDoS, MaliciousUrl, Malware, Phishing, Proxy, PUA, WatchList. Required.
        /// </summary>
        [JsonPropertyName("threatType")]
        public string ThreatType { get; set; }
    
        /// <summary>
        /// Gets or sets tlp level.
        /// Traffic Light Protocol value for the indicator. Possible values are: unknown, white, green, amber, red. Required.
        /// </summary>
        [JsonPropertyName("tlpLevel")]
        public TlpLevel? TlpLevel { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or sets user agent.
        /// </summary>
        [JsonPropertyName("userAgent")]
        public string UserAgent { get; set; }
    
    }
}

