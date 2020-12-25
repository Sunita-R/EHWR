using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EHWR.API.DTO.Account;
using EHWR.API.Models;
using EHWR.Domain.DTO.Account;
using EHWR.Domain.DTO.Password;
using EHWR.Domain.Response;
using EHWR.Domain.Shared;
using EHWR.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace EHWR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserManager<AppIdentityUser> userManager;
        private SignInManager<AppIdentityUser> signInManager;
        private readonly IAccountLogService _accountLogService;

        public AccountController(UserManager<AppIdentityUser> userMgr, SignInManager<AppIdentityUser> signinMgr, IAccountLogService accountLogService)
        {
            userManager = userMgr;
            signInManager = signinMgr;
            _accountLogService = accountLogService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginDTO login)
        {
         //   SendNotification.SendEmail("himanshusinglawins@gmail.com", "hello", "test email", false);
            AppIdentityUser appUser = await userManager.FindByNameAsync(login.UserName);
            if (appUser != null)
            {
                var accountLogModel = new AccountLogModel();
                Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appUser, login.Password, false, true);
                if (result.Succeeded)
                {
                    accountLogModel.Success = true;
                    accountLogModel.LoginDateTime = DateTime.Now;
                    accountLogModel.UserId = appUser.Id;

                }
                else
                {
                    accountLogModel.Success = false;
                }
                await _accountLogService.UserLog(accountLogModel);
                return Ok();     
            }
            return BadRequest();
        }

        [HttpPut]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(UpdatePasswordDTO model)
        {
            // var user = await userManager.(model.UserName);
            AppIdentityUser user = userManager.Users.First(x => x.NormalizedEmail == model.NormalizedEmail);

            // Generate the reset token (this would generally be sent out as a query parameter as part of a 'reset' link in an email)
            string resetToken = await userManager.GeneratePasswordResetTokenAsync(user);

            // Use the reset token to verify the provenance of the reset request and reset the password.
            IdentityResult updateResult = await userManager.ResetPasswordAsync(user, resetToken, model.Passwordhash);
            SendNotification.SendEmail(model.NormalizedEmail, "Dear" + "&nbsp;&nbsp; " + "<b>" + model.NormalizedUserName + "</b>" + "<br/><br/>" + "Your Password has been changed successfully" + "<br/><br/>" +"<b>Thank You</b>"+"<br/>"+"<b>EHWR Team</b>"+"<br/><br/>" + "<img src = 'http://ditstekdemo.com/ehwr/images/logo-wide.png' alt = 'Logo' style='width: 30%; height: 15%;'>", "EHWR Password Changed ", true);

            return Ok(updateResult);
        }

        [HttpPost("Logout")]
        public async Task<IActionResult> Logout(LogOutDTO logOutDTO)
        {
            // AppIdentityUser appUser = await userManager.FindByNameAsync(logOutDTO.UserName);
            AppIdentityUser appUser = await userManager.FindByNameAsync(logOutDTO.UserName);
            await signInManager.SignOutAsync();
            var accountLogOutModel = new AccountLogOutModel();

            accountLogOutModel.Success = true;
            accountLogOutModel.LogOutDateTime = DateTime.Now;
            accountLogOutModel.UserId = appUser.Id;

            await _accountLogService.UserLogOut(accountLogOutModel);
            return Ok();
          //  return RedirectToAction("Index", "Home");

        }
    }
}
