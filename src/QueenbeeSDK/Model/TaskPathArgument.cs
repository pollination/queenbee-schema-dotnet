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
    /// BaseModel with functionality to return the object as a yaml string.
    /// </summary>
    [DataContract(Name = "TaskPathArgument")]
    public partial class TaskPathArgument : OpenAPIGenBaseModel, IEquatable<TaskPathArgument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPathArgument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskPathArgument() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "TaskPathArgument";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPathArgument" /> class.
        /// </summary>
        /// <param name="name">Argument name. The name must match one of the input names from Task&#39;s template which can be a function or DAG. (required).</param>
        /// <param name="from">A reference to a DAG input, a DAG output or another task output. You can also use the ValueReference type to hard-code an input value. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="subPath">A sub_path inside the path that is provided in the &#x60;&#x60;from&#x60;&#x60; field. Use sub_path to only access part of the Path that is needed instead of copying all the files and folders inside the path..</param>
        public TaskPathArgument
        (
             string name, AnyOf<InputFileReference,InputFolderReference,InputPathReference,TaskFileReference,TaskFolderReference,TaskPathReference,ValueFileReference,ValueFolderReference> from, // Required parameters
            Dictionary<string, string> annotations= default, string subPath= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for TaskPathArgument and cannot be null");
            // to ensure "from" is required (not null)
            this.From = from ?? throw new ArgumentNullException("from is a required property for TaskPathArgument and cannot be null");
            this.Annotations = annotations;
            this.SubPath = subPath;

            // Set non-required readonly properties with defaultValue
            this.Type = "TaskPathArgument";
        }

        /// <summary>
        /// Argument name. The name must match one of the input names from Task&#39;s template which can be a function or DAG.
        /// </summary>
        /// <value>Argument name. The name must match one of the input names from Task&#39;s template which can be a function or DAG.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; } 
        /// <summary>
        /// A reference to a DAG input, a DAG output or another task output. You can also use the ValueReference type to hard-code an input value.
        /// </summary>
        /// <value>A reference to a DAG input, a DAG output or another task output. You can also use the ValueReference type to hard-code an input value.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = false)]
        public AnyOf<InputFileReference,InputFolderReference,InputPathReference,TaskFileReference,TaskFolderReference,TaskPathReference,ValueFileReference,ValueFolderReference> From { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// A sub_path inside the path that is provided in the &#x60;&#x60;from&#x60;&#x60; field. Use sub_path to only access part of the Path that is needed instead of copying all the files and folders inside the path.
        /// </summary>
        /// <value>A sub_path inside the path that is provided in the &#x60;&#x60;from&#x60;&#x60; field. Use sub_path to only access part of the Path that is needed instead of copying all the files and folders inside the path.</value>
        [DataMember(Name = "sub_path", EmitDefaultValue = false)]
        public string SubPath { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "TaskPathArgument";
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
            sb.Append("TaskPathArgument:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  SubPath: ").Append(SubPath).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>TaskPathArgument object</returns>
        public static TaskPathArgument FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<TaskPathArgument>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>TaskPathArgument object</returns>
        public virtual TaskPathArgument DuplicateTaskPathArgument()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateTaskPathArgument();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateTaskPathArgument();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskPathArgument);
        }

        /// <summary>
        /// Returns true if TaskPathArgument instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskPathArgument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskPathArgument input)
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
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && base.Equals(input) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.SubPath == input.SubPath ||
                    (this.SubPath != null &&
                    this.SubPath.Equals(input.SubPath))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SubPath != null)
                    hashCode = hashCode * 59 + this.SubPath.GetHashCode();
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
            Regex regexType = new Regex(@"^TaskPathArgument$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
