//===================================================================================
// # 34 Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// * Найдите все пары (равных чисел) в массиве и выведите пользователю.
//===================================================================================

int[] inputArray = FillArray(15, -10, 100);
PrintArray(inputArray);

PrintResult($"Сумма элементов на нечётных позициях: {SumOddElem(inputArray)}");
Console.WriteLine("Пары равных чисел в массиве:");
PrintPairElements(inputArray);

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

// Подсчитывает сумму элементов на нечётных позициях
int SumOddElem(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2) sum += arr[i];
    return sum;
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

// Вывод всех пар одинаковых чисел
void PrintPairElements(int[] arr)
{
    int[] seekArr = BubbleSortAsc(arr);
    for (int i = 0; i < seekArr.Length - 1; i++)
    {
        if (seekArr[i] == seekArr[i + 1])
        {
            Console.WriteLine($"{seekArr[i]} {seekArr[i + 1]}");
        }
    }

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