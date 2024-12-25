using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Shop
{
    public class Product
    {
        public virtual int Price => 100;
    }

    public class MobilePhone : Product
    {
        public override int Price => 500;
    }

    public class Laptop : Product
    {
        public int YearProduced {  get; set; }
        public override int Price => 2500 + YearProduced * 10;
    }

    public class Headphones : Product
    {
        public override int Price => 1000;
    }

    public class Fridge : Product
    {
        public string Brand { get; set; }
        public override int Price => Brand == "Samsung" ? 20000 : 5000;
    }

    public class TV : Product
    {
        public string Brand { get; set; }
        public override int Price => Brand == "Samsung" ? 12000 : 10000;
    }
}
