# 🌱 Getting Started with Microsoft.Extensions.AI Using Azure AI Foundry

`Azure AI Foundry` offers a robust and growing catalog of frontier and open-source models that can be applied over your data from Microsoft, OpenAI, Hugging Face, Meta, Mistral, and other partners. It requires a subscription and provides more extensive capabilities. 

It offers a unified platform for enterprise AI operations, model builders, and application development. Azure AI Foundry combines production-grade infrastructure with user-friendly interfaces, ensuring organizations can build and operate AI applications with confidence.


### ⚙️ Step 1: Setting Up Azure AI Foundry

We would be using Azure AI services for our solution. To use Azure AI Foundry models, you would need to follow the steps in this section:

1. Go to [Azure Portal](https://portal.azure.com)

2. Create an **Azure OpenAI** resource

3. Open the resource and click on **Go to Azure AI Foundry portal**

    ![Creating an Azure OpenAI resource](/MEAI-Azure-OpenAI/images/create-an-azure-openai-resource.png)

4. You would be directed to the Azure AI Foundry portal and should see a page like the one below

    ![The Azure AI Foundry portal](/MEAI-Azure-OpenAI/images/azure-ai-foundry-portal.png)

5. Click on **Deployments** to open a new page that allows you to create a deployment using any of the 27 models available on Azure AI Foundry

    ![The Azure AI models deployment page](/MEAI-Azure-OpenAI/images/azure-ai-model-deployment-page.png)

6. Click on **Deploy model**. For this solution, we would be using `gpt-40-mini`. So go ahead to select that model and click on **Confirm** to continue

7. Give your deployment a name and click on **Deploy**

    ![Creating a model deployment](/MEAI-Azure-OpenAI/images/creating-a-deployment.png)

8. Well-done. For the next step, you would need your **endpoint** and **API key**, so be sure to take note of those.

---

### 🚀 Step 2: Create a .NET Console Application

You can either decide to work with **VS Code** or **Visual Studio**.

If you're using **VS Code**, open the terminal and run the command below to create a .NET console application. Give your application a name, for example `TextGenerationApp`.

```bash
dotnet new console -o TextGenerationApp
```

If you're using **Visual Studio**, go ahead to create a .NET console project with your desired name. I'll name my project `TextGenerationApp`.  
Ensure your terminal is switched to this directory.

As an alternative, you can also decide to clone the repository:

👉 [https://github.com/japhletnwamu/MEAI-for-Dotnet-Developers](https://github.com/japhletnwamu/MEAI-for-Dotnet-Developers)  
Either in **VS Code** or **Visual Studio**.

---

### 🛠️ Step 3: Install the NuGet Package

You can either decide to install `Microsoft.Extensions.AI` using the .NET CLI:

```bash
dotnet add package Microsoft.Extensions.AI
```

Or, if you use a Windows device and prefer to, you can use Package Manager:

```powershell
Install-Package Microsoft.Extensions.AI
```

---

### 🔗 Step 4: Configure AI Services in Your App

Now let's configure the AI service inside `Program.cs`.  
This setup connects your .NET app to Azure OpenAI, allowing you to use GPT models with minimal effort.

> 💡 Don't forget to replace the placeholders with your **endpoint**, **API key**, and **deployment name**.

```csharp
using System.ClientModel;
using Azure.AI.OpenAI;
using Microsoft.Extensions.AI;

var endpoint = new Uri("YOUR_ENDPOINT"); // e.g. "https://<your-hub-name>.openai.azure.com/"
var apiKey = new ApiKeyCredential("YOUR_API_KEY");
var deploymentName = "YOUR_DEPLOYMENT_NAME"; // e.g. "gpt-4o-mini"
```

---

### 🔧 Step 5: Initialize the AzureOpenAIClient

Next, we would need to set up the communication channel between our .NET application and the Azure OpenAI service.

```csharp
IChatClient client = new AzureOpenAIClient(
    endpoint,
    apiKey)
.AsChatClient(deploymentName);
```

---

### 💬 Step 6: Test Your Application

To test your application, run (not "Run and Debug") the following command:

```bash
dotnet run
```

✅ You're now ready to build and run your .NET AI-powered application using `Microsoft.Extensions.AI` and `Azure AI Foundry`!

## 🎒 Additional Resources

We have a lot of other content to help your learning journey. Check out:

- [Generative AI for Beginners](https://aka.ms/buildgenai)

- [Generative AI for Beginners .NET](https://aka.ms/genai.net)

- [AI Agents for Beginners](https://aka.ms/buildaiagents)

- [Mastering GitHub Copilot for C#/.NET Developers](https://aka.ms/github-copilot.net)