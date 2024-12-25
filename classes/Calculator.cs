using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public static class Calculator
    {
        private static readonly double Pi = 3.14; 

        static Calculator()
        {
            throw new NotImplementedException();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
