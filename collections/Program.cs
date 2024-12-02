// Коллекції
// 1. Массив

int[] array = new int[5];
int[] array2 = new int[] { 1, 2, 3 };

int[] array3 = { 1, 2, 3 };
byte[] array4 = { 1, 2, 3 };

// optional
int[] array5 = [1, 2, 3];

array[0] = 1;

int sumArray = array[0] + array[1];

//array[5] = 15; // IndexOutOfRangeException

int arrl = array.Length; // 5

for (int i = 0; i < array.Length; i++)
{
    array[i] = i + 1;
}

foreach (int element in array)
{
    if (element % 2 == 0)
    {
        Console.WriteLine(element);
    }
}

//Console.WriteLine(array);


// 1.1 Двовимірний масив

int[,] array2D = new int[2, 3];

array2D[0, 0] = 1;
//array2D.Rank; // 2

// 1.2 Масив масивів

int[][] array6 = new int[3][];

array6[0] = new int[2];
array6[0][0] = 1;

array6[2] = new int[3];
array6[2][1] = 5; // NullReferenceException

// 2. Список
// Add, Remove, Contains, IndexOf, Insert, Clear, Count

List<string> listStrings = new List<string>();

listStrings.Add("First");
listStrings.Add("Second");
listStrings.Add("First");

listStrings.Contains("First"); // true
listStrings.IndexOf("First"); // 0

listStrings.Insert(1, "New Second");

listStrings.Remove("First");

listStrings[0] = "New First";

//listStrings.Count; // 3
//listStrings.Capacity; // 4
//listStrings.ToArray().Length; // 3

// 2.1 Зв'язаний список
// AddFirst, AddLast, RemoveFirst, RemoveLast, Contains, Clear, Count

// 2 <-> 3 <-> 7 <-> 4 <-> 5

LinkedList<int> linkedList = new LinkedList<int>();

linkedList.AddLast(3);
linkedList.AddFirst(7);

linkedList.AddAfter(linkedList.First, 4);
linkedList.AddBefore(linkedList.Last, 5);

linkedList.AddLast(30);

foreach (int element in linkedList)
{
    Console.WriteLine(element);
}

// 3. Словник
// Add, Remove, ContainsKey, ContainsValue, Clear, Count

Dictionary<int, string> dict = new Dictionary<int, string>();

dict.Add(1, "One");
dict.Add(2, "Two");
dict.Add(3, "Three");
dict.Add(4, "Four");
dict.Add(5, "Five");

if (dict.TryGetValue(3, out string otput))
{
    Console.WriteLine(otput);
}

//dict.Add(3, "New Three");

dict[3] = "New Three";

Dictionary<string, string> newDict = new Dictionary<string, string>();
newDict.Add("FirstKey", "FirstValue");

Console.WriteLine($"newDict value: {newDict["FirstKey"]}");

Dictionary<string, string> dictionary2 = new Dictionary<string, string>()
{ 
    { "key1", "key2" },
    { "key2", "key3" }
};

foreach (KeyValuePair<int, string> pair in dict)
{
    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
}

// ітерування по ключам
foreach (string key in dictionary2.Keys)
{ 
    
}

// ітерування по значенням
foreach (string value in dictionary2.Values)
{

}

dictionary2.ContainsKey("key1");


// 4. Множина
// Add, Remove, Contains, Clear, Count

HashSet<int> hashInts = new HashSet<int>();

// 1-> hex 0x1

// 5. Черга
// Enqueue, Dequeue, Peek, Clear, Count

Queue<int> queue = new Queue<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

int firstQueueValue = queue.Dequeue(); // 1
int secondQueueValue = queue.Dequeue(); // 2

queue.Peek(); // 3

// 6. Стек
// Push, Pop, Peek, Clear, Count

Stack<int> stack = new Stack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

int lastStackValue =  stack.Pop(); // 4

stack.Peek(); // 3

int orderType = 1;

if (orderType == 1) // самовивіз
{
    // обробка замовлення самовивозу
}
else if (orderType == 2)
{
    // обробка замовлення доставки
}
else if (orderType == 3)
{
    // обробка замовлення поштою
}
else
{
    // обробка замовлення кур'єром
}

switch (orderType)
{
    case 1:
        // обробка замовлення самовивозу
        break;
    case 2:
        // обробка замовлення доставки
        break;
    case 3:
        // обробка замовлення поштою
        break;
    default:
        // обробка замовлення кур'єром
        break;
}

OrderType orderTypeEnum = OrderType.Delivery;

if (orderTypeEnum == OrderType.SelfPickup)
{
    // обробка замовлення самовивозу
}
else if (orderTypeEnum == OrderType.Delivery)
{
    // обробка замовлення доставки
}
else if (orderTypeEnum == OrderType.Post)
{
    // обробка замовлення поштою
}
else
{
    // обробка замовлення кур'єром
}

switch (orderTypeEnum)
{
    case OrderType.SelfPickup:
        // обробка замовлення самовивозу
        break;
    case OrderType.Delivery:
        // обробка замовлення доставки
        break;
    case OrderType.Post:
        // обробка замовлення поштою
        break;
    default:
        // обробка замовлення кур'єром
        break;
}

enum OrderType
{
    Delivery = 1,
    SelfPickup,
    Post,
    Courier
}

