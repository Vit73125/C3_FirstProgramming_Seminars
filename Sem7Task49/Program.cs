//===================================================================================
// # 49 Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
//===================================================================================

int rowsNum = ReadData("Введите количество строк: ");
int colsNum = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArrayInt(rowsNum, colsNum, 0, 100);
Print2DArray("Пересчитанный массив:", arr2D);
Print2DArray("Исходный массив:", Update2dArr(arr2D));

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
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

// Возводит в квадрат элементы с чётными индексами
int[,] Update2dArr(int[,] arr)
{
    int[,] arrBuf = (int[,])arr.Clone();
    for (int i = 0; i < arrBuf.GetLength(0); i += 2)
        for (int j = 0; j < arrBuf.GetLength(1); j += 2)
        {
            arrBuf[i, j] = (int) Math.Pow(arrBuf[i, j], 2);
        }
    return arrBuf;
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
