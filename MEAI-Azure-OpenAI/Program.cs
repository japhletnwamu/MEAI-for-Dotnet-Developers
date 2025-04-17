using System.ClientModel;
using Azure.AI.OpenAI;
using Microsoft.Extensions.AI;

var endpoint = new Uri("YOUR_ENDPOINT"); // e.g. "https://< your hub name >.openai.azure.com/"
var apiKey = new ApiKeyCredential("YOUR_API_KEY");
var deploymentName = "YOUR_DEPLOYMENT_NAME"; // e.g. "gpt-4o-mini"

IChatClient client = new AzureOpenAIClient(
    endpoint,
    apiKey)
.AsChatClient(deploymentName);

var response = await client.GetResponseAsync("Write a short story about a robot who loves to learn");

Console.WriteLine(response);