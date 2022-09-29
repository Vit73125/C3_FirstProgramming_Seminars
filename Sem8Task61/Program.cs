//===================================================================================
// # 61 Вывести первые N строк треугольника Паскаля. Сделать вывод в виде
// равнобедренного треугольника.
//===================================================================================

int rows = ReadData("Введите количество строк треугольника Паскаля: ");
PrintPascalTriangle(rows);

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Вычисление: факториал
long Factorial(int k)
{
    if (k < 0) return -1;
    long buf = 1;
    for (int i = 2; i <= k; i++)
        buf *= i;
    return buf;
}

// Вывод: первые N строк треугольника Паскаля
void PrintPascalTriangle(int rows)
{
    for (int i = 0; i < rows; i++)
    {
        // создаём после каждой строки n-i отступов от левой стороны консоли, 
        // чем ниже строка, тем меньше отступ
        for (int j = 0; j <= (rows - i); j++)
            Console.Write(" ");
        for (int j = 0; j <= i; j++)
        {
            // создаём пробелы между элементами треугольника
            Console.Write(" ");
            //формула вычисления элементов треугольника
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
        }
        Console.WriteLine();
        // после каждой строки с числами отступаем две пустые строчки
        Console.WriteLine();
    }
}