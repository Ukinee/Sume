using System.Diagnostics.CodeAnalysis;
using Jabba.Ai.Generation.Setup;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;
using OllamaSharp;

namespace Core
{
    public static class Startup
    {
        [Experimental("SKEXP0070")]
        public static IKernelBuilder ConfigureServices
        (
            this IKernelBuilder kernelBuilder,
            OllamaApiClient.Configuration chatConfig,
            OllamaApiClient.Configuration embeddingConfig
        )
        {
            kernelBuilder
                .SetupGeneration(chatConfig, embeddingConfig)
                .Services
                .AddLogging()
                ;

            return kernelBuilder;
        }
    }
}
