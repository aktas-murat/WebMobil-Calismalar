﻿using System.ComponentModel.DataAnnotations;


namespace Identity101.ViewModels
{
    public class LoginViewModel
    {

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı alanı gerekiyor")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre alanı gerekiyor")]
        [StringLength(100,MinimumLength =6,ErrorMessage="Şifreniz minimum 6 karakter olmalıdır")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }

    }
}



