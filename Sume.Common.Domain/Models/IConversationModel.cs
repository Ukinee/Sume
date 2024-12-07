namespace Sume.Common.Domain.Models
{
    public interface IConversationModel
    {
        public Guid Id { get; }
        
        public string Name { get; }
        public string Description { get; }
        public string Context { get; }
        
        public Task<List<IPersonaModel>> GetPersonas(CancellationToken cancellationToken);
        public Task<List<IMessageModel>> GetLastMessagesContext(int maxAmount, CancellationToken cancellationToken);
    }
}
