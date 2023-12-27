using MediatR;
using PlantNursary.ApplicationServices.Exceptions;
using PlantNursary.DataAccess;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices.UseCases.GetPlantByID
{
    public class GetReservationByIdHandler : IRequestHandler<GetReservationByIdRequest, Reservation>
    {
        private readonly NursaryContext _context;
        public GetReservationByIdHandler(NursaryContextFactory nursaryContextFactory)
        {
            _context = nursaryContextFactory.Create();
        }
        public async Task<Reservation> Handle(GetReservationByIdRequest request, CancellationToken token)
        {
            var foundReservation = await _context.Reservations.FindAsync(new object[] { request.reservationId }, token)
                ?? throw new EntityNotFoundException(request.reservationId);

            return foundReservation;
        }
    }
}
