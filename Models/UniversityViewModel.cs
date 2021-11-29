using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NetCore.Models
{
    public class UniversityViewModel
    {
        // danh sách sinh viên
        public List<Student> Students {get; set;}
        // 1 danh sách cho phép select các trường ĐH
        public SelectList Universitys {get; set;}
        public string universityName { get; set; }
        public string SearchString { get; set; }
    }
}