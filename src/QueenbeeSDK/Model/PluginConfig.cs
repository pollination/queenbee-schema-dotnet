/* 
 * Queenbee Schema with Inheritance
 *
 * Documentation for Queenbee schema.
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
using System.ComponentModel.DataAnnotations;


namespace QueenbeeSDK
{
    /// <summary>
    /// Plugin configuration.  The config is used to schedule functions on a desktop or in other contexts (ie: Docker).
    /// </summary>
    [DataContract(Name = "PluginConfig")]
    public partial class PluginConfig : OpenAPIGenBaseModel, IEquatable<PluginConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PluginConfig() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "PluginConfig";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginConfig" /> class.
        /// </summary>
        /// <param name="docker">The configuration to use this plugin in a docker container (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="local">The configuration to use this plugin locally.</param>
        public PluginConfig
        (
            DockerConfig docker, // Required parameters
            Dictionary<string, string> annotations= default, LocalConfig local= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "docker" is required (not null)
            this.Docker = docker ?? throw new ArgumentNullException("docker is a required property for PluginConfig and cannot be null");
            this.Annotations = annotations;
            this.Local = local;

            // Set non-required readonly properties with defaultValue
            this.Type = "PluginConfig";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "PluginConfig";

        /// <summary>
        /// The configuration to use this plugin in a docker container
        /// </summary>
        /// <value>The configuration to use this plugin in a docker container</value>
        [DataMember(Name = "docker", IsRequired = true, EmitDefaultValue = false)]
        public DockerConfig Docker { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The configuration to use this plugin locally
        /// </summary>
        /// <value>The configuration to use this plugin locally</value>
        [DataMember(Name = "local", EmitDefaultValue = false)]
        public LocalConfig Local { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "PluginConfig";
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
            sb.Append("PluginConfig:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Docker: ").Append(Docker).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>PluginConfig object</returns>
        public static PluginConfig FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<PluginConfig>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>PluginConfig object</returns>
        public virtual PluginConfig DuplicatePluginConfig()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicatePluginConfig();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicatePluginConfig();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as PluginConfig);
        }

        /// <summary>
        /// Returns true if PluginConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginConfig input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Docker == input.Docker ||
                    (this.Docker != null &&
                    this.Docker.Equals(input.Docker))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && base.Equals(input) && 
                (
                    this.Local == input.Local ||
                    (this.Local != null &&
                    this.Local.Equals(input.Local))
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
                if (this.Docker != null)
                    hashCode = hashCode * 59 + this.Docker.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Local != null)
                    hashCode = hashCode * 59 + this.Local.GetHashCode();
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
            Regex regexType = new Regex(@"^PluginConfig", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
