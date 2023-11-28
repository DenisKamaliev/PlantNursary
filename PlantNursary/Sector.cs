using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class Sector : BaseAuditableEntity
    {
        public List<Line> Lines { get; set; }
    }
}
