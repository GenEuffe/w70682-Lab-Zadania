using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Teacher : Student
    {
        public string TitleScientific { get; set; }
        public List<Student> Students { get; set; } = new List<Student> { };

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            Console.WriteLine($"Lista uczniów którzy mogą sami wracać do domu: {dateToCheck.ToShortDateString()}");

            foreach (Student student in Students) 
            {
                if (student.CanGoHomeAlone()) 
                {
                    Console.Writeline(Student.GetFullName())
                }

            }
        }
    }
}
