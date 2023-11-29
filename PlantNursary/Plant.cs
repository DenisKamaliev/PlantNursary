using Entities.Enums;
using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class Plant : BaseAuditableEntity
    {
        public PlantType plantType { get; set; }
        public string name { get; set; }
        public string height { get; set; }
        public string diameter { get; set; }
        public WinterHardinessType hardinessType { get; set; }
        public PlaceType placeType { get; set; }
        public GroundType groundType { get; set; }
        public string? peculiarities { get; set; }

    }
}
