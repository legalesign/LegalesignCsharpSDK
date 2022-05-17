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
    /// StatusResponse
    /// </summary>
    [DataContract]
    public partial class StatusResponse :  IEquatable<StatusResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public SignerStatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponse" /> class.
        /// </summary>
        /// <param name="archived">archived.</param>
        /// <param name="resourceUri">resourceUri.</param>
        /// <param name="status">status.</param>
        /// <param name="downloadFinal">downloadFinal.</param>
        /// <param name="tag">tag.</param>
        public StatusResponse(bool archived = default(bool), string resourceUri = default(string), SignerStatusEnum? status = default(SignerStatusEnum?), bool downloadFinal = default(bool), string tag = default(string))
        {
            this.Archived = archived;
            this.ResourceUri = resourceUri;
            this.Status = status;
            this.DownloadFinal = downloadFinal;
            this.Tag = tag;
        }

        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name="archived", EmitDefaultValue=false)]
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or Sets ResourceUri
        /// </summary>
        [DataMember(Name="resource_uri", EmitDefaultValue=false)]
        public string ResourceUri { get; set; }


        /// <summary>
        /// Gets or Sets DownloadFinal
        /// </summary>
        [DataMember(Name="download_final", EmitDefaultValue=false)]
        public bool DownloadFinal { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusResponse {\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  ResourceUri: ").Append(ResourceUri).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DownloadFinal: ").Append(DownloadFinal).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as StatusResponse);
        }

        /// <summary>
        /// Returns true if StatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Archived == input.Archived ||
                    (this.Archived != null &&
                    this.Archived.Equals(input.Archived))
                ) && 
                (
                    this.ResourceUri == input.ResourceUri ||
                    (this.ResourceUri != null &&
                    this.ResourceUri.Equals(input.ResourceUri))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DownloadFinal == input.DownloadFinal ||
                    (this.DownloadFinal != null &&
                    this.DownloadFinal.Equals(input.DownloadFinal))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.Archived != null)
                    hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.ResourceUri != null)
                    hashCode = hashCode * 59 + this.ResourceUri.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DownloadFinal != null)
                    hashCode = hashCode * 59 + this.DownloadFinal.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
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
