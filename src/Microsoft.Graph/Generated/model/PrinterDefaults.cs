// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type PrinterDefaults.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PrinterDefaults
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterDefaults"/> class.
        /// </summary>
        public PrinterDefaults()
        {
            this.ODataType = "microsoft.graph.printerDefaults";
        }

        /// <summary>
        /// Gets or sets colorMode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "colorMode", Required = Newtonsoft.Json.Required.Default)]
        public PrintColorMode? ColorMode { get; set; }
    
        /// <summary>
        /// Gets or sets contentType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentType", Required = Newtonsoft.Json.Required.Default)]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets copiesPerJob.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "copiesPerJob", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CopiesPerJob { get; set; }
    
        /// <summary>
        /// Gets or sets documentMimeType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "documentMimeType", Required = Newtonsoft.Json.Required.Default)]
        public string DocumentMimeType { get; set; }
    
        /// <summary>
        /// Gets or sets dpi.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dpi", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Dpi { get; set; }
    
        /// <summary>
        /// Gets or sets duplexConfiguration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "duplexConfiguration", Required = Newtonsoft.Json.Required.Default)]
        public PrintDuplexConfiguration? DuplexConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets duplexMode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "duplexMode", Required = Newtonsoft.Json.Required.Default)]
        public PrintDuplexMode? DuplexMode { get; set; }
    
        /// <summary>
        /// Gets or sets finishings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "finishings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrintFinishing> Finishings { get; set; }
    
        /// <summary>
        /// Gets or sets fitPdfToPage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fitPdfToPage", Required = Newtonsoft.Json.Required.Default)]
        public bool? FitPdfToPage { get; set; }
    
        /// <summary>
        /// Gets or sets mediaColor.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaColor", Required = Newtonsoft.Json.Required.Default)]
        public string MediaColor { get; set; }
    
        /// <summary>
        /// Gets or sets mediaSize.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaSize", Required = Newtonsoft.Json.Required.Default)]
        public string MediaSize { get; set; }
    
        /// <summary>
        /// Gets or sets mediaType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaType", Required = Newtonsoft.Json.Required.Default)]
        public string MediaType { get; set; }
    
        /// <summary>
        /// Gets or sets multipageLayout.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multipageLayout", Required = Newtonsoft.Json.Required.Default)]
        public PrintMultipageLayout? MultipageLayout { get; set; }
    
        /// <summary>
        /// Gets or sets orientation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orientation", Required = Newtonsoft.Json.Required.Default)]
        public PrintOrientation? Orientation { get; set; }
    
        /// <summary>
        /// Gets or sets outputBin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outputBin", Required = Newtonsoft.Json.Required.Default)]
        public string OutputBin { get; set; }
    
        /// <summary>
        /// Gets or sets pagesPerSheet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pagesPerSheet", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PagesPerSheet { get; set; }
    
        /// <summary>
        /// Gets or sets pdfFitToPage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pdfFitToPage", Required = Newtonsoft.Json.Required.Default)]
        public bool? PdfFitToPage { get; set; }
    
        /// <summary>
        /// Gets or sets presentationDirection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "presentationDirection", Required = Newtonsoft.Json.Required.Default)]
        public PrintPresentationDirection? PresentationDirection { get; set; }
    
        /// <summary>
        /// Gets or sets printColorConfiguration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "printColorConfiguration", Required = Newtonsoft.Json.Required.Default)]
        public PrintColorConfiguration? PrintColorConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets printQuality.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "printQuality", Required = Newtonsoft.Json.Required.Default)]
        public PrintQuality? PrintQuality { get; set; }
    
        /// <summary>
        /// Gets or sets quality.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quality", Required = Newtonsoft.Json.Required.Default)]
        public PrintQuality? Quality { get; set; }
    
        /// <summary>
        /// Gets or sets scaling.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scaling", Required = Newtonsoft.Json.Required.Default)]
        public PrintScaling? Scaling { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}