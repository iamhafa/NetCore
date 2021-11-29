using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NetCore.Models
{
    public class UniversityViewModel
    {
        public List<Student> Students {get; set;}
        public SelectList Universitys {get; set;}
        public string universityName { get; set; }
        public string SearchString { get; set; }
    }
}