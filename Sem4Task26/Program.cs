//===================================================================================
// # 26 Напишите программу, которая принимает на вход число A и выдаёт
// количество цифр числа.
//===================================================================================

using System;
using System.Diagnostics;

Stopwatch st = new Stopwatch();

int num = ReadData("Введите число: ");

// Вариант 1: цикл
st.Start();
int res = DigitCountCycle(num);
st.Stop();
PrintResult("В числе " + num + " - " + res + " цифр");
Console.WriteLine(st.Elapsed);
st.Reset();

// Вариант 2: строка
st.Start();
res = DigitCountString(num);
st.Stop();
PrintResult("В числе " + num + " - " + res + " цифр");
Console.WriteLine(st.Elapsed);
st.Reset();

// Вариант 3: логарифм
st.Start();
res = DigitCountLog(num);
st.Stop();
PrintResult("В числе " + num + " - " + res + " цифр");
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

// Расчёт количества цифр числа Вариант 1: цикл
int DigitCountCycle(int num) {
    int sum = 0;
    while (num > 0)
    {
        sum ++;
        num /= 10;
    }
    return sum;
}

int DigitCountString(int num) {
    string numToString = num.ToString();
    return numToString.Length;
}

// Расчёт количества цифр числа Вариант 3: логарифм
int DigitCountLog(int num) {
    return (int)Math.Log10(num) + 1;
}

// Вывод: результат на консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}