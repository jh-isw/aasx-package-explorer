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
    /// Entity
    /// </summary>
    [DataContract]
    public partial class Entity : SubmodelElement, IEquatable<Entity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="entityType">entityType (required).</param>
        /// <param name="globalAssetId">globalAssetId.</param>
        /// <param name="specificAssetIds">specificAssetIds.</param>
        /// <param name="statements">statements.</param>
        public Entity(EntityType entityType = default(EntityType), Reference globalAssetId = default(Reference), List<IdentifierKeyValuePair> specificAssetIds = default(List<IdentifierKeyValuePair>), List<SubmodelElement> statements = default(List<SubmodelElement>), List<EmbeddedDataSpecification> embeddedDataSpecifications = default(List<EmbeddedDataSpecification>), Reference semanticId = default(Reference), List<Constraint> qualifiers = default(List<Constraint>), ModelingKind kind = default(ModelingKind)) : base(embeddedDataSpecifications, semanticId, qualifiers, kind)
        {
            // to ensure "entityType" is required (not null)
            if (entityType == null)
            {
                throw new InvalidDataException("entityType is a required property for Entity and cannot be null");
            }
            else
            {
                this.EntityType = entityType;
            }
            this.GlobalAssetId = globalAssetId;
            this.SpecificAssetIds = specificAssetIds;
            this.Statements = statements;
        }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Gets or Sets GlobalAssetId
        /// </summary>
        [DataMember(Name = "globalAssetId", EmitDefaultValue = false)]
        public Reference GlobalAssetId { get; set; }

        /// <summary>
        /// Gets or Sets SpecificAssetIds
        /// </summary>
        [DataMember(Name = "specificAssetIds", EmitDefaultValue = false)]
        public List<IdentifierKeyValuePair> SpecificAssetIds { get; set; }

        /// <summary>
        /// Gets or Sets Statements
        /// </summary>
        [DataMember(Name = "statements", EmitDefaultValue = false)]
        public List<SubmodelElement> Statements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entity {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  GlobalAssetId: ").Append(GlobalAssetId).Append("\n");
            sb.Append("  SpecificAssetIds: ").Append(SpecificAssetIds).Append("\n");
            sb.Append("  Statements: ").Append(Statements).Append("\n");
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
            return this.Equals(input as Entity);
        }

        /// <summary>
        /// Returns true if Entity instances are equal
        /// </summary>
        /// <param name="input">Instance of Entity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entity input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && base.Equals(input) &&
                (
                    this.GlobalAssetId == input.GlobalAssetId ||
                    (this.GlobalAssetId != null &&
                    this.GlobalAssetId.Equals(input.GlobalAssetId))
                ) && base.Equals(input) &&
                (
                    this.SpecificAssetIds == input.SpecificAssetIds ||
                    this.SpecificAssetIds != null &&
                    input.SpecificAssetIds != null &&
                    this.SpecificAssetIds.SequenceEqual(input.SpecificAssetIds)
                ) && base.Equals(input) &&
                (
                    this.Statements == input.Statements ||
                    this.Statements != null &&
                    input.Statements != null &&
                    this.Statements.SequenceEqual(input.Statements)
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
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.GlobalAssetId != null)
                    hashCode = hashCode * 59 + this.GlobalAssetId.GetHashCode();
                if (this.SpecificAssetIds != null)
                    hashCode = hashCode * 59 + this.SpecificAssetIds.GetHashCode();
                if (this.Statements != null)
                    hashCode = hashCode * 59 + this.Statements.GetHashCode();
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
