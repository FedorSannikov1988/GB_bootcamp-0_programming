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

//алгоритм сортировки пузырьком

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < (array.Length - 1); j++)
    {
        if (array[j] < array[j + 1])
        // if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    
    Console.WriteLine($"Шаг сортирвки {i+1}:");

    for (int g = 0; g < array.Length; g++)
    {
        Console.Write($"{array[g]}; ");
    }
    Console.WriteLine("");
}

//распечатываем отсортированный массив

Console.WriteLine("Отсортированный массив:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}; ");
}
Console.WriteLine("");