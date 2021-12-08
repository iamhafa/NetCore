using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
    }
}