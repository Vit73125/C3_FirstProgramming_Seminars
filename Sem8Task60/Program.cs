//===================================================================================
// # 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите
// программу, которая будет построчно выводить массив, добавляя индексы каждого
// элемента.
//===================================================================================

int[] lenDims = new int[3];
lenDims[0] = ReadData("Введите размер 1: ");
lenDims[1] = ReadData("Введите размер 2: ");
lenDims[2] = ReadData("Введите размер 3: ");
int min = 0;
int max = 100;
if (TestFillMDArray(lenDims, max - min))
{
    int[,,] arr = Fill3DArrayInt(lenDims[0], lenDims[1], lenDims[2], min, max);
    Print3DArray("Исходный массив:", arr);
}
else
    Console.WriteLine("Размер массива превышает допустимый");

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Ввод: Генератор списка случайных чисел
List<int> FillList(int downBorder, int topBorder)
{
    List<int> numList = new List<int>();
    for (int i = downBorder; i <= topBorder; i++)
        numList.Add(i);
    return numList;
}

// Проверка достаточного размера массива для ввода неповторяющихся чисел
bool TestFillMDArray(int[] lenDims, int limitSize)
{
    int mult = 1;
    foreach (int len in lenDims)
        mult *= len;
    return mult <= limitSize;
}

// Ввод: Заполнение двумерного массива неповторяющимися случайными числами - целые числа
int[,,] Fill3DArrayInt(int lenDim1, int lenDim2, int lenDim3, int downBorder, int topBorder)
{
    Random rnd = new Random();
    int[,,] arr = new int[lenDim1, lenDim2, lenDim3];
    List<int> bufList = FillList(downBorder, topBorder);
    if (downBorder > topBorder)
    {
        int temp = downBorder;
        downBorder = topBorder;
        topBorder = downBorder;
    }
    int count = 0;
    for (int i = 0; i < lenDim1; i++)
        for (int j = 0; j < lenDim2; j++)
            for (int k = 0; k < lenDim3; k++)
            {
                int index = rnd.Next(0, topBorder - downBorder - count++);
                arr[i, j, k] = bufList[index];
                bufList.RemoveAt(index);
            }
    return arr;
}

// Вывод: трёхмерный массив с комментарием, с индексами - целые числа
void Print3DArray(string prefix, int[,,] arr)
{
    Console.WriteLine(prefix);
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
                Console.Write("{0,3:d2} (" + i + "," + j + "," + k + ") ", arr[i, j, k]);
            Console.WriteLine();
        }
}
