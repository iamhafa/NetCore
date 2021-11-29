using System.ComponentModel.DataAnnotations;

namespace NetCore.Models
{
    public class Student : Person
    {
        [StringLength(60, MinimumLength = 6)]
        [Display(Name ="Đại học")]
        [Required]
        public string University { get; set; }

        [Display(Name ="Mã sinh viên")]        
        [StringLength(15, MinimumLength = 10)]
        [Required]
        public string MaSinhVien { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [Display(Name ="Chuyên ngành")]
        public string Major { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Display(Name ="Địa chỉ")]
        public string Address { get; set; }
    }
}