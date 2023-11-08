using Entities.Enums;
using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class Plant : BaseAuditableEntity
    {
        public DateOnly BirthDay { get; set; }
        public PlantType plantType {  get; set; }
        public string name { get; set; }
        public int height { get; set; }
        public int diameter { get; set; }
        public WinterHardinessType hardinessType { get; set; }
        public PlaceType placeType { get; set; }
        public  GroundType groundType { get; set; }
        public string? Peculiarities { get; set; }

    }
}
