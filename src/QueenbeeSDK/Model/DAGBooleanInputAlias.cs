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
    /// The boolean type matches only two special values: True and False.  Note that values that evaluate to true or false, such as 1 and 0, are not accepted.  You can add additional validation by defining a JSONSchema specification.  See http://json-schema.org/understanding-json-schema/reference/boolean.html for more information.
    /// </summary>
    [DataContract(Name = "DAGBooleanInputAlias")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class DAGBooleanInputAlias : OpenAPIGenBaseModel, IEquatable<DAGBooleanInputAlias>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGBooleanInputAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGBooleanInputAlias() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGBooleanInputAlias";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGBooleanInputAlias" /> class.
        /// </summary>
        /// <param name="name">Input name. (required).</param>
        /// <param name="platform">Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe. (required).</param>
        /// <param name="handler">List of process actions to process the input or output value. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for input..</param>
        /// <param name="_default">Default value to use for an input if a value was not supplied..</param>
        /// <param name="spec">An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec..</param>
        public DAGBooleanInputAlias
        (
             string name, List<string> platform, List<IOAliasHandler> handler, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, bool _default= default, Object spec= default // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for DAGBooleanInputAlias and cannot be null");
            // to ensure "platform" is required (not null)
            this.Platform = platform ?? throw new ArgumentNullException("platform is a required property for DAGBooleanInputAlias and cannot be null");
            // to ensure "handler" is required (not null)
            this.Handler = handler ?? throw new ArgumentNullException("handler is a required property for DAGBooleanInputAlias and cannot be null");
            this.Annotations = annotations;
            this.Description = description;
            this.Default = _default;
            this.Spec = spec;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGBooleanInputAlias";
        }

        /// <summary>
        /// Input name.
        /// </summary>
        /// <value>Input name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        
        public string Name { get; set; } 
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
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Optional description for input.
        /// </summary>
        /// <value>Optional description for input.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        
        public string Description { get; set; } 
        /// <summary>
        /// Default value to use for an input if a value was not supplied.
        /// </summary>
        /// <value>Default value to use for an input if a value was not supplied.</value>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        
        public bool Default { get; set; } 
        /// <summary>
        /// An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.
        /// </summary>
        /// <value>An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.</value>
        [DataMember(Name = "spec", EmitDefaultValue = false)]
        
        public Object Spec { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGBooleanInputAlias";
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
            sb.Append("DAGBooleanInputAlias:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Spec: ").Append(Spec).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGBooleanInputAlias object</returns>
        public static DAGBooleanInputAlias FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGBooleanInputAlias>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGBooleanInputAlias object</returns>
        public virtual DAGBooleanInputAlias DuplicateDAGBooleanInputAlias()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGBooleanInputAlias();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateDAGBooleanInputAlias();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DAGBooleanInputAlias);
        }

        /// <summary>
        /// Returns true if DAGBooleanInputAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGBooleanInputAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGBooleanInputAlias input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
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
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && base.Equals(input) && 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGBooleanInputAlias$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
