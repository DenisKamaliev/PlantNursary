using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class Field : BaseAuditableEntity
    {
        public List<Sector> sectors { get; set; }
    }
}
