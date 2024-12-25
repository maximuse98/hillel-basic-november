using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.user
{
    public class User
    {
        // поля
        private string name;
        //private string surname;

        private string password;

        // властивості
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname { get; set; }

        // статичне поле
        public static string country = "Ukraine";

        // конструктор
        public User()
        {
            //Surname = "asd";
            password = "simple_password";
        }

        public User(string password)
        {
            this.password = password;
        }

        // методи
        public void Introduce()
        {
            country = "England";

            if (Surname == null)
            {
                Console.WriteLine($"Hi, I'm {name}");
            }
            else
            {
                Console.WriteLine($"Hi, I'm {name} {Surname}");
            }
        }

        public static string GetClassName()
        {
            return "User";
        }

        public static string GetFullLocation()
        {
            return "Europe, " + country;
        }
    }
}
