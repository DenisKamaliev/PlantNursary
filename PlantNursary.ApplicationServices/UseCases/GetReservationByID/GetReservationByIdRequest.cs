using MediatR;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices.UseCases.GetPlantByID
{
    public record GetReservationByIdRequest(Guid reservationId) : IRequest<Reservation>;
}
