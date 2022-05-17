using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Boolean TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> queryStudents = context.Students;
            int countStudents = queryStudents.Count();


            if (countStudents == 0) return true;
            return false;
        }

        public void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();
            foreach (Student st in StudentData.TestStudents)
            {
                context.Students.Add(st);
            }
            context.SaveChanges();

            
        }

        public void CopyUser()
        {
            StudentInfoContext context = new StudentInfoContext();
            foreach(User u in UserData.TestUsers)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }

        public List<string> Specialities { get; set; }

        public MainWindow(User user) {

            MainWindowVM windowVM = new MainWindowVM(user);

            InitializeComponent();
            _student = StudentValidation.GetStudentDataByUser(user);
            this.DataContext = new MainWindowVM(user);
            
        }

        private Student _student;

        private void clearBut_Click(object sender, RoutedEventArgs e)
        {
            clearTextBox();
        }

        private void disableBut_Click(object sender, RoutedEventArgs e)
        {
            disableControls();
        }

        private void clearTextBox() {
           
            foreach (var item in Grid1.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
            foreach (var item in Grid2.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        private void disableControls() {
            foreach(var item in Grid1.Children)
            {
                if(item is TextBox) 
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
            foreach (var item in Grid2.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
        }

        private void enableControls()
        {
            foreach (var item in Grid1.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
            foreach (var item in Grid2.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
        }

        private void enableButton_Click(object sender, RoutedEventArgs e)
        {
            enableControls();
        }

        private void TestStudentsIfEmpty(object sender, RoutedEventArgs e)
        {
            if (TestStudentsIfEmpty())
                CopyTestStudents();
            CopyUser();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            string studentName = this._student.name + " " + this._student.surname;
            JobApply job = new JobApply(studentName,this._student.facNumber);
            job.ShowDialog();
        }
    }
}
