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
    /// ReceivingWorksheet
    /// </summary>
    [DataContract]
    public partial class ReceivingWorksheet :  IEquatable<ReceivingWorksheet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivingWorksheet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReceivingWorksheet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivingWorksheet" /> class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="PoNoId">PoNoId.</param>
        /// <param name="LobId">LobId.</param>
        /// <param name="VendorId">VendorId.</param>
        /// <param name="ServiceLevel">ServiceLevel (required).</param>
        /// <param name="ReceivingProcessId">ReceivingProcessId.</param>
        /// <param name="DockDate">DockDate.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="WorksheetName">WorksheetName (required).</param>
        /// <param name="Carrier">Carrier.</param>
        /// <param name="OnTheDock">OnTheDock (default to false).</param>
        /// <param name="AutoCommit">AutoCommit (required) (default to false).</param>
        /// <param name="LineItems">LineItems.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public ReceivingWorksheet(int? WarehouseId = default(int?), int? PoNoId = default(int?), int? LobId = default(int?), int? VendorId = default(int?), string ServiceLevel = default(string), int? ReceivingProcessId = default(int?), DateTime? DockDate = default(DateTime?), int? CreatedBy = default(int?), string WorksheetName = default(string), string Carrier = default(string), bool? OnTheDock = false, bool? AutoCommit = false, List<ReceivingWorksheetLineItem> LineItems = default(List<ReceivingWorksheetLineItem>), string Notes = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for ReceivingWorksheet and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "ServiceLevel" is required (not null)
            if (ServiceLevel == null)
            {
                throw new InvalidDataException("ServiceLevel is a required property for ReceivingWorksheet and cannot be null");
            }
            else
            {
                this.ServiceLevel = ServiceLevel;
            }
            // to ensure "WorksheetName" is required (not null)
            if (WorksheetName == null)
            {
                throw new InvalidDataException("WorksheetName is a required property for ReceivingWorksheet and cannot be null");
            }
            else
            {
                this.WorksheetName = WorksheetName;
            }
            // to ensure "AutoCommit" is required (not null)
            if (AutoCommit == null)
            {
                throw new InvalidDataException("AutoCommit is a required property for ReceivingWorksheet and cannot be null");
            }
            else
            {
                this.AutoCommit = AutoCommit;
            }
            this.PoNoId = PoNoId;
            this.LobId = LobId;
            this.VendorId = VendorId;
            this.ReceivingProcessId = ReceivingProcessId;
            this.DockDate = DockDate;
            this.CreatedBy = CreatedBy;
            this.Carrier = Carrier;
            // use default value if no "OnTheDock" provided
            if (OnTheDock == null)
            {
                this.OnTheDock = false;
            }
            else
            {
                this.OnTheDock = OnTheDock;
            }
            this.LineItems = LineItems;
            this.Notes = Notes;
            this.CustomFields = CustomFields;
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
        /// Gets or Sets PoNoId
        /// </summary>
        [DataMember(Name="poNoId", EmitDefaultValue=false)]
        public int? PoNoId { get; set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendorId", EmitDefaultValue=false)]
        public int? VendorId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or Sets ServiceLevel
        /// </summary>
        [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
        public string ServiceLevel { get; set; }

        /// <summary>
        /// Gets or Sets ReceivingProcessId
        /// </summary>
        [DataMember(Name="receivingProcessId", EmitDefaultValue=false)]
        public int? ReceivingProcessId { get; set; }

        /// <summary>
        /// Gets or Sets DockDate
        /// </summary>
        [DataMember(Name="dockDate", EmitDefaultValue=false)]
        public DateTime? DockDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets WorksheetName
        /// </summary>
        [DataMember(Name="worksheetName", EmitDefaultValue=false)]
        public string WorksheetName { get; set; }

        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or Sets OnTheDock
        /// </summary>
        [DataMember(Name="onTheDock", EmitDefaultValue=false)]
        public bool? OnTheDock { get; set; }

        /// <summary>
        /// Gets or Sets AutoCommit
        /// </summary>
        [DataMember(Name="autoCommit", EmitDefaultValue=false)]
        public bool? AutoCommit { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<ReceivingWorksheetLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets WorkBatchId
        /// </summary>
        [DataMember(Name="workBatchId", EmitDefaultValue=false)]
        public int? WorkBatchId { get; private set; }

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
            sb.Append("class ReceivingWorksheet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  PoNoId: ").Append(PoNoId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
            sb.Append("  ReceivingProcessId: ").Append(ReceivingProcessId).Append("\n");
            sb.Append("  DockDate: ").Append(DockDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  WorksheetName: ").Append(WorksheetName).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  OnTheDock: ").Append(OnTheDock).Append("\n");
            sb.Append("  AutoCommit: ").Append(AutoCommit).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  WorkBatchId: ").Append(WorkBatchId).Append("\n");
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
            return this.Equals(input as ReceivingWorksheet);
        }

        /// <summary>
        /// Returns true if ReceivingWorksheet instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceivingWorksheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivingWorksheet input)
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
                    this.PoNoId == input.PoNoId ||
                    (this.PoNoId != null &&
                    this.PoNoId.Equals(input.PoNoId))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.VendorId == input.VendorId ||
                    (this.VendorId != null &&
                    this.VendorId.Equals(input.VendorId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ServiceLevel == input.ServiceLevel ||
                    (this.ServiceLevel != null &&
                    this.ServiceLevel.Equals(input.ServiceLevel))
                ) && 
                (
                    this.ReceivingProcessId == input.ReceivingProcessId ||
                    (this.ReceivingProcessId != null &&
                    this.ReceivingProcessId.Equals(input.ReceivingProcessId))
                ) && 
                (
                    this.DockDate == input.DockDate ||
                    (this.DockDate != null &&
                    this.DockDate.Equals(input.DockDate))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.WorksheetName == input.WorksheetName ||
                    (this.WorksheetName != null &&
                    this.WorksheetName.Equals(input.WorksheetName))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.OnTheDock == input.OnTheDock ||
                    (this.OnTheDock != null &&
                    this.OnTheDock.Equals(input.OnTheDock))
                ) && 
                (
                    this.AutoCommit == input.AutoCommit ||
                    (this.AutoCommit != null &&
                    this.AutoCommit.Equals(input.AutoCommit))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.WorkBatchId == input.WorkBatchId ||
                    (this.WorkBatchId != null &&
                    this.WorkBatchId.Equals(input.WorkBatchId))
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
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.PoNoId != null)
                    hashCode = hashCode * 59 + this.PoNoId.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.VendorId != null)
                    hashCode = hashCode * 59 + this.VendorId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ServiceLevel != null)
                    hashCode = hashCode * 59 + this.ServiceLevel.GetHashCode();
                if (this.ReceivingProcessId != null)
                    hashCode = hashCode * 59 + this.ReceivingProcessId.GetHashCode();
                if (this.DockDate != null)
                    hashCode = hashCode * 59 + this.DockDate.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.WorksheetName != null)
                    hashCode = hashCode * 59 + this.WorksheetName.GetHashCode();
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.OnTheDock != null)
                    hashCode = hashCode * 59 + this.OnTheDock.GetHashCode();
                if (this.AutoCommit != null)
                    hashCode = hashCode * 59 + this.AutoCommit.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.WorkBatchId != null)
                    hashCode = hashCode * 59 + this.WorkBatchId.GetHashCode();
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
