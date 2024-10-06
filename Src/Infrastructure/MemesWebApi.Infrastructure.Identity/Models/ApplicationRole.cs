using Microsoft.AspNetCore.Identity;
using System;

namespace MemesWebApi.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
