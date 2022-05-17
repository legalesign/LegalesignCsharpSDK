/*
 * Legalesign API
 *
 * Legalesign.com is an electronic signature software. This is the documentation for its REST API.   Start by creating a trial account at https://app1.legalesign.com/auth/intro/. Upon account activation, select the API dev option.  Get an API key by emailing support@legalesign with background on your use-case and skills. You will need to show experience in API dev.  You will be in sandbox mode that will limit you to 5 signers. Add them on https://app1.legalesign.com/acc/settings/#api. Contact support to move to production mode when you are ready.  For any queries contact us at support@legalesign.com. 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@legalesign.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// PdfFieldsPost
    /// </summary>
    [DataContract]
    public partial class PdfFieldsPost :  IEquatable<PdfFieldsPost>, IValidatableObject
    {
        /// <summary>
        /// one of the following:    * 1 - left    * 2 - middle    * 3 - right 
        /// </summary>
        /// <value>one of the following:    * 1 - left    * 2 - middle    * 3 - right </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlignEnum
        {
            /// <summary>
            /// Enum left for value: 1
            /// </summary>
            left = 1,

            /// <summary>
            /// Enum center for value: 2
            /// </summary>
            center = 2,

            /// <summary>
            /// Enum right for value: 3
            /// </summary>
            right = 3

        }

        /// <summary>
        /// one of the following:    * 1 - left    * 2 - middle    * 3 - right 
        /// </summary>
        /// <value>one of the following:    * 1 - left    * 2 - middle    * 3 - right </value>
        [DataMember(Name="align", EmitDefaultValue=true)]
        public AlignEnum? Align { get; set; }
        /// <summary>
        /// Must be one of the following: * signature - signature field * initials - initials field  * text - signer field (field for signer to complete)  * admin - sender field (field to complete by admin user when sending, use pdftext) 
        /// </summary>
        /// <value>Must be one of the following: * signature - signature field * initials - initials field  * text - signer field (field for signer to complete)  * admin - sender field (field to complete by admin user when sending, use pdftext) </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ElementTypeEnum
        {
            /// <summary>
            /// Enum Signature for value: signature
            /// </summary>
            [EnumMember(Value = "signature")]
            Signature = 1,

            /// <summary>
            /// Enum Initials for value: initials
            /// </summary>
            [EnumMember(Value = "initials")]
            Initials = 2,

            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 3,

            /// <summary>
            /// Enum Admin for value: admin
            /// </summary>
            [EnumMember(Value = "admin")]
            Admin = 4

        }

        /// <summary>
        /// Must be one of the following: * signature - signature field * initials - initials field  * text - signer field (field for signer to complete)  * admin - sender field (field to complete by admin user when sending, use pdftext) 
        /// </summary>
        /// <value>Must be one of the following: * signature - signature field * initials - initials field  * text - signer field (field for signer to complete)  * admin - sender field (field to complete by admin user when sending, use pdftext) </value>
        [DataMember(Name="element_type", EmitDefaultValue=true)]
        public ElementTypeEnum ElementType { get; set; }
        /// <summary>
        /// Defines FontName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontNameEnum
        {
            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 1,

            /// <summary>
            /// Enum Arial for value: arial
            /// </summary>
            [EnumMember(Value = "arial")]
            Arial = 2,

            /// <summary>
            /// Enum Courier for value: courier
            /// </summary>
            [EnumMember(Value = "courier")]
            Courier = 3,

            /// <summary>
            /// Enum Helvetica for value: helvetica
            /// </summary>
            [EnumMember(Value = "helvetica")]
            Helvetica = 4,

            /// <summary>
            /// Enum Liberation for value: liberation
            /// </summary>
            [EnumMember(Value = "liberation")]
            Liberation = 5,

            /// <summary>
            /// Enum Verdana for value: verdana
            /// </summary>
            [EnumMember(Value = "verdana")]
            Verdana = 6

        }

        /// <summary>
        /// Gets or Sets FontName
        /// </summary>
        [DataMember(Name="font_name", EmitDefaultValue=false)]
        public FontNameEnum? FontName { get; set; }
        /// <summary>
        /// offers options for more advanced forms   1 &#x3D; One of a set of field - radio group   2 &#x3D; Sum a set of fields   3 &#x3D; Conditional upon another field 
        /// </summary>
        /// <value>offers options for more advanced forms   1 &#x3D; One of a set of field - radio group   2 &#x3D; Sum a set of fields   3 &#x3D; Conditional upon another field </value>
        public enum LogicActionEnum
        {
            /// <summary>
            /// Enum one-of-a-group for value: 1
            /// </summary>
            oneofagroup = 1,

            /// <summary>
            /// Enum sum for value: 2
            /// </summary>
            sum = 2,

            /// <summary>
            /// Enum conditional for value: 3
            /// </summary>
            conditional = 3

        }

        /// <summary>
        /// offers options for more advanced forms   1 &#x3D; One of a set of field - radio group   2 &#x3D; Sum a set of fields   3 &#x3D; Conditional upon another field 
        /// </summary>
        /// <value>offers options for more advanced forms   1 &#x3D; One of a set of field - radio group   2 &#x3D; Sum a set of fields   3 &#x3D; Conditional upon another field </value>
        [DataMember(Name="logic_action", EmitDefaultValue=false)]
        public LogicActionEnum? LogicAction { get; set; }
        /// <summary>
        /// Gets or Sets Validation
        /// </summary>
        [DataMember(Name="validation", EmitDefaultValue=true)]
        public PdfFieldValidationEnum? Validation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfFieldsPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfFieldsPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfFieldsPost" /> class.
        /// </summary>
        /// <param name="align">one of the following:    * 1 - left    * 2 - middle    * 3 - right .</param>
        /// <param name="ax">% of page width - left vertical: 0 &#x3D; left page edge, 1 &#x3D; right page edge (required).</param>
        /// <param name="ay">% of page height - upper horizontal: 0 &#x3D; top page edge, 1 &#x3D; bottom page edge (required).</param>
        /// <param name="bx">% of page width - right vertical, 0 &#x3D; left page edge, 1 &#x3D; right page edge (required).</param>
        /// <param name="by">% of page height lower horizontal. 0 &#x3D; top page edge, 1 &#x3D; bottom page edge (required).</param>
        /// <param name="elementType">Must be one of the following: * signature - signature field * initials - initials field  * text - signer field (field for signer to complete)  * admin - sender field (field to complete by admin user when sending, use pdftext)  (required).</param>
        /// <param name="fieldorder">Ordering of fields as the signer progresses (top-down by if left blank).</param>
        /// <param name="fontName">fontName.</param>
        /// <param name="fontSize">fontSize.</param>
        /// <param name="hideBorder">hideBorder.</param>
        /// <param name="label">Help a signer/sender understand what to do with the form field.</param>
        /// <param name="labelExtra">unused. more label if required.</param>
        /// <param name="logicAction">offers options for more advanced forms   1 &#x3D; One of a set of field - radio group   2 &#x3D; Sum a set of fields   3 &#x3D; Conditional upon another field .</param>
        /// <param name="logicGroup">values to enable a given logic_action in the form.</param>
        /// <param name="mapTo">custom data for form integrations.</param>
        /// <param name="optional">Set true to allow field to be ignored (default to false).</param>
        /// <param name="options">Additional values for certain validation types..</param>
        /// <param name="page">which page to place field on (required).</param>
        /// <param name="signer">1-indexed number of signer (witness+100) (approver+200) (required).</param>
        /// <param name="substantive">Set if field substantive to contract terms, if so will not let other sign till this field completed (default to false).</param>
        /// <param name="validation">validation.</param>
        /// <param name="value">value.</param>
        public PdfFieldsPost(AlignEnum? align = default(AlignEnum?), float ax = default(float), float ay = default(float), float bx = default(float), float by = default(float), ElementTypeEnum elementType = default(ElementTypeEnum), int? fieldorder = default(int?), FontNameEnum? fontName = default(FontNameEnum?), int fontSize = default(int), bool hideBorder = default(bool), string label = default(string), string labelExtra = default(string), LogicActionEnum? logicAction = default(LogicActionEnum?), string logicGroup = default(string), string mapTo = default(string), bool optional = false, string options = default(string), int page = default(int), int signer = default(int), bool substantive = false, PdfFieldValidationEnum? validation = default(PdfFieldValidationEnum?), string value = default(string))
        {
            this.Align = align;
            // to ensure "ax" is required (not null)
            if (ax == null)
            {
                throw new InvalidDataException("ax is a required property for PdfFieldsPost and cannot be null");
            }
            else
            {
                this.Ax = ax;
            }

            // to ensure "ay" is required (not null)
            if (ay == null)
            {
                throw new InvalidDataException("ay is a required property for PdfFieldsPost and cannot be null");
            }
            else
            {
                this.Ay = ay;
            }

            // to ensure "bx" is required (not null)
            if (bx == null)
            {
                throw new InvalidDataException("bx is a required property for PdfFieldsPost and cannot be null");
            }
            else
            {
                this.Bx = bx;
            }

            // to ensure "by" is required (not null)
            if (by == null)
            {
                throw new InvalidDataException("by is a required property for PdfFieldsPost and cannot be null");
            }
            else
            {
                this.By = by;
            }

            // to ensure "elementType" is required (not null)
            if (elementType == null)
            {
                throw new InvalidDataException("elementType is a required property for PdfFieldsPost and cannot be null");
            }
            else
            {
                this.ElementType = elementType;
            }

            this.Fieldorder = fieldorder;
            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new InvalidDataException("page is a required property for PdfFieldsPost and cannot be null");
            }
            else
            {
                this.Page = page;
            }

            // to ensure "signer" is required (not null)
            if (signer == null)
            {
                throw new InvalidDataException("signer is a required property for PdfFieldsPost and cannot be null");
            }
            else
            {
                this.Signer = signer;
            }

            this.Validation = validation;
            this.Align = align;
            this.Fieldorder = fieldorder;
            this.FontName = fontName;
            this.FontSize = fontSize;
            this.HideBorder = hideBorder;
            this.Label = label;
            this.LabelExtra = labelExtra;
            this.LogicAction = logicAction;
            this.LogicGroup = logicGroup;
            this.MapTo = mapTo;
            // use default value if no "optional" provided
            if (optional == null)
            {
                this.Optional = false;
            }
            else
            {
                this.Optional = optional;
            }
            this.Options = options;
            // use default value if no "substantive" provided
            if (substantive == null)
            {
                this.Substantive = false;
            }
            else
            {
                this.Substantive = substantive;
            }
            this.Validation = validation;
            this.Value = value;
        }


        /// <summary>
        /// % of page width - left vertical: 0 &#x3D; left page edge, 1 &#x3D; right page edge
        /// </summary>
        /// <value>% of page width - left vertical: 0 &#x3D; left page edge, 1 &#x3D; right page edge</value>
        [DataMember(Name="ax", EmitDefaultValue=true)]
        public float Ax { get; set; }

        /// <summary>
        /// % of page height - upper horizontal: 0 &#x3D; top page edge, 1 &#x3D; bottom page edge
        /// </summary>
        /// <value>% of page height - upper horizontal: 0 &#x3D; top page edge, 1 &#x3D; bottom page edge</value>
        [DataMember(Name="ay", EmitDefaultValue=true)]
        public float Ay { get; set; }

        /// <summary>
        /// % of page width - right vertical, 0 &#x3D; left page edge, 1 &#x3D; right page edge
        /// </summary>
        /// <value>% of page width - right vertical, 0 &#x3D; left page edge, 1 &#x3D; right page edge</value>
        [DataMember(Name="bx", EmitDefaultValue=true)]
        public float Bx { get; set; }

        /// <summary>
        /// % of page height lower horizontal. 0 &#x3D; top page edge, 1 &#x3D; bottom page edge
        /// </summary>
        /// <value>% of page height lower horizontal. 0 &#x3D; top page edge, 1 &#x3D; bottom page edge</value>
        [DataMember(Name="by", EmitDefaultValue=true)]
        public float By { get; set; }


        /// <summary>
        /// Ordering of fields as the signer progresses (top-down by if left blank)
        /// </summary>
        /// <value>Ordering of fields as the signer progresses (top-down by if left blank)</value>
        [DataMember(Name="fieldorder", EmitDefaultValue=true)]
        public int? Fieldorder { get; set; }


        /// <summary>
        /// Gets or Sets FontSize
        /// </summary>
        [DataMember(Name="font_size", EmitDefaultValue=false)]
        public int FontSize { get; set; }

        /// <summary>
        /// Gets or Sets HideBorder
        /// </summary>
        [DataMember(Name="hide_border", EmitDefaultValue=false)]
        public bool HideBorder { get; set; }

        /// <summary>
        /// Help a signer/sender understand what to do with the form field
        /// </summary>
        /// <value>Help a signer/sender understand what to do with the form field</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// unused. more label if required
        /// </summary>
        /// <value>unused. more label if required</value>
        [DataMember(Name="label_extra", EmitDefaultValue=false)]
        [Obsolete]
        public string LabelExtra { get; set; }


        /// <summary>
        /// values to enable a given logic_action in the form
        /// </summary>
        /// <value>values to enable a given logic_action in the form</value>
        [DataMember(Name="logic_group", EmitDefaultValue=false)]
        public string LogicGroup { get; set; }

        /// <summary>
        /// custom data for form integrations
        /// </summary>
        /// <value>custom data for form integrations</value>
        [DataMember(Name="map_to", EmitDefaultValue=false)]
        public string MapTo { get; set; }

        /// <summary>
        /// Set true to allow field to be ignored
        /// </summary>
        /// <value>Set true to allow field to be ignored</value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool Optional { get; set; }

        /// <summary>
        /// Additional values for certain validation types.
        /// </summary>
        /// <value>Additional values for certain validation types.</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public string Options { get; set; }

        /// <summary>
        /// which page to place field on
        /// </summary>
        /// <value>which page to place field on</value>
        [DataMember(Name="page", EmitDefaultValue=true)]
        public int Page { get; set; }

        /// <summary>
        /// 1-indexed number of signer (witness+100) (approver+200)
        /// </summary>
        /// <value>1-indexed number of signer (witness+100) (approver+200)</value>
        [DataMember(Name="signer", EmitDefaultValue=true)]
        public int Signer { get; set; }

        /// <summary>
        /// Set if field substantive to contract terms, if so will not let other sign till this field completed
        /// </summary>
        /// <value>Set if field substantive to contract terms, if so will not let other sign till this field completed</value>
        [DataMember(Name="substantive", EmitDefaultValue=false)]
        public bool Substantive { get; set; }


        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfFieldsPost {\n");
            sb.Append("  Align: ").Append(Align).Append("\n");
            sb.Append("  Ax: ").Append(Ax).Append("\n");
            sb.Append("  Ay: ").Append(Ay).Append("\n");
            sb.Append("  Bx: ").Append(Bx).Append("\n");
            sb.Append("  By: ").Append(By).Append("\n");
            sb.Append("  ElementType: ").Append(ElementType).Append("\n");
            sb.Append("  Fieldorder: ").Append(Fieldorder).Append("\n");
            sb.Append("  FontName: ").Append(FontName).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  HideBorder: ").Append(HideBorder).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  LabelExtra: ").Append(LabelExtra).Append("\n");
            sb.Append("  LogicAction: ").Append(LogicAction).Append("\n");
            sb.Append("  LogicGroup: ").Append(LogicGroup).Append("\n");
            sb.Append("  MapTo: ").Append(MapTo).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Signer: ").Append(Signer).Append("\n");
            sb.Append("  Substantive: ").Append(Substantive).Append("\n");
            sb.Append("  Validation: ").Append(Validation).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PdfFieldsPost);
        }

        /// <summary>
        /// Returns true if PdfFieldsPost instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfFieldsPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfFieldsPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Align == input.Align ||
                    (this.Align != null &&
                    this.Align.Equals(input.Align))
                ) && 
                (
                    this.Ax == input.Ax ||
                    (this.Ax != null &&
                    this.Ax.Equals(input.Ax))
                ) && 
                (
                    this.Ay == input.Ay ||
                    (this.Ay != null &&
                    this.Ay.Equals(input.Ay))
                ) && 
                (
                    this.Bx == input.Bx ||
                    (this.Bx != null &&
                    this.Bx.Equals(input.Bx))
                ) && 
                (
                    this.By == input.By ||
                    (this.By != null &&
                    this.By.Equals(input.By))
                ) && 
                (
                    this.ElementType == input.ElementType ||
                    (this.ElementType != null &&
                    this.ElementType.Equals(input.ElementType))
                ) && 
                (
                    this.Fieldorder == input.Fieldorder ||
                    (this.Fieldorder != null &&
                    this.Fieldorder.Equals(input.Fieldorder))
                ) && 
                (
                    this.FontName == input.FontName ||
                    (this.FontName != null &&
                    this.FontName.Equals(input.FontName))
                ) && 
                (
                    this.FontSize == input.FontSize ||
                    (this.FontSize != null &&
                    this.FontSize.Equals(input.FontSize))
                ) && 
                (
                    this.HideBorder == input.HideBorder ||
                    (this.HideBorder != null &&
                    this.HideBorder.Equals(input.HideBorder))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.LabelExtra == input.LabelExtra ||
                    (this.LabelExtra != null &&
                    this.LabelExtra.Equals(input.LabelExtra))
                ) && 
                (
                    this.LogicAction == input.LogicAction ||
                    (this.LogicAction != null &&
                    this.LogicAction.Equals(input.LogicAction))
                ) && 
                (
                    this.LogicGroup == input.LogicGroup ||
                    (this.LogicGroup != null &&
                    this.LogicGroup.Equals(input.LogicGroup))
                ) && 
                (
                    this.MapTo == input.MapTo ||
                    (this.MapTo != null &&
                    this.MapTo.Equals(input.MapTo))
                ) && 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Signer == input.Signer ||
                    (this.Signer != null &&
                    this.Signer.Equals(input.Signer))
                ) && 
                (
                    this.Substantive == input.Substantive ||
                    (this.Substantive != null &&
                    this.Substantive.Equals(input.Substantive))
                ) && 
                (
                    this.Validation == input.Validation ||
                    (this.Validation != null &&
                    this.Validation.Equals(input.Validation))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Align != null)
                    hashCode = hashCode * 59 + this.Align.GetHashCode();
                if (this.Ax != null)
                    hashCode = hashCode * 59 + this.Ax.GetHashCode();
                if (this.Ay != null)
                    hashCode = hashCode * 59 + this.Ay.GetHashCode();
                if (this.Bx != null)
                    hashCode = hashCode * 59 + this.Bx.GetHashCode();
                if (this.By != null)
                    hashCode = hashCode * 59 + this.By.GetHashCode();
                if (this.ElementType != null)
                    hashCode = hashCode * 59 + this.ElementType.GetHashCode();
                if (this.Fieldorder != null)
                    hashCode = hashCode * 59 + this.Fieldorder.GetHashCode();
                if (this.FontName != null)
                    hashCode = hashCode * 59 + this.FontName.GetHashCode();
                if (this.FontSize != null)
                    hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.HideBorder != null)
                    hashCode = hashCode * 59 + this.HideBorder.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.LabelExtra != null)
                    hashCode = hashCode * 59 + this.LabelExtra.GetHashCode();
                if (this.LogicAction != null)
                    hashCode = hashCode * 59 + this.LogicAction.GetHashCode();
                if (this.LogicGroup != null)
                    hashCode = hashCode * 59 + this.LogicGroup.GetHashCode();
                if (this.MapTo != null)
                    hashCode = hashCode * 59 + this.MapTo.GetHashCode();
                if (this.Optional != null)
                    hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Signer != null)
                    hashCode = hashCode * 59 + this.Signer.GetHashCode();
                if (this.Substantive != null)
                    hashCode = hashCode * 59 + this.Substantive.GetHashCode();
                if (this.Validation != null)
                    hashCode = hashCode * 59 + this.Validation.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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


            // FontSize (int) maximum
            if(this.FontSize > (int)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FontSize, must be a value less than or equal to 20.", new [] { "FontSize" });
            }

            // FontSize (int) minimum
            if(this.FontSize < (int)6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FontSize, must be a value greater than or equal to 6.", new [] { "FontSize" });
            }



            // Label (string) pattern
            Regex regexLabel = new Regex(@"^[-\\w ]{0,60}$", RegexOptions.CultureInvariant);
            if (false == regexLabel.Match(this.Label).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Label, must match a pattern of " + regexLabel, new [] { "Label" });
            }

            // LabelExtra (string) maxLength
            if(this.LabelExtra != null && this.LabelExtra.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LabelExtra, length must be less than 250.", new [] { "LabelExtra" });
            }


            // LogicGroup (string) maxLength
            if(this.LogicGroup != null && this.LogicGroup.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogicGroup, length must be less than 60.", new [] { "LogicGroup" });
            }


            // LogicGroup (string) pattern
            Regex regexLogicGroup = new Regex(@"^[\\.-_  \\w:]{0,60}$", RegexOptions.CultureInvariant);
            if (false == regexLogicGroup.Match(this.LogicGroup).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogicGroup, must match a pattern of " + regexLogicGroup, new [] { "LogicGroup" });
            }

            // MapTo (string) maxLength
            if(this.MapTo != null && this.MapTo.Length > 120)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MapTo, length must be less than 120.", new [] { "MapTo" });
            }


            // MapTo (string) pattern
            Regex regexMapTo = new Regex(@"^[\\.-_  \\w:]{0,120}$", RegexOptions.CultureInvariant);
            if (false == regexMapTo.Match(this.MapTo).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MapTo, must match a pattern of " + regexMapTo, new [] { "MapTo" });
            }



            // Signer (int) minimum
            if(this.Signer < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Signer, must be a value greater than or equal to 1.", new [] { "Signer" });
            }

            yield break;
        }
    }

}
