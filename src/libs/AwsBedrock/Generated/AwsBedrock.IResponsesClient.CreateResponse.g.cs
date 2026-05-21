#nullable enable

namespace AwsBedrock
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Create a response
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AwsBedrock.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AwsBedrock.ResponseObject> CreateResponseAsync(

            global::AwsBedrock.CreateResponseRequest request,
            global::AwsBedrock.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a response
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AwsBedrock.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AwsBedrock.AutoSDKHttpResponse<global::AwsBedrock.ResponseObject>> CreateResponseAsResponseAsync(

            global::AwsBedrock.CreateResponseRequest request,
            global::AwsBedrock.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a response
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="instructions"></param>
        /// <param name="stream"></param>
        /// <param name="tools"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AwsBedrock.ResponseObject> CreateResponseAsync(
            string model,
            global::AwsBedrock.OneOf<string, global::System.Collections.Generic.IList<global::AwsBedrock.Message>> input,
            string? instructions = default,
            bool? stream = default,
            global::System.Collections.Generic.IList<global::AwsBedrock.Tool>? tools = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::AwsBedrock.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}