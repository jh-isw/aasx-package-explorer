/* 
 * DotAAS Part 2 | HTTP/REST | Entire Interface Collection
 *
 * The entire interface collection as part of Details of the Asset Administration Shell Part 2
 *
 * OpenAPI spec version: Final-Draft
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// MultiLanguageProperty
    /// </summary>
    [DataContract]
    public partial class MultiLanguageProperty : SubmodelElement, IEquatable<MultiLanguageProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiLanguageProperty" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="valueId">valueId.</param>
        public MultiLanguageProperty(List<LangString> value = default(List<LangString>), Reference valueId = default(Reference), List<EmbeddedDataSpecification> embeddedDataSpecifications = default(List<EmbeddedDataSpecification>), Reference semanticId = default(Reference), List<Constraint> qualifiers = default(List<Constraint>), ModelingKind kind = default(ModelingKind)) : base(embeddedDataSpecifications, semanticId, qualifiers, kind)
        {
            this.Value = value;
            this.ValueId = valueId;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public List<LangString> Value { get; set; }

        /// <summary>
        /// Gets or Sets ValueId
        /// </summary>
        [DataMember(Name = "valueId", EmitDefaultValue = false)]
        public Reference ValueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiLanguageProperty {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueId: ").Append(ValueId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultiLanguageProperty);
        }

        /// <summary>
        /// Returns true if MultiLanguageProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiLanguageProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiLanguageProperty input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && base.Equals(input) &&
                (
                    this.ValueId == input.ValueId ||
                    (this.ValueId != null &&
                    this.ValueId.Equals(input.ValueId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ValueId != null)
                    hashCode = hashCode * 59 + this.ValueId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
