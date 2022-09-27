//===================================================================================
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится
// по формуле: A(mn) = m + n. Выведите полученный массив на экран.
//===================================================================================

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArrayMNInt(m, n);
Print2DArray("Массив случайных чисел:", arr2D);

// Ввод: любое число
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Заполнение двумерного массива случайными числами - Целые числа
int[,] Fill2DArrayMNInt(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = i + j;
        }
    return arr;
}

// Вывод: двумерный массив целых чисел с комментарием
void Print2DArray(string prefix, int[,] arr)
{
    Console.WriteLine(prefix);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,5:d}", arr[i, j]);
        }
        Console.WriteLine();
    }
}
