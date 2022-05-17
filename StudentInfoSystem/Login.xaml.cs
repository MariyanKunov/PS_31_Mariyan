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
    /// Interaction logic for Login.xam
    /// </summary>
    /// 


    public partial class Login : Window
    {

        ShowTextCommand ShowText = new ShowTextCommand();
        LoginCommand LoginCommand = new LoginCommand();
       
        public Login()
        {
            InitializeComponent();
            
            DataContext = new StringOne();
           // this.DataContext = this;
            
        }
    }
}
