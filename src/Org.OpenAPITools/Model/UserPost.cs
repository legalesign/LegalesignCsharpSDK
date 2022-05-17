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
    /// Create a new user who can gain access to your groups. You should specify the groups the user should be able to access. Only the groups the API user can access are valid. If you do not set a password then a verification link will be emailed to the user. This will allow the user to set their password and activate their account. In this case you can also add a redirect_to url to redirect the user back to your website after they have activated their account. N.B. Make sure you add the user to at least one of your groups, otherwise you will not have API access to the user information. 
    /// </summary>
    [DataContract]
    public partial class UserPost :  IEquatable<UserPost>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public TimezoneEnum? Timezone { get; set; }
        /// <summary>
        /// set user permissions * 1 - admin * 2 - create and send docs, team user * 3 - readonly, team user * 4 - send only, team user * 5 - send only, individual user * 6 - create and send docs, invidual user
        /// </summary>
        /// <value>set user permissions * 1 - admin * 2 - create and send docs, team user * 3 - readonly, team user * 4 - send only, team user * 5 - send only, individual user * 6 - create and send docs, invidual user</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 1,

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 2,

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 3,

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 4,

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 5,

            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 6

        }

        /// <summary>
        /// set user permissions * 1 - admin * 2 - create and send docs, team user * 3 - readonly, team user * 4 - send only, team user * 5 - send only, individual user * 6 - create and send docs, invidual user
        /// </summary>
        /// <value>set user permissions * 1 - admin * 2 - create and send docs, team user * 3 - readonly, team user * 4 - send only, team user * 5 - send only, individual user * 6 - create and send docs, invidual user</value>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public PermissionEnum? Permission { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPost" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="password">If not set a verification email is sent. Password must be at least 8 chars, include upper and lower case, with a number and a special character.</param>
        /// <param name="groups">comma delimited list of groups to add user to, can be full group resource_uri or groupId.</param>
        /// <param name="permission">set user permissions * 1 - admin * 2 - create and send docs, team user * 3 - readonly, team user * 4 - send only, team user * 5 - send only, individual user * 6 - create and send docs, invidual user.</param>
        public UserPost(string firstName = default(string), string lastName = default(string), string email = default(string), TimezoneEnum? timezone = default(TimezoneEnum?), string password = default(string), string groups = default(string), PermissionEnum? permission = default(PermissionEnum?))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for UserPost and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }

            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for UserPost and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }

            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for UserPost and cannot be null");
            }
            else
            {
                this.Email = email;
            }

            this.Timezone = timezone;
            this.Password = password;
            this.Groups = groups;
            this.Permission = permission;
        }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }


        /// <summary>
        /// If not set a verification email is sent. Password must be at least 8 chars, include upper and lower case, with a number and a special character
        /// </summary>
        /// <value>If not set a verification email is sent. Password must be at least 8 chars, include upper and lower case, with a number and a special character</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// comma delimited list of groups to add user to, can be full group resource_uri or groupId
        /// </summary>
        /// <value>comma delimited list of groups to add user to, can be full group resource_uri or groupId</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public string Groups { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPost {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as UserPost);
        }

        /// <summary>
        /// Returns true if UserPost instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Groups == input.Groups ||
                    (this.Groups != null &&
                    this.Groups.Equals(input.Groups))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
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
            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 30.", new [] { "FirstName" });
            }


            // FirstName (string) pattern
            Regex regexFirstName = new Regex(@"^[-\\w' ]{1,75}", RegexOptions.CultureInvariant);
            if (false == regexFirstName.Match(this.FirstName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, must match a pattern of " + regexFirstName, new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 30.", new [] { "LastName" });
            }


            // LastName (string) pattern
            Regex regexLastName = new Regex(@"^[-\\w' ]{1,75}", RegexOptions.CultureInvariant);
            if (false == regexLastName.Match(this.LastName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, must match a pattern of " + regexLastName, new [] { "LastName" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 75.", new [] { "Email" });
            }



            // Password (string) minLength
            if(this.Password != null && this.Password.Length < 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 8.", new [] { "Password" });
            }

            // Password (string) pattern
            //Regex regexPassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[=+\\-^$*.\\[\\]{}()?\"!@#%&\/\\\\,><':;|_~`])\\S{8,99}$", RegexOptions.CultureInvariant);
            if (this.Password.Contains(";"))
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password", new [] { "Password" });
            }



            // Groups (string) pattern
            Regex regexGroups = new Regex(@"^\/api\/v1\/group\/[-\\w]{1,50}\/$", RegexOptions.CultureInvariant);
            if (false == regexGroups.Match(this.Groups).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Groups, must match a pattern of " + regexGroups, new [] { "Groups" });
            }

            yield break;
        }
    }

}