using NeoCA.Application.Responses;
using MediatR;

namespace NeoCA.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommand: IRequest<Response<CreateCategoryDto>>
    {
        public string Name { get; set; }
    }
}
