/* 
 * Queenbee Recipe Schema
 *
 * Schema documentation for Queenbee Recipes
 *
 * The version of the OpenAPI document: 1.17.0
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
    /// Loop configuration for the task.  This will run the template provided multiple times and in parallel relative to an input or task parameter which should be a list.
    /// </summary>
    [DataContract]
    public partial class DAGTaskLoop :  IEquatable<DAGTaskLoop>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTaskLoop" /> class.
        /// </summary>
        /// <param name="from">The task or DAG parameter to loop over (must be iterable)..</param>
        /// <param name="value">A list of values or JSON objects to loop over..</param>
        public DAGTaskLoop
        (
           // Required parameters
           AnyOf<InputParameterReference,TaskParameterReference> from= default, List<AnyOf<string,int,double,object>> value= default// Optional parameters
        )// BaseClass
        {
            this.From = from;
            this.Value = value;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The task or DAG parameter to loop over (must be iterable).
        /// </summary>
        /// <value>The task or DAG parameter to loop over (must be iterable).</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        [JsonProperty("from")]
        public AnyOf<InputParameterReference,TaskParameterReference> From { get; set; } 
        /// <summary>
        /// A list of values or JSON objects to loop over.
        /// </summary>
        /// <value>A list of values or JSON objects to loop over.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        [JsonProperty("value")]
        public List<AnyOf<string,int,double,object>> Value { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DAGTaskLoop {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
        /// <returns>DAGTaskLoop object</returns>
        public static DAGTaskLoop FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGTaskLoop>(json, JsonSetting.AnyOfConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGTaskLoop object</returns>
        public DAGTaskLoop DuplicateDAGTaskLoop()
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
            return this.Equals(input as DAGTaskLoop);
        }

        /// <summary>
        /// Returns true if DAGTaskLoop instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGTaskLoop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGTaskLoop input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
