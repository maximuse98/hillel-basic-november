// Цикли

// 1. while
// 2. do while
// 3. for
// 4. foreach

// break - передчасний вихід з циклу
// continue

// 1. Тіло циклу
// 2. Умова продовження/зупинки циклу

//start:
//int a = 0;

//// while

//while (/* умова */ a < 5)
//{ 
//    Console.WriteLine(a);
//    a++;
//}

//// do while

//do
//{ 
//    Console.WriteLine(a);
//}
//while (/* умова */ a < 5);

//// for
//Console.WriteLine("for");

//for (int i = 0; i++ < 10; ++i)
//{ 
//    Console.WriteLine(i);
//}

//// 1. Ініціалізація i = 0
//// 2. Перевірка умови i < 10
//// 3. Інкремент i = 1
//// 4. Тіло циклу 
//// 5. Інкремент i = 2
//// 6. Перевірка умови i < 10
//// 7. Інкремент i = 3
//// 8. Тіло циклу


//++a; // префіксна форма
//a++; // постфіксна форма

//// нескінченний цикл

//for (;;)
//{
//    Console.WriteLine(a);
//}

//while (true)
//{ }

//for (int i = 0; i < 100; i++)
//{
//    if (i < 30)
//    {
//        goto start;
//        continue;
//    }

//    Console.WriteLine(i);

//    if (i == 50)
//    {
//        break;
//    }
//}

//// 1. Ініціалізація i = 0
//// 2. Перевірка умови i < 30
//// 3. i = 30
//// 4. Console.WriteLine
//// 4. i = 50
//// 5. break

//// goto

//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    { 
//        if (i == 5 && j == 5)
//        {
//            goto finish;
//        }
//    }
//}

//finish:
//Console.WriteLine("Finish");


// Write a program in C# Sharp to display such a pattern
// for n number of rows using a number starting with the number 1.
// The first and last number of each row will be 1.

// Input : 3
//12321
// 121
//  1


int input = 10;

for (int i = 0; i < input; i++)
{
    bool isMiddle = false;
    int negative = 1;
    int spaces = i;
    int maxVal = input - i;
    int k = 0;

    for (int j = 0; j < input * 2 - 1; j++)
    {
        if (j < spaces || (input * 2 - 1) - 1 - spaces < j)
        { 
            Console.Write(" ");
            continue;
        }

        if (isMiddle)
        {
            Console.Write(k++ - negative);
            negative += 2;
        }
        else
        {
            Console.Write(k++ + 1);
        }

        if (j + 1 == input)
        {
            isMiddle = true;
        }
    }

    Console.WriteLine();
}