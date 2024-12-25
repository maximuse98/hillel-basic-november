using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Company
{
    public class Worker
    {
        public int Id { get; set; }

        protected int coef = 2;

        public virtual int CalculateSalary(int hours)
        {
            return coef * hours;
        }
    }
}
