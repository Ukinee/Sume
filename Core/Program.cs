using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.VectorData;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Memory;
using Sume.Common.Configs;

namespace Core
{
    public class Program
    {
        [Experimental("SKEXP0070")]
        public static void Main(string[] args)
        {
            // IVectorStore vectorStore = null;

            IKernelBuilder builder = Kernel.CreateBuilder();

            builder.ConfigureServices(OllamaConfigs.GenerationConfig, OllamaConfigs.EmbeddingConfig);
        }
    }
}
