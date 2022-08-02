using System.ComponentModel.DataAnnotations;

namespace BackEndProjectAllup.ViewModels
{
    public class RegisterVM
    {
        [Required,StringLength(100)]
        public string Fullname { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string RepeatPassword { get; set; }
    }
}
