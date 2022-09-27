//===================================================================================
// # 50 Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента
// нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
//===================================================================================

int row = ReadData("Введите номер строки (1-5): ");
int col = ReadData("Введите номер столбца (1-10): ");
int[,] arr2D = Fill2DArrayInt(10, 15, 1, 100);
Print2DArrayInt("Массив случайных чисел:", arr2D);
if (HasNum(arr2D, row - 1, col - 1)) {
    PrintResult("Элемент в массиве с указанным адресом: ", arr2D[row - 1, col - 1]);
}
else
{
    Console.WriteLine("Такого элемента в массиве нет");
}

// *Числа Фибоначчи
row = ReadData("Введите номер строки (1-4): ");
col = ReadData("Введите номер столбца (1-5): ");
int[,] arr2DFib = Fill2DArrayFibNums(4, 5);
if (HasNum(arr2DFib, row - 1, col - 1)) {
    Print2DArrayColoredNum("Массив чисел Фибоначчи:", arr2DFib, row - 1, col - 1);
}
else
{
    Print2DArrayInt("Массив чисел Фибоначчи:", arr2DFib);
    Console.WriteLine("Такого элемента в массиве нет");
}

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполнение двумерного массива случайными числами - целые числа
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

// Построчно заполняет двумерный массив числами Фибоначчи
int[,] Fill2DArrayFibNums(int countRow, int countCol)
{
    int[,] fibNums = new int[countRow, countCol];
    fibNums[0, 0] = 0;
    fibNums[0, 1] = 1;
    int buf1 = 0;
    int buf2 = 1;
    for (int i = 0; i < countRow; i++)
        for (int j = (i > 0 ? 0 : 2); j < countCol; j++)
        {
            fibNums[i, j] = buf1 + buf2;
            buf1 = buf2;
            buf2 = fibNums[i, j];
        }
    return fibNums;
}

// Проверяет, есть ли адрес в массиве
bool HasNum(int[,] arr, int row, int col)
{
    return row <= arr.GetLength(0) && col <= arr.GetLength(1);
}

// Вывод: двумерный массив целых чисел с комментарием
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

// Вывод: двумерный массив целых чисел с выделенным элементом
void Print2DArrayColoredNum(string prefix, int[,] arr, int row, int col)
{
    Console.WriteLine(prefix);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == row && j == col)
            {
                PrintColoredNum("{0,5:d}", ConsoleColor.Red, arr[i, j]);
            }
            else
            {
                Console.Write("{0,5:d}", arr[i, j]);
            }
        }
        Console.WriteLine();
    }
}

// Вывод числа, выделенного цветом
void PrintColoredNum (string format, ConsoleColor color, int num)
{
    Console.ForegroundColor = color;
    Console.Write(format, num);
    Console.ResetColor();
}

// Вывод: Число с комментарием
void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}
