using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutomatedTellerMachine.Models
{
    public class Department
    {
        public Department()
        {
            Courses = new HashSet<Course>();
        }

        [Required(ErrorMessage = "This field is urgently required")]
        public int Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Name { get; set; }
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime StartDate { get; set; }

        [Range(1, 100)]
        public int? Administrator { get; set; }

        public  ICollection<Course> Courses { get; set; }

    }

    public class Course
    {
        public string  Name { get; set; }
    }
}