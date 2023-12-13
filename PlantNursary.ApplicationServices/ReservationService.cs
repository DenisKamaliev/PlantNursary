using PlantNursary.DataAccess;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices
{
    public class ReservationService
    {
        private NursaryContext _NursaryContext;
        private ImportService _ImportService;
        private PlantRemovalService _PlantRemovalService;

        public ReservationService(NursaryContextFactory nursaryContextFactory)
        {
            _NursaryContext = nursaryContextFactory.Create();
            _ImportService = new ImportService(nursaryContextFactory);
            _PlantRemovalService = new PlantRemovalService(nursaryContextFactory);
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
            _ImportService.ImportReservation(reservation);
        }
        public void AcceptReservation(Reservation reservationAccept)
        {

            if (_NursaryContext.Reservations.Any(reservation => reservation.Id == reservationAccept.Id))
            {
                var List = reservationAccept.reservationList;
                foreach (var item in List)
                {
                    _PlantRemovalService.RemovePlantsFromLine(item.Key, item.Value);
                }
                RemoveReservation(reservationAccept);
            }
            else
            { throw new Exception("Bad request"); }
        }
        public void RemoveReservation(Reservation reservationRemove)
        {
            if (reservationRemove == null) { throw new Exception("Bad request"); }
            if (_NursaryContext.Reservations.Any(reservation => reservation.Id == reservationRemove.Id))
                _NursaryContext.Remove(_NursaryContext);
            else
                throw new Exception("Entity not found");
        }

    }
}
