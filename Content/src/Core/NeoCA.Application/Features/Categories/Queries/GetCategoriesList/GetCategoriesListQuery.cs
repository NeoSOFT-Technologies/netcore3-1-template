using NeoCA.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace NeoCA.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<Response<IEnumerable<CategoryListVm>>>
    {
    }
}
