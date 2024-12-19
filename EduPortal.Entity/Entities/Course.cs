using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPortal.Entity.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CouseName { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public CourseCategory Category { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }

    }
}
