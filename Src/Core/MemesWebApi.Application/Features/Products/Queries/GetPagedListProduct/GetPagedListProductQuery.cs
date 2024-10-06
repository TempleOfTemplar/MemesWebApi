using MediatR;
using MemesWebApi.Application.Parameters;
using MemesWebApi.Application.Wrappers;
using MemesWebApi.Domain.Products.DTOs;

namespace MemesWebApi.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
