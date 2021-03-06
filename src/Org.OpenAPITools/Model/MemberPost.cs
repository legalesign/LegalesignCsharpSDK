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
    /// MemberPost
    /// </summary>
    [DataContract]
    public partial class MemberPost :  IEquatable<MemberPost>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public PermissionsEnum? Permission { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MemberPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberPost" /> class.
        /// </summary>
        /// <param name="group">group (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="doEmail">use legalesign to send email notification to new user (default to false).</param>
        /// <param name="permission">permission.</param>
        public MemberPost(string group = default(string), string email = default(string), bool doEmail = false, PermissionsEnum? permission = default(PermissionsEnum?))
        {
            // to ensure "group" is required (not null)
            if (group == null)
            {
                throw new InvalidDataException("group is a required property for MemberPost and cannot be null");
            }
            else
            {
                this.Group = group;
            }

            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for MemberPost and cannot be null");
            }
            else
            {
                this.Email = email;
            }

            // use default value if no "doEmail" provided
            if (doEmail == null)
            {
                this.DoEmail = false;
            }
            else
            {
                this.DoEmail = doEmail;
            }
            this.Permission = permission;
        }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=true)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// use legalesign to send email notification to new user
        /// </summary>
        /// <value>use legalesign to send email notification to new user</value>
        [DataMember(Name="do_email", EmitDefaultValue=false)]
        public bool DoEmail { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberPost {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DoEmail: ").Append(DoEmail).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
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
            return this.Equals(input as MemberPost);
        }

        /// <summary>
        /// Returns true if MemberPost instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.DoEmail == input.DoEmail ||
                    (this.DoEmail != null &&
                    this.DoEmail.Equals(input.DoEmail))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
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
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.DoEmail != null)
                    hashCode = hashCode * 59 + this.DoEmail.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
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

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 75.", new [] { "Email" });
            }


            yield break;
        }
    }

}
