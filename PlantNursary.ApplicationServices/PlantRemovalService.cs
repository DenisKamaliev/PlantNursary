using PlantNursary.DataAccess;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices
{
    public class PlantRemovalService
    {
        private NursaryContext _NursaryContext;
        private ImportService _ImportService;

        public PlantRemovalService(NursaryContextFactory nursaryContextFactory)
        {
            _NursaryContext = nursaryContextFactory.Create();
            _ImportService = new ImportService(nursaryContextFactory);
        }

        public void RemovePlantsFromLine(Line line, int count)
        {
            if (line == null || count == 0)
                throw new Exception("Bad request");

            line.countOfPlants = line.countOfPlants - count;
            _ImportService.ImportLine(line);
        }


    }
}
