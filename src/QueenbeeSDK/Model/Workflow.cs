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
    /// Queenbee Workflow.  A Workflow is a Baked Recipe with some arguments that will be used to execute the recipe.
    /// </summary>
    [DataContract(Name = "Workflow")]
    public partial class Workflow : OpenAPIGenBaseModel, IEquatable<Workflow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Workflow() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Workflow";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow" /> class.
        /// </summary>
        /// <param name="recipe">The baked recipe to be used by the execution engine to generate a workflow (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="labels">Optional user data as a dictionary. User data is for user reference only and will not be used in the execution of the workflow..</param>
        /// <param name="arguments">Input arguments for this workflow.</param>
        /// <param name="status">The status of the workflow.</param>
        public Workflow
        (
             BakedRecipe recipe, // Required parameters
            Dictionary<string, string> annotations= default, Object labels= default, List<AnyOf<WorkflowArgument,WorkflowPathArgument>> arguments= default, WorkflowStatus status= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "recipe" is required (not null)
            this.Recipe = recipe ?? throw new ArgumentNullException("recipe is a required property for Workflow and cannot be null");
            this.Annotations = annotations;
            this.Labels = labels;
            this.Arguments = arguments;
            this.Status = status;

            // Set non-required readonly properties with defaultValue
            this.Type = "Workflow";
        }

        /// <summary>
        /// The baked recipe to be used by the execution engine to generate a workflow
        /// </summary>
        /// <value>The baked recipe to be used by the execution engine to generate a workflow</value>
        [DataMember(Name = "recipe", IsRequired = true, EmitDefaultValue = false)]
        public BakedRecipe Recipe { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Optional user data as a dictionary. User data is for user reference only and will not be used in the execution of the workflow.
        /// </summary>
        /// <value>Optional user data as a dictionary. User data is for user reference only and will not be used in the execution of the workflow.</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public Object Labels { get; set; } 
        /// <summary>
        /// Input arguments for this workflow
        /// </summary>
        /// <value>Input arguments for this workflow</value>
        [DataMember(Name = "arguments", EmitDefaultValue = false)]
        public List<AnyOf<WorkflowArgument,WorkflowPathArgument>> Arguments { get; set; } 
        /// <summary>
        /// The status of the workflow
        /// </summary>
        /// <value>The status of the workflow</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public WorkflowStatus Status { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Workflow";
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
            sb.Append("Workflow:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Recipe: ").Append(Recipe).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Workflow object</returns>
        public static Workflow FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Workflow>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Workflow object</returns>
        public virtual Workflow DuplicateWorkflow()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateWorkflow();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateWorkflow();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Workflow);
        }

        /// <summary>
        /// Returns true if Workflow instances are equal
        /// </summary>
        /// <param name="input">Instance of Workflow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Workflow input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Recipe == input.Recipe ||
                    (this.Recipe != null &&
                    this.Recipe.Equals(input.Recipe))
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
                    this.Labels == input.Labels ||
                    (this.Labels != null &&
                    this.Labels.Equals(input.Labels))
                ) && base.Equals(input) && 
                (
                    this.Arguments == input.Arguments ||
                    this.Arguments != null &&
                    input.Arguments != null &&
                    this.Arguments.SequenceEqual(input.Arguments)
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Recipe != null)
                    hashCode = hashCode * 59 + this.Recipe.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
            Regex regexType = new Regex(@"^Workflow$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}