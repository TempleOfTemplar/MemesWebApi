using System.Threading.Tasks;

namespace MemesWebApi.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
