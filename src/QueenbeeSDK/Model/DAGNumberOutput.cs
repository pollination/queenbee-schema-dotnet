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
using System.ComponentModel.DataAnnotations;


namespace QueenbeeSDK
{
    /// <summary>
    /// DAG number output.  This output loads the content from a file as a floating number.
    /// </summary>
    [DataContract(Name = "DAGNumberOutput")]
    public partial class DAGNumberOutput : GenericOutput, IEquatable<DAGNumberOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGNumberOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGNumberOutput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGNumberOutput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGNumberOutput" /> class.
        /// </summary>
        /// <param name="from">Reference to a file or a task output. Task output must be file. (required).</param>
        /// <param name="alias">A list of additional processes for loading this output on different platforms..</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        public DAGNumberOutput
        (
            string name, AnyOf<TaskReference,FileReference> from, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, List<AnyOf<DAGGenericOutputAlias,DAGStringOutputAlias,DAGIntegerOutputAlias,DAGNumberOutputAlias,DAGBooleanOutputAlias,DAGFolderOutputAlias,DAGFileOutputAlias,DAGPathOutputAlias,DAGArrayOutputAlias,DAGJSONObjectOutputAlias,DAGLinkedOutputAlias>> alias= default // Optional parameters
        ) : base(name: name, annotations: annotations, description: description)// BaseClass
        {
            // to ensure "from" is required (not null)
            this.From = from ?? throw new ArgumentNullException("from is a required property for DAGNumberOutput and cannot be null");
            this.Alias = alias;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGNumberOutput";
        }

        /// <summary>
        /// Reference to a file or a task output. Task output must be file.
        /// </summary>
        /// <value>Reference to a file or a task output. Task output must be file.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = false)]
        public AnyOf<TaskReference,FileReference> From { get; set; } 
        /// <summary>
        /// A list of additional processes for loading this output on different platforms.
        /// </summary>
        /// <value>A list of additional processes for loading this output on different platforms.</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public List<AnyOf<DAGGenericOutputAlias,DAGStringOutputAlias,DAGIntegerOutputAlias,DAGNumberOutputAlias,DAGBooleanOutputAlias,DAGFolderOutputAlias,DAGFileOutputAlias,DAGPathOutputAlias,DAGArrayOutputAlias,DAGJSONObjectOutputAlias,DAGLinkedOutputAlias>> Alias { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGNumberOutput";
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
            sb.Append("DAGNumberOutput:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGNumberOutput object</returns>
        public static DAGNumberOutput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGNumberOutput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGNumberOutput object</returns>
        public virtual DAGNumberOutput DuplicateDAGNumberOutput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGNumberOutput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override GenericOutput DuplicateGenericOutput()
        {
            return DuplicateDAGNumberOutput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DAGNumberOutput);
        }

        /// <summary>
        /// Returns true if DAGNumberOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGNumberOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGNumberOutput input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && base.Equals(input) && 
                (
                    this.Alias == input.Alias ||
                    this.Alias != null &&
                    input.Alias != null &&
                    this.Alias.SequenceEqual(input.Alias)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGNumberOutput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
