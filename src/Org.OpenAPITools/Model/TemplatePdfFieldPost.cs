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
    /// TemplatePdfFieldPost
    /// </summary>
    [DataContract]
    public partial class TemplatePdfFieldPost :  IEquatable<TemplatePdfFieldPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatePdfFieldPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplatePdfFieldPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatePdfFieldPost" /> class.
        /// </summary>
        /// <param name="archiveUponSend">archive PDF when sent.</param>
        /// <param name="group">group (required).</param>
        /// <param name="pdfFile">base64 encoded PDF file data (required).</param>
        /// <param name="processTags">processTags.</param>
        /// <param name="title">title.</param>
        /// <param name="user">assign to group member if not api user.</param>
        public TemplatePdfFieldPost(bool archiveUponSend = default(bool), string group = default(string), byte[] pdfFile = default(byte[]), bool processTags = default(bool), string title = default(string), string user = default(string))
        {
            // to ensure "group" is required (not null)
            if (group == null)
            {
                throw new InvalidDataException("group is a required property for TemplatePdfFieldPost and cannot be null");
            }
            else
            {
                this.Group = group;
            }

            // to ensure "pdfFile" is required (not null)
            if (pdfFile == null)
            {
                throw new InvalidDataException("pdfFile is a required property for TemplatePdfFieldPost and cannot be null");
            }
            else
            {
                this.PdfFile = pdfFile;
            }

            this.ArchiveUponSend = archiveUponSend;
            this.ProcessTags = processTags;
            this.Title = title;
            this.User = user;
        }

        /// <summary>
        /// archive PDF when sent
        /// </summary>
        /// <value>archive PDF when sent</value>
        [DataMember(Name="archive_upon_send", EmitDefaultValue=false)]
        public bool ArchiveUponSend { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=true)]
        public string Group { get; set; }

        /// <summary>
        /// base64 encoded PDF file data
        /// </summary>
        /// <value>base64 encoded PDF file data</value>
        [DataMember(Name="pdf_file", EmitDefaultValue=true)]
        public byte[] PdfFile { get; set; }

        /// <summary>
        /// Gets or Sets ProcessTags
        /// </summary>
        [DataMember(Name="process_tags", EmitDefaultValue=false)]
        public bool ProcessTags { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// assign to group member if not api user
        /// </summary>
        /// <value>assign to group member if not api user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplatePdfFieldPost {\n");
            sb.Append("  ArchiveUponSend: ").Append(ArchiveUponSend).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  PdfFile: ").Append(PdfFile).Append("\n");
            sb.Append("  ProcessTags: ").Append(ProcessTags).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as TemplatePdfFieldPost);
        }

        /// <summary>
        /// Returns true if TemplatePdfFieldPost instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplatePdfFieldPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplatePdfFieldPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchiveUponSend == input.ArchiveUponSend ||
                    (this.ArchiveUponSend != null &&
                    this.ArchiveUponSend.Equals(input.ArchiveUponSend))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.PdfFile == input.PdfFile ||
                    (this.PdfFile != null &&
                    this.PdfFile.Equals(input.PdfFile))
                ) && 
                (
                    this.ProcessTags == input.ProcessTags ||
                    (this.ProcessTags != null &&
                    this.ProcessTags.Equals(input.ProcessTags))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.ArchiveUponSend != null)
                    hashCode = hashCode * 59 + this.ArchiveUponSend.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.PdfFile != null)
                    hashCode = hashCode * 59 + this.PdfFile.GetHashCode();
                if (this.ProcessTags != null)
                    hashCode = hashCode * 59 + this.ProcessTags.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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


            // Group (string) pattern
            Regex regexGroup = new Regex(@"^\/api\/v1\/group\/[-\\w]{1,50}\/$", RegexOptions.CultureInvariant);
            if (false == regexGroup.Match(this.Group).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Group, must match a pattern of " + regexGroup, new [] { "Group" });
            }

            // Title (string) maxLength
            if(this.Title != null && this.Title.Length > 120)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 120.", new [] { "Title" });
            }


            yield break;
        }
    }

}
