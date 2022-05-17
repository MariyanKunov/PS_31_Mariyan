using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    static class StudentData
    {

        static public List<Student> TestStudents { 
            get { ResetTestStudents();
                return _testStudent;
            } 
            private set { }
        }

        static private List<Student> _testStudent;

        static private void ResetTestStudents() {
            if (_testStudent == null) {
                _testStudent = new List<Student> {
                    new Student{
                        name = "Trayan",
                        secName = "Nikolaev",
                        surname = "Peykov",
                        faculty = "FCST",
                        speciality = "Maths",
                        degree = "bachelor",
                        facNumber="123445",
                        status = "distance",
                        year =3,
                        potok =9,
                        group =69
                    },
                    new Student{
                        name = "Mariyan",
                        secName = "Plamenov",
                        surname = "Kunov",
                        faculty = "FCST",
                        speciality = "Computer Science",
                        degree = "bachelor",
                        facNumber="123456",
                        status = "regular",
                        year =3,
                        potok =8,
                        group =31
                    },
                    new Student{
                        name = "Ivan",
                        secName = "Peshov",
                        surname = "Goshov",
                        faculty = "FET",
                        speciality = "Maths",
                        degree = "bachelor",
                        facNumber="123457",
                        status = "regular",
                        year =2,
                        potok =7,
                        group =81
                    },
                };

            }
        }
    }
}
