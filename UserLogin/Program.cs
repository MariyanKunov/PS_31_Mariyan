using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserLogin
{
    class Program
    {
        
        private static void errorFunction(string errorMSG) {
            Console.WriteLine("!!!!!!---" + errorMSG + "---!!!!!!");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter username : ");
            String currentUsername = Console.ReadLine();
            Console.WriteLine("Enter password : ");
            String currentPassword = Console.ReadLine();

            LoginValidation validation = new LoginValidation(currentUsername, currentPassword,errorFunction);

            User user = null;

            if (validation.ValidateUserInput(ref user))
            {
                Console.WriteLine("Username is :  " + user.Username + "  and password is : " + user.Password);
            }
            switch (LoginValidation.currentUserRole)
            {
                case UserRoles.ANONYMOUS:
                    Console.WriteLine("Who are you anonymous ? ");
                    break;

                case UserRoles.ADMIN:
                    Console.WriteLine("The boss is here ! ");
                    AdminMenu();
                    break;
                case UserRoles.INSPECTOR:
                    Console.WriteLine("What are you searching for  inspector ? ");
                    break;
                case UserRoles.PROFESSOR:
                    Console.WriteLine("Educate us professor ! ");
                    break;
                case UserRoles.STUDENT:
                    Console.WriteLine("Sit and learn student ! ");
                    break;
                default:
                    Console.WriteLine("What are u doing here");
                    break;
            }


            Console.ReadLine();
        }

        private static void AdminMenu()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("0: Exit ");
            Console.WriteLine("1: Change user's role  ");
            Console.WriteLine("2: Change user's active date  ");
            Console.WriteLine("3: List of users  ");
            Console.WriteLine("4: Check log activity ");
            Console.WriteLine("5: Check current log activity ");
            int option = Int32.Parse(Console.ReadLine());

            switch (option) {
                case 0 :
                    break;
                case 1:
                    AdminOptionOne();
                    break;
                case 2:
                    AdminOptionTwo();
                    break;
                case 3:
                    break;
                case 4:
                    AdminOptionFour();
                    break;
                case 5:
                    AdminOptionFive();
                    break;
                default :
                    Console.WriteLine("Invalid option!");
                    break;

            }


        }

        private static void AdminOptionFive()
        {
            Console.WriteLine("Enter something to search for in the current activity (to act as filter) :");
            string input = Console.ReadLine();
            
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> currentSessionActivities = Logger.GetCurrentSessionActivities(input);
            foreach (string line in currentSessionActivities)
            {
                sb.Append(line+ Environment.NewLine);
            }
            Console.WriteLine(sb.ToString());

        }

        private static void AdminOptionFour()
        {

            IEnumerable<string> text = Logger.ReadFromLogFile();
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }
        }

        private static  void AdminOptionTwo()
        {
            Console.WriteLine("Enter username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter date : ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            UserData.SetUserActiveTo(username, date);
        }

        private static void AdminOptionOne()
        {
            Console.WriteLine("Enter username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter role : ");
            Console.WriteLine("1 : ANONYMOUS  ");
            Console.WriteLine("2 : ADMIN  ");
            Console.WriteLine("3 : INSPECTOR  ");
            Console.WriteLine("4 : PROFESSOR  ");
            Console.WriteLine("5 : STUDENT  ");

            int role = Int32.Parse(Console.ReadLine());
            UserData.AssignUserRole(username,(UserRoles) role);
       

        }
    }
}
