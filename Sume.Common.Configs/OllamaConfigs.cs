using System.Diagnostics.CodeAnalysis;
using Microsoft.SemanticKernel.Connectors.Ollama;
using OllamaSharp;

namespace Sume.Common.Configs
{
    public class OllamaConfigs
    {
        private const string GenerationModel = "phi3";
        private const string EmbeddingModel = "phi3";
        
        private const string ConnectionString = "http://127.0.0.1:11434";
        
        public static OllamaApiClient.Configuration GenerationConfig => new OllamaApiClient.Configuration()
        {
            Model = GenerationModel,
            Uri = OllamaUri,
        };
        
        public static OllamaApiClient.Configuration EmbeddingConfig => new OllamaApiClient.Configuration()
        {
            Model = GenerationModel,
            Uri = OllamaUri,
        };
        
        [Experimental("SKEXP0070")]
        public static OllamaPromptExecutionSettings PromptExecutionSettings => new OllamaPromptExecutionSettings
        {
            ModelId = GenerationModel,
            FunctionChoiceBehavior = null,
            Stop = null,
            TopK = null,
            TopP = null,
            Temperature = null,
            ExtensionData = null,
        };
        
        private static Uri OllamaUri => new Uri("http://127.0.0.1:11434");
    }
}
