using MediatR;
using MemesWebApi.Application.Interfaces.Repositories;
using MemesWebApi.Application.Wrappers;
using MemesWebApi.Domain.Products.DTOs;
using System.Threading;
using System.Threading.Tasks;

namespace MemesWebApi.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetPagedListProductQuery, PagedResponse<ProductDto>>
    {
        public async Task<PagedResponse<ProductDto>> Handle(GetPagedListProductQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}
