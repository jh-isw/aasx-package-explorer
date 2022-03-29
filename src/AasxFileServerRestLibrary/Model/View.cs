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
    /// View
    /// </summary>
    [DataContract]
    public partial class View : Referable, IEquatable<View>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="View" /> class.
        /// </summary>
        /// <param name="embeddedDataSpecifications">embeddedDataSpecifications.</param>
        /// <param name="semanticId">semanticId.</param>
        /// <param name="containedElements">containedElements.</param>
        public View(List<EmbeddedDataSpecification> embeddedDataSpecifications = default(List<EmbeddedDataSpecification>), Reference semanticId = default(Reference), List<Reference> containedElements = default(List<Reference>), List<EmbeddedDataSpecification> embeddedDataSpecifications2 = default(List<EmbeddedDataSpecification>), Reference semanticId2 = default(Reference), string category = default(string), List<LangString> description = default(List<LangString>), List<LangString> displayName = default(List<LangString>), string idShort = default(string), ModelType modelType = default(ModelType)) : base(category, description, displayName, idShort, modelType)
        {
            this.EmbeddedDataSpecifications = embeddedDataSpecifications;
            this.SemanticId = semanticId;
            this.ContainedElements = containedElements;
        }

        /// <summary>
        /// Gets or Sets EmbeddedDataSpecifications
        /// </summary>
        [DataMember(Name = "embeddedDataSpecifications", EmitDefaultValue = false)]
        public List<EmbeddedDataSpecification> EmbeddedDataSpecifications { get; set; }

        /// <summary>
        /// Gets or Sets SemanticId
        /// </summary>
        [DataMember(Name = "semanticId", EmitDefaultValue = false)]
        public Reference SemanticId { get; set; }

        /// <summary>
        /// Gets or Sets ContainedElements
        /// </summary>
        [DataMember(Name = "containedElements", EmitDefaultValue = false)]
        public List<Reference> ContainedElements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class View {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EmbeddedDataSpecifications: ").Append(EmbeddedDataSpecifications).Append("\n");
            sb.Append("  SemanticId: ").Append(SemanticId).Append("\n");
            sb.Append("  ContainedElements: ").Append(ContainedElements).Append("\n");
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
            return this.Equals(input as View);
        }

        /// <summary>
        /// Returns true if View instances are equal
        /// </summary>
        /// <param name="input">Instance of View to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(View input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.EmbeddedDataSpecifications == input.EmbeddedDataSpecifications ||
                    this.EmbeddedDataSpecifications != null &&
                    input.EmbeddedDataSpecifications != null &&
                    this.EmbeddedDataSpecifications.SequenceEqual(input.EmbeddedDataSpecifications)
                ) && base.Equals(input) &&
                (
                    this.SemanticId == input.SemanticId ||
                    (this.SemanticId != null &&
                    this.SemanticId.Equals(input.SemanticId))
                ) && base.Equals(input) &&
                (
                    this.ContainedElements == input.ContainedElements ||
                    this.ContainedElements != null &&
                    input.ContainedElements != null &&
                    this.ContainedElements.SequenceEqual(input.ContainedElements)
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
                if (this.EmbeddedDataSpecifications != null)
                    hashCode = hashCode * 59 + this.EmbeddedDataSpecifications.GetHashCode();
                if (this.SemanticId != null)
                    hashCode = hashCode * 59 + this.SemanticId.GetHashCode();
                if (this.ContainedElements != null)
                    hashCode = hashCode * 59 + this.ContainedElements.GetHashCode();
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
