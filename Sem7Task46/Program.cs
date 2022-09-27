//===================================================================================
// # 46 Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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

int countRow = ReadData("Введите количество строк: ");
int countCol = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArrayInt(countRow, countCol, 1, 100);
// Print2DArray("Массив случайных чисел:", arr2D);
Print2DArrayColored("Массив случайных чисел:", arr2D);

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

// Вывод: Число с комментарием
void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
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

// Вывод: двумерный массив целых чисел с комментарием
void Print2DArrayColored(string prefix, int[,] arr)
{
    Console.WriteLine(prefix);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = colors[new System.Random().Next(0, 16)];
            Console.Write("{0,5:d}", arr[i, j]);
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}