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
    /// An array input.  You can add additional validation by defining a JSONSchema specification.  See http://json-schema.org/understanding-json-schema/reference/array.html for more information.
    /// </summary>
    [DataContract(Name = "DAGArrayInput")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class DAGArrayInput : OpenAPIGenBaseModel, IEquatable<DAGArrayInput>, IValidatableObject
    {
        /// <summary>
        /// Type of items in an array. All the items in an array must be from the same type.
        /// </summary>
        /// <value>Type of items in an array. All the items in an array must be from the same type.</value>
        [DataMember(Name="items_type", EmitDefaultValue=false)]
        public ItemType ItemsType { get; set; } = ItemType.String;
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGArrayInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGArrayInput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGArrayInput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGArrayInput" /> class.
        /// </summary>
        /// <param name="name">Input name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for input..</param>
        /// <param name="_default">Default value to use for an input if a value was not supplied..</param>
        /// <param name="spec">An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec..</param>
        /// <param name="alias">A list of aliases for this input in different platforms..</param>
        /// <param name="itemsType">Type of items in an array. All the items in an array must be from the same type..</param>
        public DAGArrayInput
        (
             string name, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, List<object> _default= default, Object spec= default, List<AnyOf<DAGGenericInputAlias,DAGStringInputAlias,DAGIntegerInputAlias,DAGNumberInputAlias,DAGBooleanInputAlias,DAGFolderInputAlias,DAGFileInputAlias,DAGPathInputAlias,DAGArrayInputAlias,DAGObjectInputAlias>> alias= default, ItemType itemsType= ItemType.String // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for DAGArrayInput and cannot be null");
            this.Annotations = annotations;
            this.Description = description;
            this.Default = _default;
            this.Spec = spec;
            this.Alias = alias;
            this.ItemsType = itemsType;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGArrayInput";
        }

        /// <summary>
        /// Input name.
        /// </summary>
        /// <value>Input name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        
        public string Name { get; set; } 
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
        
        public List<object> Default { get; set; } 
        /// <summary>
        /// An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.
        /// </summary>
        /// <value>An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec.</value>
        [DataMember(Name = "spec", EmitDefaultValue = false)]
        
        public Object Spec { get; set; } 
        /// <summary>
        /// A list of aliases for this input in different platforms.
        /// </summary>
        /// <value>A list of aliases for this input in different platforms.</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        
        public List<AnyOf<DAGGenericInputAlias,DAGStringInputAlias,DAGIntegerInputAlias,DAGNumberInputAlias,DAGBooleanInputAlias,DAGFolderInputAlias,DAGFileInputAlias,DAGPathInputAlias,DAGArrayInputAlias,DAGObjectInputAlias>> Alias { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGArrayInput";
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
            sb.Append("DAGArrayInput:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Spec: ").Append(Spec).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  ItemsType: ").Append(ItemsType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGArrayInput object</returns>
        public static DAGArrayInput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGArrayInput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGArrayInput object</returns>
        public virtual DAGArrayInput DuplicateDAGArrayInput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGArrayInput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateDAGArrayInput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DAGArrayInput);
        }

        /// <summary>
        /// Returns true if DAGArrayInput instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGArrayInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGArrayInput input)
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
                    this.Default != null &&
                    input.Default != null &&
                    this.Default.SequenceEqual(input.Default)
                ) && base.Equals(input) && 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
                ) && base.Equals(input) && 
                (
                    this.Alias == input.Alias ||
                    this.Alias != null &&
                    input.Alias != null &&
                    this.Alias.SequenceEqual(input.Alias)
                ) && base.Equals(input) && 
                (
                    this.ItemsType == input.ItemsType ||
                    (this.ItemsType != null &&
                    this.ItemsType.Equals(input.ItemsType))
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
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.ItemsType != null)
                    hashCode = hashCode * 59 + this.ItemsType.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGArrayInput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
