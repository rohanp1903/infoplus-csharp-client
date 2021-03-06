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
    /// JobTimeActivity
    /// </summary>
    [DataContract]
    public partial class JobTimeActivity :  IEquatable<JobTimeActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTimeActivity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobTimeActivity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTimeActivity" /> class.
        /// </summary>
        /// <param name="SecondDuration">SecondDuration (required).</param>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="Email">Email.</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="JobTypeId">JobTypeId (required).</param>
        /// <param name="JobTypeName">JobTypeName.</param>
        /// <param name="Note">Note.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public JobTimeActivity(int? SecondDuration = default(int?), int? UserId = default(int?), string Email = default(string), int? LobId = default(int?), int? JobTypeId = default(int?), string JobTypeName = default(string), string Note = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "SecondDuration" is required (not null)
            if (SecondDuration == null)
            {
                throw new InvalidDataException("SecondDuration is a required property for JobTimeActivity and cannot be null");
            }
            else
            {
                this.SecondDuration = SecondDuration;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for JobTimeActivity and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for JobTimeActivity and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "JobTypeId" is required (not null)
            if (JobTypeId == null)
            {
                throw new InvalidDataException("JobTypeId is a required property for JobTimeActivity and cannot be null");
            }
            else
            {
                this.JobTypeId = JobTypeId;
            }
            this.Email = Email;
            this.JobTypeName = JobTypeName;
            this.Note = Note;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets ImportedId
        /// </summary>
        [DataMember(Name="importedId", EmitDefaultValue=false)]
        public int? ImportedId { get; private set; }

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
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; private set; }

        /// <summary>
        /// Gets or Sets SecondDuration
        /// </summary>
        [DataMember(Name="secondDuration", EmitDefaultValue=false)]
        public int? SecondDuration { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets JobTypeId
        /// </summary>
        [DataMember(Name="jobTypeId", EmitDefaultValue=false)]
        public int? JobTypeId { get; set; }

        /// <summary>
        /// Gets or Sets JobTypeName
        /// </summary>
        [DataMember(Name="jobTypeName", EmitDefaultValue=false)]
        public string JobTypeName { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets BillingQuantity
        /// </summary>
        [DataMember(Name="billingQuantity", EmitDefaultValue=false)]
        public decimal? BillingQuantity { get; private set; }

        /// <summary>
        /// Gets or Sets ChargeRate
        /// </summary>
        [DataMember(Name="chargeRate", EmitDefaultValue=false)]
        public decimal? ChargeRate { get; private set; }

        /// <summary>
        /// Gets or Sets ExtendedCharge
        /// </summary>
        [DataMember(Name="extendedCharge", EmitDefaultValue=false)]
        public decimal? ExtendedCharge { get; private set; }

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
            sb.Append("class JobTimeActivity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImportedId: ").Append(ImportedId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  SecondDuration: ").Append(SecondDuration).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  JobTypeId: ").Append(JobTypeId).Append("\n");
            sb.Append("  JobTypeName: ").Append(JobTypeName).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  BillingQuantity: ").Append(BillingQuantity).Append("\n");
            sb.Append("  ChargeRate: ").Append(ChargeRate).Append("\n");
            sb.Append("  ExtendedCharge: ").Append(ExtendedCharge).Append("\n");
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
            return this.Equals(input as JobTimeActivity);
        }

        /// <summary>
        /// Returns true if JobTimeActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of JobTimeActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobTimeActivity input)
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
                    this.ImportedId == input.ImportedId ||
                    (this.ImportedId != null &&
                    this.ImportedId.Equals(input.ImportedId))
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
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.SecondDuration == input.SecondDuration ||
                    (this.SecondDuration != null &&
                    this.SecondDuration.Equals(input.SecondDuration))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.JobTypeId == input.JobTypeId ||
                    (this.JobTypeId != null &&
                    this.JobTypeId.Equals(input.JobTypeId))
                ) && 
                (
                    this.JobTypeName == input.JobTypeName ||
                    (this.JobTypeName != null &&
                    this.JobTypeName.Equals(input.JobTypeName))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.BillingQuantity == input.BillingQuantity ||
                    (this.BillingQuantity != null &&
                    this.BillingQuantity.Equals(input.BillingQuantity))
                ) && 
                (
                    this.ChargeRate == input.ChargeRate ||
                    (this.ChargeRate != null &&
                    this.ChargeRate.Equals(input.ChargeRate))
                ) && 
                (
                    this.ExtendedCharge == input.ExtendedCharge ||
                    (this.ExtendedCharge != null &&
                    this.ExtendedCharge.Equals(input.ExtendedCharge))
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
                if (this.ImportedId != null)
                    hashCode = hashCode * 59 + this.ImportedId.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.SecondDuration != null)
                    hashCode = hashCode * 59 + this.SecondDuration.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.JobTypeId != null)
                    hashCode = hashCode * 59 + this.JobTypeId.GetHashCode();
                if (this.JobTypeName != null)
                    hashCode = hashCode * 59 + this.JobTypeName.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.BillingQuantity != null)
                    hashCode = hashCode * 59 + this.BillingQuantity.GetHashCode();
                if (this.ChargeRate != null)
                    hashCode = hashCode * 59 + this.ChargeRate.GetHashCode();
                if (this.ExtendedCharge != null)
                    hashCode = hashCode * 59 + this.ExtendedCharge.GetHashCode();
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
