using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class Person : Entity, IParsable {
        /// <summary>The person's birthday.</summary>
        public string Birthday { get; set; }
        /// <summary>The name of the person's company.</summary>
        public string CompanyName { get; set; }
        /// <summary>The person's department.</summary>
        public string Department { get; set; }
        /// <summary>The person's display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The person's email addresses.</summary>
        public List<RankedEmailAddress> EmailAddresses { get; set; }
        /// <summary>The person's given name.</summary>
        public string GivenName { get; set; }
        /// <summary>true if the user has flagged this person as a favorite.</summary>
        public bool? IsFavorite { get; set; }
        /// <summary>The type of mailbox that is represented by the person's email address.</summary>
        public string MailboxType { get; set; }
        /// <summary>The location of the person's office.</summary>
        public string OfficeLocation { get; set; }
        /// <summary>Free-form notes that the user has taken about this person.</summary>
        public string PersonNotes { get; set; }
        /// <summary>The type of person.</summary>
        public string PersonType { get; set; }
        /// <summary>The person's phone numbers.</summary>
        public List<Phone> Phones { get; set; }
        /// <summary>The person's addresses.</summary>
        public List<Location> PostalAddresses { get; set; }
        /// <summary>The person's profession.</summary>
        public string Profession { get; set; }
        /// <summary>The sources the user data comes from, for example Directory or Outlook Contacts.</summary>
        public List<PersonDataSource> Sources { get; set; }
        /// <summary>The person's surname.</summary>
        public string Surname { get; set; }
        /// <summary>The person's title.</summary>
        public string Title { get; set; }
        /// <summary>The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet standard RFC 822. By convention, this should map to the person's email name. The general format is alias@domain.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>The person's websites.</summary>
        public List<Website> Websites { get; set; }
        /// <summary>The phonetic Japanese name of the person's company.</summary>
        public string YomiCompany { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Person CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Person();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"birthday", (o,n) => { (o as Person).Birthday = n.GetStringValue(); } },
                {"companyName", (o,n) => { (o as Person).CompanyName = n.GetStringValue(); } },
                {"department", (o,n) => { (o as Person).Department = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Person).DisplayName = n.GetStringValue(); } },
                {"emailAddresses", (o,n) => { (o as Person).EmailAddresses = n.GetCollectionOfObjectValues<RankedEmailAddress>(RankedEmailAddress.CreateFromDiscriminatorValue).ToList(); } },
                {"givenName", (o,n) => { (o as Person).GivenName = n.GetStringValue(); } },
                {"isFavorite", (o,n) => { (o as Person).IsFavorite = n.GetBoolValue(); } },
                {"mailboxType", (o,n) => { (o as Person).MailboxType = n.GetStringValue(); } },
                {"officeLocation", (o,n) => { (o as Person).OfficeLocation = n.GetStringValue(); } },
                {"personNotes", (o,n) => { (o as Person).PersonNotes = n.GetStringValue(); } },
                {"personType", (o,n) => { (o as Person).PersonType = n.GetStringValue(); } },
                {"phones", (o,n) => { (o as Person).Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue).ToList(); } },
                {"postalAddresses", (o,n) => { (o as Person).PostalAddresses = n.GetCollectionOfObjectValues<Location>(Location.CreateFromDiscriminatorValue).ToList(); } },
                {"profession", (o,n) => { (o as Person).Profession = n.GetStringValue(); } },
                {"sources", (o,n) => { (o as Person).Sources = n.GetCollectionOfObjectValues<PersonDataSource>(PersonDataSource.CreateFromDiscriminatorValue).ToList(); } },
                {"surname", (o,n) => { (o as Person).Surname = n.GetStringValue(); } },
                {"title", (o,n) => { (o as Person).Title = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as Person).UserPrincipalName = n.GetStringValue(); } },
                {"websites", (o,n) => { (o as Person).Websites = n.GetCollectionOfObjectValues<Website>(Website.CreateFromDiscriminatorValue).ToList(); } },
                {"yomiCompany", (o,n) => { (o as Person).YomiCompany = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("birthday", Birthday);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<RankedEmailAddress>("emailAddresses", EmailAddresses);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteBoolValue("isFavorite", IsFavorite);
            writer.WriteStringValue("mailboxType", MailboxType);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteStringValue("personNotes", PersonNotes);
            writer.WriteStringValue("personType", PersonType);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteCollectionOfObjectValues<Location>("postalAddresses", PostalAddresses);
            writer.WriteStringValue("profession", Profession);
            writer.WriteCollectionOfObjectValues<PersonDataSource>("sources", Sources);
            writer.WriteStringValue("surname", Surname);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfObjectValues<Website>("websites", Websites);
            writer.WriteStringValue("yomiCompany", YomiCompany);
        }
    }
}
