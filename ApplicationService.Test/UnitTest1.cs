using PlantNursary.ApplicationServices;
using PlantNursary.DataAccess;
using PlantNursary.Entities;

namespace ApplicationService.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            NursaryContextFactory nursaryContextFactory = new NursaryContextFactory();
            PlantRemovalService plantRemovalService = new PlantRemovalService(nursaryContextFactory);
            ImportService importService = new ImportService(nursaryContextFactory);
            Nursary nursary = new Nursary();
            Field field1 = new Field();
            Field field2 = new Field();
            Sector sector1 = new Sector();
            Sector sector2 = new Sector();
            Sector sector3 = new Sector();
            Sector sector4 = new Sector();
            Line line1 = new Line();
            Line line2 = new Line();
            Line line3 = new Line();
            Line line4 = new Line();
            Line line5 = new Line();
            Line line6 = new Line();
            Line line7 = new Line();
            Line line8 = new Line();
            Plant plant1 = new Plant();
            plant1.name = "Test1";
            Plant plant2 = new Plant();
            plant2.name = "Test2";
            Plant plant3 = new Plant();
            plant3.name = "Test3";
            Plant plant4 = new Plant();
            plant4.name = "Test4";
            Plant plant5 = new Plant();
            plant5.name = "Test5";
            Plant plant6 = new Plant();
            plant6.name = "Test6";
            Plant plant7 = new Plant();
            plant7.name = "Test7";

            line1.plantInLine = plant1;
            line1.countOfPlants = 10;
            line2.plantInLine = plant2;
            line2.countOfPlants = 10;
            line3.plantInLine = plant3;
            line3.countOfPlants = 10;
            line4.plantInLine = plant4;
            line4.countOfPlants = 10;
            line5.plantInLine = plant5;
            line5.countOfPlants = 10;
            line6.plantInLine = plant6;
            line6.countOfPlants = 10;
            line7.plantInLine = plant7;
            line7.countOfPlants = 10;
            line8.plantInLine = plant7;
            line8.countOfPlants = 10;

            sector1.Lines.Add(line1);
            sector1.Lines.Add(line2);

            sector2.Lines.Add(line3);
            sector2.Lines.Add(line4);

            sector3.Lines.Add(line5);
            sector3.Lines.Add(line6);

            sector4.Lines.Add(line7);
            sector4.Lines.Add(line8);

            field1.sectors.Add(sector1);
            field1.sectors.Add(sector2);

            field2.sectors.Add(sector3);
            field2.sectors.Add(sector4);

            nursary.fields.Add(field1);
            nursary.fields.Add(field2);

            importService.ImportNurse(nursary);
            plantRemovalService.RemovePlantsFromLine(line7, 5);
        }
        
    }
}