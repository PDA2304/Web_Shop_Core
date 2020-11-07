using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_Shop_core.Data.Models
{
    public class RegisteViewModel
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "Пароль слишком длинный, максимальное значение 12 символов")]
        [MinLength(6,ErrorMessage = "Пароль слишком короткий, минимальное значение 6 символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }

    }
}
