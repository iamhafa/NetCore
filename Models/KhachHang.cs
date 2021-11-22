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
        public string TenKhachHang { get; set; }
        public int SoDienThoai { get; set; }
        public ICollection<HoaDon> HoaDons {get; set;}
    }
}