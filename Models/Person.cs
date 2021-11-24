using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [Display(Name ="Căn cước công dân")]
        public string CCCD { get; set; }
        [Display(Name ="Họ và tên")]
        public string FullName { get; set; }
    }
}