using System;
using System.Collections.Generic;
using System.Text;

namespace University.Models
{
   public class Department
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
