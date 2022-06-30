﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.ViewModels
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required,Compare(nameof(Password))]
        public string PasswordConfirm { get; set; }
    }
}
