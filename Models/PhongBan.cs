using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("PhongBans")]
    public class PhongBan
    {
        [Key]
        public string PhongBanID { get; set; }
        public string TangLamViec { get; set; }
        public ICollection<NhanVien> NhanViens {get; set;}
    }
}