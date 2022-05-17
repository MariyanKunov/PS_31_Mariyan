using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        public static Student GetStudentDataByUser(User user) {

            if (user.FakNum.Equals(null ) ) {
                Console.WriteLine("Faculty number fault!!!");
                return null;
            }


            Student student = (from tempstudent in StudentData.TestStudents
                               where tempstudent.facNumber.Equals(user.FakNum)
                               select tempstudent).FirstOrDefault();

            return student;

        }

    }
}
