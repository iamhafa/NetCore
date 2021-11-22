using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string CCCD { get; set; }
        public string FullName { get; set; }
    }
}