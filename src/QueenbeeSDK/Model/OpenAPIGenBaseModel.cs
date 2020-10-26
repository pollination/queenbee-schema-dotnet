/* 
 * Queenbee Recipe Schema
 *
 * Documentation for Queenbee recipe schema.
 *
 * The version of the OpenAPI document: 1.6.6
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


namespace QueenbeeSDK.Model
{
    /// <summary>
    /// OpenAPIGenBaseModel
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(DAGFileInput), "DAGFileInput")]
    [JsonSubtypes.KnownSubType(typeof(Recipe), "Recipe")]
    [JsonSubtypes.KnownSubType(typeof(License), "License")]
    [JsonSubtypes.KnownSubType(typeof(DAGFolderInput), "DAGFolderInput")]
    [JsonSubtypes.KnownSubType(typeof(DAGPathInput), "DAGPathInput")]
    [JsonSubtypes.KnownSubType(typeof(IOBase), "IOBase")]
    [JsonSubtypes.KnownSubType(typeof(TaskArgument), "TaskArgument")]
    [JsonSubtypes.KnownSubType(typeof(Dependency), "Dependency")]
    [JsonSubtypes.KnownSubType(typeof(DAGTask), "DAGTask")]
    [JsonSubtypes.KnownSubType(typeof(ArtifactSource), "_ArtifactSource")]
    [JsonSubtypes.KnownSubType(typeof(BaseReference), "_BaseReference")]
    [JsonSubtypes.KnownSubType(typeof(Maintainer), "Maintainer")]
    [JsonSubtypes.KnownSubType(typeof(DAGArrayInput), "DAGArrayInput")]
    [JsonSubtypes.KnownSubType(typeof(GenericOutput), "GenericOutput")]
    [JsonSubtypes.KnownSubType(typeof(DAG), "DAG")]
    [JsonSubtypes.KnownSubType(typeof(DAGObjectInput), "DAGObjectInput")]
    [JsonSubtypes.KnownSubType(typeof(DAGBooleanInput), "DAGBooleanInput")]
    [JsonSubtypes.KnownSubType(typeof(MetaData), "MetaData")]
    [JsonSubtypes.KnownSubType(typeof(DAGTaskLoop), "DAGTaskLoop")]
    [JsonSubtypes.KnownSubType(typeof(DAGNumberInput), "DAGNumberInput")]
    [JsonSubtypes.KnownSubType(typeof(GenericInput), "GenericInput")]
    [JsonSubtypes.KnownSubType(typeof(DAGIntegerInput), "DAGIntegerInput")]
    [JsonSubtypes.KnownSubType(typeof(TaskPathArgument), "TaskPathArgument")]
    public partial class OpenAPIGenBaseModel :  IEquatable<OpenAPIGenBaseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIGenBaseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OpenAPIGenBaseModel
        (
           // Required parameters
           // Optional parameters
        )// BaseClass
        {

            // Set non-required readonly properties with defaultValue
            this.Type = "InvalidType";
        }
        
        /// <summary>
        /// A base class to use when there is no baseclass available to fall on.
        /// </summary>
        /// <value>A base class to use when there is no baseclass available to fall on.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }  = "InvalidType";
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenAPIGenBaseModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// <returns>OpenAPIGenBaseModel object</returns>
        public static OpenAPIGenBaseModel FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<OpenAPIGenBaseModel>(json, JsonSetting.AnyOfConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel object</returns>
        public OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
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
            return this.Equals(input as OpenAPIGenBaseModel);
        }

        /// <summary>
        /// Returns true if OpenAPIGenBaseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenAPIGenBaseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenAPIGenBaseModel input)
        {
            if (input == null)
                return false;

            return 
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
                int hashCode = 41;
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
