namespace AwsBedrock.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AwsBedrockClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("AWS_BEARER_TOKEN_BEDROCK") is { Length: > 0 } bedrockKeyValue
                ? bedrockKeyValue
                : Environment.GetEnvironmentVariable("AWSBEDROCK_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("AWS_BEARER_TOKEN_BEDROCK or AWSBEDROCK_API_KEY environment variable is not found.");

        var client = new AwsBedrockClient(apiKey);
        
        return client;
    }
}
