using System.ComponentModel.DataAnnotations;

namespace NetCore.Models
{
    public class Student : Person
    {
        [Display(Name ="Đại học")]
        public string University { get; set; }
        [Display(Name ="Mã sinh viên")]
        public string MaSinhVien { get; set; }
        [Display(Name ="Địa chỉ")]
        public string Address { get; set; }
    }
}