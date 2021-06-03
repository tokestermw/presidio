/*
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Presidio.Client.OpenAPIDateConverter;

namespace Presidio.Model
{
    /// <summary>
    /// AnalyzeRequest
    /// </summary>
    [DataContract(Name = "AnalyzeRequest")]
    public partial class AnalyzeRequest : IEquatable<AnalyzeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyzeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeRequest" /> class.
        /// </summary>
        /// <param name="text">The text to analyze (required).</param>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (required).</param>
        /// <param name="correlationId">A correlation id to append to headers and traces.</param>
        /// <param name="scoreThreshold">The minimal detection score threshold.</param>
        /// <param name="entities">A list of entities to analyze.</param>
        /// <param name="returnDecisionProcess">Whether to include analysis explanation in the response.</param>
        /// <param name="adHocRecognizers">list of recognizers to be used in the context of this request only (ad-hoc)..</param>
        public AnalyzeRequest(string text = default(string), string language = default(string), string correlationId = default(string), double scoreThreshold = default(double), List<string> entities = default(List<string>), bool returnDecisionProcess = default(bool), List<PatternRecognizer> adHocRecognizers = default(List<PatternRecognizer>))
        {
            // to ensure "text" is required (not null)
            this.Text = text ?? throw new ArgumentNullException("text is a required property for AnalyzeRequest and cannot be null");
            // to ensure "language" is required (not null)
            this.Language = language ?? throw new ArgumentNullException("language is a required property for AnalyzeRequest and cannot be null");
            this.CorrelationId = correlationId;
            this.ScoreThreshold = scoreThreshold;
            this.Entities = entities;
            this.ReturnDecisionProcess = returnDecisionProcess;
            this.AdHocRecognizers = adHocRecognizers;
        }

        /// <summary>
        /// The text to analyze
        /// </summary>
        /// <value>The text to analyze</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Two characters for the desired language in ISO_639-1 format
        /// </summary>
        /// <value>Two characters for the desired language in ISO_639-1 format</value>
        [DataMember(Name = "language", IsRequired = true, EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// A correlation id to append to headers and traces
        /// </summary>
        /// <value>A correlation id to append to headers and traces</value>
        [DataMember(Name = "correlation_id", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// The minimal detection score threshold
        /// </summary>
        /// <value>The minimal detection score threshold</value>
        [DataMember(Name = "score_threshold", EmitDefaultValue = false)]
        public double ScoreThreshold { get; set; }

        /// <summary>
        /// A list of entities to analyze
        /// </summary>
        /// <value>A list of entities to analyze</value>
        [DataMember(Name = "entities", EmitDefaultValue = false)]
        public List<string> Entities { get; set; }

        /// <summary>
        /// Whether to include analysis explanation in the response
        /// </summary>
        /// <value>Whether to include analysis explanation in the response</value>
        [DataMember(Name = "return_decision_process", EmitDefaultValue = true)]
        public bool ReturnDecisionProcess { get; set; }

        /// <summary>
        /// list of recognizers to be used in the context of this request only (ad-hoc).
        /// </summary>
        /// <value>list of recognizers to be used in the context of this request only (ad-hoc).</value>
        [DataMember(Name = "ad_hoc_recognizers", EmitDefaultValue = false)]
        public List<PatternRecognizer> AdHocRecognizers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyzeRequest {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  ScoreThreshold: ").Append(ScoreThreshold).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  ReturnDecisionProcess: ").Append(ReturnDecisionProcess).Append("\n");
            sb.Append("  AdHocRecognizers: ").Append(AdHocRecognizers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnalyzeRequest);
        }

        /// <summary>
        /// Returns true if AnalyzeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyzeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyzeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.ScoreThreshold == input.ScoreThreshold ||
                    this.ScoreThreshold.Equals(input.ScoreThreshold)
                ) && 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    input.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
                ) && 
                (
                    this.ReturnDecisionProcess == input.ReturnDecisionProcess ||
                    this.ReturnDecisionProcess.Equals(input.ReturnDecisionProcess)
                ) && 
                (
                    this.AdHocRecognizers == input.AdHocRecognizers ||
                    this.AdHocRecognizers != null &&
                    input.AdHocRecognizers != null &&
                    this.AdHocRecognizers.SequenceEqual(input.AdHocRecognizers)
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.CorrelationId != null)
                    hashCode = hashCode * 59 + this.CorrelationId.GetHashCode();
                hashCode = hashCode * 59 + this.ScoreThreshold.GetHashCode();
                if (this.Entities != null)
                    hashCode = hashCode * 59 + this.Entities.GetHashCode();
                hashCode = hashCode * 59 + this.ReturnDecisionProcess.GetHashCode();
                if (this.AdHocRecognizers != null)
                    hashCode = hashCode * 59 + this.AdHocRecognizers.GetHashCode();
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