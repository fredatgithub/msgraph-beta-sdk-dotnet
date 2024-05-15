// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class CertificateAuthorityAsEntity : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The trusted certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Certificate
        {
            get { return BackingStore?.Get<byte[]?>("certificate"); }
            set { BackingStore?.Set("certificate", value); }
        }
#nullable restore
#else
        public byte[] Certificate
        {
            get { return BackingStore?.Get<byte[]>("certificate"); }
            set { BackingStore?.Set("certificate", value); }
        }
#endif
        /// <summary>Indicates if the certificate is a root authority. In a certificateBasedApplicationConfiguration object, at least one object in the trustedCertificateAuthorities collection must be a root authority.</summary>
        public bool? IsRootAuthority
        {
            get { return BackingStore?.Get<bool?>("isRootAuthority"); }
            set { BackingStore?.Set("isRootAuthority", value); }
        }
        /// <summary>The issuer of the trusted certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer
        {
            get { return BackingStore?.Get<string?>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#nullable restore
#else
        public string Issuer
        {
            get { return BackingStore?.Get<string>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#endif
        /// <summary>The subject key identifier of the trusted certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerSubjectKeyIdentifier
        {
            get { return BackingStore?.Get<string?>("issuerSubjectKeyIdentifier"); }
            set { BackingStore?.Set("issuerSubjectKeyIdentifier", value); }
        }
#nullable restore
#else
        public string IssuerSubjectKeyIdentifier
        {
            get { return BackingStore?.Get<string>("issuerSubjectKeyIdentifier"); }
            set { BackingStore?.Set("issuerSubjectKeyIdentifier", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CertificateAuthorityAsEntity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CertificateAuthorityAsEntity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CertificateAuthorityAsEntity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificate", n => { Certificate = n.GetByteArrayValue(); } },
                { "isRootAuthority", n => { IsRootAuthority = n.GetBoolValue(); } },
                { "issuer", n => { Issuer = n.GetStringValue(); } },
                { "issuerSubjectKeyIdentifier", n => { IssuerSubjectKeyIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("certificate", Certificate);
            writer.WriteBoolValue("isRootAuthority", IsRootAuthority);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("issuerSubjectKeyIdentifier", IssuerSubjectKeyIdentifier);
        }
    }
}
