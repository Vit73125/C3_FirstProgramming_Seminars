//===================================================================================
// # 52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить
// разным цветом.
//===================================================================================

int countRows = ReadData("Введите число строк: ");
int countCols = ReadData("Введите число столбцов: ");
int[,] arr2D = Fill2DArrayInt(countRows, countCols, 1, 100);

// Средние арифметические по столбцам
Print2DArrayInt("Массив случайных чисел:", arr2D);
PrintArrayDouble("Среднее арифметическое по столбцам:", ColsAverage(arr2D));

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Ввод: заполнение двумерного массива случайными числами - целые числа
int[,] Fill2DArrayInt(int countRow, int countCol, int downBorder, int topBorder)
{
    Random numSintezator = new Random();
    int[,] arr = new int[countRow, countCol];
    if (downBorder > topBorder)
    {
        int temp = downBorder;
        downBorder = topBorder;
        topBorder = downBorder;
    }
    for (int i = 0; i < countRow; i++)
        for (int j = 0; j < countCol; j++)
        {
            arr[i, j] = numSintezator.Next(downBorder, topBorder + 1);
        }
    return arr;
}

// Получение: столбец двумерного массива
int[] GetCol(int[,] arrIn, int colNum)
{
    int[] arrOut = new int[arrIn.GetLength(0)];
    for (int i = 0; i < arrIn.GetLength(0); i++)
        arrOut[i] = arrIn[i, colNum];
    return arrOut;
}

// Вычисление: средние арифметические по столбцам
double[] ColsAverage(int[,] arr)
{
    double[] colsAverage = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
        colsAverage[i] = GetCol(arr, i).Average();
    return colsAverage;
}

// Вывод: двумерный массив с комментарием - целые числа
void Print2DArrayInt(string prefix, int[,] arr)
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

// Вывод: одномерный массив с комментарием - вещественные числа
void PrintArrayDouble(string prefix, double[] arr)
{
    Console.WriteLine(prefix);
    for (int i = 0; i < arr.Length; i++)
        Console.Write("{0,5:f1}", arr[i]);
    Console.WriteLine();
}
