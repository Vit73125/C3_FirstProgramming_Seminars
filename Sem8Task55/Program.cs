//===================================================================================
// # 55 Задайте двумерный массив. Напишите программу, которая заменяет строки на
// столбцы. В случае, если это невозможно, программа должна вывести сообщение для
// пользователя.
//===================================================================================

int countRows = ReadData("Введите число строк: ");
int countCols = ReadData("Введите число столбцов: ");
int[,] arr = Fill2DArrayInt(countRows, countCols, 1, 100);
Print2DArray("Исходный массив:", arr);
if (TestRotate(arr))
    Print2DArray("Массив с заменой строк на столбцы:", Rotate2DArraySwap(arr));
else
    Console.WriteLine("Замена строк на столбцы невозможна");

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

// Проверка: возможность замены в матрице строк на столбцы
bool TestRotate(int [,] arr)
{
    return arr.GetLength(0) == arr.GetLength(1);
}

// Меняет строки на столбцы - метод замены элементов, меньше итераций
int[,] Rotate2DArraySwap(int[,] arr)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
        for (int j = i; j < cols - i; j++)
        {
            int buf = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = buf;
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
