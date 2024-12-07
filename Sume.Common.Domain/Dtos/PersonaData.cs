using Sume.Common.Domain.Models;

namespace Sume.Common.Domain.Dtos
{
    public class PersonaData
    {
        public PersonaData(IPersonaModel persona, IDossierModel dossier)
        {
            Persona = persona;
            Dossier = dossier;
        }

        public IPersonaModel Persona { get; }
        public IDossierModel Dossier { get; }
    }
}
