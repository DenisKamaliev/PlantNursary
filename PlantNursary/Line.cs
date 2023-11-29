
using PlantNursary.Entities.Common;
using PlantNursary.Entities.Enums;

namespace PlantNursary.Entities
{
    public class Line : BaseAuditableEntity
    {
        public Plant plantInLine { get; set; }
        public int countOfPlants { get; set; }
        public DateOnly dateOfPlanting { get; set; }
        public List<EventType> events { get; set; }

    }
}
