
#nullable enable

namespace AwsBedrock
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResponseRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AwsBedrock.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::AwsBedrock.Message>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AwsBedrock.OneOf<string, global::System.Collections.Generic.IList<global::AwsBedrock.Message>> Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::AwsBedrock.Tool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="instructions"></param>
        /// <param name="stream"></param>
        /// <param name="tools"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseRequest(
            string model,
            global::AwsBedrock.OneOf<string, global::System.Collections.Generic.IList<global::AwsBedrock.Message>> input,
            string? instructions,
            bool? stream,
            global::System.Collections.Generic.IList<global::AwsBedrock.Tool>? tools,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Instructions = instructions;
            this.Stream = stream;
            this.Tools = tools;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequest" /> class.
        /// </summary>
        public CreateResponseRequest()
        {
        }
    }
}