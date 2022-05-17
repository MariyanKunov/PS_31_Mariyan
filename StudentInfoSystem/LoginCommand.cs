using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UserLogin;

namespace StudentInfoSystem
{
    public class LoginCommand : ICommand
    {
        
       
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {

            return true;
        }

        public void Execute(object parameter)
        {
            StringOne t = (StringOne)parameter;
            
            foreach (User user in UserData.TestUsers)
            {
                if (user.FakNum.Equals(t.Login) && user.Role == 1)
                {
                    AdminMenu admin = new AdminMenu();
                    admin.ShowDialog();
                    return;
                }
                else if (user.FakNum.Equals(t.Login) && user.Role == 4)
                {
                    MainWindow student = new MainWindow(user);
                    student.ShowDialog();
                    return;
                }
            }

            MessageBox.Show("No user found");
        }
    }
}
