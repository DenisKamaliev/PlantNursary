using MediatR;
using PlantNursary.DataAccess;
using PlantNursary.Entities;

namespace PlantNursary.ApplicationServices.UseCases.GetLineById
{
    public class GetLineByIdHandler : IRequestHandler<GetLineByIdRequest, Line>
    {
        private readonly NursaryContext _context;
        public GetLineByIdHandler(NursaryContextFactory nursaryContextFactory)
        {
            _context = nursaryContextFactory.Create();
        }
        public async Task<Line> Handle(GetLineByIdRequest request, CancellationToken token)
        {
            var foundLine = await _context.Lines.FindAsync(new object[] { request.lineId }, token)
                ?? throw new Exception("Entity not found");

            return foundLine;
        }
    }
}
