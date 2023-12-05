using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlantNursary.ApplicationServices.UseCases.GetLineById;
using PlantNursary.Entities;

namespace PlantNursary.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LineController : ControllerBase
    {
        private readonly ISender _sender;

        public LineController(ISender sender)
        {
            _sender = sender;
        }
        
        [HttpGet("{lineId:guid}")]
        public Task<Line> Get(Guid lineId)
        {
            return _sender.Send(new GetLineByIdRequest(lineId));
        }

    }
}
