using PlantNursary.DataAccess;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices
{
    public class ImportService


    {

        private NursaryContext _NursaryContext;
        public ImportService(NursaryContextFactory nursaryContextFactory)
        {
            _NursaryContext = nursaryContextFactory.Create();
        }
        public void ImportPlants(IReadOnlyCollection<Plant> plants)
        {
            foreach (var plant in plants)
            {
                if (_NursaryContext.Plants.Any(plant => plant.Id == plant.Id))
                    _NursaryContext.Update(_NursaryContext);
                else
                    _NursaryContext.Add(plant);
                _NursaryContext.SaveChanges();
            }
        }
        public void ImportLines(IReadOnlyCollection<Line> lines)
        {
            foreach (var line in lines)
            {
                if (_NursaryContext.Lines.Any(line => line.Id == line.Id))
                    _NursaryContext.Update(_NursaryContext);
                else
                    _NursaryContext.Add(line);
                _NursaryContext.SaveChanges();
            }
        }
        public void ImportSectors(IReadOnlyCollection<Sector> sectors)
        {
            foreach (var sector in sectors)
            {
                if (_NursaryContext.Sectors.Any(sector => sector.Id == sector.Id))
                    _NursaryContext.Update(_NursaryContext);
                else
                    _NursaryContext.Add(sector);
                _NursaryContext.SaveChanges();
            }
        }
        public void ImportFields(IReadOnlyCollection<Sector> fields)
        {
            foreach (var field in fields)
            {
                if (_NursaryContext.Fields.Any(field => field.Id == field.Id))
                    _NursaryContext.Update(_NursaryContext);
                else
                    _NursaryContext.Add(field);
                _NursaryContext.SaveChanges();
            }
        }
        public void ImportBreedings(IReadOnlyCollection<Sector> breedings)
        {
            foreach (var breeding in breedings)
            {
                if (_NursaryContext.Breedings.Any(breeding => breeding.Id == breeding.Id))
                    _NursaryContext.Update(_NursaryContext);
                else
                    _NursaryContext.Add(breeding);
                _NursaryContext.SaveChanges();
            }
        }
        public void ImportQueenCells(IReadOnlyCollection<QueenCell> queenCells)
        {
            foreach (var queenCell in queenCells)
            {
                if (_NursaryContext.QueenCells.Any(queenCell => queenCell.Id == queenCell.Id))
                    _NursaryContext.Update(_NursaryContext);
                else
                    _NursaryContext.Add(queenCell);
                _NursaryContext.SaveChanges();
            }
        }
        public void ImportReservations(Reservation reservation)
        {

            if (_NursaryContext.Reservations.Any(reservation => reservation.Id == reservation.Id))
                _NursaryContext.Update(_NursaryContext);
            else
                _NursaryContext.Add(reservation);
            _NursaryContext.SaveChanges();

        }
        public void ImportBeds(IReadOnlyCollection<Bed> beds)
        {
            foreach (var bed in beds)
            {
                if (_NursaryContext.Beds.Any(bed => bed.Id == bed.Id))
                    _NursaryContext.Update(_NursaryContext);
                else
                    _NursaryContext.Add(bed);
                _NursaryContext.SaveChanges();
            }
        }
        public void ImportGreenHouses(IReadOnlyCollection<GreenHouse> greenHouses)
        {
            foreach (var greenHouse in greenHouses)
            {
                if (_NursaryContext.GreenHouses.Any(greenHouse => greenHouse.Id == greenHouse.Id))
                    _NursaryContext.Update(_NursaryContext);
                else
                    _NursaryContext.Add(greenHouse);
                _NursaryContext.SaveChanges();
            }
        }
        public void ImportNurses(IReadOnlyCollection<Nursary> nurses)
        {
            foreach (var nursary in nurses)
            {
                if (_NursaryContext.Nurses.Any(nursary => nursary.Id == nursary.Id))
                    _NursaryContext.Update(_NursaryContext);
                else
                    _NursaryContext.Add(nursary);
                _NursaryContext.SaveChanges();
            }
        }


    }
}
