// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Ready4Tech.Kiota.Client.Models {
    /// <summary>
    /// Output response for DawnDusk Calculation
    /// </summary>
    public class DawnDuskCalculationOutputResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The calculationId property</summary>
        public Guid? CalculationId { get; set; }
        /// <summary>Sunrise time</summary>
        public DateTimeOffset? Sunrise { get; set; }
        /// <summary>Sunset time</summary>
        public DateTimeOffset? Sunset { get; set; }
        /// <summary>Zenith time</summary>
        public DateTimeOffset? Zenith { get; set; }
        /// <summary>
        /// Instantiates a new DawnDuskCalculationOutputResponse and sets the default values.
        /// </summary>
        public DawnDuskCalculationOutputResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DawnDuskCalculationOutputResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DawnDuskCalculationOutputResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"calculationId", n => { CalculationId = n.GetGuidValue(); } },
                {"sunrise", n => { Sunrise = n.GetDateTimeOffsetValue(); } },
                {"sunset", n => { Sunset = n.GetDateTimeOffsetValue(); } },
                {"zenith", n => { Zenith = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("calculationId", CalculationId);
            writer.WriteDateTimeOffsetValue("sunrise", Sunrise);
            writer.WriteDateTimeOffsetValue("sunset", Sunset);
            writer.WriteDateTimeOffsetValue("zenith", Zenith);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}