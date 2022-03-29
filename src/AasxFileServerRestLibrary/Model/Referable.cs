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
    /// Referable
    /// </summary>
    [DataContract]
    public partial class Referable : HasExtensions, IEquatable<Referable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Referable" /> class.
        /// </summary>
        /// <param name="category">category.</param>
        /// <param name="description">description.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="idShort">idShort (required).</param>
        /// <param name="modelType">modelType (required).</param>
        public Referable(string category = default(string), List<LangString> description = default(List<LangString>), List<LangString> displayName = default(List<LangString>), string idShort = default(string), ModelType modelType = default(ModelType), List<Extension> extensions = default(List<Extension>)) : base(extensions)
        {
            // to ensure "idShort" is required (not null)
            if (idShort == null)
            {
                throw new InvalidDataException("idShort is a required property for Referable and cannot be null");
            }
            else
            {
                this.IdShort = idShort;
            }
            // to ensure "modelType" is required (not null)
            if (modelType == null)
            {
                throw new InvalidDataException("modelType is a required property for Referable and cannot be null");
            }
            else
            {
                this.ModelType = modelType;
            }
            this.Category = category;
            this.Description = description;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public List<LangString> Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public List<LangString> DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets IdShort
        /// </summary>
        [DataMember(Name = "idShort", EmitDefaultValue = false)]
        public string IdShort { get; set; }

        /// <summary>
        /// Gets or Sets ModelType
        /// </summary>
        [DataMember(Name = "modelType", EmitDefaultValue = false)]
        public ModelType ModelType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Referable {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IdShort: ").Append(IdShort).Append("\n");
            sb.Append("  ModelType: ").Append(ModelType).Append("\n");
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
            return this.Equals(input as Referable);
        }

        /// <summary>
        /// Returns true if Referable instances are equal
        /// </summary>
        /// <param name="input">Instance of Referable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Referable input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && base.Equals(input) &&
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && base.Equals(input) &&
                (
                    this.DisplayName == input.DisplayName ||
                    this.DisplayName != null &&
                    input.DisplayName != null &&
                    this.DisplayName.SequenceEqual(input.DisplayName)
                ) && base.Equals(input) &&
                (
                    this.IdShort == input.IdShort ||
                    (this.IdShort != null &&
                    this.IdShort.Equals(input.IdShort))
                ) && base.Equals(input) &&
                (
                    this.ModelType == input.ModelType ||
                    (this.ModelType != null &&
                    this.ModelType.Equals(input.ModelType))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.IdShort != null)
                    hashCode = hashCode * 59 + this.IdShort.GetHashCode();
                if (this.ModelType != null)
                    hashCode = hashCode * 59 + this.ModelType.GetHashCode();
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
