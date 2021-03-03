using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class ProductionWorker : Employee
    {
        /// <summary>
        /// 1: Day Shift 2: Night Shift
        /// </summary>
        public int Shift { get; set; }
        public double HourlyRate { get; set; }

        public ProductionWorker() : base()
        {
            Shift = 0;
            HourlyRate = 0;
        }

        public ProductionWorker(int empNumber, string name, int shift, double hourlyRate) : base(empNumber, name)
        {
            Shift = shift;
            HourlyRate = hourlyRate;
        }
    }
}
