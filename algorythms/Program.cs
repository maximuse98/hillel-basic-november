// Алгоритми
// Алгоритмічна складність

// O(1) - константна складність
// O(n) - лінійна складність
// O(log n) - логарифмічна складність
// O(n^2) - квадратична складність
// O(!n) - факторіальна складність

// Bubble sort
// 2 3 1 5 4
// 2 3 1 5 4 -> 2 1 3 4 5
// 2 1 3 4 5 -> 2 1 3 4 5
// 2 1 3 4 5 -> 2 1 3 4 5
// 2 1 3 4 5 -> 1 2 3 4 5

int[] arrayToSort = { 5, 4, 3, 2, 1 };
bool isSorted = false;

for (int i = 0; i < arrayToSort.Length; i++)
{
    isSorted = true;
    for (int j = 0; j < arrayToSort.Length - i - 1; j++)
    {
        if (arrayToSort[j] > arrayToSort[j+1])
        {
            //int temp = arrayToSort[j];
            //arrayToSort[j] = arrayToSort[j + 1];
            //arrayToSort[j + 1] = temp;

            (arrayToSort[j], arrayToSort[j+1]) = (arrayToSort[j + 1], arrayToSort[j]);
            isSorted = false;
        }
    }

    if (isSorted)
    {
        break;
    }
}

foreach (var item in arrayToSort)
{
    Console.Write(item + " ");
}
Console.WriteLine();

// Binary search
// 1 2 3 4 5 6 7 8 9 10

int[] arrayToSearch = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int searchValue = 1;
int result = -1;

int left = 0;
int right = arrayToSearch.Length - 1;

while (left <= right)
{
    int mid = (left + right) / 2;

    if (arrayToSearch[mid] < searchValue)
    {
        left = mid + 1;
    }
    else if (arrayToSearch[mid] > searchValue)
    {
        right = mid - 1;
    }
    else
    {
        result = mid;
        break;
    }
}

Console.WriteLine($"Found {searchValue} at index {result}");