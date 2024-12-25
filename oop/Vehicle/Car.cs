using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Vehicle
{
    public class Car
    {
        private Engine engine;

        public Car(Engine engine)
        {
            this.engine = engine;
        }

        public Car()
        {
            this.engine = new Engine();
        }
    }
}
