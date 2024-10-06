using MediatR;
using MemesWebApi.Application.Wrappers;
using MemesWebApi.Domain.Products.DTOs;

namespace MemesWebApi.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
