//быстрая сортировка

int[] QuickSort(int[] array, int startIndex, int stopIndex)
{
    if (startIndex >= stopIndex)
    {
        return array;
    }
    
    int pivotIndex = GetPivotIndex(array, startIndex, stopIndex);

    QuickSort(array, startIndex, pivotIndex - 1);
    
    QuickSort(array, pivotIndex + 1, stopIndex);
    
    return array; 
}

int GetPivotIndex(int[] array, int startIndex, int stopIndex)
{
    int pivotIndex = startIndex - 1;

    for (int i = startIndex; i <= stopIndex; i++)
    {
        if(array[i] < array[stopIndex])
        {
            pivotIndex++;

            Swap(array, i, pivotIndex);
        }
    }

    pivotIndex++;

    Swap(array, pivotIndex, stopIndex);
    
    return pivotIndex;
}

static void Swap(int[] array, int leftItem, int rigthItem)
{
    int temp = array[leftItem];
    array[leftItem] = array[rigthItem];
    array[rigthItem] = temp;
}

Console.Write("Количество элементов массива для сортировки: ");

int N = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[N];

for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите число №{i + 1}: ");

    Array[i] = Convert.ToInt32(Console.ReadLine());
}

int[] SortArray = QuickSort(Array, 0, (Array.Length-1));

Console.WriteLine("Отсортированный массив:");

for (int i = 0; i < SortArray.Length; i++)
{
    Console.Write($"{SortArray[i]}; ");
}
Console.WriteLine("");