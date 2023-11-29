using PlantNursary.DataAccess;

namespace PlantNursary.ApplicationServices
{
    public class PlantsTransportationService
    {
        private NursaryContext _NursaryContext;
        public PlantsTransportationService(NursaryContextFactory nursaryContextFactory)
        {
            _NursaryContext = nursaryContextFactory.Create();
        }
    }
}
