using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentInfoContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }


        public DbSet<Job> Jobs { get; set; }

        public StudentInfoContext(): base(Properties.Settings.Default.DbConnect)
        { 

        }

        public  Boolean TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> queryStudents = context.Students;
            int countStudents = queryStudents.Count();
            if (countStudents == 0) return true;
            return false;
        }

    }
}
