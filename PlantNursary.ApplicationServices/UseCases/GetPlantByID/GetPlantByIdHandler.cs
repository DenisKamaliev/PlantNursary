using MediatR;
using PlantNursary.DataAccess;
using PlantNursary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNursary.ApplicationServices.UseCases.GetPlantByID
{
    public class GetPlantByIdHandler : IRequestHandler<GetPlantByIdRequest, Plant>
    {
        private readonly NursaryContext _context;
        public GetPlantByIdHandler(NursaryContextFactory nursaryContextFactory)
        {
            _context = nursaryContextFactory.Create();
        }
        public async Task<Plant> Handle(GetPlantByIdRequest request, CancellationToken token)
        {
            var foundPlant = await _context.Plants.FindAsync(new object[] { request.plantId }, token)
                ?? throw new Exception("Entity not found");

            return foundPlant;
        }
    }
}
