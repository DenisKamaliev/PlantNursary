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
        public void ImportPlant(Plant plantImport)
        {
            
                if (_NursaryContext.Plants.Any(plant => plant.Id == plantImport.Id))
                    _NursaryContext.Update(plantImport);
                else
                    _NursaryContext.Add(plantImport);
                _NursaryContext.SaveChanges();
            
        }
        public void ImportLine(Line lineImport)
        {
            
            
                if (_NursaryContext.Lines.Any(line => line.Id == lineImport.Id))
                    _NursaryContext.Update(lineImport);
                else
                    _NursaryContext.Add(lineImport);
                _NursaryContext.SaveChanges();
            
        }
        public void ImportSector(Sector sectorImport)
        {
            
            
                if (_NursaryContext.Sectors.Any(sector => sector.Id == sectorImport.Id))
                    _NursaryContext.Update(sectorImport);
                else
                    _NursaryContext.Add(sectorImport);
                _NursaryContext.SaveChanges();
            
        }
        public void ImportField(Field fieldImport)
        {
            
                if (_NursaryContext.Fields.Any(field => field.Id == fieldImport.Id))
                    _NursaryContext.Update(fieldImport);
                else
                    _NursaryContext.Add(fieldImport);
                _NursaryContext.SaveChanges();
            
        }
        public void ImportBreeding(BreedingSector breedingImport)
        {
            
            
                if (_NursaryContext.Breedings.Any(breeding => breeding.Id == breedingImport.Id))
                    _NursaryContext.Update(breedingImport);
                else
                    _NursaryContext.Add(breedingImport);
                _NursaryContext.SaveChanges();
            
        }
        public void ImportQueenCell(QueenCell queenCellImport)
        {
            
                if (_NursaryContext.QueenCells.Any(queenCell => queenCell.Id == queenCellImport.Id))
                    _NursaryContext.Update(queenCellImport);
                else
                    _NursaryContext.Add(queenCellImport);
                _NursaryContext.SaveChanges();
            
        }
        public void ImportReservation(Reservation reservationImport)
        {

            if (_NursaryContext.Reservations.Any(reservation => reservation.Id == reservationImport.Id))
                _NursaryContext.Update(reservationImport);
            else
                _NursaryContext.Add(reservationImport);
            _NursaryContext.SaveChanges();

        }
        public void ImportBed(Bed bedImport)
        {
            
                if (_NursaryContext.Beds.Any(bed => bed.Id == bedImport.Id))
                    _NursaryContext.Update(bedImport);
                else
                    _NursaryContext.Add(bedImport);
                _NursaryContext.SaveChanges();
            
        }
        public void ImportGreenHouse(GreenHouse greenHouseImport)
        {
            
                if (_NursaryContext.GreenHouses.Any(greenHouse => greenHouse.Id == greenHouseImport.Id))
                    _NursaryContext.Update(greenHouseImport);
                else
                    _NursaryContext.Add(greenHouseImport);
                _NursaryContext.SaveChanges();
            
        }
        public void ImportNurse(Nursary nursaryImport)
        {
            
                if (_NursaryContext.Nurses.Any(nursary => nursary.Id == nursaryImport.Id))
                    _NursaryContext.Update(nursaryImport);
                else
                    _NursaryContext.Add(nursaryImport);
                _NursaryContext.SaveChanges();
            
        }


    }
}
