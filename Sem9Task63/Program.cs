//===================================================================================
// # 63 Задайте значение N. Напишите программу, которая выдаёт все натуральные числа
// в промежутке от 1 до N.
//===================================================================================

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Возвращает строку из чисел от 1 до N
string LineGenRec(int numN)
{
    // Точка остановки
    if (numN == 0) return string.Empty;
    string outLine = LineGenRec(numN - 1) + " " + numN;
    return outLine;
}

// Вывод: строка
void PrintResult(string res)
{
    Console.WriteLine(res);
}

int numN = ReadData("Введите число N: ");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);