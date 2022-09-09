//===================================================================================
// # 20 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
//===================================================================================

int x1 = ReadData("Введите координаты 1-й точки (x1): ");
int y1 = ReadData("Введите координату 1-й точки (y1): ");
int z1 = ReadData("Введите координату 1-й точки (z1): ");
int x2 = ReadData("Введите координату 2-й точки (x2): ");
int y2 = ReadData("Введите координату 2-й точки (y2): ");
int z2 = ReadData("Введите координату 2-й точки (z2): ");

PrintResult(Math.Round(CalculateDistance(x1, y1, x2, y2, z1, z2), 1));

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

// Вычисление: расстояние между двумя точками
double CalculateDistance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
}

// Вывод: результат на консоль
void PrintResult(double res)
{
    Console.WriteLine(res);
}