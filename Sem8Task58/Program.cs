//===================================================================================
// # 58 Задайте две матрицы. Напишите программу, которая будет находить произведение
// двух матриц.
//===================================================================================

int countRows1 = ReadData("Введите число строк 1-й матрицы: ");
int countCols1 = ReadData("Введите число столбцов 1-й матрицы: ");
int countRows2 = ReadData("Введите число строк 2-й матрицы: ");
int countCols2 = ReadData("Введите число столбцов 2-й матрицы: ");
int[,] arr1 = Fill2DArrayInt(countRows1, countCols1, 1, 5);
int[,] arr2 = Fill2DArrayInt(countRows2, countCols2, 1, 5);
Print2DArray("Исходный массив:", arr1);
Print2DArray("Исходный массив:", arr2);
if (TestMUltMatrix(arr1, arr2))
    Print2DArray("Произведение матриц: ", MultMatrix(arr1, arr2));
else
    Console.WriteLine("Произведение матриц невозможно");

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Ввод: Заполнение двумерного массива случайными числами - целые числа
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

// Вычисление: произведение двух матриц
int[,] MultMatrix(int[,] arr1, int[,] arr2)
{
    int[,] arrOut = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
        for (int j = 0; j < arr2.GetLength(1); j++)
            for (int k = 0; k < arr2.GetLength(0); k++)
                arrOut[i, j] += arr1[i, k] * arr2[k, j];
    return arrOut;
}

// Проверка возможности умножения матриц
bool TestMUltMatrix(int[,] arr1, int[,] arr2)
{
    return arr1.GetLength(1) == arr2.GetLength(0);
}

// Вывод: двумерный массив с комментарием - целые числа
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
