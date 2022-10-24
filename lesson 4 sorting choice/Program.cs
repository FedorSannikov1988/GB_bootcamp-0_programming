//сортировка выбором

Console.Write("Количество элементов массива для сортировки: ");

int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    
    array[i] = Convert.ToInt32(Console.ReadLine());
}

//распечатываем введенный массив

Console.WriteLine("Введенный массив:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}; ");
}
Console.WriteLine("");

//алгоритм сортировки выбором

for (int i = 0; i < (array.Length - 1); i++)
{
    int Index = i;

    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[Index])
        // if (array[j] > array[Index])
        {
            Index = j;
        }
    }

    int temp = array[Index];
    array[Index] = array[i];
    array[i] = temp;
}

//распечатываем отсортированный массив

Console.WriteLine("Отсортированный массив:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}; ");
}
Console.WriteLine("");