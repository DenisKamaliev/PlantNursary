using MediatR;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using PlantNursary.ApplicationServices.UseCases.GetPlantByID;
using PlantNursary.Entities;

namespace PlantNursary.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FindController : ControllerBase
    {
        private readonly ISender _sender;

        public FindController(ISender sender)
        {
            _sender = sender;
        }
        [HttpGet("{plantId:guid}")]
        public Task<Plant> Get(Guid plantId)
        {
            return _sender.Send(new GetPlantByIdRequest(plantId));
        }
    }
}
