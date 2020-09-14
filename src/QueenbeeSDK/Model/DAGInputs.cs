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
    /// Inputs of a DAG.
    /// </summary>
    [DataContract]
    public partial class DAGInputs :  IEquatable<DAGInputs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGInputs" /> class.
        /// </summary>
        /// <param name="parameters">A list of parameters the DAG will use as input values.</param>
        /// <param name="artifacts">A list of artifacts the DAG will use.</param>
        public DAGInputs
        (
           // Required parameters
           List<DAGInputParameter> parameters= default, List<DAGInputArtifact> artifacts= default// Optional parameters
        )// BaseClass
        {
            this.Parameters = parameters;
            this.Artifacts = artifacts;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// A list of parameters the DAG will use as input values
        /// </summary>
        /// <value>A list of parameters the DAG will use as input values</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        [JsonProperty("parameters")]
        public List<DAGInputParameter> Parameters { get; set; } 
        /// <summary>
        /// A list of artifacts the DAG will use
        /// </summary>
        /// <value>A list of artifacts the DAG will use</value>
        [DataMember(Name="artifacts", EmitDefaultValue=false)]
        [JsonProperty("artifacts")]
        public List<DAGInputArtifact> Artifacts { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DAGInputs {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
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
        /// <returns>DAGInputs object</returns>
        public static DAGInputs FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGInputs>(json, JsonSetting.AnyOfConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGInputs object</returns>
        public DAGInputs DuplicateDAGInputs()
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
            return this.Equals(input as DAGInputs);
        }

        /// <summary>
        /// Returns true if DAGInputs instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGInputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGInputs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Artifacts == input.Artifacts ||
                    this.Artifacts != null &&
                    input.Artifacts != null &&
                    this.Artifacts.SequenceEqual(input.Artifacts)
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
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Artifacts != null)
                    hashCode = hashCode * 59 + this.Artifacts.GetHashCode();
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
