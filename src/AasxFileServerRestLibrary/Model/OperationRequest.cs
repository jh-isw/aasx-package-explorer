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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// OperationRequest
    /// </summary>
    [DataContract]
    public partial class OperationRequest : IEquatable<OperationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationRequest" /> class.
        /// </summary>
        /// <param name="inoutputArguments">inoutputArguments.</param>
        /// <param name="inputArguments">inputArguments.</param>
        /// <param name="requestId">requestId.</param>
        /// <param name="timeout">timeout.</param>
        public OperationRequest(List<OperationVariable> inoutputArguments = default(List<OperationVariable>), List<OperationVariable> inputArguments = default(List<OperationVariable>), string requestId = default(string), int? timeout = default(int?))
        {
            this.InoutputArguments = inoutputArguments;
            this.InputArguments = inputArguments;
            this.RequestId = requestId;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Gets or Sets InoutputArguments
        /// </summary>
        [DataMember(Name = "inoutputArguments", EmitDefaultValue = false)]
        public List<OperationVariable> InoutputArguments { get; set; }

        /// <summary>
        /// Gets or Sets InputArguments
        /// </summary>
        [DataMember(Name = "inputArguments", EmitDefaultValue = false)]
        public List<OperationVariable> InputArguments { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationRequest {\n");
            sb.Append("  InoutputArguments: ").Append(InoutputArguments).Append("\n");
            sb.Append("  InputArguments: ").Append(InputArguments).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as OperationRequest);
        }

        /// <summary>
        /// Returns true if OperationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.InoutputArguments == input.InoutputArguments ||
                    this.InoutputArguments != null &&
                    input.InoutputArguments != null &&
                    this.InoutputArguments.SequenceEqual(input.InoutputArguments)
                ) &&
                (
                    this.InputArguments == input.InputArguments ||
                    this.InputArguments != null &&
                    input.InputArguments != null &&
                    this.InputArguments.SequenceEqual(input.InputArguments)
                ) &&
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) &&
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                int hashCode = 41;
                if (this.InoutputArguments != null)
                    hashCode = hashCode * 59 + this.InoutputArguments.GetHashCode();
                if (this.InputArguments != null)
                    hashCode = hashCode * 59 + this.InputArguments.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
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
