
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AwsBedrock
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::AwsBedrock.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::AwsBedrock.Message>>),

            typeof(global::AwsBedrock.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::AwsBedrock.ContentPart>>),

            typeof(global::AwsBedrock.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.ModelListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AwsBedrock.ModelObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.ModelObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.CreateResponseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.OneOf<string, global::System.Collections.Generic.IList<global::AwsBedrock.Message>>), TypeInfoPropertyName = "OneOfStringIListMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AwsBedrock.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AwsBedrock.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.ResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.OneOf<string, global::System.Collections.Generic.IList<global::AwsBedrock.ContentPart>>), TypeInfoPropertyName = "OneOfStringIListContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AwsBedrock.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.ContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AwsBedrock.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AwsBedrock.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AwsBedrock.ModelObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.OneOf<string, global::System.Collections.Generic.List<global::AwsBedrock.Message>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AwsBedrock.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AwsBedrock.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AwsBedrock.OneOf<string, global::System.Collections.Generic.List<global::AwsBedrock.ContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AwsBedrock.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AwsBedrock.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AwsBedrock.Choice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}