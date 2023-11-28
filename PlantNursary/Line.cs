
using PlantNursary.Entities.Common;
using PlantNursary.Entities.Enums;

namespace PlantNursary.Entities
{
    public class Line : BaseAuditableEntity
    {
        public List<Plant> plants {  get; set; }
        public List<EventType> events { get; set; }

    }
}
