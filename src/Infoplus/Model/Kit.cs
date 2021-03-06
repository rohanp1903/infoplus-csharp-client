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
    /// Kit
    /// </summary>
    [DataContract]
    public partial class Kit :  IEquatable<Kit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Kit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Kit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Kit" /> class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="KitSKU">KitSKU (required).</param>
        /// <param name="PackagingType">PackagingType.</param>
        /// <param name="Other">Other.</param>
        /// <param name="Line1">Line1.</param>
        /// <param name="Line2">Line2.</param>
        /// <param name="Line3">Line3.</param>
        /// <param name="Line4">Line4.</param>
        /// <param name="Line5">Line5.</param>
        /// <param name="Line6">Line6.</param>
        /// <param name="Line7">Line7.</param>
        /// <param name="Line8">Line8.</param>
        /// <param name="Touches">Touches (required).</param>
        /// <param name="MinInvQty">MinInvQty.</param>
        /// <param name="MidInvQty">MidInvQty.</param>
        /// <param name="MaxInvQty">MaxInvQty.</param>
        /// <param name="IsKOD">IsKOD (required).</param>
        /// <param name="KodType">KodType.</param>
        /// <param name="KitComponentList">KitComponentList (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public Kit(int? LobId = default(int?), string KitSKU = default(string), string PackagingType = default(string), string Other = default(string), string Line1 = default(string), string Line2 = default(string), string Line3 = default(string), string Line4 = default(string), string Line5 = default(string), string Line6 = default(string), string Line7 = default(string), string Line8 = default(string), int? Touches = default(int?), int? MinInvQty = default(int?), int? MidInvQty = default(int?), int? MaxInvQty = default(int?), string IsKOD = default(string), string KodType = default(string), List<KitComponent> KitComponentList = default(List<KitComponent>), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Kit and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "KitSKU" is required (not null)
            if (KitSKU == null)
            {
                throw new InvalidDataException("KitSKU is a required property for Kit and cannot be null");
            }
            else
            {
                this.KitSKU = KitSKU;
            }
            // to ensure "Touches" is required (not null)
            if (Touches == null)
            {
                throw new InvalidDataException("Touches is a required property for Kit and cannot be null");
            }
            else
            {
                this.Touches = Touches;
            }
            // to ensure "IsKOD" is required (not null)
            if (IsKOD == null)
            {
                throw new InvalidDataException("IsKOD is a required property for Kit and cannot be null");
            }
            else
            {
                this.IsKOD = IsKOD;
            }
            // to ensure "KitComponentList" is required (not null)
            if (KitComponentList == null)
            {
                throw new InvalidDataException("KitComponentList is a required property for Kit and cannot be null");
            }
            else
            {
                this.KitComponentList = KitComponentList;
            }
            this.PackagingType = PackagingType;
            this.Other = Other;
            this.Line1 = Line1;
            this.Line2 = Line2;
            this.Line3 = Line3;
            this.Line4 = Line4;
            this.Line5 = Line5;
            this.Line6 = Line6;
            this.Line7 = Line7;
            this.Line8 = Line8;
            this.MinInvQty = MinInvQty;
            this.MidInvQty = MidInvQty;
            this.MaxInvQty = MaxInvQty;
            this.KodType = KodType;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets KitSKU
        /// </summary>
        [DataMember(Name="kitSKU", EmitDefaultValue=false)]
        public string KitSKU { get; set; }

        /// <summary>
        /// Gets or Sets PackagingType
        /// </summary>
        [DataMember(Name="packagingType", EmitDefaultValue=false)]
        public string PackagingType { get; set; }

        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue=false)]
        public string Other { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfComponents
        /// </summary>
        [DataMember(Name="numberOfComponents", EmitDefaultValue=false)]
        public int? NumberOfComponents { get; private set; }

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
        /// Gets or Sets Line1
        /// </summary>
        [DataMember(Name="line1", EmitDefaultValue=false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Gets or Sets Line2
        /// </summary>
        [DataMember(Name="line2", EmitDefaultValue=false)]
        public string Line2 { get; set; }

        /// <summary>
        /// Gets or Sets Line3
        /// </summary>
        [DataMember(Name="line3", EmitDefaultValue=false)]
        public string Line3 { get; set; }

        /// <summary>
        /// Gets or Sets Line4
        /// </summary>
        [DataMember(Name="line4", EmitDefaultValue=false)]
        public string Line4 { get; set; }

        /// <summary>
        /// Gets or Sets Line5
        /// </summary>
        [DataMember(Name="line5", EmitDefaultValue=false)]
        public string Line5 { get; set; }

        /// <summary>
        /// Gets or Sets Line6
        /// </summary>
        [DataMember(Name="line6", EmitDefaultValue=false)]
        public string Line6 { get; set; }

        /// <summary>
        /// Gets or Sets Line7
        /// </summary>
        [DataMember(Name="line7", EmitDefaultValue=false)]
        public string Line7 { get; set; }

        /// <summary>
        /// Gets or Sets Line8
        /// </summary>
        [DataMember(Name="line8", EmitDefaultValue=false)]
        public string Line8 { get; set; }

        /// <summary>
        /// Gets or Sets Touches
        /// </summary>
        [DataMember(Name="touches", EmitDefaultValue=false)]
        public int? Touches { get; set; }

        /// <summary>
        /// Gets or Sets MinInvQty
        /// </summary>
        [DataMember(Name="minInvQty", EmitDefaultValue=false)]
        public int? MinInvQty { get; set; }

        /// <summary>
        /// Gets or Sets MidInvQty
        /// </summary>
        [DataMember(Name="midInvQty", EmitDefaultValue=false)]
        public int? MidInvQty { get; set; }

        /// <summary>
        /// Gets or Sets MaxInvQty
        /// </summary>
        [DataMember(Name="maxInvQty", EmitDefaultValue=false)]
        public int? MaxInvQty { get; set; }

        /// <summary>
        /// Gets or Sets IsKOD
        /// </summary>
        [DataMember(Name="isKOD", EmitDefaultValue=false)]
        public string IsKOD { get; set; }

        /// <summary>
        /// Gets or Sets KodType
        /// </summary>
        [DataMember(Name="kodType", EmitDefaultValue=false)]
        public string KodType { get; set; }

        /// <summary>
        /// Gets or Sets KitComponentList
        /// </summary>
        [DataMember(Name="kitComponentList", EmitDefaultValue=false)]
        public List<KitComponent> KitComponentList { get; set; }

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
            sb.Append("class Kit {\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  KitSKU: ").Append(KitSKU).Append("\n");
            sb.Append("  PackagingType: ").Append(PackagingType).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  NumberOfComponents: ").Append(NumberOfComponents).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  Line3: ").Append(Line3).Append("\n");
            sb.Append("  Line4: ").Append(Line4).Append("\n");
            sb.Append("  Line5: ").Append(Line5).Append("\n");
            sb.Append("  Line6: ").Append(Line6).Append("\n");
            sb.Append("  Line7: ").Append(Line7).Append("\n");
            sb.Append("  Line8: ").Append(Line8).Append("\n");
            sb.Append("  Touches: ").Append(Touches).Append("\n");
            sb.Append("  MinInvQty: ").Append(MinInvQty).Append("\n");
            sb.Append("  MidInvQty: ").Append(MidInvQty).Append("\n");
            sb.Append("  MaxInvQty: ").Append(MaxInvQty).Append("\n");
            sb.Append("  IsKOD: ").Append(IsKOD).Append("\n");
            sb.Append("  KodType: ").Append(KodType).Append("\n");
            sb.Append("  KitComponentList: ").Append(KitComponentList).Append("\n");
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
            return this.Equals(input as Kit);
        }

        /// <summary>
        /// Returns true if Kit instances are equal
        /// </summary>
        /// <param name="input">Instance of Kit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Kit input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.KitSKU == input.KitSKU ||
                    (this.KitSKU != null &&
                    this.KitSKU.Equals(input.KitSKU))
                ) && 
                (
                    this.PackagingType == input.PackagingType ||
                    (this.PackagingType != null &&
                    this.PackagingType.Equals(input.PackagingType))
                ) && 
                (
                    this.Other == input.Other ||
                    (this.Other != null &&
                    this.Other.Equals(input.Other))
                ) && 
                (
                    this.NumberOfComponents == input.NumberOfComponents ||
                    (this.NumberOfComponents != null &&
                    this.NumberOfComponents.Equals(input.NumberOfComponents))
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
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) && 
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
                ) && 
                (
                    this.Line3 == input.Line3 ||
                    (this.Line3 != null &&
                    this.Line3.Equals(input.Line3))
                ) && 
                (
                    this.Line4 == input.Line4 ||
                    (this.Line4 != null &&
                    this.Line4.Equals(input.Line4))
                ) && 
                (
                    this.Line5 == input.Line5 ||
                    (this.Line5 != null &&
                    this.Line5.Equals(input.Line5))
                ) && 
                (
                    this.Line6 == input.Line6 ||
                    (this.Line6 != null &&
                    this.Line6.Equals(input.Line6))
                ) && 
                (
                    this.Line7 == input.Line7 ||
                    (this.Line7 != null &&
                    this.Line7.Equals(input.Line7))
                ) && 
                (
                    this.Line8 == input.Line8 ||
                    (this.Line8 != null &&
                    this.Line8.Equals(input.Line8))
                ) && 
                (
                    this.Touches == input.Touches ||
                    (this.Touches != null &&
                    this.Touches.Equals(input.Touches))
                ) && 
                (
                    this.MinInvQty == input.MinInvQty ||
                    (this.MinInvQty != null &&
                    this.MinInvQty.Equals(input.MinInvQty))
                ) && 
                (
                    this.MidInvQty == input.MidInvQty ||
                    (this.MidInvQty != null &&
                    this.MidInvQty.Equals(input.MidInvQty))
                ) && 
                (
                    this.MaxInvQty == input.MaxInvQty ||
                    (this.MaxInvQty != null &&
                    this.MaxInvQty.Equals(input.MaxInvQty))
                ) && 
                (
                    this.IsKOD == input.IsKOD ||
                    (this.IsKOD != null &&
                    this.IsKOD.Equals(input.IsKOD))
                ) && 
                (
                    this.KodType == input.KodType ||
                    (this.KodType != null &&
                    this.KodType.Equals(input.KodType))
                ) && 
                (
                    this.KitComponentList == input.KitComponentList ||
                    this.KitComponentList != null &&
                    this.KitComponentList.SequenceEqual(input.KitComponentList)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.KitSKU != null)
                    hashCode = hashCode * 59 + this.KitSKU.GetHashCode();
                if (this.PackagingType != null)
                    hashCode = hashCode * 59 + this.PackagingType.GetHashCode();
                if (this.Other != null)
                    hashCode = hashCode * 59 + this.Other.GetHashCode();
                if (this.NumberOfComponents != null)
                    hashCode = hashCode * 59 + this.NumberOfComponents.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.Line1 != null)
                    hashCode = hashCode * 59 + this.Line1.GetHashCode();
                if (this.Line2 != null)
                    hashCode = hashCode * 59 + this.Line2.GetHashCode();
                if (this.Line3 != null)
                    hashCode = hashCode * 59 + this.Line3.GetHashCode();
                if (this.Line4 != null)
                    hashCode = hashCode * 59 + this.Line4.GetHashCode();
                if (this.Line5 != null)
                    hashCode = hashCode * 59 + this.Line5.GetHashCode();
                if (this.Line6 != null)
                    hashCode = hashCode * 59 + this.Line6.GetHashCode();
                if (this.Line7 != null)
                    hashCode = hashCode * 59 + this.Line7.GetHashCode();
                if (this.Line8 != null)
                    hashCode = hashCode * 59 + this.Line8.GetHashCode();
                if (this.Touches != null)
                    hashCode = hashCode * 59 + this.Touches.GetHashCode();
                if (this.MinInvQty != null)
                    hashCode = hashCode * 59 + this.MinInvQty.GetHashCode();
                if (this.MidInvQty != null)
                    hashCode = hashCode * 59 + this.MidInvQty.GetHashCode();
                if (this.MaxInvQty != null)
                    hashCode = hashCode * 59 + this.MaxInvQty.GetHashCode();
                if (this.IsKOD != null)
                    hashCode = hashCode * 59 + this.IsKOD.GetHashCode();
                if (this.KodType != null)
                    hashCode = hashCode * 59 + this.KodType.GetHashCode();
                if (this.KitComponentList != null)
                    hashCode = hashCode * 59 + this.KitComponentList.GetHashCode();
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
