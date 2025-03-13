using System.ComponentModel.DataAnnotations;

namespace DevCard.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="اجباری است.")]
        [MinLength(3, ErrorMessage = "حداقل 3 کاراکتر وارد کنید.")]
        [MaxLength(100, ErrorMessage = "حداکثر 100 کاراکتر وارد کنید.")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نیست.")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; } 
    }
}
