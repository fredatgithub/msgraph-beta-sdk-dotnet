// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.Item.IsPublished
{
    [Obsolete("This class is obsolete. Use IsPublishedGetResponse instead.")]
    #pragma warning disable CS1591
    public class IsPublishedResponse : IsPublishedGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IsPublishedResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IsPublishedResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IsPublishedResponse();
        }
    }
}
