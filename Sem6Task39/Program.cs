//===================================================================================
// # 39 Напишите программу, которая перевернёт одномерный массив (последний элемент
// будет на первом месте, а первый - на последнем и т.д.) 
//===================================================================================

int[] arr = FillArray(20, 1, 100);
Console.WriteLine("Исходный массив:");
PrintArray(arr);

int[] copyArray = SwapNewArray(arr);
Console.WriteLine("Новый перевёрнутый массив:");
PrintArray(copyArray);
Console.WriteLine("Исходный массив:");
PrintArray(arr);

Console.WriteLine("Перевёрнутый массив:");
arr = SwapArray(arr);
PrintArray(arr);

// Универсальный метод генерации и заполнения массива
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

// Реверс массива с созданием нового массива
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }

    return outArr;
}

// Реверс массива без создания нового массива: изменение входящего массива
int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = bufElement;
    }

    return arr;
}

// Вывод: результат на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0,5:d}", array[i]);
    }
    Console.WriteLine();
}