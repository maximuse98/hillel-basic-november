using classes.user;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Класи, з чого вони складаються
            User user = new User(); // створюється новий об'єкт класу

            user.Name = "Maxim";
            user.Surname = "Kabakov";

            Console.WriteLine(user.Name);

            user.Introduce();


            // 2. Статіка

            User.GetClassName();
            string c = User.country;
            //User.Introduce(); // error - non-static

            // 3. Конструктори, перегрузка

            User user2 = new User("user2 password");

            user2.Name = "Vadym";
            user2.Introduce();

            Console.WriteLine(User.country);

            try
            {
                Calculator.Add(10, 25);
            }
            catch (Exception ex)
            {
            }

            Calculator.Add(25, 354);

            Math.Cos(90);

            // 4. Ініціалізація, присвоєння

            User user3 = new User()
            { 
                Name = "Vlad",
                Surname = "Ivanov"
            };

            // 5. Інкапсуляція, властивості
        }
    }
}
