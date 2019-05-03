using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Model
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DoctorCode { get; set; }
        public string HospitalName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int GroupID { get; set; }
        public Group Group { get; set; }
    }
}
