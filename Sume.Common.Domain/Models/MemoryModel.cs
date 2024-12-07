namespace Sume.Common.Domain.Models
{
    public class MemoryModel
    {
        public required string Content { get; init; }
        public required string ContextDescription { get; init; }
        
        public required ReadOnlyMemory<float> Embedding { get; init; }
        
        public required string[] Tags { get; init; }
    }
}
