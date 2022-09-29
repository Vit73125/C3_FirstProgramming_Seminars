//===================================================================================
// # 62 Напишите программу, которая заполнит спирально массив 4 на 4.
//===================================================================================

using System.Diagnostics;
Stopwatch stw = new Stopwatch();
string tt1;
string tt2;
string tt3;

int rows = 21;
int cols = 21;
int[,] arr = new int[rows, cols];

int iterations1 = 0;
stw.Start();
arr = FillArraySpiral1(arr, ref iterations1);
stw.Stop();
tt1 = stw.Elapsed.ToString();
stw.Reset();
Print2DArray($"Массив, заполненный числами по спирали Вариант 1 ({iterations1} итераций):", arr);
Console.WriteLine();

int iterations2 = 0;
stw.Start();
arr = FillArraySpiral2(arr, ref iterations2);
stw.Stop();
tt2 = stw.Elapsed.ToString();
stw.Reset();
Print2DArray($"Массив, заполненный числами по спирали Вариант 2 ({iterations2} итераций):", arr);
Console.WriteLine();

int iterations3 = 0;
stw.Start();
arr = FillArraySpiral3(arr, ref iterations3);
stw.Stop();
tt3 = stw.Elapsed.ToString();
stw.Reset();
Print2DArray($"Массив, заполненный числами по спирали Вариант 3 ({iterations3} итераций):", arr);

Console.WriteLine();
Console.WriteLine("Вариант 1 - {0,3:d} итераций: " + tt1, iterations1);
Console.WriteLine("Вариант 2 - {0,3:d} итераций: " + tt2, iterations2);
Console.WriteLine("Вариант 3 - {0,3:d} итераций: " + tt3, iterations3);

// Заполняет двумерный массив числами по спирали Вариант 1 - базовый
int[,] FillArraySpiral1(int[,] arr, ref int iterations)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int startRow = 0;
    int stopRow = 0;
    int startCol = 0;
    int stopCol = 0;
    int row = 0;
    int col = 0;
    int count = 0;
    while (count < rows * cols)
    {
        arr[row, col] = count++;
        if (row == startRow && col < cols - stopCol - 1)
            col++;
        else if (col == cols - stopCol - 1 && row < rows - stopRow - 1)
            row++;
        else if (row == rows - stopRow - 1 && col > startCol)
            col--;
        else
            row--;

        if ((row == startRow + 1) && (col == startCol) && (startCol != cols - stopCol - 1))
        {
            startRow++;
            startCol++;
            stopRow++;
            stopCol++;
        }
        
        iterations++;
    }
    return arr;
}

// Заполняет двумерный массив числами по спирали Вариант 2 - базовый, исключение дублирующихся переменных stopRow, stopCol
int[,] FillArraySpiral2(int[,] arr, ref int iterations)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int startRow = 0;
    int startCol = 0;
    int row = 0;
    int col = 0;
    int count = 0;
    while (count < rows * cols)
    {
        arr[row, col] = count++;
        if (row == startRow && col < cols - startCol - 1)
            col++;
        else if (col == cols - startCol - 1 && row < rows - startRow - 1)
            row++;
        else if (row == rows - startRow - 1 && col > startCol)
            col--;
        else
            row--;

        if ((row == startRow + 1) && (col == startCol) && (startCol != cols - startCol - 1))
        {
            startRow++;
            startCol++;
        }
        
        iterations++;
    }
    return arr;
}

// Заполняет двумерный массив числами по спирали Вариант 3 - сокращение итераций в 2 раза
int[,] FillArraySpiral3(int[,] arr, ref int iterations)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int startRow = 0;
    int startCol = 0;
    int row = 0;
    int col = 0;
    int count = 0;
    int countNext = rows + cols - 2;
    while (countNext < rows * cols)
    {
        arr[row, col] = count++;
        arr[rows - row - 1, cols - col - 1] = countNext++;
        if (row == startRow && col < cols - startCol - 1)
            col++;
        else if (col == cols - startCol - 1 && row < rows - startRow - 1)
            row++;
        if ((row == rows - startRow - 1) && (col == cols - startCol - 1))
        {
            col = ++startCol;
            row = ++startRow;
            count = countNext;
            countNext += (startRow + startCol) * 2 - 2;
        }
        
        iterations++;
    }
    return arr;
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
