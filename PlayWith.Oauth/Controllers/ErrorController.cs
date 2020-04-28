using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using PlayWith.Oauth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayWith.Oauth.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet, HttpPost, Route("~/error")]
        public IActionResult Error()
        {
            // If the error was not caused by an invalid
            // OIDC request, display a generic error page.
            var response = HttpContext.GetOpenIdConnectResponse();
            if (response == null)
            {
                return View(new ErrorViewModel());
            }

            return View(new ErrorViewModel
            {
                Error = response.Error,
                ErrorDescription = response.ErrorDescription
            });
        }
    }
}
