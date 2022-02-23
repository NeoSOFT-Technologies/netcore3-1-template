using NeoCA.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace NeoCA.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
