using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
   static public class UserData
    {   
        static public List<User> TestUsers
        {
            get {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }

        static private List<User> _testUsers;


        private static void ResetTestUserData() {
            
            if (_testUsers == null)
            {
                _testUsers = new List<User>
                {
                    new User
                    {
                        Username = "testAdmin",
                        Password = "password",
                        FakNum = "123446",
                        Role = 1,
                        Created = DateTime.Now,
                        ActiveTill = DateTime.MaxValue
                    },
                    new User
                    {
                        Username = "testStudent1",
                        Password = "password1",
                        FakNum = "123445",
                        Role = 4,
                        Created = DateTime.Now,
                        ActiveTill = DateTime.MaxValue
                    },
                    new User
                    {

                        Username = "testStudent2",
                        Password = "password2",
                        FakNum = "123456",
                        Role = 4,
                        Created = DateTime.Now,
                        ActiveTill = DateTime.MaxValue
                    },
                    new User
                    {

                        Username = "testStudent3",
                        Password = "password3",
                        FakNum = "123457",
                        Role = 4,
                        Created = DateTime.Now,
                        ActiveTill = DateTime.MaxValue
                    }
                };
            }
           
        }
        public static User IsUserPassCorrect(String username, String password) {

            /*   foreach(User user in UserData.TestUsers) {
                   if (username.Equals(user.Username) && password.Equals(user.Password))
                   {
                       return user;
                   }
               }
            */

            User user = (from tempuser in UserData.TestUsers
                         where tempuser.Username.Equals(username) && tempuser.Password.Equals(password)
                         select tempuser).FirstOrDefault();
           
            return user;
           
        }

        public static void SetUserActiveTo(string username, DateTime date) {
            if (FindUserByUsername(username) != null)
            {
                FindUserByUsername(username).ActiveTill = date;
                Logger.LogActivity("Changed activity date for : " + username);
            }

        }
        
        public static void AssignUserRole(string username, UserRoles role) {
            if (FindUserByUsername(username) != null) {
                UserContext context =new UserContext();

                User usr =
                (from u in UserData.TestUsers
                 where u.Username == username
                 select u).First();
                usr.Role = (int)role;
                context.SaveChanges();
                Logger.LogActivity("Changed role for : " + username);
            }
        }

        private static User FindUserByUsername(string username) {
       
            foreach (User user in UserData.TestUsers) {
                if (user.Username.Equals(username)) {
                    return user;
                }
            }
            return null;
        }

    }
}
