using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class Nursary : BaseAuditableEntity
    {
        List<Field> fields { get; set; }
        List<QueenCell> queenCells { get; set; }
        List<BreedingSector> breedingSectors { get; set; }
        List<GreenHouse> greenHouses { get; set; }


    }
}
