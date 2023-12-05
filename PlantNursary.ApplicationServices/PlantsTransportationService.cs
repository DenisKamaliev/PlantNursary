using PlantNursary.DataAccess;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices
{
    public class PlantsTransportationService
    {
        private NursaryContext _NursaryContext;
        public PlantsTransportationService(NursaryContextFactory nursaryContextFactory)
        {
            _NursaryContext = nursaryContextFactory.Create();
        }

        public void TransportationFirstToSecond (Line line1,  Line line2)
        {

        }
    }
}
