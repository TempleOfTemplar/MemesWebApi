using MediatR;
using MemesWebApi.Application.Wrappers;

namespace MemesWebApi.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<BaseResult>
    {
        public long Id { get; set; }
    }
}
