using System.Threading.Tasks;
using Blazor.Shared.Models;

namespace Blazor.BlazorUI.Services
{
    public interface IAuthService
    {
        Task<RegisterResult> Register(RegisterModel registerModel);
        Task<LoginResult> Login(LoginModel loginModel);

        Task Logout();
    }
}