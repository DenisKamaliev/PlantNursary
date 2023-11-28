using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class GreenHouse : BaseAuditableEntity
    {
        List<Plant> plants { get; set; }
    }
}
