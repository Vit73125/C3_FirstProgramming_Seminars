//===================================================================================
// # 45 Напишите программу, которая будет создавать копию заданного
// одномерного массива с помощью поэлементного копирования. 
//===================================================================================

int[] arr = FillArray(5, -10, 10);
PrintArray("Исходный массив", arr);
PrintArray("Скопированный массив", CopyArray(arr));

// Заполнение массива случайными числами - Целые числа
int[] FillArray(int num, int downBorder, int topBorder)
{
    // Генератор случайных чисел
    Random numSintezator = new Random();
    // Создаём массив
    int[] arr = new int[num];
    // Тест границ
    
    if (downBorder > topBorder)
    {
        int temp = downBorder;
        downBorder = topBorder;
        topBorder = downBorder;
    }
    // Заполняем массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = numSintezator.Next(downBorder, topBorder + 1);
    }
    return arr;
}

int[] CopyArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[i];
    }
    return outArr;
}

// Вывод: массив целых чисел
void PrintArray(string prefix, int[] array)
{
    Console.WriteLine(prefix);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0,5:d}", array[i]);
    }
    Console.WriteLine();
}