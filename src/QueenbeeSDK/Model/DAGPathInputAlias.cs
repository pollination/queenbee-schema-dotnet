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
    /// A file or a folder input.  Use this input only in cases that the input can be either a file or folder. For file or folder-only inputs see File and Folder.  Path is a special string input. Unlike other string inputs, a path will be copied from its location to execution folder when a workflow is executed.  You can add additional validation by defining a JSONSchema specification.  See http://json-schema.org/understanding-json-schema/reference/string.html#string for more information.  .. code-block:: python      # a file with maximum 50 characters with an &#x60;&#x60;epw&#x60;&#x60; extension.      \&quot;schema\&quot;: {         \&quot;type\&quot;: \&quot;string\&quot;,         \&quot;maxLength\&quot;: 50,         \&quot;pattern\&quot;: \&quot;(?i)(^.*\\.epw$)\&quot;     }
    /// </summary>
    [DataContract(Name = "DAGPathInputAlias")]
    public partial class DAGPathInputAlias : GenericInput, IEquatable<DAGPathInputAlias>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGPathInputAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGPathInputAlias() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGPathInputAlias";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGPathInputAlias" /> class.
        /// </summary>
        /// <param name="platform">Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe. (required).</param>
        /// <param name="handler">List of process actions to process the input or output value. (required).</param>
        /// <param name="_default">The default source for file if the value is not provided..</param>
        /// <param name="required">A field to indicate if this input is required. This input needs to be set explicitly even when a default value is provided. (default to false).</param>
        /// <param name="spec">An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec..</param>
        /// <param name="extensions">Optional list of extensions for path. The check for extension is case-insensitive. The extension will only be validated for file inputs..</param>
        /// <param name="name">Input name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for input..</param>
        public DAGPathInputAlias
        (
            string name, List<string> platform, List<IOAliasHandler> handler, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, AnyOf<HTTP,S3,ProjectFolder> _default= default, bool required = false, Object spec= default, List<string> extensions= default // Optional parameters
        ) : base(name: name, annotations: annotations, description: description)// BaseClass
        {
            // to ensure "platform" is required (not null)
            this.Platform = platform ?? throw new ArgumentNullException("platform is a required property for DAGPathInputAlias and cannot be null");
            // to ensure "handler" is required (not null)
            this.Handler = handler ?? throw new ArgumentNullException("handler is a required property for DAGPathInputAlias and cannot be null");
            this.Default = _default;
            this.Required = required;
            this.Spec = spec;
            this.Extensions = extensions;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGPathInputAlias";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "DAGPathInputAlias";

        /// <summary>
        /// Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe.
        /// </summary>
        /// <value>Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe.</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Platform { get; set; } 
        /// <summary>
        /// List of process actions to process the input or output value.
        /// </summary>
        /// <value>List of process actions to process the input or output value.</value>
        [DataMember(Name = "handler", IsRequired = true, EmitDefaultValue = false)]
        public List<IOAliasHandler> Handler { get; set; } 
        /// <summary>
        /// The default source for file if the value is not provided.
        /// </summary>
        /// <value>The default source for file if the value is not provided.</value>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public AnyOf<HTTP,S3,ProjectFolder> Default { get; set; } 
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
        /// Optional list of extensions for path. The check for extension is case-insensitive. The extension will only be validated for file inputs.
        /// </summary>
        /// <value>Optional list of extensions for path. The check for extension is case-insensitive. The extension will only be validated for file inputs.</value>
        [DataMember(Name = "extensions", EmitDefaultValue = false)]
        public List<string> Extensions { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGPathInputAlias";
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
            sb.Append("DAGPathInputAlias:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Spec: ").Append(Spec).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGPathInputAlias object</returns>
        public static DAGPathInputAlias FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGPathInputAlias>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGPathInputAlias object</returns>
        public virtual DAGPathInputAlias DuplicateDAGPathInputAlias()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGPathInputAlias();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override GenericInput DuplicateGenericInput()
        {
            return DuplicateDAGPathInputAlias();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DAGPathInputAlias);
        }

        /// <summary>
        /// Returns true if DAGPathInputAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGPathInputAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGPathInputAlias input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform != null &&
                    input.Platform != null &&
                    this.Platform.SequenceEqual(input.Platform)
                ) && base.Equals(input) && 
                (
                    this.Handler == input.Handler ||
                    this.Handler != null &&
                    input.Handler != null &&
                    this.Handler.SequenceEqual(input.Handler)
                ) && base.Equals(input) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
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
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGPathInputAlias$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
