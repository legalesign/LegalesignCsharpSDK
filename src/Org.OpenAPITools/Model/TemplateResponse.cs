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
    /// TemplateResponse
    /// </summary>
    [DataContract]
    public partial class TemplateResponse :  IEquatable<TemplateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponse" /> class.
        /// </summary>
        /// <param name="archive">archive.</param>
        /// <param name="created">created.</param>
        /// <param name="group">group.</param>
        /// <param name="hasFields">hasFields.</param>
        /// <param name="modified">modified.</param>
        /// <param name="resourceUri">resourceUri.</param>
        /// <param name="signeeCount">signeeCount.</param>
        /// <param name="title">title.</param>
        /// <param name="user">user.</param>
        /// <param name="uuid">uuid.</param>
        public TemplateResponse(bool archive = default(bool), DateTime created = default(DateTime), string group = default(string), bool hasFields = default(bool), DateTime modified = default(DateTime), string resourceUri = default(string), int signeeCount = default(int), string title = default(string), string user = default(string), string uuid = default(string))
        {
            this.Archive = archive;
            this.Created = created;
            this.Group = group;
            this.HasFields = hasFields;
            this.Modified = modified;
            this.ResourceUri = resourceUri;
            this.SigneeCount = signeeCount;
            this.Title = title;
            this.User = user;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Gets or Sets Archive
        /// </summary>
        [DataMember(Name="archive", EmitDefaultValue=false)]
        public bool Archive { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets HasFields
        /// </summary>
        [DataMember(Name="has_fields", EmitDefaultValue=false)]
        public bool HasFields { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// Gets or Sets ResourceUri
        /// </summary>
        [DataMember(Name="resource_uri", EmitDefaultValue=false)]
        public string ResourceUri { get; set; }

        /// <summary>
        /// Gets or Sets SigneeCount
        /// </summary>
        [DataMember(Name="signee_count", EmitDefaultValue=false)]
        public int SigneeCount { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateResponse {\n");
            sb.Append("  Archive: ").Append(Archive).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  HasFields: ").Append(HasFields).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  ResourceUri: ").Append(ResourceUri).Append("\n");
            sb.Append("  SigneeCount: ").Append(SigneeCount).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(input as TemplateResponse);
        }

        /// <summary>
        /// Returns true if TemplateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Archive == input.Archive ||
                    (this.Archive != null &&
                    this.Archive.Equals(input.Archive))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.HasFields == input.HasFields ||
                    (this.HasFields != null &&
                    this.HasFields.Equals(input.HasFields))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.ResourceUri == input.ResourceUri ||
                    (this.ResourceUri != null &&
                    this.ResourceUri.Equals(input.ResourceUri))
                ) && 
                (
                    this.SigneeCount == input.SigneeCount ||
                    (this.SigneeCount != null &&
                    this.SigneeCount.Equals(input.SigneeCount))
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
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Archive != null)
                    hashCode = hashCode * 59 + this.Archive.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.HasFields != null)
                    hashCode = hashCode * 59 + this.HasFields.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.ResourceUri != null)
                    hashCode = hashCode * 59 + this.ResourceUri.GetHashCode();
                if (this.SigneeCount != null)
                    hashCode = hashCode * 59 + this.SigneeCount.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
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
