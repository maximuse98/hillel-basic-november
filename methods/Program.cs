namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethod();

            // нестатичний метод
            MyClass myClasRef = new MyClass();
            myClasRef.MyMethod();

            // статичний метод
            MyClass.MyStaticMethod();

            PrintHello();
            PrintHello();

            PrintHelloToUser("Maxim");
            PrintHelloToUser("Adriiy");

            PrintHello("ua");

            PrintHelloWithDetails("Maxim", "Kabakov");

            int sum = ArraySum([1, 2, 3, 4, 5]);
            Console.WriteLine(sum);
            
            // ref
            int num = 5;
            Plus1(ref num);

            Console.WriteLine(num);

            // reference types
            List<int> list = [1, 2, 4, 8];
            Add1(list);

            Console.WriteLine(list.Last());

            int.TryParse("1", out int result);

            TryCompareAsNumbers("12", "24", out bool isEqual);

            Sum(num1: "25", 
                num3: 12, 
                num2: 15, 
                num4: 2555);

            Sum(num1: "25",
                num3: 12,
                num2: 15);

            int[] ints = list.ToArray();
            SumNumbers(2, ints);

            Console.WriteLine(Factorial(5));
        }

        static void PrintBye()
        {
            Console.WriteLine("Bye");
        }

        static void PrintHello()
        { 
            Console.WriteLine("Hello");
        }

        static void PrintHello(string language)
        {
            if (language == "ru")
            {
                return;
            }

            if (language == "ua")
            {
                Console.WriteLine("Привіт");
            }
            else
            {
                PrintHello();
            }
        }

        static void PrintHelloToUser(string username)
        { 
            Console.WriteLine($"Hello {username}");
        }

        static void PrintHelloWithDetails(string name, string surname)
        {
            Console.WriteLine($"Hello {name} {surname}");
        }

        static void MyMethod()
        {
            // якась дія / набір дій
            //MyMethod();
        }

        static int Factorial(int value)
        {
            if (value < 1)
                throw new ArgumentException(nameof(value));

            if (value == 1)
                return 1;

            return value * Factorial(value - 1);
        }

        static int ArraySum(int[] array)
        {
            int result = 0;
            foreach (int i in array)
            {
                result += i;
            }
            return result;
        }

        static void Plus1(ref int num)
        {
            num++;
        }

        static void Add1(List<int> ints)
        { 
            ints.Add(1);
        }

        static bool TryCompareAsNumbers(string s1, string s2, out bool result)
        {
            result = false;

            try
            {
                result = int.Parse(s1) == int.Parse(s2);
                return true;
            }
            catch
            {
                return false;
            }
        }
    
        static long Sum(string num1, int num2, short num3, long num4 = 0)
        {
            Console.WriteLine("4 params");
            return int.Parse(num1) + num2 + num3 + num4;
        }

        static long Sum(string num1, int num2, short num3)
        {
            Console.WriteLine("3 params");
            return int.Parse(num1) + num2 + num3;
        }

        static int SumNumbers(int num, params int[]? ints)
        {
            return ints.Sum();
        }
    }

    class MyClass
    {
        public void MyMethod()
        {
            // якась дія / набір дій
        }

        public static void MyStaticMethod()
        {

        }
    }
}
