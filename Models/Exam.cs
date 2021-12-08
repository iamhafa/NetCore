using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    [Table("Exams")]
    public class Exam
    {
        [Key]
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string SubjectType { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }
        public string PointOfStudent { get; set; }
    }
}