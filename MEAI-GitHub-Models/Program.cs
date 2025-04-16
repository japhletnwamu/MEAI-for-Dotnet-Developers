using Azure;
using Azure.AI.Inference;
using Microsoft.Extensions.AI;

string token = Environment.GetEnvironmentVariable("GITHUB_TOKEN") ??
    throw new InvalidOperationException("Make sure to add GITHUB_TOKEN value to the user secrets or environment variables.");

// These variables are needed to access the GitHub Models'
AzureKeyCredential credential = new(token);
Uri modelEndpoint = new("https://models.inference.ai.azure.com");
string modelName = "GPT-4o";

IChatClient chatClient = new ChatCompletionsClient(modelEndpoint, credential)
    .AsChatClient(modelName);

string question = "Write a short story about a robot who loves to learn";
var response = chatClient.GetStreamingResponseAsync(question);

await foreach (var item in response)
{
    Console.Write(item);
}