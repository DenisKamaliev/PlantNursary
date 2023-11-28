using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class BreedingSector : BaseAuditableEntity
    {
        
        public List<Bed> beds { get; set; }
    }
}
