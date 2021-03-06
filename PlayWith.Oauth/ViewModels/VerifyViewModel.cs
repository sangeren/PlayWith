﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OpenIddict.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlayWith.Oauth.ViewModels
{
    public class VerifyViewModel
    {
        [Display(Name = "Application")]
        public string ApplicationName { get; set; }

        [BindNever, Display(Name = "Error")]
        public string Error { get; set; }

        [BindNever, Display(Name = "Error description")]
        public string ErrorDescription { get; set; }

        [Display(Name = "Scope")]
        public string Scope { get; set; }

        [FromQuery(Name = OpenIddictConstants.Parameters.UserCode)]
        [Display(Name = "User code")]
        public string UserCode { get; set; }
    }
}
