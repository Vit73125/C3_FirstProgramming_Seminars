//===================================================================================
// # 38 Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу
// между первым и последним элементом. Для задачи со звездочкой использовать
// заполнение массива целыми числами.
//===================================================================================

double[] inputDoubleArray = FillArrayDouble(100, 0.0, 100.0);
PrintArrayDouble(inputDoubleArray);
double max = MaxDouble(inputDoubleArray);
double min = MinDouble(inputDoubleArray);
string res = String.Format("max = {0:f1}; min = {1:f1}; max - min = {2:f1}", max, min, max - min);
PrintResult (res);

Console.WriteLine("Целочисленный массив:");
int[] inputIntArray = FillArrayInt(15, 0, 100);
PrintArrayInt(inputIntArray);
Console.WriteLine("Отсортированный массив - метод выбора:");
PrintArrayInt(SortChoice(inputIntArray));
Console.WriteLine("Отсортированный массив - метод подсчёта:");
PrintArrayInt(SortCount(inputIntArray));

// Универсальный метод генерации и заполнения массива - Целые числа
int[] FillArrayInt(int num, int downBorder, int topBorder)
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

// Универсальный метод генерации и заполнения массива - вещественные числа
double[] FillArrayDouble(int num, double downBorder, double topBorder)
{
    // Генератор случайных чисел
    Random numSintezator = new Random();
    // Создаём массив
    double[] arr = new double[num];
    // Тест границ
    
    if (downBorder > topBorder)
    {
        double temp = downBorder;
        downBorder = topBorder;
        topBorder = downBorder;
    }
    // Заполняем массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = numSintezator.NextDouble() * (topBorder - downBorder) + downBorder;
    }
    return arr;
}

// Минимальный элемент массива - вещественные числа
double MinDouble(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

// Максимальный элемент массива - вещественные числа
double MaxDouble(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

// Максимальный элемент массива - целые числа
int MaxInt(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

// Сортировка: метод выбора
int[] SortChoice(int[] arrIn)
{
    int[] arrOut = new int[arrIn.Length];
    arrIn.CopyTo(arrOut, 0);
    for (int i = 0; i < arrIn.Length - 1; i++)
    {
        int minIndex = i;
        int min = arrOut[i];
        for (int j = i + 1; j < arrIn.Length; j++)
        {
            if (arrOut[j] < min)
            {
                min = arrOut[j];
                minIndex = j;
            }

        }
        if (min != arrOut[i])
        {
            int temp = arrOut[minIndex];
            arrOut[minIndex] = arrOut[i];
            arrOut[i] = temp;
        }
    }
    return arrOut;
}

// Сортировка: метод подсчёта
int[] SortCount(int[] arrIn)
{
    int[] arrOut = new int[arrIn.Length];
    arrIn.CopyTo(arrOut, 0);
    int[] arrCount = new int[MaxInt(arrOut) + 1];
    for (int i = 0; i < arrOut.Length; i++)
    {
        arrCount[arrOut[i]]++;
    }
    int index = 0;
    for (int i = 0; i < arrCount.Length; i++)
    {
        while (arrCount[i] != 0)
        {
            arrOut[index++] = i;
            arrCount[i]--;
        }
    }
    return arrOut;
}

// Вывод: результат на консоль - целые числа
void PrintArrayInt(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0,5:d}", array[i]);
    }
    Console.WriteLine();
}

// Вывод: результат на консоль - вещественные числа
void PrintArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0,8:f1}", array[i]);
    }
    Console.WriteLine();
}

// Вывод: результат на консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}