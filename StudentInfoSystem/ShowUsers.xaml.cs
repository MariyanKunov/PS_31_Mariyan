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
    /// Interaction logic for ShowUsers.xaml
    /// </summary>
    public partial class ShowUsers : Window
    {
        public ShowUsers()
        {
            InitializeComponent();
            foreach (User user in UserData.TestUsers) {
                users.Items.Add("username : " + user.Username + "     faculty number : " + user.FakNum + "     Role : " + user.Role);
            }
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
