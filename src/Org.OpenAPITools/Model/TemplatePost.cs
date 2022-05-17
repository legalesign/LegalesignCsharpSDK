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
    /// TemplatePost
    /// </summary>
    [DataContract]
    public partial class TemplatePost :  IEquatable<TemplatePost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatePost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplatePost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatePost" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="group">group (required).</param>
        /// <param name="latestText">text/html for template (required).</param>
        /// <param name="user">assign to a user if not api user.</param>
        public TemplatePost(string title = default(string), string group = default(string), string latestText = default(string), string user = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for TemplatePost and cannot be null");
            }
            else
            {
                this.Title = title;
            }

            // to ensure "group" is required (not null)
            if (group == null)
            {
                throw new InvalidDataException("group is a required property for TemplatePost and cannot be null");
            }
            else
            {
                this.Group = group;
            }

            // to ensure "latestText" is required (not null)
            if (latestText == null)
            {
                throw new InvalidDataException("latestText is a required property for TemplatePost and cannot be null");
            }
            else
            {
                this.LatestText = latestText;
            }

            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=true)]
        public string Group { get; set; }

        /// <summary>
        /// text/html for template
        /// </summary>
        /// <value>text/html for template</value>
        [DataMember(Name="latest_text", EmitDefaultValue=true)]
        public string LatestText { get; set; }

        /// <summary>
        /// assign to a user if not api user
        /// </summary>
        /// <value>assign to a user if not api user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplatePost {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  LatestText: ").Append(LatestText).Append("\n");
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
            return this.Equals(input as TemplatePost);
        }

        /// <summary>
        /// Returns true if TemplatePost instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplatePost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplatePost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.LatestText == input.LatestText ||
                    (this.LatestText != null &&
                    this.LatestText.Equals(input.LatestText))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.LatestText != null)
                    hashCode = hashCode * 59 + this.LatestText.GetHashCode();
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


            // Title (string) pattern
            Regex regexTitle = new Regex(@"^[-\\w ]{1,60}$", RegexOptions.CultureInvariant);
            if (false == regexTitle.Match(this.Title).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, must match a pattern of " + regexTitle, new [] { "Title" });
            }



            // Group (string) pattern
            Regex regexGroup = new Regex(@"^\/api\/v1\/group\/[-\\w]{1,50}\/$", RegexOptions.CultureInvariant);
            if (false == regexGroup.Match(this.Group).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Group, must match a pattern of " + regexGroup, new [] { "Group" });
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
