using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public string IDProduct { get; set; }

        [Required, Display(Name = "Tên sản phẩm")]
        public string ProductName { get; set; }

        [Required, Display(Name = "Ngày nhập")]
        public DateTime DateAdded { get; set; }

        [Required, Display(Name = "Khối lượng")]
        public string ProductWeight { get; set; }

        [Required, Display(Name = "Kiểu loại")]
        public string ProductType { get; set; }
    }
}