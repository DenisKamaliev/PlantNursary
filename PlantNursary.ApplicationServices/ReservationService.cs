using PlantNursary.DataAccess;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices
{
    public class ReservationService
    {
        private NursaryContext _NursaryContext;
        private ImportService _ImportService;

        public ReservationService(NursaryContextFactory nursaryContextFactory)
        {
            _NursaryContext = nursaryContextFactory.Create();
            _ImportService = new ImportService(nursaryContextFactory);
        }

        public void NewReservation(Line[] lines, int[] plantCounts, DateOnly givingDate)
        {
            if (lines.Length != plantCounts.Length) { throw new Exception("Bad request"); }
            Dictionary<Line, int> reservationList = new Dictionary<Line, int>();
            for (int i = 0; i < lines.Length; i++)
            {
                reservationList.Add(lines[i], plantCounts[i]);
            }
            Reservation reservation = new Reservation(reservationList, givingDate);
            _ImportService.ImportReservations(reservation);
        }

    }
}
