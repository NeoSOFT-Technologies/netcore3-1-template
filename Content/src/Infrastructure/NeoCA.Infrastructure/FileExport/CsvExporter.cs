using CsvHelper;
using NeoCA.Application.Contracts.Infrastructure;
using NeoCA.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;
using System.IO;

namespace NeoCA.Infrastructure
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter);
                csvWriter.WriteRecords(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}
