using Microsoft.AspNetCore.Mvc;
using NoTownMusicalStore.Models.DTO;
using NoTownMusicalStore.Models.Repositories.Interfaces;

namespace NoTownMusicalStore.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private IUserAuthenticationService authService;

        public UserAuthenticationController(IUserAuthenticationService authService)
        {
            this.authService = authService;
        }

        // We will create a user with admin rights, after that we are going to comment this method because we need only one user in this application
        // If we need other users, we can implement this registration method with View
        public async Task<IActionResult> Register()
        {
            var model = new RegistrationModel
            {
                
                Email = "admin@gmail.com",
                Username = "admin",
                Name = "Ajit",
                Password = "Admin@123",
                PasswordConfirm = "Admin@123",
                Role = "Admin"
            };
            
            // if we want to register with user, Change Role to User
            var result = await authService.RegisterAsync(model);
            return Ok(result);
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await authService.LoginAsync(model);
                if(result.StatusCode == 1)
                    return RedirectToAction("Index","Home");
                else
                {
                    TempData["msg"] = "Login failed";
                    return RedirectToAction(nameof(Login));
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await authService.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }

       
    }
}
