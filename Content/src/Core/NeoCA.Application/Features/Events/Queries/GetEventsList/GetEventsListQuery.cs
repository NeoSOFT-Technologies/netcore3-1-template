using NeoCA.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace NeoCA.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery: IRequest<Response<IEnumerable<EventListVm>>>
    {

    }
}
