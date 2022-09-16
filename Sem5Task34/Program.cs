//===================================================================================
// # 34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька
//===================================================================================

int[] inputArray = FillArray(10, 100, 1000);
PrintArray(inputArray);

PrintResult($"В массиве {CountEvenElem(inputArray)} чётных чисел");

Console.WriteLine("Отсортированный масив (методом пузырька)");
PrintArray(BubbleSortAsc(inputArray));

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
        topBorder = temp;
    }
    // Заполняем массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = numSintezator.Next(downBorder, topBorder + 1);
    }
    return arr;
}

// Подсчитывает количество чётных элементов в массиве
int CountEvenElem(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (TestEven(arr[i])) count++;
    }
    return count;
}

bool TestEven(int num)
{
    return (num % 2 == 0);
}

// Сортировка массива методом пузырька по возрастанию
int[] BubbleSortAsc(int[] arr)
{
    int[] arrCopy = new int[arr.Length];
    arr.CopyTo(arrCopy, 0);
    for (int i = 1; i < arrCopy.Length; i++)
    {
        for (int j = 0; j < arrCopy.Length - i; j++)
        {
            if (arrCopy[j] > arrCopy [j + 1])
            {
                int temp = arrCopy[j];
                arrCopy[j] = arrCopy[j + 1];
                arrCopy[j + 1] = temp;
            }
        }
    }
    return arrCopy;
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