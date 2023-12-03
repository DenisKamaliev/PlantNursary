using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class Nursary : BaseAuditableEntity
    {
        public List<Field> fields { get; set; } = new List<Field>();
        public List<QueenCell> queenCells { get; set; } = new List<QueenCell>();
        public List<BreedingSector> breedingSectors { get; set; } = new List<BreedingSector>();
        public List<GreenHouse> greenHouses { get; set; } = new List<GreenHouse>();


    }
}
