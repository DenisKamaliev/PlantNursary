using PlantNursary.Entities.Enums;
using PlantNursary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNursary.ApplicationServices.UseCases.GetLineById
{
    public class GetLineByIdDto
    {
        public Guid? plantInLineId { get; set; }
        public int countOfPlants { get; set; }
        public DateOnly dateOfPlanting { get; set; }
        public List<EventType> events { get; set; } = new List<EventType>();

        public GetLineByIdDto(Line line) 
        {
            plantInLineId = line.plantInLine?.Id;
            countOfPlants = line.countOfPlants;
            dateOfPlanting = line.dateOfPlanting;
            events = new List<EventType>(events);

        }
    }
}
