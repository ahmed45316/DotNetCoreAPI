using IdentityServer4.Events;
using IdentityServer4.Models;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCore.Common.Parameters;

namespace TestCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IEventService _events;
        //private readonly AccountService _account;
        public LoginController(IIdentityServerInteractionService interaction, IClientStore clientStore,IHttpContextAccessor httpContextAccessor,IEventService events,UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _interaction = interaction;
            _events = events;
            //_account = new AccountService(interaction, httpContextAccessor, clientStore);
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Login(LoginParameters model, string button)
        //{
        //    if (button != "login")
        //    {
        //        var context = await _interaction.GetAuthorizationContextAsync(model.ReturnUrl);
        //        if (context != null)
        //        {
        //            await _interaction.GrantConsentAsync(context, ConsentResponse.Denied);
        //            return Redirect(model.ReturnUrl);
        //        }
        //        else
        //        {
        //            return Redirect("~/");
        //        }
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByNameAsync(model.Username);

        //        if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
        //        {
        //            await _events.RaiseAsync(
        //                new UserLoginSuccessEvent(user.UserName, user.Id, user.UserName));

        //            AuthenticationProperties props = null;
        //            if (AccountOptions.AllowRememberLogin && model.RememberLogin)
        //            {
        //                props = new AuthenticationProperties
        //                {
        //                    IsPersistent = true,
        //                    ExpiresUtc = DateTimeOffset.UtcNow.Add(AccountOptions.RememberMeLoginDuration)
        //                };
        //            };

        //            await HttpContext.SignInAsync(user.Id, user.UserName, props);

        //            if (_interaction.IsValidReturnUrl(model.ReturnUrl)
        //                    || Url.IsLocalUrl(model.ReturnUrl))
        //            {
        //                return Redirect(model.ReturnUrl);
        //            }

        //            return Redirect("~/");
        //        }

        //        await _events.RaiseAsync(new UserLoginFailureEvent(model.Username, "invalid credentials"));
        //        ModelState.AddModelError("", AccountOptions.InvalidCredentialsErrorMessage);
        //    }

        //    var vm = await _account.BuildLoginViewModelAsync(model);
        //    return View(vm);
        //}
    }
}