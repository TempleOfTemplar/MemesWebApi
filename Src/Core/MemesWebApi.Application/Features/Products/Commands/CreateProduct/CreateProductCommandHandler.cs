using MediatR;
using MemesWebApi.Application.Interfaces;
using MemesWebApi.Application.Interfaces.Repositories;
using MemesWebApi.Application.Wrappers;
using MemesWebApi.Domain.Products.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MemesWebApi.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price, request.BarCode);

            await productRepository.AddAsync(product);
            await unitOfWork.SaveChangesAsync();

            return product.Id;
        }
    }
}
