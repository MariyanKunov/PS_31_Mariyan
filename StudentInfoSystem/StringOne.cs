using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StringOne : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string login;

        private ShowTextCommand showTextCommand = new ShowTextCommand();

        public ShowTextCommand ShowText { get { return showTextCommand; }  }

       
       
        public string Login
        {
            get { return login ; }
            set
            {
                if (login != value)
                {
                    
                    login = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        private LoginCommand _logCommand = new LoginCommand();

        public LoginCommand LogCommand { get { return _logCommand; } }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
       
    }
}
