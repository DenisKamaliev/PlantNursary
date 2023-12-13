using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlantNursary.ApplicationServices.UseCases.GetPlantByID;
using PlantNursary.Entities;

namespace PlantNursary.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly ISender _sender;

        public ReservationController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet("{reservationId:guid}")]
        public Task<Reservation> Get(Guid reservationId)
        {
            return _sender.Send(new GetReservationByIdRequest(reservationId));
        }

        //[HttpPost()]
        //public void Post(Line[] lines, int[] plantCounts, DateOnly givingDate) 
        //{
        //    NursaryContextFactory ncf = new NursaryContextFactory();
        //    ReservationService rs = new ReservationService(ncf);
        //    rs.NewReservation(lines, plantCounts, givingDate);
        //}

    }
}
