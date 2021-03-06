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
    /// EmailTemplate
    /// </summary>
    [DataContract]
    public partial class EmailTemplate :  IEquatable<EmailTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplate" /> class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Subject">Subject (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="FromName">FromName (required).</param>
        /// <param name="FromAddress">FromAddress (required).</param>
        /// <param name="ToName">ToName.</param>
        /// <param name="ToAddress">ToAddress.</param>
        /// <param name="CcAddress">CcAddress.</param>
        /// <param name="BccAddress">BccAddress.</param>
        /// <param name="EmailTemplateType">EmailTemplateType (required).</param>
        /// <param name="RecordType">RecordType.</param>
        /// <param name="ApiVersion">ApiVersion.</param>
        /// <param name="ScriptId">ScriptId.</param>
        /// <param name="SendToBillTo">SendToBillTo (default to false).</param>
        /// <param name="SendToShipTo">SendToShipTo (default to false).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public EmailTemplate(int? LobId = default(int?), string Subject = default(string), string Name = default(string), string FromName = default(string), string FromAddress = default(string), string ToName = default(string), string ToAddress = default(string), string CcAddress = default(string), string BccAddress = default(string), string EmailTemplateType = default(string), string RecordType = default(string), string ApiVersion = default(string), int? ScriptId = default(int?), bool? SendToBillTo = false, bool? SendToShipTo = false, Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Subject" is required (not null)
            if (Subject == null)
            {
                throw new InvalidDataException("Subject is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.Subject = Subject;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "FromName" is required (not null)
            if (FromName == null)
            {
                throw new InvalidDataException("FromName is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.FromName = FromName;
            }
            // to ensure "FromAddress" is required (not null)
            if (FromAddress == null)
            {
                throw new InvalidDataException("FromAddress is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.FromAddress = FromAddress;
            }
            // to ensure "EmailTemplateType" is required (not null)
            if (EmailTemplateType == null)
            {
                throw new InvalidDataException("EmailTemplateType is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.EmailTemplateType = EmailTemplateType;
            }
            this.ToName = ToName;
            this.ToAddress = ToAddress;
            this.CcAddress = CcAddress;
            this.BccAddress = BccAddress;
            this.RecordType = RecordType;
            this.ApiVersion = ApiVersion;
            this.ScriptId = ScriptId;
            // use default value if no "SendToBillTo" provided
            if (SendToBillTo == null)
            {
                this.SendToBillTo = false;
            }
            else
            {
                this.SendToBillTo = SendToBillTo;
            }
            // use default value if no "SendToShipTo" provided
            if (SendToShipTo == null)
            {
                this.SendToShipTo = false;
            }
            else
            {
                this.SendToShipTo = SendToShipTo;
            }
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FromName
        /// </summary>
        [DataMember(Name="fromName", EmitDefaultValue=false)]
        public string FromName { get; set; }

        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public string FromAddress { get; set; }

        /// <summary>
        /// Gets or Sets ToName
        /// </summary>
        [DataMember(Name="toName", EmitDefaultValue=false)]
        public string ToName { get; set; }

        /// <summary>
        /// Gets or Sets ToAddress
        /// </summary>
        [DataMember(Name="toAddress", EmitDefaultValue=false)]
        public string ToAddress { get; set; }

        /// <summary>
        /// Gets or Sets CcAddress
        /// </summary>
        [DataMember(Name="ccAddress", EmitDefaultValue=false)]
        public string CcAddress { get; set; }

        /// <summary>
        /// Gets or Sets BccAddress
        /// </summary>
        [DataMember(Name="bccAddress", EmitDefaultValue=false)]
        public string BccAddress { get; set; }

        /// <summary>
        /// Gets or Sets EmailTemplateType
        /// </summary>
        [DataMember(Name="emailTemplateType", EmitDefaultValue=false)]
        public string EmailTemplateType { get; set; }

        /// <summary>
        /// Gets or Sets RecordType
        /// </summary>
        [DataMember(Name="recordType", EmitDefaultValue=false)]
        public string RecordType { get; set; }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets ScriptId
        /// </summary>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public int? ScriptId { get; set; }

        /// <summary>
        /// Gets or Sets SendToBillTo
        /// </summary>
        [DataMember(Name="sendToBillTo", EmitDefaultValue=false)]
        public bool? SendToBillTo { get; set; }

        /// <summary>
        /// Gets or Sets SendToShipTo
        /// </summary>
        [DataMember(Name="sendToShipTo", EmitDefaultValue=false)]
        public bool? SendToShipTo { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FromName: ").Append(FromName).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToName: ").Append(ToName).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  CcAddress: ").Append(CcAddress).Append("\n");
            sb.Append("  BccAddress: ").Append(BccAddress).Append("\n");
            sb.Append("  EmailTemplateType: ").Append(EmailTemplateType).Append("\n");
            sb.Append("  RecordType: ").Append(RecordType).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  SendToBillTo: ").Append(SendToBillTo).Append("\n");
            sb.Append("  SendToShipTo: ").Append(SendToShipTo).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
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
            return this.Equals(input as EmailTemplate);
        }

        /// <summary>
        /// Returns true if EmailTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailTemplate input)
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
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FromName == input.FromName ||
                    (this.FromName != null &&
                    this.FromName.Equals(input.FromName))
                ) && 
                (
                    this.FromAddress == input.FromAddress ||
                    (this.FromAddress != null &&
                    this.FromAddress.Equals(input.FromAddress))
                ) && 
                (
                    this.ToName == input.ToName ||
                    (this.ToName != null &&
                    this.ToName.Equals(input.ToName))
                ) && 
                (
                    this.ToAddress == input.ToAddress ||
                    (this.ToAddress != null &&
                    this.ToAddress.Equals(input.ToAddress))
                ) && 
                (
                    this.CcAddress == input.CcAddress ||
                    (this.CcAddress != null &&
                    this.CcAddress.Equals(input.CcAddress))
                ) && 
                (
                    this.BccAddress == input.BccAddress ||
                    (this.BccAddress != null &&
                    this.BccAddress.Equals(input.BccAddress))
                ) && 
                (
                    this.EmailTemplateType == input.EmailTemplateType ||
                    (this.EmailTemplateType != null &&
                    this.EmailTemplateType.Equals(input.EmailTemplateType))
                ) && 
                (
                    this.RecordType == input.RecordType ||
                    (this.RecordType != null &&
                    this.RecordType.Equals(input.RecordType))
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.ScriptId == input.ScriptId ||
                    (this.ScriptId != null &&
                    this.ScriptId.Equals(input.ScriptId))
                ) && 
                (
                    this.SendToBillTo == input.SendToBillTo ||
                    (this.SendToBillTo != null &&
                    this.SendToBillTo.Equals(input.SendToBillTo))
                ) && 
                (
                    this.SendToShipTo == input.SendToShipTo ||
                    (this.SendToShipTo != null &&
                    this.SendToShipTo.Equals(input.SendToShipTo))
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
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FromName != null)
                    hashCode = hashCode * 59 + this.FromName.GetHashCode();
                if (this.FromAddress != null)
                    hashCode = hashCode * 59 + this.FromAddress.GetHashCode();
                if (this.ToName != null)
                    hashCode = hashCode * 59 + this.ToName.GetHashCode();
                if (this.ToAddress != null)
                    hashCode = hashCode * 59 + this.ToAddress.GetHashCode();
                if (this.CcAddress != null)
                    hashCode = hashCode * 59 + this.CcAddress.GetHashCode();
                if (this.BccAddress != null)
                    hashCode = hashCode * 59 + this.BccAddress.GetHashCode();
                if (this.EmailTemplateType != null)
                    hashCode = hashCode * 59 + this.EmailTemplateType.GetHashCode();
                if (this.RecordType != null)
                    hashCode = hashCode * 59 + this.RecordType.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.ScriptId != null)
                    hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.SendToBillTo != null)
                    hashCode = hashCode * 59 + this.SendToBillTo.GetHashCode();
                if (this.SendToShipTo != null)
                    hashCode = hashCode * 59 + this.SendToShipTo.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
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
