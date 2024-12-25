namespace linq
{
    internal class Program
    {
        delegate void PrintOperation();

        static void Main(string[] args)
        {
            // 1. delegate

            // ініціалізація
            PrintOperation printDelegate = PrintHello;

            // запуск
            printDelegate();

            //printDelegate = PrintGoodbye;
            //printDelegate();

            printDelegate += PrintGoodbye;
            printDelegate += PrintHello;

            printDelegate += Console.WriteLine;
            printDelegate -= Console.WriteLine;

            // 2. Action, Function, Predicate

            Action<int, int> actionDelegate = Sum;
            actionDelegate += Multiply;

            // Output: 25
            // 150
            actionDelegate(10, 15);

            Func<int, int, int> funcDelegate = Divide;
            funcDelegate += Deduct;

            int funcResult = funcDelegate(20, 2); // 18

            Predicate<int> predict = IsPositive;

            // 3. Лямбда вирази

            predict = (inputNumber) => inputNumber >= 0;

            // 4. Запити в базу даних
            // 5. Linq

            string[] names = { "Maxim", "Vadym", "Tim", "Tom", "Nikolay", "Timofey" };

            List<string> sortedNames = new List<string>();

            foreach (string name in names)
            {
                if (name[0] == 'T')
                {
                    sortedNames.Add(name);
                }
            }

            // 1
            var query = from name in names
                        where name[0] == 'T'
                        orderby name descending
                        select name;

            sortedNames = query.ToList();

            // 2
            var query2 = names.Where((name) => name[0] == 'T').
                                Select((name) => name);

            sortedNames = query2.ToList();

            var newSortdNames = query2.OrderByDescending(name => name).ToList();

            // Select
            // Where
            // OrderBy
            // OrderByDescending

            // Reverse

            names.Reverse();

            // All
            // чи дійсно всі імена починаються на Т
            names.All(x => x.StartsWith('T'));

            // Any
            // чи хоч один елемент відповідає умові 
            names.Any(x => x.StartsWith('T'));

            // Contains
            // чи містить колекція певний елемент
            names.Contains("Tim");

            // Distinct
            names.Distinct();

            // Except
            //names.Except("Maxim");

            // Union
            names.Union(sortedNames);

            // Count
            // Sum
            names.Select((name, count) => count).Sum();

            // Average
            // Min
            // Max
            // найдовше ім'я
            names.MaxBy(name => name.Length);

            // Take
            // Skip

            // First
            if (names != null && names.Length != 0)
            { 
                string firstName = names.First();
            }

            // FirstOrDefault

            string firstDefaultName = names.FirstOrDefault();

            if ( firstDefaultName != null)
            {
                
            }

            // Last
            // LastOrDefault

            // ElementAt
            // ElementAtOrDefault
        }

        static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        static void PrintGoodbye()
        {
            Console.WriteLine("Goodbye");
        }

        static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static int Deduct(int x, int y)
        {
            return x + y;
        }

        static int Divide(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch
            {
                return 0;
            }
        }

        static bool IsPositive(int x)
        {
            return x >= 0;
        }
    }
}
