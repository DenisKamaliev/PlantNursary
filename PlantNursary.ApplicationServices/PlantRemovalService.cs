using PlantNursary.DataAccess;

namespace PlantNursary.ApplicationServices
{
    public class PlantRemovalService
    {
        private NursaryContext _NursaryContext;
        public PlantRemovalService(NursaryContextFactory nursaryContextFactory)
        {
            _NursaryContext = nursaryContextFactory.Create();
        }
    }
}
