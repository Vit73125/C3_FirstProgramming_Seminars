//===================================================================================
// # 64 Задайте значение N. Напишите программу, которая выдаёт все натуральные числа
// в промежутке от N до 1.
//===================================================================================

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Возвращает строку из чисел от N до 1
string LineGenRec(int numN)
{
    // Точка остановки
    if (numN == 0) return string.Empty;
    string outLine = numN + " " + LineGenRec(numN - 1);
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