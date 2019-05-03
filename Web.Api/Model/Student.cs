using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Model
{
    public class Student
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int NumberOfHourse { get; set; }
        public double GDPA { get; set; }
        public char Gender { get; set; }
        public bool Toofel { get; set; }
        public bool IsSubscribed { get; set; }
        public int GroupID { get; set; }
        public Group Group { get; set; }
    }
}
