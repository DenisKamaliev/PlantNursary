using PlantNursary.DataAccess;
using PlantNursary.Entities;
using PlantNursary.Entities.Enums;

namespace PlantNursary.ApplicationServices
{
    public class EventService
    {
        private NursaryContext _NursaryContext;
        private ImportService _ImportService;
        
        public EventService(NursaryContextFactory nursaryContextFactory)
        {
            _NursaryContext = nursaryContextFactory.Create();
            _ImportService = new ImportService(nursaryContextFactory);
        }

        public void NewIventInLine(Line line, EventType eventType )
        {
            if (line == null) { throw new Exception("Bad request"); }
            line.events.Add(eventType);
            _ImportService.ImportLine(line);
        }
        public void RemoveIventFromLine(Line line, EventType eventType)
        {
            if (line == null) { throw new Exception("Bad request"); }
            line.events.Remove(eventType);
            _ImportService.ImportLine(line);
        }
    }
}
