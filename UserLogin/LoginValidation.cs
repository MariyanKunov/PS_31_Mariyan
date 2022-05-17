using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{

    public class LoginValidation
    {

        public delegate void ActionOnError(string errorMsg);

        private ActionOnError delegateAction;
        private String UserName { get; set; }
        private String Password { get; set; }
        private String Message { get; set; }
        static public UserRoles currentUserRole { get; private set; }
        static public string currentUserUsername { get; private set; }



        public LoginValidation(String name, String pass,ActionOnError action) {
            this.UserName = name;
            this.Password = pass;
            this.delegateAction = action;
        }    

    public bool ValidateUserInput(ref User user) {
            if (this.UserName.Equals(String.Empty))
            {
                Message = "NO USERNAME ENTERED!";
                currentUserRole = UserRoles.ANONYMOUS;
                delegateAction(Message);
                return false;
            }
            else if (this.Password.Equals(String.Empty))
            {
                Message = "NO PASSWORD ENTERED!";
                currentUserRole = UserRoles.ANONYMOUS;
                delegateAction(Message);
                return false;
            }
            else if (this.Password.Length < 5 || this.UserName.Length < 5) {
                Message = "The entered password/username is too short";
                currentUserRole = UserRoles.ANONYMOUS;
                delegateAction(Message);
                return false;
            }

            user = UserData.IsUserPassCorrect(this.UserName, this.Password);
            if (user != null) {
                currentUserRole = (UserRoles)user.Role;
                currentUserUsername = UserName;
                Logger.LogActivity("Successful login !");
                return true;
            }
            Message = "No user found";
            currentUserRole = UserRoles.ANONYMOUS;
            delegateAction(Message);
            return false;
        }

    }
}

