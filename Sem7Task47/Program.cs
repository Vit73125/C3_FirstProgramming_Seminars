//===================================================================================
// # 47 Задайте двумерный массив размером m × n, заполненный случайными вещественными
// числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16).
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

int rowsNum = ReadData("Введите количество строк: ");
int colsNum = ReadData("Введите количество столбцов: ");
double[,] arr2D = Fill2DArrayDouble(rowsNum, colsNum, -100, 100);
Print2DArrayDouble("Исходный массив:", arr2D);

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполнение двумерного массива случайными числами - вещественные числа
double[,] Fill2DArrayDouble(int countRow, int countCol, double downBorder, double topBorder)
{
    Random numSintezator = new Random();
    double[,] arr = new double[countRow, countCol];
    if (downBorder > topBorder)
    {
        double temp = downBorder;
        downBorder = topBorder;
        topBorder = downBorder;
    }
    for (int i = 0; i < countRow; i++)
        for (int j = 0; j < countCol; j++)
        {
            arr[i, j] = numSintezator.NextDouble() * (topBorder - downBorder)+ downBorder;
        }
    return arr;
}

// Вывод: двумерный массив вещественных чисел с комментарием
void Print2DArrayDouble(string prefix, double[,] arr)
{
    Console.WriteLine(prefix);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            char[] numChar = String.Format("{0,7:f1}", arr[i, j]).ToCharArray();
            PrintCharArrColored(numChar);
        }
        Console.WriteLine();
    }
}

// Печать строки посимвольно разными цветами
void PrintCharArrColored(char[] charArr)
{
    Random rnd = new Random();
    for (int i = 0; i < charArr.Length; i++)
    {
        Console.ForegroundColor = colors[rnd.Next(0, 16)];
        Console.Write(charArr[i]);
    }
    Console.ResetColor();
}