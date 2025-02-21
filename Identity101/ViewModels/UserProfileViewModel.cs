﻿using System.ComponentModel.DataAnnotations;


namespace Identity101.ViewModels
{
    public class UserProfileViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı gerekiyor")]
        [Display(Name = "Ad")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanı gerekiyor")]
        [Display(Name = "Soyad")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "E-posta adı alanı gerekiyor")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
