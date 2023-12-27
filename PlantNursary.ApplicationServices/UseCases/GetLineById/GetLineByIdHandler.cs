using MediatR;
using PlantNursary.ApplicationServices.Exceptions;
using PlantNursary.DataAccess;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices.UseCases.GetLineById
{
    public class GetLineByIdHandler : IRequestHandler<GetLineByIdRequest, GetLineByIdDto>
    {
        private readonly NursaryContext _context;
        public GetLineByIdHandler(NursaryContextFactory nursaryContextFactory)
        {
            _context = nursaryContextFactory.Create();
        }
        public async Task<GetLineByIdDto> Handle(GetLineByIdRequest request, CancellationToken token)
        {
            Line foundLine = await _context.Lines.FindAsync(new object[] { request.lineId }, token)
                ?? throw new EntityNotFoundException(request.lineId);

            GetLineByIdDto getLineByIdDto = new GetLineByIdDto(foundLine);
            

            return getLineByIdDto;
        }
    }
}
