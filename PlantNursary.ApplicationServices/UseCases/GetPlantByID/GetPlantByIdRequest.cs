﻿using MediatR;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices.UseCases.GetPlantByID
{
    public record GetPlantByIdRequest(Guid plantId) : IRequest<Plant>;
}
