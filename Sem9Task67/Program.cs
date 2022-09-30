//===================================================================================
// # 67 Напишите программу, которая принимает на вход число N и возвращает сумму его
// цифр
//===================================================================================

// Ввод: любое число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Вычисление: сумма чисел
int RecSumDig(int num)
{
    if (num == 0) return 0;
    return num % 10 + RecSumDig(num / 10);
}

// Вывод: Число с комментарием
void PrintData(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}

int num = ReadData("Введите число N: ");
PrintData("Сумма цифр числа: ", RecSumDig(num));