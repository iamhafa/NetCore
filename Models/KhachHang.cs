using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public int KhachHangID { get; set; }
        [Display(Name ="Tên Khách hàng")]
        public string TenKhachHang { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name ="Số điện thoại")]
        public int SoDienThoai { get; set; }
        public ICollection<HoaDon> HoaDons {get; set;}
    }
}