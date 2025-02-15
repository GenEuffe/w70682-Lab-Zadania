using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Student : Person
    {
        public string School { get; set; }
        public bool HecanGoHomeAlone { get; set; }
        public void SetSchool(string school) => School = school;
        public void ChangeSchool(string newschool) => School = newschool;
        public void SetCanGoHomeAlone(bool decision) => HecanGoHomeAlone = decision;
        public override string GetEducationInfo() => $"Uczeń szkoły: {School}";
        public override string GetFullName() => $"{FirstName}{LastName}"


    }

}
