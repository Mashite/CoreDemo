﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Lütfen ad soyad giriniz!")]
        public string NameSurname { get; set; }

        [Display(Name ="Şifre")]
        [Required(ErrorMessage ="Lütfen şifre giriniz!")]
        public string Password { get; set; }

        [Display(Name ="Şifre Tekrarı")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }

        [Display(Name ="Mail Adresi")]
        [Required(ErrorMessage ="Lütfen mail giriniz!")]
        public string Mail { get; set; }

        [Display(Name ="UserName")]
        [Required(ErrorMessage ="Username giriniz!")]
        public string UserName { get; set; }

    }
}
