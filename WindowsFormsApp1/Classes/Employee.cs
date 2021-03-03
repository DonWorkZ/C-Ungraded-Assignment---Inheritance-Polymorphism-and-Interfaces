using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public abstract class Employee
    {
        public int EmpNumber { get; set; }
        public string Name { get; set; }

        public Employee()
        {
            EmpNumber = 0;
            Name = string.Empty;
        }

        public Employee(int empNumber,string name)
        {
            EmpNumber = empNumber;
            Name = name;
        }
    }
}
