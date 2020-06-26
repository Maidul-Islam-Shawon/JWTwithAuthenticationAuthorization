﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWTwithAuthenticationAuthorization.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage ="User Name is Required!")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is Required!")]
        public string password { get; set; }
    }
}
