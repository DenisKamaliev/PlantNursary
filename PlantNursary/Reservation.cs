using PlantNursary.Entities.Common;

namespace PlantNursary.Entities
{
    public class Reservation : BaseAuditableEntity
    {
        public Dictionary<Line, int> reservationList = new Dictionary<Line, int>();

        public DateOnly givenDate { get; set; }
        public Reservation() { }
        public Reservation(Dictionary<Line, int> reservationList, DateOnly givingDate)
        {
            this.reservationList = reservationList;
            this.givenDate = givingDate;
        }



    }
}
