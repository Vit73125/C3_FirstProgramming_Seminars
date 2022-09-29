//===================================================================================
// # 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
//===================================================================================

int countRows = ReadData("Введите число строк: ");
int countCols = ReadData("Введите число столбцов: ");
int[,] arr = Fill2DArrayInt(countRows, countCols, 1, 100);
Print2DArray("Исходный массив:", arr);
PrintResult("Строка с наименьшей суммой элементов: ", FindMinRow(arr));

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

// Находит номер строки с минимальной суммой элементов
int FindMinRow(int[,] arr)
{
    int minRowIndex = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            sum += arr[i, j];
        if (sum < minSum)
        {
            minSum = sum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
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

// Вывод: Число с комментарием
void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}
