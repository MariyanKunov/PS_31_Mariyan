using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    enum JobType
    {
        WithGrades,
        WithCV,
    }

    class Job
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [Column("student_name")]
        [Required]
        public String StudentName { get; set; }

        [Column("student_faculty_number")]
        [Required]
        public String StudentFacNumber { get; set; }

        [Column("job_type")]
        [Required]
        public JobType JobType { get; set; }

        [Column("student_grade")]
        [Required]
        public Decimal StudentGrade { get; set; }

        public Job(string studentName, string studentFacNumber, JobType jobType, decimal studentGrade)
        {
            StudentName = studentName;
            StudentFacNumber = studentFacNumber;
            JobType = jobType;
            StudentGrade = studentGrade;
        }

        public Job() { }
    }
}
