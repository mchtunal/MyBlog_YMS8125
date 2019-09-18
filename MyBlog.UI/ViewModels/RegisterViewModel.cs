using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.ViewModels
{
    public class RegisterViewModel
    {
        //Register olabilmek için gerekli olan alanları oluşturduk.Propertylerini(Özelliklerini)
        //Register alanı email,parola ve parola tekrar alanlarından olluşuyor.

        //Validation controllerini sağlıyoruz.Daha verileri sunucuya göndermeden hataları almak için.

        [Required(ErrorMessage ="{0} alanı zorunludur.")]
        [EmailAddress(ErrorMessage ="Geçersiz E-mail Adresi.")]
        [Display(Name ="E-mail")]
        public string Email { get; set; }



        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Parola")]
        [MinLength(6,ErrorMessage ="Parola en az 6 karakterden oluşmalıdır.")]
        public string Password { get; set; }



        [Compare("Password",ErrorMessage ="Parolalar Eşleşmiyor.")]
        [Display(Name = "Parola (Tekrar)")]
        public string ConfirmPassword { get; set; }
    }
}
