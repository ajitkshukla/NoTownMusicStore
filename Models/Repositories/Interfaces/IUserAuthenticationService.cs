using NoTownMusicalStore.Models.DTO;

namespace NoTownMusicalStore.Models.Repositories.Interfaces
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status>RegisterAsync(RegistrationModel model);
    }
}
