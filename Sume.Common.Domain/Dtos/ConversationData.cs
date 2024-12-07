using Sume.Common.Domain.Models;

namespace Sume.Common.Domain.Dtos
{
    public class ConversationData
    {
        public ConversationData(IConversationModel conversation, List<IPersonaModel> personas, List<IMessageModel> messages)
        {
            Conversation = conversation;
            Personas = personas;
            Messages = messages;
        }

        public IConversationModel Conversation { get; }
        public List<IPersonaModel> Personas { get; }
        public List<IMessageModel> Messages { get; }
    }
}
