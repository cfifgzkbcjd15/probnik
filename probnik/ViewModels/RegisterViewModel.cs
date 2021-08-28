using Microsoft.AspNetCore.Http;
using probnik.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace probnik.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Год рождения")]
        public DateTime Year { get; set; }
        [Display(Name = "Фотография")]
        public byte[] Photo { get; set; }
        [Required]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Поле {0} должно иметь минимум {2} и максимум {1} символов.", MinimumLength = 5)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }

    }
    public class RegViewModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public IFormFile Photo { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
