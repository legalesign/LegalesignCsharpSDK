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
    /// DocumentSignerPost
    /// </summary>
    [DataContract]
    public partial class DocumentSignerPost :  IEquatable<DocumentSignerPost>, IValidatableObject
    {
        /// <summary>
        /// If this person is a witness use \\\&quot;witness\\\&quot;. Required where a witness is defined in your PDF. If this person is a normal signer, use \\\&quot;approver\\\&quot; to switch to an approver role.  Witnesses and witnessed signers also require \\\&quot;sms\\\&quot; (see also \\\&quot;decide_later\\\&quot;).
        /// </summary>
        /// <value>If this person is a witness use \\\&quot;witness\\\&quot;. Required where a witness is defined in your PDF. If this person is a normal signer, use \\\&quot;approver\\\&quot; to switch to an approver role.  Witnesses and witnessed signers also require \\\&quot;sms\\\&quot; (see also \\\&quot;decide_later\\\&quot;).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum Witness for value: witness
            /// </summary>
            [EnumMember(Value = "witness")]
            Witness = 1,

            /// <summary>
            /// Enum Approver for value: approver
            /// </summary>
            [EnumMember(Value = "approver")]
            Approver = 2

        }

        /// <summary>
        /// If this person is a witness use \\\&quot;witness\\\&quot;. Required where a witness is defined in your PDF. If this person is a normal signer, use \\\&quot;approver\\\&quot; to switch to an approver role.  Witnesses and witnessed signers also require \\\&quot;sms\\\&quot; (see also \\\&quot;decide_later\\\&quot;).
        /// </summary>
        /// <value>If this person is a witness use \\\&quot;witness\\\&quot;. Required where a witness is defined in your PDF. If this person is a normal signer, use \\\&quot;approver\\\&quot; to switch to an approver role.  Witnesses and witnessed signers also require \\\&quot;sms\\\&quot; (see also \\\&quot;decide_later\\\&quot;).</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        [Obsolete]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSignerPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentSignerPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSignerPost" /> class.
        /// </summary>
        /// <param name="order">Zero-indexed signer ordering, deprecated. Ordering of signers/witnesses/approvers is now the natural order of your signers list..</param>
        /// <param name="email">email (required).</param>
        /// <param name="firstname">firstname (required).</param>
        /// <param name="lastname">lastname (required).</param>
        /// <param name="attachments">List of attachment resource URIs.</param>
        /// <param name="behalfof">deprecated, do not use.</param>
        /// <param name="decideLater">Add this you want the previous signer or approver to decide who the next person should be.  Commonly used for witnesses (see \\\&quot;role\\\&quot;). If you use this leave all other attributes blank. First signer cannot use this attribute..</param>
        /// <param name="expires">ISO8601 formed datetime, set to TZ of sender or timezone if used.</param>
        /// <param name="message">Use keyword \\\&quot;default\\\&quot; to use group message.</param>
        /// <param name="reviewers">reviewers.</param>
        /// <param name="role">If this person is a witness use \\\&quot;witness\\\&quot;. Required where a witness is defined in your PDF. If this person is a normal signer, use \\\&quot;approver\\\&quot; to switch to an approver role.  Witnesses and witnessed signers also require \\\&quot;sms\\\&quot; (see also \\\&quot;decide_later\\\&quot;)..</param>
        /// <param name="sms">Use international format number to add SMS verification. Required if a witness or a witnessed signer..</param>
        /// <param name="subject">Subject line for outbound email.</param>
        /// <param name="timezone">TZ of the signer, must be valid TZ as per timezoneenum (see User for timezoneenum details).  If blank uses tz of the sender..</param>
        public DocumentSignerPost(int order = default(int), string email = default(string), string firstname = default(string), string lastname = default(string), List<string> attachments = default(List<string>), string behalfof = default(string), bool decideLater = default(bool), DateTime expires = default(DateTime), string message = default(string), List<ReviewersPost> reviewers = default(List<ReviewersPost>), RoleEnum? role = default(RoleEnum?), string sms = default(string), string subject = default(string), string timezone = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for DocumentSignerPost and cannot be null");
            }
            else
            {
                this.Email = email;
            }

            // to ensure "firstname" is required (not null)
            if (firstname == null)
            {
                throw new InvalidDataException("firstname is a required property for DocumentSignerPost and cannot be null");
            }
            else
            {
                this.Firstname = firstname;
            }

            // to ensure "lastname" is required (not null)
            if (lastname == null)
            {
                throw new InvalidDataException("lastname is a required property for DocumentSignerPost and cannot be null");
            }
            else
            {
                this.Lastname = lastname;
            }

            this.Order = order;
            this.Attachments = attachments;
            this.Behalfof = behalfof;
            this.DecideLater = decideLater;
            this.Expires = expires;
            this.Message = message;
            this.Reviewers = reviewers;
            this.Role = role;
            this.Sms = sms;
            this.Subject = subject;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Zero-indexed signer ordering, deprecated. Ordering of signers/witnesses/approvers is now the natural order of your signers list.
        /// </summary>
        /// <value>Zero-indexed signer ordering, deprecated. Ordering of signers/witnesses/approvers is now the natural order of your signers list.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        [Obsolete]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Firstname
        /// </summary>
        [DataMember(Name="firstname", EmitDefaultValue=true)]
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name="lastname", EmitDefaultValue=true)]
        public string Lastname { get; set; }

        /// <summary>
        /// List of attachment resource URIs
        /// </summary>
        /// <value>List of attachment resource URIs</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// deprecated, do not use
        /// </summary>
        /// <value>deprecated, do not use</value>
        [DataMember(Name="behalfof", EmitDefaultValue=false)]
        [Obsolete]
        public string Behalfof { get; set; }

        /// <summary>
        /// Add this you want the previous signer or approver to decide who the next person should be.  Commonly used for witnesses (see \\\&quot;role\\\&quot;). If you use this leave all other attributes blank. First signer cannot use this attribute.
        /// </summary>
        /// <value>Add this you want the previous signer or approver to decide who the next person should be.  Commonly used for witnesses (see \\\&quot;role\\\&quot;). If you use this leave all other attributes blank. First signer cannot use this attribute.</value>
        [DataMember(Name="decide_later", EmitDefaultValue=false)]
        public bool DecideLater { get; set; }

        /// <summary>
        /// ISO8601 formed datetime, set to TZ of sender or timezone if used
        /// </summary>
        /// <value>ISO8601 formed datetime, set to TZ of sender or timezone if used</value>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public DateTime Expires { get; set; }

        /// <summary>
        /// Use keyword \\\&quot;default\\\&quot; to use group message
        /// </summary>
        /// <value>Use keyword \\\&quot;default\\\&quot; to use group message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Reviewers
        /// </summary>
        [DataMember(Name="reviewers", EmitDefaultValue=false)]
        public List<ReviewersPost> Reviewers { get; set; }


        /// <summary>
        /// Use international format number to add SMS verification. Required if a witness or a witnessed signer.
        /// </summary>
        /// <value>Use international format number to add SMS verification. Required if a witness or a witnessed signer.</value>
        [DataMember(Name="sms", EmitDefaultValue=false)]
        public string Sms { get; set; }

        /// <summary>
        /// Subject line for outbound email
        /// </summary>
        /// <value>Subject line for outbound email</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// TZ of the signer, must be valid TZ as per timezoneenum (see User for timezoneenum details).  If blank uses tz of the sender.
        /// </summary>
        /// <value>TZ of the signer, must be valid TZ as per timezoneenum (see User for timezoneenum details).  If blank uses tz of the sender.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentSignerPost {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Behalfof: ").Append(Behalfof).Append("\n");
            sb.Append("  DecideLater: ").Append(DecideLater).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(input as DocumentSignerPost);
        }

        /// <summary>
        /// Returns true if DocumentSignerPost instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentSignerPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentSignerPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Behalfof == input.Behalfof ||
                    (this.Behalfof != null &&
                    this.Behalfof.Equals(input.Behalfof))
                ) && 
                (
                    this.DecideLater == input.DecideLater ||
                    (this.DecideLater != null &&
                    this.DecideLater.Equals(input.DecideLater))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Reviewers == input.Reviewers ||
                    this.Reviewers != null &&
                    input.Reviewers != null &&
                    this.Reviewers.SequenceEqual(input.Reviewers)
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Sms == input.Sms ||
                    (this.Sms != null &&
                    this.Sms.Equals(input.Sms))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
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
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Behalfof != null)
                    hashCode = hashCode * 59 + this.Behalfof.GetHashCode();
                if (this.DecideLater != null)
                    hashCode = hashCode * 59 + this.DecideLater.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Reviewers != null)
                    hashCode = hashCode * 59 + this.Reviewers.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Sms != null)
                    hashCode = hashCode * 59 + this.Sms.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
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
            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 75.", new [] { "Email" });
            }


            // Firstname (string) maxLength
            if(this.Firstname != null && this.Firstname.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Firstname, length must be less than 60.", new [] { "Firstname" });
            }


            // Firstname (string) pattern
            Regex regexFirstname = new Regex(@"^[-\\w' ]{1,60}", RegexOptions.CultureInvariant);
            if (false == regexFirstname.Match(this.Firstname).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Firstname, must match a pattern of " + regexFirstname, new [] { "Firstname" });
            }

            // Lastname (string) maxLength
            if(this.Lastname != null && this.Lastname.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Lastname, length must be less than 60.", new [] { "Lastname" });
            }


            // Lastname (string) pattern
            Regex regexLastname = new Regex(@"^[-\\w' ]{1,60}", RegexOptions.CultureInvariant);
            if (false == regexLastname.Match(this.Lastname).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Lastname, must match a pattern of " + regexLastname, new [] { "Lastname" });
            }

            // Behalfof (string) maxLength
            if(this.Behalfof != null && this.Behalfof.Length > 120)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Behalfof, length must be less than 120.", new [] { "Behalfof" });
            }


            // Subject (string) maxLength
            if(this.Subject != null && this.Subject.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Subject, length must be less than 150.", new [] { "Subject" });
            }


            yield break;
        }
    }

}
