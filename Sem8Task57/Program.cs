//===================================================================================
// # 57 Составить частотный словарь элементов двумерного массива. Частотный словарь
// содержит информацию о том, сколько раз встречается элемент входных данных.
//===================================================================================

int countRows = ReadData("Введите число строк: ");
int countCols = ReadData("Введите число столбцов: ");
int min = 1;
int max = 10;
int[,] arr = Fill2DArrayInt(countRows, countCols, min, max);
Print2DArray("Исходный массив:", arr);
PrintFreqArray("Частотный словарь", FreqDicLoad(arr));

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

// Создаёт частотный словарь из двумерного массива целых чисел
int[] FreqDicLoad(int [,] arr)
{
    int[] dic = new int[max + 1];
    foreach (int num in arr) dic[num]++;
    return dic;
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

// Вывод: массив целых чисел с комментарием
void PrintFreqArray(string prefix, int[] arr)
{
    Console.WriteLine(prefix);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("{0,3:d} - {1,3:d}", i, arr[i]);
    }
    // Console.WriteLine();
}
