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
    /// Parametric Job Status.
    /// </summary>
    [DataContract(Name = "JobStatus")]
    public partial class JobStatus : OpenAPIGenBaseModel, IEquatable<JobStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobStatus() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "JobStatus";
            this.ApiVersion = "v1beta1";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="JobStatus" /> class.
        /// </summary>
        /// <param name="id">The ID of the individual job. (required).</param>
        /// <param name="status">The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot; (required).</param>
        /// <param name="startedAt">The time at which the task was started (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="message">Any message produced by the task. Usually error/debugging hints..</param>
        /// <param name="finishedAt">The time at which the task was completed.</param>
        /// <param name="source">Source url for the status object. It can be a recipe or a function..</param>
        /// <param name="runsPending">The count of runs that are pending (default to 0).</param>
        /// <param name="runsRunning">The count of runs that are running (default to 0).</param>
        /// <param name="runsCompleted">The count of runs that have completed (default to 0).</param>
        /// <param name="runsFailed">The count of runs that have failed (default to 0).</param>
        public JobStatus
        (
            string id, string status, DateTime startedAt, // Required parameters
            Dictionary<string, string> annotations= default, string message= default, DateTime finishedAt= default, string source= default, int runsPending = 0, int runsRunning = 0, int runsCompleted = 0, int runsFailed = 0// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for JobStatus and cannot be null");
            // to ensure "status" is required (not null)
            this.Status = status ?? throw new ArgumentNullException("status is a required property for JobStatus and cannot be null");
            this.StartedAt = startedAt;
            this.Annotations = annotations;
            this.Message = message;
            this.FinishedAt = finishedAt;
            this.Source = source;
            this.RunsPending = runsPending;
            this.RunsRunning = runsRunning;
            this.RunsCompleted = runsCompleted;
            this.RunsFailed = runsFailed;

            // Set non-required readonly properties with defaultValue
            this.Type = "JobStatus";
            this.ApiVersion = "v1beta1";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "JobStatus";
        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name = "api_version", EmitDefaultValue = true)]
        public string ApiVersion { get; protected internal set; }  = "v1beta1";

        /// <summary>
        /// The ID of the individual job.
        /// </summary>
        /// <value>The ID of the individual job.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; } 
        /// <summary>
        /// The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot;
        /// </summary>
        /// <value>The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot;</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; } 
        /// <summary>
        /// The time at which the task was started
        /// </summary>
        /// <value>The time at which the task was started</value>
        [DataMember(Name = "started_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime StartedAt { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Any message produced by the task. Usually error/debugging hints.
        /// </summary>
        /// <value>Any message produced by the task. Usually error/debugging hints.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; } 
        /// <summary>
        /// The time at which the task was completed
        /// </summary>
        /// <value>The time at which the task was completed</value>
        [DataMember(Name = "finished_at", EmitDefaultValue = false)]
        public DateTime FinishedAt { get; set; } 
        /// <summary>
        /// Source url for the status object. It can be a recipe or a function.
        /// </summary>
        /// <value>Source url for the status object. It can be a recipe or a function.</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; } 
        /// <summary>
        /// The count of runs that are pending
        /// </summary>
        /// <value>The count of runs that are pending</value>
        [DataMember(Name = "runs_pending", EmitDefaultValue = true)]
        public int RunsPending { get; set; }  = 0;
        /// <summary>
        /// The count of runs that are running
        /// </summary>
        /// <value>The count of runs that are running</value>
        [DataMember(Name = "runs_running", EmitDefaultValue = true)]
        public int RunsRunning { get; set; }  = 0;
        /// <summary>
        /// The count of runs that have completed
        /// </summary>
        /// <value>The count of runs that have completed</value>
        [DataMember(Name = "runs_completed", EmitDefaultValue = true)]
        public int RunsCompleted { get; set; }  = 0;
        /// <summary>
        /// The count of runs that have failed
        /// </summary>
        /// <value>The count of runs that have failed</value>
        [DataMember(Name = "runs_failed", EmitDefaultValue = true)]
        public int RunsFailed { get; set; }  = 0;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "JobStatus";
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
            sb.Append("JobStatus:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  RunsPending: ").Append(RunsPending).Append("\n");
            sb.Append("  RunsRunning: ").Append(RunsRunning).Append("\n");
            sb.Append("  RunsCompleted: ").Append(RunsCompleted).Append("\n");
            sb.Append("  RunsFailed: ").Append(RunsFailed).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>JobStatus object</returns>
        public static JobStatus FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<JobStatus>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>JobStatus object</returns>
        public virtual JobStatus DuplicateJobStatus()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateJobStatus();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateJobStatus();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as JobStatus);
        }

        /// <summary>
        /// Returns true if JobStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of JobStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobStatus input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && base.Equals(input) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && base.Equals(input) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && base.Equals(input) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
                ) && base.Equals(input) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && base.Equals(input) && 
                (
                    this.RunsPending == input.RunsPending ||
                    (this.RunsPending != null &&
                    this.RunsPending.Equals(input.RunsPending))
                ) && base.Equals(input) && 
                (
                    this.RunsRunning == input.RunsRunning ||
                    (this.RunsRunning != null &&
                    this.RunsRunning.Equals(input.RunsRunning))
                ) && base.Equals(input) && 
                (
                    this.RunsCompleted == input.RunsCompleted ||
                    (this.RunsCompleted != null &&
                    this.RunsCompleted.Equals(input.RunsCompleted))
                ) && base.Equals(input) && 
                (
                    this.RunsFailed == input.RunsFailed ||
                    (this.RunsFailed != null &&
                    this.RunsFailed.Equals(input.RunsFailed))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.FinishedAt != null)
                    hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.RunsPending != null)
                    hashCode = hashCode * 59 + this.RunsPending.GetHashCode();
                if (this.RunsRunning != null)
                    hashCode = hashCode * 59 + this.RunsRunning.GetHashCode();
                if (this.RunsCompleted != null)
                    hashCode = hashCode * 59 + this.RunsCompleted.GetHashCode();
                if (this.RunsFailed != null)
                    hashCode = hashCode * 59 + this.RunsFailed.GetHashCode();
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
            Regex regexType = new Regex(@"^JobStatus$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }


            
            // ApiVersion (string) pattern
            Regex regexApiVersion = new Regex(@"^v1beta1$", RegexOptions.CultureInvariant);
            if (false == regexApiVersion.Match(this.ApiVersion).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApiVersion, must match a pattern of " + regexApiVersion, new [] { "ApiVersion" });
            }

            yield break;
        }
    }
}
