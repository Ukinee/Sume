namespace Sume.Common.Domain.Models
{
    public interface IPersonaModel
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        
        public bool IsMemorable { get; }
        
        public Task<List<MemoryModel>> GetAssociatedMemories(CancellationToken cancellationToken);
        public Task<IDossierModel> GetOrCreateDossier(CancellationToken cancellationToken);
    }
}
