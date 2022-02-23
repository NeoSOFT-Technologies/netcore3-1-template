using AutoMapper;
using NeoCA.Application.Features.Categories.Commands.CreateCateogry;
using NeoCA.Application.Features.Categories.Commands.StoredProcedure;
using NeoCA.Application.Features.Categories.Queries.GetCategoriesList;
using NeoCA.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using NeoCA.Application.Features.Events.Commands.CreateEvent;
using NeoCA.Application.Features.Events.Commands.Transaction;
using NeoCA.Application.Features.Events.Commands.UpdateEvent;
using NeoCA.Application.Features.Events.Queries.GetEventDetail;
using NeoCA.Application.Features.Events.Queries.GetEventsExport;
using NeoCA.Application.Features.Events.Queries.GetEventsList;
using NeoCA.Application.Features.Orders.GetOrdersForMonth;
using NeoCA.Domain.Entities;

namespace NeoCA.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {          
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, TransactionCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, StoredProcedureCommand>();
            CreateMap<Category, StoredProcedureDto>();

            CreateMap<Order, OrdersForMonthDto>();

            CreateMap<Event, EventListVm>().ConvertUsing<EventVmCustomMapper>();
        }
    }
}
