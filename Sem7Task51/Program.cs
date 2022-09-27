//===================================================================================
// # 51 Задайте двумерный массив. Найдите сумму элементов, находящихся на главной
// диагонали (с индексами (0,0); (1;1) и т.д.
//===================================================================================

int rowsNum = ReadData("Введите количество строк: ");
int colsNum = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArrayInt(rowsNum, colsNum, 0, 100);
Print2DArray("Исходный массив:", arr2D);
PrintResult("Сумма элементов на главной диагонали массива: ", Sum2DArrMainDiag(arr2D));

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

// Сумма элементов на главной диагонали двумерного массива
int Sum2DArrMainDiag(int[,] arr)
{
    int sum = 0;
    int len = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);
    for (int i = 0; i < len; i++)
        sum += arr[i, i];
    return sum;
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

// Вывод: Число с комментарием
void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}
