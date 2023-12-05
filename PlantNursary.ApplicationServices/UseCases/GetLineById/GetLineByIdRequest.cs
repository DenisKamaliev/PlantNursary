using MediatR;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices.UseCases.GetLineById
{
    public record GetLineByIdRequest(Guid lineId) : IRequest<Line>;
}
