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
    /// GroupPost
    /// </summary>
    [DataContract]
    public partial class GroupPost :  IEquatable<GroupPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPost" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="xframeAllow">Set to true if you want to embed your signing page. We recommend avoiding iframe. (required).</param>
        /// <param name="approveAllDeletions">Set to false to disable secondary approval on deletions (if you wish to use permanent delete) (default to true).</param>
        public GroupPost(string name = default(string), string user = default(string), bool xframeAllow = default(bool), bool approveAllDeletions = true)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GroupPost and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for GroupPost and cannot be null");
            }
            else
            {
                this.User = user;
            }

            // to ensure "xframeAllow" is required (not null)
            if (xframeAllow == null)
            {
                throw new InvalidDataException("xframeAllow is a required property for GroupPost and cannot be null");
            }
            else
            {
                this.XframeAllow = xframeAllow;
            }

            // use default value if no "approveAllDeletions" provided
            if (approveAllDeletions == null)
            {
                this.ApproveAllDeletions = true;
            }
            else
            {
                this.ApproveAllDeletions = approveAllDeletions;
            }
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public string User { get; set; }

        /// <summary>
        /// Set to true if you want to embed your signing page. We recommend avoiding iframe.
        /// </summary>
        /// <value>Set to true if you want to embed your signing page. We recommend avoiding iframe.</value>
        [DataMember(Name="xframe_allow", EmitDefaultValue=true)]
        public bool XframeAllow { get; set; }

        /// <summary>
        /// Set to false to disable secondary approval on deletions (if you wish to use permanent delete)
        /// </summary>
        /// <value>Set to false to disable secondary approval on deletions (if you wish to use permanent delete)</value>
        [DataMember(Name="approve_all_deletions", EmitDefaultValue=false)]
        public bool ApproveAllDeletions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupPost {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  XframeAllow: ").Append(XframeAllow).Append("\n");
            sb.Append("  ApproveAllDeletions: ").Append(ApproveAllDeletions).Append("\n");
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
            return this.Equals(input as GroupPost);
        }

        /// <summary>
        /// Returns true if GroupPost instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.XframeAllow == input.XframeAllow ||
                    (this.XframeAllow != null &&
                    this.XframeAllow.Equals(input.XframeAllow))
                ) && 
                (
                    this.ApproveAllDeletions == input.ApproveAllDeletions ||
                    (this.ApproveAllDeletions != null &&
                    this.ApproveAllDeletions.Equals(input.ApproveAllDeletions))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.XframeAllow != null)
                    hashCode = hashCode * 59 + this.XframeAllow.GetHashCode();
                if (this.ApproveAllDeletions != null)
                    hashCode = hashCode * 59 + this.ApproveAllDeletions.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 60.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 4.", new [] { "Name" });
            }



            // User (string) pattern
            Regex regexUser = new Regex(@"^\/api\/v1\/user\/[-\\w]{1,60}\/$", RegexOptions.CultureInvariant);
            if (false == regexUser.Match(this.User).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for User, must match a pattern of " + regexUser, new [] { "User" });
            }

            yield break;
        }
    }

}
