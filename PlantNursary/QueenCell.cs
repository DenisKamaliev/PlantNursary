using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class QueenCell : BaseAuditableEntity
    {
        List<Plant> plants { get; set; }
    }
}
