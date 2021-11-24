using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        [Display(Name ="Tên nhân viên")]
        public string TenNhanVien { get; set; }
        [Display(Name ="Chức vụ")]
        public string ChucVu { get; set; }
        [Display(Name ="ID Phòng ban")]
        public string PhongBanID { get; set; }
        public PhongBan PhongBan { get; set; }
    }
}