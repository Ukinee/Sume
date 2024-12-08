using Microsoft.Extensions.VectorData;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Memory;

namespace Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // IVectorStore vectorStore = null;

            IKernelBuilder builder = Kernel.CreateBuilder();

            builder.ConfigureServices();
        }
    }
}
