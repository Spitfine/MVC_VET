using Microsoft.AspNetCore.Identity;
using MVC_VET.Web.Data.Entities;
using System.Threading.Tasks;

namespace MVC_VET.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
