using oop.Company;
using oop.Shop;
using oop.Soccer;
using oop.Vehicle;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Асоціація
            Team realMadrid = new Team();

            Player Mbappe = new Player();
            Mbappe.PlayersTeam = realMadrid;

            Team chelsea = new Team();
            Mbappe.PlayersTeam = chelsea;

            Mbappe.PlayersTeam = null;

            // 2. Агрегація
            Engine electricEngine = new Engine();
            Car tesla = new Car(electricEngine);

            // 3. Композиція
            Car car = new Car(); // ствоорює new Engine();


            BaseClass baseClass = new BaseClass("baseField");
            baseClass.DoSmth();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.DoSmthElse();
            derivedClass.DoSmth();

            DerivedDerivedClass derivedDerivedClass = new DerivedDerivedClass();


            // cast
            Worker officeManager = new OfficeManager(); // - upcast
            Worker cleaner = new Cleaner();

            OfficeManager manager1 = (OfficeManager)officeManager; // - downcast
            //OfficeManager manager2 = (OfficeManager)cleaner; // - InvalidCastException

            //object obj = new object();

            officeManager.CalculateSalary(4); // 8
            manager1.CalculateSalary(4); // 16

            cleaner.CalculateSalary(10); // 15 - від класу Cleaner

            Worker worker = new Worker();
            worker.CalculateSalary(3); // 6 - від класу Worker




            Laptop laptop = new Laptop()
            {
                YearProduced = 2020
            };

            Cart cart = new Cart();
            cart.AddProduct(laptop);

            TV tV = new TV();
            cart.AddProduct(tV);
        }
    }
}
