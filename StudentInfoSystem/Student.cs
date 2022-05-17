using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        public int StudentId { get; set; }

        public string name { get; set; }
        public string secName { get; set; }
        public string surname { get; set; }
        public string faculty { get; set; }
        public string speciality { get; set; }
        public string degree { get; set; }

        public string facNumber { get; set; }

        public string status { get; set; }
        public int year { get; set; }
        public int potok { get; set; }
        public int group { get; set; }

        public Byte[] Photo { get; set; }

    }
}
