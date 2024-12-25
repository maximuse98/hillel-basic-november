// строки

// 1. ініціалізація рядка

using System.Text;

string str0 = "Hello, World!";

// 1.1 як набір символів
// 1.2 як масив символів
// 1.3 як об'єкт класу String
char[] chars = { 'H', 'e', 'l', 'l', 'o' };
string str1 = new string(chars);

foreach (char ch in str1)
{ 
    //Console.Write(ch);
}

string name = "Maxim";

// 2. Форматування string.Format

string ff = $"Hello {name}";
string ff2 = string.Format("Hello {0}", name);

Console.WriteLine("Hello {0}, I am {1} years old", name, 26);

double price = 99.99;
string priceOutput = string.Format("Price: {0:C2}", price);

Console.WriteLine(priceOutput);

// 3. Отримання частини рядка 

Console.WriteLine(priceOutput.Substring(7,6));

// 4. Порівняння двох рядків ==, Equals

string stringCompare1 = "test";
string stringCompare2 = "test";

Console.WriteLine(stringCompare1 == stringCompare2); // true

int[] nums1 = new int[] { 1, 2, 3 };
int[] nums2 = new int[] { 1, 2, 3 };

int[] nums3 = nums1;

Console.WriteLine(nums1 == nums2); // false
Console.WriteLine(nums1 == nums3); // true

// 5. Конкатенація рядків Concat, +, StringBuilder

string greeting = "My name is " + name + "!";

string age = "26";
string info = greeting + " I'm " + age + " years old.";

StringBuilder sb = new StringBuilder();

sb.Append("My name is ");
sb.Append(name);
sb.Append("!");

sb.Append(" I'm ");
sb.Append(age);
sb.Append(" years old.");

string result = sb.ToString();

Console.WriteLine(result);

// 6. Вставка підрядка починаючи з заданого індексу Insert

Console.WriteLine(info.Insert(0, "Hello! "));

// 7. Заміна символів у рядку Replace

string replacedString = info.Replace("name", "first name");

// 8. Розділення Split

string val = "12|12-04-2025|nt@gmail.com|12225";
string[] strings = val.Split('|');

foreach (string s in strings)
{
    Console.WriteLine(s);
}


int a = 10;
a = 15;

string str = "Hello";
str = "World";

string str2 = "Hello";
string str3 = "Hello World";
str2 = str3;


int b = 10;
int c = b;

b = 20;

Console.WriteLine(c);

String str4 = "Hello";

DateTime dt = DateTime.Now;
DateTime dtu = DateTime.UtcNow;

dt.ToString();

dt.AddDays(1);