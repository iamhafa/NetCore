using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string HoaDonID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayTao { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}