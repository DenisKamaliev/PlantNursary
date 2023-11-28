namespace PlantNursary.DataAccess
{
    public class NursaryContextFactory
    {
        public NursaryContext Create()
        {
            return new NursaryContext();
        }
    }
}
