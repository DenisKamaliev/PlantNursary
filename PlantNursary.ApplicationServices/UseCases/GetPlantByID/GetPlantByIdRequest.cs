using MediatR;
using PlantNursary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNursary.ApplicationServices.UseCases.GetPlantByID
{
    public record GetPlantByIdRequest(Guid plantId) : IRequest<Plant>;
}
