//===================================================================================
// # 27 Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
//===================================================================================

using System;
using System.Diagnostics;

Stopwatch st = new Stopwatch();

int num = ReadData("Введите число: ");

st.Start();
int res = DigitSum(num);
st.Stop();
PrintResult("Сумма цифр числа " + num + " равна: " + res);
Console.WriteLine(st.Elapsed);

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

// Расчёт суммы цифр числа
int DigitSum(int num) {
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

// Вывод: результат на консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}