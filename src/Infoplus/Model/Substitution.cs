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
    /// Substitution
    /// </summary>
    [DataContract]
    public partial class Substitution :  IEquatable<Substitution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Substitution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Substitution() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Substitution" /> class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="OrderSKUId">OrderSKUId (required).</param>
        /// <param name="SubstituteSKUId">SubstituteSKUId (required).</param>
        /// <param name="Period">Period (required).</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="SubstitutionQuantity">SubstitutionQuantity (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public Substitution(int? LobId = default(int?), DateTime? CreateDate = default(DateTime?), DateTime? ModifyDate = default(DateTime?), int? OrderSKUId = default(int?), int? SubstituteSKUId = default(int?), string Period = default(string), string Type = default(string), decimal? SubstitutionQuantity = default(decimal?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Substitution and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "OrderSKUId" is required (not null)
            if (OrderSKUId == null)
            {
                throw new InvalidDataException("OrderSKUId is a required property for Substitution and cannot be null");
            }
            else
            {
                this.OrderSKUId = OrderSKUId;
            }
            // to ensure "SubstituteSKUId" is required (not null)
            if (SubstituteSKUId == null)
            {
                throw new InvalidDataException("SubstituteSKUId is a required property for Substitution and cannot be null");
            }
            else
            {
                this.SubstituteSKUId = SubstituteSKUId;
            }
            // to ensure "Period" is required (not null)
            if (Period == null)
            {
                throw new InvalidDataException("Period is a required property for Substitution and cannot be null");
            }
            else
            {
                this.Period = Period;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Substitution and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "SubstitutionQuantity" is required (not null)
            if (SubstitutionQuantity == null)
            {
                throw new InvalidDataException("SubstitutionQuantity is a required property for Substitution and cannot be null");
            }
            else
            {
                this.SubstitutionQuantity = SubstitutionQuantity;
            }
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets OrderSKUId
        /// </summary>
        [DataMember(Name="orderSKUId", EmitDefaultValue=false)]
        public int? OrderSKUId { get; set; }

        /// <summary>
        /// Gets or Sets SubstituteSKUId
        /// </summary>
        [DataMember(Name="substituteSKUId", EmitDefaultValue=false)]
        public int? SubstituteSKUId { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SubstitutionQuantity
        /// </summary>
        [DataMember(Name="substitutionQuantity", EmitDefaultValue=false)]
        public decimal? SubstitutionQuantity { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Substitution {\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderSKUId: ").Append(OrderSKUId).Append("\n");
            sb.Append("  SubstituteSKUId: ").Append(SubstituteSKUId).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubstitutionQuantity: ").Append(SubstitutionQuantity).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
            return this.Equals(input as Substitution);
        }

        /// <summary>
        /// Returns true if Substitution instances are equal
        /// </summary>
        /// <param name="input">Instance of Substitution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Substitution input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.ModifyDate == input.ModifyDate ||
                    (this.ModifyDate != null &&
                    this.ModifyDate.Equals(input.ModifyDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrderSKUId == input.OrderSKUId ||
                    (this.OrderSKUId != null &&
                    this.OrderSKUId.Equals(input.OrderSKUId))
                ) && 
                (
                    this.SubstituteSKUId == input.SubstituteSKUId ||
                    (this.SubstituteSKUId != null &&
                    this.SubstituteSKUId.Equals(input.SubstituteSKUId))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SubstitutionQuantity == input.SubstitutionQuantity ||
                    (this.SubstitutionQuantity != null &&
                    this.SubstitutionQuantity.Equals(input.SubstitutionQuantity))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
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
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OrderSKUId != null)
                    hashCode = hashCode * 59 + this.OrderSKUId.GetHashCode();
                if (this.SubstituteSKUId != null)
                    hashCode = hashCode * 59 + this.SubstituteSKUId.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SubstitutionQuantity != null)
                    hashCode = hashCode * 59 + this.SubstitutionQuantity.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
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