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
    /// A file input.
    /// </summary>
    [DataContract(Name = "StepFileInput")]
    public partial class StepFileInput : GenericInput, IEquatable<StepFileInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepFileInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepFileInput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "StepFileInput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StepFileInput" /> class.
        /// </summary>
        /// <param name="source">The path to source the file from. (required).</param>
        /// <param name="_default">The default source for file if the value is not provided..</param>
        /// <param name="alias">A list of aliases for this input in different platforms..</param>
        /// <param name="required">A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided. (default to false).</param>
        /// <param name="spec">An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec..</param>
        /// <param name="path">Path to the target location that the input will be copied to.  This path is relative to the working directory where the command is executed..</param>
        /// <param name="extensions">Optional list of extensions for file. The check for extension is case-insensitive..</param>
        /// <param name="name">Input name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for input..</param>
        public StepFileInput
        (
            string name, AnyOf<HTTP,S3,ProjectFolder> source, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, AnyOf<HTTP,S3,ProjectFolder> _default= default, List<AnyOf<DAGGenericInputAlias,DAGStringInputAlias,DAGIntegerInputAlias,DAGNumberInputAlias,DAGBooleanInputAlias,DAGFolderInputAlias,DAGFileInputAlias,DAGPathInputAlias,DAGArrayInputAlias,DAGJSONObjectInputAlias,DAGLinkedInputAlias>> alias= default, bool required = false, Object spec= default, string path= default, List<string> extensions= default // Optional parameters
        ) : base(name: name, annotations: annotations, description: description)// BaseClass
        {
            // to ensure "source" is required (not null)
            this.Source = source ?? throw new ArgumentNullException("source is a required property for StepFileInput and cannot be null");
            this.Default = _default;
            this.Alias = alias;
            this.Required = required;
            this.Spec = spec;
            this.Path = path;
            this.Extensions = extensions;

            // Set non-required readonly properties with defaultValue
            this.Type = "StepFileInput";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "StepFileInput";

        /// <summary>
        /// The path to source the file from.
        /// </summary>
        /// <value>The path to source the file from.</value>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = false)]
        public AnyOf<HTTP,S3,ProjectFolder> Source { get; set; } 
        /// <summary>
        /// The default source for file if the value is not provided.
        /// </summary>
        /// <value>The default source for file if the value is not provided.</value>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public AnyOf<HTTP,S3,ProjectFolder> Default { get; set; } 
        /// <summary>
        /// A list of aliases for this input in different platforms.
        /// </summary>
        /// <value>A list of aliases for this input in different platforms.</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public List<AnyOf<DAGGenericInputAlias,DAGStringInputAlias,DAGIntegerInputAlias,DAGNumberInputAlias,DAGBooleanInputAlias,DAGFolderInputAlias,DAGFileInputAlias,DAGPathInputAlias,DAGArrayInputAlias,DAGJSONObjectInputAlias,DAGLinkedInputAlias>> Alias { get; set; } 
        /// <summary>
        /// A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided.
        /// </summary>
        /// <value>A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided.</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }  = false;
        /// <summary>
        /// An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.
        /// </summary>
        /// <value>An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.</value>
        [DataMember(Name = "spec", EmitDefaultValue = false)]
        public Object Spec { get; set; } 
        /// <summary>
        /// Path to the target location that the input will be copied to.  This path is relative to the working directory where the command is executed.
        /// </summary>
        /// <value>Path to the target location that the input will be copied to.  This path is relative to the working directory where the command is executed.</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; } 
        /// <summary>
        /// Optional list of extensions for file. The check for extension is case-insensitive.
        /// </summary>
        /// <value>Optional list of extensions for file. The check for extension is case-insensitive.</value>
        [DataMember(Name = "extensions", EmitDefaultValue = false)]
        public List<string> Extensions { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "StepFileInput";
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
            sb.Append("StepFileInput:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Spec: ").Append(Spec).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>StepFileInput object</returns>
        public static StepFileInput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StepFileInput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StepFileInput object</returns>
        public virtual StepFileInput DuplicateStepFileInput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateStepFileInput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override GenericInput DuplicateGenericInput()
        {
            return DuplicateStepFileInput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as StepFileInput);
        }

        /// <summary>
        /// Returns true if StepFileInput instances are equal
        /// </summary>
        /// <param name="input">Instance of StepFileInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepFileInput input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && base.Equals(input) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && base.Equals(input) && 
                (
                    this.Alias == input.Alias ||
                    this.Alias != null &&
                    input.Alias != null &&
                    this.Alias.SequenceEqual(input.Alias)
                ) && base.Equals(input) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && base.Equals(input) && 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.ToString().Equals(input.Spec.ToString()))
                ) && base.Equals(input) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && base.Equals(input) && 
                (
                    this.Extensions == input.Extensions ||
                    this.Extensions != null &&
                    input.Extensions != null &&
                    this.Extensions.SequenceEqual(input.Extensions)
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Extensions != null)
                    hashCode = hashCode * 59 + this.Extensions.GetHashCode();
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
            Regex regexType = new Regex(@"^StepFileInput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
