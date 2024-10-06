using MemesWebApi.Application.Parameters;

namespace MemesWebApi.Application.DTOs.Account.Requests
{
    public class GetAllUsersRequest : PaginationRequestParameter
    {
        public string Name { get; set; }
    }
}
