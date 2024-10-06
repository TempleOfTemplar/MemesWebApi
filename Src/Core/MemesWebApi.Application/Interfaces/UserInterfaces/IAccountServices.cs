using MemesWebApi.Application.DTOs.Account.Requests;
using MemesWebApi.Application.DTOs.Account.Responses;
using MemesWebApi.Application.Wrappers;
using System.Threading.Tasks;

namespace MemesWebApi.Application.Interfaces.UserInterfaces
{
    public interface IAccountServices
    {
        Task<BaseResult<string>> RegisterGhostAccount();
        Task<BaseResult> ChangePassword(ChangePasswordRequest model);
        Task<BaseResult> ChangeUserName(ChangeUserNameRequest model);
        Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request);
        Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username);

    }
}
