using AutoMapper;
using NeoCA.Application.Features.Events.Commands.CreateEvent;
using NeoCA.Application.Features.Events.Commands.UpdateEvent;
using NeoCA.Application.Features.Events.Queries.GetEventDetail;
using NeoCA.Application.Features.Events.Queries.GetEventsList;
using NeoCA.Application.Responses;
using System;

namespace NeoCA.gRPC.Mapper
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<EventDetailVm, Event.V1.EventModel>().ReverseMap();
            CreateMap<EventListVm, Event.V1.EventModel>().ReverseMap();
            CreateMap<Response<Guid>, Event.V1.EventModelReturn>().ReverseMap();
            CreateMap<CreateEventCommand, Event.V1.CreateEventRequest>().ReverseMap();
            CreateMap<UpdateEventCommand, Event.V1.UpdateEventRequest>().ReverseMap();
        }
    }
}
