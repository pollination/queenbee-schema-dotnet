/* 
 * Queenbee Queenbee Schema
 *
 * Documentation for Queenbee queenbee schema.
 *
 * Contact: info@ladybug.tools
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;


namespace QueenbeeSDK
{
    /// <summary>
    /// S3 Source  An S3 bucket artifact Source.
    /// </summary>
    [DataContract(Name = "S3")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class S3 : ArtifactSource, IEquatable<S3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected S3() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "S3";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="S3" /> class.
        /// </summary>
        /// <param name="key">The path inside the bucket to source artifacts from. (required).</param>
        /// <param name="endpoint">The HTTP endpoint to reach the S3 bucket. (required).</param>
        /// <param name="bucket">The name of the S3 bucket on the host server. (required).</param>
        /// <param name="credentialsPath">Path to the file holding the AccessKey and SecretAccessKey to authenticate to the bucket. Assumes public bucket access if none are specified..</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        public S3
        (
             string key, string endpoint, string bucket, // Required parameters
            Dictionary<string, string> annotations= default, string credentialsPath= default// Optional parameters
        ) : base(annotations: annotations)// BaseClass
        {
            // to ensure "key" is required (not null)
            this.Key = key ?? throw new ArgumentNullException("key is a required property for S3 and cannot be null");
            // to ensure "endpoint" is required (not null)
            this.Endpoint = endpoint ?? throw new ArgumentNullException("endpoint is a required property for S3 and cannot be null");
            // to ensure "bucket" is required (not null)
            this.Bucket = bucket ?? throw new ArgumentNullException("bucket is a required property for S3 and cannot be null");
            this.CredentialsPath = credentialsPath;

            // Set non-required readonly properties with defaultValue
            this.Type = "S3";
        }

        /// <summary>
        /// The path inside the bucket to source artifacts from.
        /// </summary>
        /// <value>The path inside the bucket to source artifacts from.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        
        public string Key { get; set; } 
        /// <summary>
        /// The HTTP endpoint to reach the S3 bucket.
        /// </summary>
        /// <value>The HTTP endpoint to reach the S3 bucket.</value>
        [DataMember(Name = "endpoint", IsRequired = true, EmitDefaultValue = false)]
        
        public string Endpoint { get; set; } 
        /// <summary>
        /// The name of the S3 bucket on the host server.
        /// </summary>
        /// <value>The name of the S3 bucket on the host server.</value>
        [DataMember(Name = "bucket", IsRequired = true, EmitDefaultValue = false)]
        
        public string Bucket { get; set; } 
        /// <summary>
        /// Path to the file holding the AccessKey and SecretAccessKey to authenticate to the bucket. Assumes public bucket access if none are specified.
        /// </summary>
        /// <value>Path to the file holding the AccessKey and SecretAccessKey to authenticate to the bucket. Assumes public bucket access if none are specified.</value>
        [DataMember(Name = "credentials_path", EmitDefaultValue = false)]
        
        public string CredentialsPath { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "S3";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("S3:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  CredentialsPath: ").Append(CredentialsPath).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>S3 object</returns>
        public static S3 FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<S3>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>S3 object</returns>
        public virtual S3 DuplicateS3()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateS3();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override ArtifactSource DuplicateArtifactSource()
        {
            return DuplicateS3();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as S3);
        }

        /// <summary>
        /// Returns true if S3 instances are equal
        /// </summary>
        /// <param name="input">Instance of S3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3 input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && base.Equals(input) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && base.Equals(input) && 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.CredentialsPath == input.CredentialsPath ||
                    (this.CredentialsPath != null &&
                    this.CredentialsPath.Equals(input.CredentialsPath))
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
                int hashCode = base.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CredentialsPath != null)
                    hashCode = hashCode * 59 + this.CredentialsPath.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^S3$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
