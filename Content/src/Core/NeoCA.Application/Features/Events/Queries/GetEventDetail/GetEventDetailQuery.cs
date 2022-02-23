using NeoCA.Application.Responses;
using MediatR;
using System;

namespace NeoCA.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEventDetailQuery: IRequest<Response<EventDetailVm>>
    {
        public string Id { get; set; }
    }
}
