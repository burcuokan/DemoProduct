﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        
            [Required(ErrorMessage = "Lütfen isim giriniz")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Lütfen soyisim giriniz")]
            public string Surname { get; set; }

            [Required(ErrorMessage = "Lütfen mail giriniz")]
            public string Mail { get; set; }

            [Required(ErrorMessage = "Lütfen cinsiyet giriniz")]
            public string Gender { get; set; }

            [Required(ErrorMessage = "Lütfen şifre giriniz")]
            public string Password { get; set; }

            [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
            [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olun")]
            public string ConfirmPassword { get; set; }
        
    }
}
