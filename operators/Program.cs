// оператори в C#
// 1. Арифметични оператори
// +, -, *, /, %

int a = 5;
//int b = (3 + 2);
//int c = 5 - 4;

//int d = 8 % 5; // 3
//int e = 3 % 3; // 0

//int f = a + b;
//int g = (a - b) / (c + d) ^ e;

//long bb = 5;
//long bc = 3;

//long k = bb + bc;

//Console.WriteLine(a + b);

// 2. Унарні оператори
// +, -, ++, --, !, ~

//int b = -a;
//int c = +a;

////a++;
////(a + 1);

//int d1 = a++;
//int e1 = (a + 1);

//int d2 = ++a;

//bool f1 = true;
//bool f2 = !f1;

//int g1 = ~0;
//Console.WriteLine(g1);

// 3. Логічні оператори
// &&, ||, !

bool b = true;
bool c = true;

//bool d1 = b && c;
//bool d2 = !b || c;

// логічне НЕ
// !0 = 1
// !1 = 0

// логічне І
// 0 && 0 = 0
// 0 && 1 = 0
// 1 && 0 = 0
// 1 && 1 = 1

// логічне АБО
// 0 || 0 = 0
// 0 || 1 = 1
// 1 || 0 = 1
// 1 || 1 = 1

// 4. Порівняння
// ==, !=, >, <, >=, <=

//bool isEqual = 5 == 5;
//// javascript
//// '5' == 5 -> true
//// '5' === 5 -> false

bool is5NotEqual5 = 5 != 5;
//bool isMore = 8 > 8; // false
//bool isLess = 8 < 8; // false
//bool isMoreOrEqual = 8 >= 8; // true
//bool isLessOrEqual = 8 <= 8; // true

//bool d = (5 > 3) && (5 < 8);
//bool e = (5 < 8) && !(10 < 3); // true

// 5. Побітові оператори
// &, |, ^, <<, >>

//   0 = 0
//   1 = 1
//  10 = 2
//  11 = 3
// 100 = 4
// 101 = 5
// 110 = 6
// 111 = 7

// XOR
// 0 ^ 0 = 0
// 0 ^ 1 = 1
// 1 ^ 0 = 1
// 1 ^ 1 = 0

int d = 5 & 3; // 1
// 101 & 011 = 001

int e = 5 | 3; // 7
// 101 | 011 = 111

int f = 3 << 2; // 12
// 011 << 1 = 1100

int g = 3 >> 1; // 1
// 011 >> 1 = 001

// 6. Тернарний оператор
// ?:

int result;

if (d == e)
{
    result = d;
}
else
{
    result = e;
}

result = (d == e)? d : e;



// умовний оператор if
if (b == c)
{
    Console.WriteLine("b is equal c");
}
else
{
    Console.WriteLine("b is not equal 6");
}

int c1 = 4;
int d1 = 5;

if (c1 > d1)
{ 
    Console.WriteLine("c1 is greater than d1");
}
else if (c1 < d1)
{
    Console.WriteLine("c1 is less than d1");
}
else
{
    Console.WriteLine("c1 is equal d1");
}

// умовний оператор switch
int day = 4;

if ( day == 1)
{
    Console.WriteLine("Monday");
}
else if (day == 2)
{
    Console.WriteLine("Tuesday");
}
else if (day == 3 || day == 4)
{
    Console.WriteLine("Wednesday or Thursday");
}
else
{
    Console.WriteLine("Unknown day");
}

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
    case 4:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Unknown day");
        break;
}

string dayName = day switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    4 => "Thursday",
    _ => "Unknown day"
};