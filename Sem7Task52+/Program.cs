//===================================================================================
// # 52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить
// разным цветом.
//===================================================================================

ConsoleColor[] colors = new ConsoleColor[] {ConsoleColor.Black,
                                            ConsoleColor.Blue,
                                            ConsoleColor.Cyan,
                                            ConsoleColor.DarkBlue,
                                            ConsoleColor.DarkCyan,
                                            ConsoleColor.DarkGray,
                                            ConsoleColor.DarkGreen,
                                            ConsoleColor.DarkMagenta,
                                            ConsoleColor.DarkRed,
                                            ConsoleColor.DarkYellow,
                                            ConsoleColor.Gray,
                                            ConsoleColor.Green,
                                            ConsoleColor.Magenta,
                                            ConsoleColor.Red,
                                            ConsoleColor.White,
                                            ConsoleColor.Yellow};

int countRows = ReadData("Введите число строк: ");
int countCols = ReadData("Введите число столбцов: ");
int[,] arr = Fill2DArrayInt(countRows, countCols, 1, 100);
ConsoleColor[,] arrColors = new ConsoleColor[countRows, countCols];

// Среднее арифметическое по столбцам
Print2DArray("Массив случайных чисел:", arr);
PrintArrayDouble("Среднее арифметическое по столбцам:", ColsAverage(arr));

// Среднее арифметическое по диагоналям
double[] diags = DiagsAverageColored(arr, arrColors);
Print2DArrayColored("Диагонали массива", arr, arrColors);
PrintArrayDouble("Среднее арифметическое по дигоналям:", diags);

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

// Возврашает столбец двумерного массива
int[] GetCol(int[,] arrIn, int colNum)
{
    int[] arrOut = new int[arrIn.GetLength(0)];
    for (int i = 0; i < arrIn.GetLength(0); i++)
        arrOut[i] = arrIn[i, colNum];
    return arrOut;
}

// Подсчитывает среднее арифметическое в каждом столбце
double[] ColsAverage(int[,] arr)
{
    double[] colsAverage = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
        colsAverage[i] = GetCol(arr, i).Average();
    return colsAverage;
}

double[] DiagsAverageColored(int[,] arr, ConsoleColor[,] arrColors)
{
    System.Random rnd = new System.Random();
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int diags = rows + cols - 1;
    double[] averages = new double[diags];
    for (int i = 0; i < diags; i++)
    {
        int row = i < rows ? rows - i - 1 : 0;
        int col = i < rows ? 0 : i - rows + 1;
        double sum = 0;
        int count = 1;
        ConsoleColor color = colors[rnd.Next(1, 16)];
        while (row < rows && col < cols)
        {
            sum += (double) arr[row, col];
            arrColors[row, col] = color;
            count++;
            row++;
            col++;
        }
        averages[i] = sum / count;
    }
    return averages;
}

// Вывод: одномерный массив с комментарием - вещественные числа
void PrintArrayDouble(string prefix, double[] arr)
{
    Console.WriteLine(prefix);
    for (int i = 0; i < arr.Length; i++)
        Console.Write("{0,5:f1}", arr[i]);
    Console.WriteLine();
}

// Вывод: двумерный массив целых чисел с выделенной диагональю: 0 - прямая, другое - обратная
void Print2DArrayColored(string prefix, int[,] arr, ConsoleColor[,] arrColors)
{
    Console.WriteLine(prefix);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            PrintColoredNum("{0,5:d}", arr[i, j], arrColors[i, j]);
        }
        Console.WriteLine();
    }
}

// Вывод числа, выделенного цветом
void PrintColoredNum (string format, int num, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(format, num);
    Console.ResetColor();
}

// Вывод: двумерный массив целых чисел с выделенной диагональю: 0 - прямая, другое - обратная
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

// Вывод: Число с комментарием
void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}
