/* 
 * Queenbee Recipe Schema
 *
 * Documentation for Queenbee recipe schema.
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
    /// Configuration to fetch a Recipe or Operator that another Recipe depends on.
    /// </summary>
    [DataContract(Name = "Dependency")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class Dependency : OpenAPIGenBaseModel, IEquatable<Dependency>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public DependencyType DepandencyType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Dependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Dependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dependency" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="name">Workflow name. This name should be unique among all the resources in your resource. Use an alias if this is not the case. (required).</param>
        /// <param name="tag">Tag of the resource. (required).</param>
        /// <param name="source">URL to a repository where this resource can be found. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="hash">The digest hash of the dependency when retrieved from its source. This is locked when the resource dependencies are downloaded..</param>
        /// <param name="alias">An optional alias to refer to this dependency. Useful if the name is already used somewhere else..</param>
        public Dependency
        (
             DependencyType type, string name, string tag, string source, // Required parameters
            Dictionary<string, string> annotations= default, string hash= default, string alias= default// Optional parameters
        ) : base()// BaseClass
        {
            this.DepandencyType = type;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for Dependency and cannot be null");
            // to ensure "tag" is required (not null)
            this.Tag = tag ?? throw new ArgumentNullException("tag is a required property for Dependency and cannot be null");
            // to ensure "source" is required (not null)
            this.Source = source ?? throw new ArgumentNullException("source is a required property for Dependency and cannot be null");
            this.Annotations = annotations;
            this.Hash = hash;
            this.Alias = alias;

            // Set non-required readonly properties with defaultValue
            this.Type = "Dependency";
        }

        /// <summary>
        /// Workflow name. This name should be unique among all the resources in your resource. Use an alias if this is not the case.
        /// </summary>
        /// <value>Workflow name. This name should be unique among all the resources in your resource. Use an alias if this is not the case.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        
        public string Name { get; set; } 
        /// <summary>
        /// Tag of the resource.
        /// </summary>
        /// <value>Tag of the resource.</value>
        [DataMember(Name = "tag", IsRequired = true, EmitDefaultValue = false)]
        
        public string Tag { get; set; } 
        /// <summary>
        /// URL to a repository where this resource can be found.
        /// </summary>
        /// <value>URL to a repository where this resource can be found.</value>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = false)]
        
        public string Source { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The digest hash of the dependency when retrieved from its source. This is locked when the resource dependencies are downloaded.
        /// </summary>
        /// <value>The digest hash of the dependency when retrieved from its source. This is locked when the resource dependencies are downloaded.</value>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        
        public string Hash { get; set; } 
        /// <summary>
        /// An optional alias to refer to this dependency. Useful if the name is already used somewhere else.
        /// </summary>
        /// <value>An optional alias to refer to this dependency. Useful if the name is already used somewhere else.</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        
        public string Alias { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Dependency";
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
            sb.Append("Dependency:\n");
            sb.Append("  Type: ").Append(DepandencyType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Dependency object</returns>
        public static Dependency FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Dependency>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Dependency object</returns>
        public virtual Dependency DuplicateDependency()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDependency();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateDependency();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Dependency);
        }

        /// <summary>
        /// Returns true if Dependency instances are equal
        /// </summary>
        /// <param name="input">Instance of Dependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dependency input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.DepandencyType == input.DepandencyType ||
                    (this.DepandencyType != null &&
                    this.DepandencyType.Equals(input.DepandencyType))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && base.Equals(input) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && base.Equals(input) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && base.Equals(input) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && base.Equals(input) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
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
                if (this.DepandencyType != null)
                    hashCode = hashCode * 59 + this.DepandencyType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
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
            yield break;
        }
    }
}
