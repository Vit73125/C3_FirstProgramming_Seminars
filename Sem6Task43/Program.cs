//===================================================================================
// # 43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем. 
//===================================================================================

Console.WriteLine("Введите коэффициенты линейного уравнения y = k * x + b");
double[,] kb = ReadArgs("Уравнение ", "k", "b", 3);
Console.WriteLine("Вы задали уравнения 3-х прямых для поиска точки пересечения:");
PrintLinEqs(kb);

double[,] xy = CrossPoints(kb);
string[] lines = CrossLineNames(xy);
Console.WriteLine("Координаты точек пересечения прямых:");
PrintXY(lines, xy);
PrintResultDouble("Площадь треугольника, образованного пересекающимися прямыми: ", TriangleSquare(xy));

// Ввод: массива из набора пар параметров заданного количества, передаются наименования параметров и количество пар
double[,] ReadArgs(string message, string argName1, string argName2, int count)
{
    double[,] data = new double[count, 2];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(message + $"[{i + 1}]");
        Console.Write(argName1 + ": ");
        data[i, 0] = double.Parse(Console.ReadLine() ?? "0");
        Console.Write(argName2 + ": ");
        data[i, 1] = double.Parse(Console.ReadLine() ?? "0");
    }
    return data;
}

// Подсчитывает точки пересечения произвольного числа прямых, заданных линейными уравнениями с коэффициентами -
// передаются в двумерном массиве
double[,] CrossPoints(double[,] kb)
{
    int countLines = kb.GetUpperBound(0) + 1;
    int index = 0;
    double[,] xy = new double[CountCombs(countLines, 2), 4];
    for (int i = 0; i < countLines - 1; i++)
        for (int j = i + 1; j < countLines; j++)
        {
            xy[index, 0] = (kb[i, 1] - kb[j, 1]) / (kb[j, 0] - kb[i, 0]);
            xy[index, 1] = (kb[i, 1] * kb[j, 0] - kb[j, 1] * kb[i, 0]) / (kb[j, 0] - kb[i, 0]);
            xy[index, 2] = i + 1;
            xy[index, 3] = j + 1;
            index++;
        }
    return xy;
}

// Строки - наименования пересекающихся прямых
string[] CrossLineNames(double[,] xy)
{
    int count = xy.GetUpperBound(0) + 1;
    string[] names = new string[count];
    for (int i = 0; i < count; i++)
         names[i] = $"[{xy[i, 2]}-{xy[i, 3]}]";
    return names;
}

// Вычисление: число сочетаний
int CountCombs(int total, int sub)
{
    return (int) (Fact(total) / Fact(sub) * Fact(total - sub));
}

// Вычисление: факториал
long Fact(int k)
{
    if (k < 0) return -1;
    long buf = 1;
    for (int i = 2; i <= k; i++)
        buf *= i;
    return buf;
}

// Вычисление: Площадь треугольника с заданными коодринатами вершин - массив из пар координат
double TriangleSquare(double[,] xy)
{
    if (xy.GetUpperBound(0) != 2)
    {
        Console.WriteLine("Набор прямых не образует прямоугольник");
        return -1;
    }
    else
        return Math.Abs((xy[1, 0] - xy[0, 0]) * (xy[2, 1] - xy[0, 1]) - (xy[2, 0] - xy[0, 0]) * (xy[1, 1] - xy[0, 1])) / 2;
}

// Вывод: формулы линейных уравнений, параметры передаются в двумерном массиве
void PrintLinEqs(double[,] args)
{
    for (int i = 0; i < args.GetUpperBound(0) + 1; i++)
    {
        Console.WriteLine($"[{i + 1}] " + "y = {0,4:f1} * x + {1,4:f1}", args[i, 0], args[i, 1]);
    }
}

// Вывод: коодринаты - массив вещественных чисел
void PrintXY(string[] prefix, double[,] args)
{
    for (int i = 0; i < args.GetUpperBound(0) + 1; i++)
    {
        Console.WriteLine($"{prefix[i]} " + "({0,4:f1}; {1,4:f1})", args[i, 0], args[i, 1]);
    }
}

void PrintResultDouble(string comment, double num)
{
    Console.WriteLine(comment + "{0,4:f2}", num);
}