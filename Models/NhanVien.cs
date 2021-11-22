using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string TenNhanVien { get; set; }
        public string PhongBanID { get; set; }
        public string ChucVu { get; set; }
        public PhongBan PhongBan { get; set; }
    }
}