//===================================================================================
// # 59 Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент массива.
//===================================================================================

int countRows = ReadData("Введите число строк: ");
int countCols = ReadData("Введите число столбцов: ");
int[,] arr = Fill2DArrayInt(countRows, countCols, 0, 100);
Print2DArray("Исходный массив:", arr);
int x = 0;
int y = 0;
FindMin(arr, ref x, ref y);
PrintResult($"Минимальный элемент в массиве: ({x}, {y}) ", arr[x, y]);
Print2DArray("Массив без минимального элемента: ", CreateArr(arr, x, y));

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

// Получить индекс минимального элемента
void FindMin(int[,] arr, ref int x, ref int y)
{
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                x = i;
                y = j;
            }
        }
    }
}

// Создать массив
int[,] CreateArr(int[,] arr, int x, int y)
{
    int[,] arrOut = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int kx = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int ky = 0;
        if (i != x)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                if (j != y)
                {
                    arrOut[kx, ky] = arr[i, j];
                    ky++;
                }
            kx++;
        }
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

// Вывод: Число с комментарием
void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}
