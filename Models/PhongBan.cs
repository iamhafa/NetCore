using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("PhongBans")]
    public class PhongBan
    {
        [Key]
        [Display(Name ="ID Phòng ban")]
        public string PhongBanID { get; set; }
        [Display(Name ="Tầng làm việc")]
        public string TangLamViec { get; set; }
        public ICollection<NhanVien> NhanViens {get; set;}
    }
}