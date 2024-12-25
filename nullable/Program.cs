string? name = null;
PrintUpper(name);

void PrintUpper(string? name)
{
    Console.WriteLine(name.ToUpper());
}

string? input = Console.ReadLine();

// 1
if (input != null)
{
    input.ToUpper();
}

// 2
if (input is not null)
{
    input.ToUpper();
}

input.Trim();


int? num = null;

// 3
if (num.HasValue)
{
    Console.WriteLine($"Non nullable value is: {num.Value}");
}

// 4
if (!string.IsNullOrEmpty(name))
{
    Console.WriteLine($"{name}");
}

string surname = "Smith";

string prefix = name ?? "Mr";


string? product = GetProductFromDb() ?? throw new Exception("Product not found");

//if (product is null)
//{
//    throw new Exception("Product not found");
//}

static string GetProductFromDb()
{
    // action
    return string.Empty;
}