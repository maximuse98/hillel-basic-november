using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Company
{
    public class Cleaner : Worker
    {
        public string MasterKey { get; set; }

        public override int CalculateSalary(int hours)
        {
            int salary = base.CalculateSalary(hours) - 5;
            return salary > 0 ? salary : 1;
        }
    }
}
