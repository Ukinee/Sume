namespace Sume.Common.Domain.Models
{
    public interface IMessageModel
    {
        public DateTime Timestamp { get; }
        public string Content { get; }
        public bool IsSystem { get; }
        
        public bool IsRead { get; }

        public IMessageModel? RespondedMessage { get; }

        public Task<List<MemoryModel>> GetAssociatedMemories(CancellationToken cancellationToken);
        public Task<IPersonaModel> GetSenderPersona(CancellationToken cancellationToken);

        public void MarkAsRead();
    }
}
