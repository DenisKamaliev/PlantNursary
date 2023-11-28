using PlantNursary.Entities;
using PlantNursary.DataAccess;

namespace PlantNursary.ApplicationServices
{
    public class ImportService


    {

        private NursaryContext _NursaryContext;
        public ImportService(NursaryContextFactory nursaryContextFactory)
        {
            _NursaryContext = nursaryContextFactory.Create();
        }
        public void ImportPlantToSistem(IReadOnlyCollection<Plant> plants) 
        {
            foreach (var plant in plants)
            {
                if (plant != null)
                {
                    _NursaryContext.Add(plant);
                }
                _NursaryContext.SaveChanges();
            }
            
        }
    }
}
