#nullable enable

namespace AwsBedrock
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List available models
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AwsBedrock.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AwsBedrock.ModelListResponse> ListModelsAsync(
            global::AwsBedrock.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List available models
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AwsBedrock.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AwsBedrock.AutoSDKHttpResponse<global::AwsBedrock.ModelListResponse>> ListModelsAsResponseAsync(
            global::AwsBedrock.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}