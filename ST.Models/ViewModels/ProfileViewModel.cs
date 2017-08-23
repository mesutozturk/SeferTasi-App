using System.ComponentModel.DataAnnotations;

namespace ST.Models.ViewModels
{
    public  class ProfileViewModel
    {
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        public string Surname { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }
        [Display(Name = "Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Şifreniz en az 5 karakter olmalıdır!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Şifreniz en az 5 karakter olmalıdır!")]
        [Display(Name = "Eski Şifre")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
    }
}
