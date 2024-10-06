using MemesWebApi.Application.DTOs;
using MemesWebApi.Domain.Products.DTOs;
using MemesWebApi.Domain.Products.Entities;
using System.Threading.Tasks;

namespace MemesWebApi.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
