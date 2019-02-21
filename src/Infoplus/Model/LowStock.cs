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
    /// LowStock
    /// </summary>
    [DataContract]
    public partial class LowStock :  IEquatable<LowStock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LowStock" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LowStock() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LowStock" /> class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="Sku">Sku.</param>
        public LowStock(int? WarehouseId = default(int?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>), string Sku = default(string))
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for LowStock and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            this.CustomFields = CustomFields;
            this.Sku = Sku;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }

        /// <summary>
        /// Gets or Sets LowLevelDate
        /// </summary>
        [DataMember(Name="lowLevelDate", EmitDefaultValue=false)]
        public DateTime? LowLevelDate { get; private set; }

        /// <summary>
        /// Gets or Sets LowStockMessage
        /// </summary>
        [DataMember(Name="lowStockMessage", EmitDefaultValue=false)]
        public string LowStockMessage { get; private set; }

        /// <summary>
        /// Gets or Sets PrintFlag
        /// </summary>
        [DataMember(Name="printFlag", EmitDefaultValue=false)]
        public string PrintFlag { get; private set; }

        /// <summary>
        /// Gets or Sets IsDelayed
        /// </summary>
        [DataMember(Name="isDelayed", EmitDefaultValue=false)]
        public bool? IsDelayed { get; private set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }

        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LowStock {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LowLevelDate: ").Append(LowLevelDate).Append("\n");
            sb.Append("  LowStockMessage: ").Append(LowStockMessage).Append("\n");
            sb.Append("  PrintFlag: ").Append(PrintFlag).Append("\n");
            sb.Append("  IsDelayed: ").Append(IsDelayed).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
            return this.Equals(input as LowStock);
        }

        /// <summary>
        /// Returns true if LowStock instances are equal
        /// </summary>
        /// <param name="input">Instance of LowStock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LowStock input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
                ) && 
                (
                    this.LowLevelDate == input.LowLevelDate ||
                    (this.LowLevelDate != null &&
                    this.LowLevelDate.Equals(input.LowLevelDate))
                ) && 
                (
                    this.LowStockMessage == input.LowStockMessage ||
                    (this.LowStockMessage != null &&
                    this.LowStockMessage.Equals(input.LowStockMessage))
                ) && 
                (
                    this.PrintFlag == input.PrintFlag ||
                    (this.PrintFlag != null &&
                    this.PrintFlag.Equals(input.PrintFlag))
                ) && 
                (
                    this.IsDelayed == input.IsDelayed ||
                    (this.IsDelayed != null &&
                    this.IsDelayed.Equals(input.IsDelayed))
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
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.LowLevelDate != null)
                    hashCode = hashCode * 59 + this.LowLevelDate.GetHashCode();
                if (this.LowStockMessage != null)
                    hashCode = hashCode * 59 + this.LowStockMessage.GetHashCode();
                if (this.PrintFlag != null)
                    hashCode = hashCode * 59 + this.PrintFlag.GetHashCode();
                if (this.IsDelayed != null)
                    hashCode = hashCode * 59 + this.IsDelayed.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
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