using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class Reservation : BaseAuditableEntity
    {
        public List<Plant> plants {  get; set; }
        

        // Доделать
    }
}
