using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class ShiftSupervisor: Employee
    {
        public double AnnualSalary { get; set; }
        public double AnnualBonus { get; set; }

        public ShiftSupervisor():base()
        {
            AnnualSalary = 0;
            AnnualBonus = 0;
        }

        public ShiftSupervisor(int empNumber, string name, double annualSalary, double annualBonus):base(empNumber,name)
        {
            AnnualSalary = annualSalary;
            AnnualBonus = annualBonus;
        }
    }
}
