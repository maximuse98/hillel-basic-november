using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Company
{
    public class OfficeManager : Worker
    {
        public string ComputerName { get; set; }

        public new int CalculateSalary(int hours)
        {
            return base.CalculateSalary(hours) * 2;
        }
    }
}
