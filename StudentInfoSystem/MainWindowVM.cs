using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;
using System.Data;
using System.Data.SqlClient;


namespace StudentInfoSystem
{
    public class MainWindowVM
    {

        public List<string> StudStatusChoices { get; set; }

        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery = @"SELECT StatusDescr FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)

                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }

        public Student Student
        {
            get { return _student; }

            set
            {
                if (value != null)
                {
                    _student = value;
                    //   enableControls();
                    //    showStudent(_student);
                }
               else
                {
                  //  clearTextBox();
                  //  disableControls();
                }
            }
        }

        private Student _student;

        
        private ShowTextCommand showTextCommand = new ShowTextCommand();

        public ShowTextCommand ShowText { get { return showTextCommand; } }


        public List<string> Specialities { get; set; }
    
        public MainWindowVM(User user)
        {
            Specialities = new List<string> { "Finances", "Computer Sciences", "Maths", "Archeology", "Politics", "Medicine" };

            Student = StudentValidation.GetStudentDataByUser(user);

            Speciality = Student.speciality;
            Status = Student.status;

            FillStudStatusChoices();
        }

        public MainWindowVM() { }

        public String Speciality { get; set; }
        public String Status { get; set; }

        public Boolean TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> queryStudents = context.Students;
            int countStudents = queryStudents.Count();
            if (countStudents == 0) return true;
            return false;
        }
    }


}
