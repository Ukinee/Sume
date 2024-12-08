using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;

namespace Core
{
    public static class Startup
    {
        public static IKernelBuilder ConfigureServices(this IKernelBuilder kernelBuilder)
        {
            kernelBuilder
                .Services
                .AddLogging()
                ;

            return kernelBuilder;
        }
    }
}
