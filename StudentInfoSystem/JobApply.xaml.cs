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
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for ScolarshipApply.xaml
    /// </summary>
    public partial class JobApply : Window
    {
        private String StudentName { get; set; }
        private String FacultyNumber { get; set; }

        public JobApply()
        {
            InitializeComponent();

        }

        public JobApply(String studentName, String facNumber) {
            InitializeComponent();
            this.StudentName = studentName;
            this.FacultyNumber = facNumber;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)GradeRadio.IsChecked)
            {
                applyWithGrades();
            }
            else if((bool)CVRadio.IsChecked) {
                applyWithCV();
            }
            else {
                MessageBox.Show("You need to choose type");
            }
        }

        private void applyWithGrades() {
            StudentInfoContext context = new StudentInfoContext();
            double grade;

            if (double.TryParse(GradeBox.Text, out grade) && grade <= 6 && grade >= 2)
            {
                if (!checkIfStudentPresentInJobs(context, JobType.WithGrades))
                {
                    if (grade>=5)
                    {
                        context.Jobs.Add(new Job(StudentName, FacultyNumber, JobType.WithGrades, new Decimal(grade)));
                        context.SaveChanges();
                        MessageBox.Show("Registered Successfully");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("It will be better for you to apply with CV. ( low chance with this grade)");
                    }
                }
                else
                {
                    MessageBox.Show("Student with faculty number " + FacultyNumber + " has already been registered for this job");
                }
            }
            else {
                MessageBox.Show("Enter valid grade");
            }
        }

        private void applyWithCV() {
            StudentInfoContext context = new StudentInfoContext();
            double grade;

            if (double.TryParse(GradeBox.Text, out grade) && grade <= 6 && grade >= 2)
            {
                if (!checkIfStudentPresentInJobs(context, JobType.WithCV))
                {
                      context.Jobs.Add(new Job(StudentName, FacultyNumber,JobType.WithCV, new Decimal(grade)));
                      context.SaveChanges();
                      MessageBox.Show("Registered Successfully");
                      Close();
                }
                else
                {
                    MessageBox.Show("Student with faculty number " + FacultyNumber + " has already been registered for this job");
                }
            }
            else {
                MessageBox.Show("Enter valid grade");
            }
        }

        private Boolean checkIfStudentPresentInJobs(StudentInfoContext context,JobType type) {
            Job job = (from sc in context.Jobs
                                     where sc.JobType == type && sc.StudentFacNumber.Equals(FacultyNumber)
                                     select sc).FirstOrDefault();

            return job != null;
        }
    }
}
