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
    /// The type Customer Payment.
    /// </summary>
    public partial class CustomerPayment : Entity
    {
    
        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [JsonPropertyName("amount")]
        public Decimal? Amount { get; set; }
    
        /// <summary>
        /// Gets or sets applies to invoice id.
        /// </summary>
        [JsonPropertyName("appliesToInvoiceId")]
        public Guid? AppliesToInvoiceId { get; set; }
    
        /// <summary>
        /// Gets or sets applies to invoice number.
        /// </summary>
        [JsonPropertyName("appliesToInvoiceNumber")]
        public string AppliesToInvoiceNumber { get; set; }
    
        /// <summary>
        /// Gets or sets comment.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets or sets contact id.
        /// </summary>
        [JsonPropertyName("contactId")]
        public string ContactId { get; set; }
    
        /// <summary>
        /// Gets or sets customer id.
        /// </summary>
        [JsonPropertyName("customerId")]
        public Guid? CustomerId { get; set; }
    
        /// <summary>
        /// Gets or sets customer number.
        /// </summary>
        [JsonPropertyName("customerNumber")]
        public string CustomerNumber { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets document number.
        /// </summary>
        [JsonPropertyName("documentNumber")]
        public string DocumentNumber { get; set; }
    
        /// <summary>
        /// Gets or sets external document number.
        /// </summary>
        [JsonPropertyName("externalDocumentNumber")]
        public string ExternalDocumentNumber { get; set; }
    
        /// <summary>
        /// Gets or sets journal display name.
        /// </summary>
        [JsonPropertyName("journalDisplayName")]
        public string JournalDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets line number.
        /// </summary>
        [JsonPropertyName("lineNumber")]
        public Int32? LineNumber { get; set; }
    
        /// <summary>
        /// Gets or sets posting date.
        /// </summary>
        [JsonPropertyName("postingDate")]
        public Date PostingDate { get; set; }
    
        /// <summary>
        /// Gets or sets customer.
        /// </summary>
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
    
    }
}

