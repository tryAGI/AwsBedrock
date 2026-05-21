#nullable enable

namespace AwsBedrock
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create a chat completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AwsBedrock.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AwsBedrock.ChatCompletionResponse> CreateChatCompletionAsync(

            global::AwsBedrock.ChatCompletionRequest request,
            global::AwsBedrock.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AwsBedrock.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AwsBedrock.AutoSDKHttpResponse<global::AwsBedrock.ChatCompletionResponse>> CreateChatCompletionAsResponseAsync(

            global::AwsBedrock.ChatCompletionRequest request,
            global::AwsBedrock.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="stream"></param>
        /// <param name="maxTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="responseFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AwsBedrock.ChatCompletionResponse> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::AwsBedrock.Message> messages,
            bool? stream = default,
            int? maxTokens = default,
            int? maxCompletionTokens = default,
            float? temperature = default,
            float? topP = default,
            global::System.Collections.Generic.IList<global::AwsBedrock.Tool>? tools = default,
            string? toolChoice = default,
            global::AwsBedrock.ResponseFormat? responseFormat = default,
            global::AwsBedrock.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}