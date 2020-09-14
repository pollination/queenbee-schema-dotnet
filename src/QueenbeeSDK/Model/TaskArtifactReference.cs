/* 
 * Queenbee Recipe Schema
 *
 * Schema documentation for Queenbee Recipes
 *
 * The version of the OpenAPI document: 1.16.3
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


namespace QueenbeeSDK.Model
{
    /// <summary>
    /// A Task Artifact Reference
    /// </summary>
    [DataContract]
    public partial class TaskArtifactReference :  IEquatable<TaskArtifactReference>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TaskReference? Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskArtifactReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskArtifactReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskArtifactReference" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="name">The name of the task to pull output data from (required).</param>
        /// <param name="variable">The name of the task output variable (required).</param>
        public TaskArtifactReference
        (
           string name, string variable, // Required parameters
           TaskReference? type= default // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TaskArtifactReference and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "variable" is required (not null)
            if (variable == null)
            {
                throw new InvalidDataException("variable is a required property for TaskArtifactReference and cannot be null");
            }
            else
            {
                this.Variable = variable;
            }
            
            this.Type = type;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The name of the task to pull output data from
        /// </summary>
        /// <value>The name of the task to pull output data from</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The name of the task output variable
        /// </summary>
        /// <value>The name of the task output variable</value>
        [DataMember(Name="variable", EmitDefaultValue=false)]
        [JsonProperty("variable")]
        public string Variable { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskArtifactReference {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>TaskArtifactReference object</returns>
        public static TaskArtifactReference FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<TaskArtifactReference>(json, JsonSetting.AnyOfConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>TaskArtifactReference object</returns>
        public TaskArtifactReference DuplicateTaskArtifactReference()
        {
            return FromJson(this.ToJson());
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskArtifactReference);
        }

        /// <summary>
        /// Returns true if TaskArtifactReference instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskArtifactReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskArtifactReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Variable == input.Variable ||
                    (this.Variable != null &&
                    this.Variable.Equals(input.Variable))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Variable != null)
                    hashCode = hashCode * 59 + this.Variable.GetHashCode();
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
