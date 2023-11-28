using Entities.Enums;
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
            ImportService iser = new ImportService(nursaryContextFactory);
            Plant plant = new Plant();
            plant.name = "Test";

            Plant[] plants = new Plant[2];
            plants[0] = plant;
            iser.ImportPlantToSistem(plants);
            

    }
    }
}