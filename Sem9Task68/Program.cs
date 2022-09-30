//===================================================================================
// # 68 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m, n) = 9
// m = 3, n = 2 -> A(m, n) = 29
//===================================================================================

using System.Diagnostics;
Stopwatch st = new Stopwatch();

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Функция Аккермана
long Ackerman(long m, long n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackerman(m - 1, 1);
    else
        return Ackerman(m - 1, Ackerman(m, n - 1));

}

// Вывод: число с комментарием
void PrintData(string prefix, long data)
{
    Console.WriteLine(prefix + data);
}

Console.WriteLine("Введите аргументы функции Аккермана:");
int num1 = ReadData("1-е неотрицательное число: ");
int num2 = ReadData("2-е неотрицательное число: ");
PrintData("Значение функции Аккермана: ", Ackerman(num1, num2));