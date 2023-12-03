using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class Bed : BaseAuditableEntity

    {

        List<Plant> plants { get; set; } = new List<Plant>();
    }
}
