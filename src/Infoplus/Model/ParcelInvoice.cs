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
    /// ParcelInvoice
    /// </summary>
    [DataContract]
    public partial class ParcelInvoice :  IEquatable<ParcelInvoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelInvoice" /> class.
        /// </summary>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="Carrier">Carrier.</param>
        /// <param name="InvoiceNo">InvoiceNo.</param>
        /// <param name="AccountNo">AccountNo.</param>
        /// <param name="InvoiceDate">InvoiceDate.</param>
        /// <param name="InvoiceAmount">InvoiceAmount.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public ParcelInvoice(DateTime? CreateDate = default(DateTime?), DateTime? ModifyDate = default(DateTime?), string Carrier = default(string), string InvoiceNo = default(string), string AccountNo = default(string), DateTime? InvoiceDate = default(DateTime?), decimal? InvoiceAmount = default(decimal?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            this.Carrier = Carrier;
            this.InvoiceNo = InvoiceNo;
            this.AccountNo = AccountNo;
            this.InvoiceDate = InvoiceDate;
            this.InvoiceAmount = InvoiceAmount;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

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
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceNo
        /// </summary>
        [DataMember(Name="invoiceNo", EmitDefaultValue=false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Gets or Sets AccountNo
        /// </summary>
        [DataMember(Name="accountNo", EmitDefaultValue=false)]
        public string AccountNo { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDate
        /// </summary>
        [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceAmount
        /// </summary>
        [DataMember(Name="invoiceAmount", EmitDefaultValue=false)]
        public decimal? InvoiceAmount { get; set; }

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
            sb.Append("class ParcelInvoice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceAmount: ").Append(InvoiceAmount).Append("\n");
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
            return this.Equals(input as ParcelInvoice);
        }

        /// <summary>
        /// Returns true if ParcelInvoice instances are equal
        /// </summary>
        /// <param name="input">Instance of ParcelInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParcelInvoice input)
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
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.AccountNo == input.AccountNo ||
                    (this.AccountNo != null &&
                    this.AccountNo.Equals(input.AccountNo))
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.InvoiceAmount == input.InvoiceAmount ||
                    (this.InvoiceAmount != null &&
                    this.InvoiceAmount.Equals(input.InvoiceAmount))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.InvoiceNo != null)
                    hashCode = hashCode * 59 + this.InvoiceNo.GetHashCode();
                if (this.AccountNo != null)
                    hashCode = hashCode * 59 + this.AccountNo.GetHashCode();
                if (this.InvoiceDate != null)
                    hashCode = hashCode * 59 + this.InvoiceDate.GetHashCode();
                if (this.InvoiceAmount != null)
                    hashCode = hashCode * 59 + this.InvoiceAmount.GetHashCode();
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