// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.GetEffectivePermissions
{
    [Obsolete("This class is obsolete. Use GetEffectivePermissionsGetResponse instead.")]
    #pragma warning disable CS1591
    public class GetEffectivePermissionsResponse : GetEffectivePermissionsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GetEffectivePermissionsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GetEffectivePermissionsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetEffectivePermissionsResponse();
        }
    }
}
