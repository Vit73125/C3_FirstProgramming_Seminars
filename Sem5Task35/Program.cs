//===================================================================================
// # 35 Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//===================================================================================

int[] inputArray = FillArray(123, 1, 1000);
PrintArray(inputArray);

PrintResult($"В диапозоне [10, 99] {CountElem(inputArray)} чисел");

// Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBorder, int topBorder)
{
    // Генератор случайных чисел
    Random numSintezator = new Random();
    // Создаём массив
    int[] arr = new int[num];
    // Тест границ
    if (downBorder < topBorder)
    {
        // Заполняем массив
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    return arr;
}

int CountElem(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i])) count++;
    }
    return count;
}

bool Test(int num)
{
    return (num > 9 && num < 100);
}

// Вывод: результат на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// Вывод: результат на консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}