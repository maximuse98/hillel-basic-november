string input = Console.ReadLine();
//int num = int.Parse(input);

int result;

// 1. TryParse
if (int.TryParse(input, out result))
{
    Console.WriteLine("You entered a valid number: " + result);
}
else
{
    Console.WriteLine("You entered an invalid number: " + input); 
}

// 2. Try-Catch

try
{
    result = int.Parse(input);
    Console.WriteLine("You entered a valid number: " + result);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    //Console.WriteLine("You entered an invalid number: " + input);
}
catch (OverflowException ex)
{
    Console.WriteLine("The number is too large or too small.");
}
catch (Exception)
{
    Console.WriteLine("Something went wrong.");
}
finally
{ 
    Console.WriteLine("Finally block");
}

Console.WriteLine("Final");