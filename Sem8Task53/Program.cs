//===================================================================================
// # 53 Задайте двумерный массив. Напишите программу, которая поменяет местами первую
// и последнюю строку массива.
//===================================================================================

int countRows = ReadData("Введите число строк: ");
int countCols = ReadData("Введите число столбцов: ");
int[,] arr = Fill2DArrayInt(countRows, countCols, 1, 100);
Print2DArray("Исходный массив:", arr);
Print2DArray("Массив с заменой первой и последней строк:", Change2DArray(arr));

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

// Меняет местами первую и последнюю строки двумерного массива
int[,] Change2DArray(int[,] arr)
{
    int[,] arrOut = (int[,])arr.Clone();
    for (int i = 0; i < arrOut.GetLength(1); i++)
    {
        int buf = arrOut[0, i];
        arrOut[0, i] = arrOut[arrOut.GetLength(0) - 1, i];
        arrOut[arrOut.GetLength(0) - 1, i] = buf;
    }
    return arrOut;
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
