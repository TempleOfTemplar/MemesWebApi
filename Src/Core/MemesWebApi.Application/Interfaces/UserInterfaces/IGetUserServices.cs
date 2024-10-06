using MemesWebApi.Application.DTOs.Account.Requests;
using MemesWebApi.Application.DTOs.Account.Responses;
using MemesWebApi.Application.Wrappers;
using System.Threading.Tasks;

namespace MemesWebApi.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
