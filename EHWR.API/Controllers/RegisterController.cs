using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EHWR.API.DTO.Account;
using EHWR.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EHWR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private UserManager<AppIdentityUser> userManager;
        private IPasswordHasher<AppIdentityUser> passwordHasher;
        private IPasswordValidator<AppIdentityUser> passwordValidator;
        private IUserValidator<AppIdentityUser> userValidator;

        public RegisterController(UserManager<AppIdentityUser> usrMgr, IPasswordHasher<AppIdentityUser> passwordHash, IPasswordValidator<AppIdentityUser> passwordVal, IUserValidator<AppIdentityUser> userValid)
        {
            userManager = usrMgr;
            passwordHasher = passwordHash;
            passwordValidator = passwordVal;
            userValidator = userValid;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserDTO user)
        {
            AppIdentityUser appUser = new AppIdentityUser {
                UserName = user.Name,
                Email = user.Email
            };

            IdentityResult result = await userManager.CreateAsync(appUser, user.Password);
            if (result.Succeeded)
                return Ok("User Register Successfully");
            return BadRequest();

        }
    }
}
