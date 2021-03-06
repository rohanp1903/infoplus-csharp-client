/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
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
using SwaggerDateConverter = Infoplus.Client.SwaggerDateConverter;

namespace Infoplus.Model
{
    /// <summary>
    /// ReqManualSubstitutionInputAPIModel
    /// </summary>
    [DataContract]
    public partial class ReqManualSubstitutionInputAPIModel :  IEquatable<ReqManualSubstitutionInputAPIModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReqManualSubstitutionInputAPIModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReqManualSubstitutionInputAPIModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReqManualSubstitutionInputAPIModel" /> class.
        /// </summary>
        /// <param name="OrderNoList">OrderNoList.</param>
        /// <param name="OriginalSKU">OriginalSKU.</param>
        /// <param name="OriginalKitSKU">OriginalKitSKU.</param>
        /// <param name="OriginalQuantity">OriginalQuantity.</param>
        /// <param name="OriginalComponentSKU">OriginalComponentSKU.</param>
        /// <param name="NewSKU">NewSKU.</param>
        /// <param name="NewQuantity">NewQuantity.</param>
        /// <param name="EditType">EditType (required).</param>
        public ReqManualSubstitutionInputAPIModel(List<decimal?> OrderNoList = default(List<decimal?>), string OriginalSKU = default(string), string OriginalKitSKU = default(string), int? OriginalQuantity = default(int?), string OriginalComponentSKU = default(string), string NewSKU = default(string), int? NewQuantity = default(int?), string EditType = default(string))
        {
            // to ensure "EditType" is required (not null)
            if (EditType == null)
            {
                throw new InvalidDataException("EditType is a required property for ReqManualSubstitutionInputAPIModel and cannot be null");
            }
            else
            {
                this.EditType = EditType;
            }
            this.OrderNoList = OrderNoList;
            this.OriginalSKU = OriginalSKU;
            this.OriginalKitSKU = OriginalKitSKU;
            this.OriginalQuantity = OriginalQuantity;
            this.OriginalComponentSKU = OriginalComponentSKU;
            this.NewSKU = NewSKU;
            this.NewQuantity = NewQuantity;
        }
        
        /// <summary>
        /// Gets or Sets OrderNoList
        /// </summary>
        [DataMember(Name="orderNoList", EmitDefaultValue=false)]
        public List<decimal?> OrderNoList { get; set; }

        /// <summary>
        /// Gets or Sets OriginalSKU
        /// </summary>
        [DataMember(Name="originalSKU", EmitDefaultValue=false)]
        public string OriginalSKU { get; set; }

        /// <summary>
        /// Gets or Sets OriginalKitSKU
        /// </summary>
        [DataMember(Name="originalKitSKU", EmitDefaultValue=false)]
        public string OriginalKitSKU { get; set; }

        /// <summary>
        /// Gets or Sets OriginalQuantity
        /// </summary>
        [DataMember(Name="originalQuantity", EmitDefaultValue=false)]
        public int? OriginalQuantity { get; set; }

        /// <summary>
        /// Gets or Sets OriginalComponentSKU
        /// </summary>
        [DataMember(Name="originalComponentSKU", EmitDefaultValue=false)]
        public string OriginalComponentSKU { get; set; }

        /// <summary>
        /// Gets or Sets NewSKU
        /// </summary>
        [DataMember(Name="newSKU", EmitDefaultValue=false)]
        public string NewSKU { get; set; }

        /// <summary>
        /// Gets or Sets NewQuantity
        /// </summary>
        [DataMember(Name="newQuantity", EmitDefaultValue=false)]
        public int? NewQuantity { get; set; }

        /// <summary>
        /// Gets or Sets EditType
        /// </summary>
        [DataMember(Name="editType", EmitDefaultValue=false)]
        public string EditType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReqManualSubstitutionInputAPIModel {\n");
            sb.Append("  OrderNoList: ").Append(OrderNoList).Append("\n");
            sb.Append("  OriginalSKU: ").Append(OriginalSKU).Append("\n");
            sb.Append("  OriginalKitSKU: ").Append(OriginalKitSKU).Append("\n");
            sb.Append("  OriginalQuantity: ").Append(OriginalQuantity).Append("\n");
            sb.Append("  OriginalComponentSKU: ").Append(OriginalComponentSKU).Append("\n");
            sb.Append("  NewSKU: ").Append(NewSKU).Append("\n");
            sb.Append("  NewQuantity: ").Append(NewQuantity).Append("\n");
            sb.Append("  EditType: ").Append(EditType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as ReqManualSubstitutionInputAPIModel);
        }

        /// <summary>
        /// Returns true if ReqManualSubstitutionInputAPIModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ReqManualSubstitutionInputAPIModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReqManualSubstitutionInputAPIModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderNoList == input.OrderNoList ||
                    this.OrderNoList != null &&
                    this.OrderNoList.SequenceEqual(input.OrderNoList)
                ) && 
                (
                    this.OriginalSKU == input.OriginalSKU ||
                    (this.OriginalSKU != null &&
                    this.OriginalSKU.Equals(input.OriginalSKU))
                ) && 
                (
                    this.OriginalKitSKU == input.OriginalKitSKU ||
                    (this.OriginalKitSKU != null &&
                    this.OriginalKitSKU.Equals(input.OriginalKitSKU))
                ) && 
                (
                    this.OriginalQuantity == input.OriginalQuantity ||
                    (this.OriginalQuantity != null &&
                    this.OriginalQuantity.Equals(input.OriginalQuantity))
                ) && 
                (
                    this.OriginalComponentSKU == input.OriginalComponentSKU ||
                    (this.OriginalComponentSKU != null &&
                    this.OriginalComponentSKU.Equals(input.OriginalComponentSKU))
                ) && 
                (
                    this.NewSKU == input.NewSKU ||
                    (this.NewSKU != null &&
                    this.NewSKU.Equals(input.NewSKU))
                ) && 
                (
                    this.NewQuantity == input.NewQuantity ||
                    (this.NewQuantity != null &&
                    this.NewQuantity.Equals(input.NewQuantity))
                ) && 
                (
                    this.EditType == input.EditType ||
                    (this.EditType != null &&
                    this.EditType.Equals(input.EditType))
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
                if (this.OrderNoList != null)
                    hashCode = hashCode * 59 + this.OrderNoList.GetHashCode();
                if (this.OriginalSKU != null)
                    hashCode = hashCode * 59 + this.OriginalSKU.GetHashCode();
                if (this.OriginalKitSKU != null)
                    hashCode = hashCode * 59 + this.OriginalKitSKU.GetHashCode();
                if (this.OriginalQuantity != null)
                    hashCode = hashCode * 59 + this.OriginalQuantity.GetHashCode();
                if (this.OriginalComponentSKU != null)
                    hashCode = hashCode * 59 + this.OriginalComponentSKU.GetHashCode();
                if (this.NewSKU != null)
                    hashCode = hashCode * 59 + this.NewSKU.GetHashCode();
                if (this.NewQuantity != null)
                    hashCode = hashCode * 59 + this.NewQuantity.GetHashCode();
                if (this.EditType != null)
                    hashCode = hashCode * 59 + this.EditType.GetHashCode();
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
