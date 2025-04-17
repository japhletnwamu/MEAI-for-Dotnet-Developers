# Integrating AI into your .NET application with Microsoft.Extensions.AI

Artificial Intelligence (AI) is transforming the way we build applications. With the introduction of `Microsoft.Extensions.AI`, integrating AI services into .NET applications has never been easier. In this blog, we'll explore Microsoft.Extensions.AI, why .NET developers should try it out, and how to get started using it to build a simple text generation application.


##  Why Microsoft.Extensions.AI?
`Microsoft.Extensions.AI` provides unified abstractions and middleware for integrating AI services into .NET applications. This means you can work with AI capabilities like chat features, embedding generation, and tool calling without worrying about specific platform implementations. Whether you're using Azure AI, OpenAI, or other AI services, `Microsoft.Extensions.AI` ensures seamless integration and collaboration across the .NET ecosystem.

With this extension, .NET developers can easily connect their applications to AI services like:

- Azure OpenAI (GPT models)
- OpenAI API
- Any other library that supports MEAI — including all the models in Azure AI Foundry!

Instead of juggling raw HTTP requests and complex authentication for each provider, `Microsoft.Extensions.AI` gives you a unified API surface — so you interact with any AI model through one consistent, maintainable interface.

Let's walk through how to add text generation capabilities to your .NET application step by step, whether you decide to use GitHub Models or Azure AI Foundry.

## 🌱 Getting Started with Microsoft.Extensions.AI using GitHub Models
GitHub Models is a free service that lets you try out and interact with different AI models right within your development environment. It's easy to use with Codespaces, making it a great tool for experimenting with various models and understanding their capabilities before you decide to implement them. GitHub Models are particularly suitable for quick trials and allow easy model switching.


### 🏗️ Step 1: Creating a Personal Access Token for GitHub Models Access

To use GitHub Models, you first need to create a personal access token:

1. Select your GitHub profile picture and click **⚙️ Settings**

2. In the left sidebar, click **<> Developer settings**

    ![GitHub settings page](/MEAI-GitHub-Models/images/github-settings.png)

3. Under **🔑 Personal access tokens**, click **Tokens (classic)**

    ![Developer settings page](/MEAI-GitHub-Models/images/developer-settings.png)

4. Select **Generate new token**, then click **Generate new token (classic)**

    ![Generate new token menu](/MEAI-GitHub-Models/images/generate-new-token-menu.png)

5. Under the "Note" field, give your token a descriptive name (e.g., `Testing-MEAI-In-NET`)

    ![Generate new token page](/MEAI-GitHub-Models/images/generate-new-token-page.png)

6. For expiration, select **Custom** and set it to 7 days (recommended for security)

7. Click **Generate token** and **copy the token to your clipboard**

---

### ✨ Step 2: Creating your Codespace

Here's how to go about it:

1. Go to [https://github.com/japhletnwamu/MEAI-for-Dotnet-Developers](https://github.com/japhletnwamu/MEAI-for-Dotnet-Developers)

2. Fork the repo into your GitHub account by clicking **Fork**

3. Click the **Code** dropdown and open the **Codespaces** tab

4. Click **Create codespace on main**

5. You may be prompted to install required extensions like the **C# Dev Kit**

---

### 🔧 Step 3: Configure GitHub Models in your App

1. Open the folder `MEAI-GitHub-Models` in your Codespace

2. Navigate to the `MEAI-GitHub-Models.csproj` file

3. Replace the placeholder `"GITHUB_TOKEN"` on line 8 with the token you generated earlier

---

### 💬 Step 4: Test Your Application

1. Open the terminal (`Ctrl` + `\` on Windows or `Cmd` + `\` on macOS)

2. Navigate to the project directory:
    ```bash
    cd MEAI-for-Dotnet-Developers/MEAI-GitHub-Models
    ```

3. Or right-click on the folder and select **Open in Integrated Terminal**

    ![GitHub Codespaces environment](/MEAI-GitHub-Models/images/github-codespace-page.png)

4. Run the application:
    ```bash
    dotnet run
    ```

5. Wait a few seconds for the output message

6. You can change the prompt by editing **line 16 of `Program.cs`**

Congratulations! 🎉 You’ve successfully integrated AI capabilities into your .NET application using `Microsoft.Extensions.AI` and `GitHub Models!` 🚀

Next, let's explore how to create your application using [`Azure AI Foundry services`](https://github.com/japhletnwamu/MEAI-for-Dotnet-Developers/blob/main/MEAI-Azure-OpenAI/README.md) 🚀

## 🎒 Additional Resources

We have a lot of other content to help your learning journey. Check out:

- [Generative AI for Beginners](https://aka.ms/buildgenai)

- [Generative AI for Beginners .NET](https://aka.ms/genai.net)

- [AI Agents for Beginners](https://aka.ms/buildaiagents)

- [Mastering GitHub Copilot for C#/.NET Developers](https://aka.ms/github-copilot.net)