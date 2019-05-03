using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Model
{
    class Group
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public int Capacity { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
