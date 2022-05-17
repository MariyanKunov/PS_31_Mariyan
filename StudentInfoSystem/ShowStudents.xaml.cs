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
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for ShowStudents.xaml
    /// </summary>
    public partial class ShowStudents : Window
    {
        public ShowStudents()
        {
            InitializeComponent();
            foreach (User user in UserData.TestUsers) {
                if (user.Role == 4) {
                    students.Items.Add("username : " + user.Username + "     faculty number : " + user.FakNum + "    Created : " + user.Created );
                }
            }
        }
    }
}
