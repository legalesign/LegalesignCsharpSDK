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
    /// HTMLSigningPreviewPost
    /// </summary>
    [DataContract]
    public partial class HTMLSigningPreviewPost :  IEquatable<HTMLSigningPreviewPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HTMLSigningPreviewPost" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="title">title.</param>
        /// <param name="group">group.</param>
        /// <param name="signeeCount">signeeCount.</param>
        public HTMLSigningPreviewPost(string text = default(string), string title = default(string), string group = default(string), int signeeCount = default(int))
        {
            this.Text = text;
            this.Title = title;
            this.Group = group;
            this.SigneeCount = signeeCount;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets SigneeCount
        /// </summary>
        [DataMember(Name="signee_count", EmitDefaultValue=false)]
        public int SigneeCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HTMLSigningPreviewPost {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  SigneeCount: ").Append(SigneeCount).Append("\n");
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
            return this.Equals(input as HTMLSigningPreviewPost);
        }

        /// <summary>
        /// Returns true if HTMLSigningPreviewPost instances are equal
        /// </summary>
        /// <param name="input">Instance of HTMLSigningPreviewPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HTMLSigningPreviewPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
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
                    this.SigneeCount == input.SigneeCount ||
                    (this.SigneeCount != null &&
                    this.SigneeCount.Equals(input.SigneeCount))
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.SigneeCount != null)
                    hashCode = hashCode * 59 + this.SigneeCount.GetHashCode();
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

            yield break;
        }
    }

}
