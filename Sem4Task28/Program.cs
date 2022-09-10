//===================================================================================
// # 28 Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
//===================================================================================

using System;
using System.Diagnostics;

Stopwatch st = new Stopwatch();

int num = ReadData("Введите число: ");

st.Start();
long res = MultA(num);
st.Stop();
PrintResult("Произведение чисел от 1 до " + num + " равно: " + res);
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

// Расчёт произвдения чисел от 1 до N
long MultA(int numA)
{
    int i = 2;
    long mult = 1;
    while (i <= numA)
    {
        mult *= i;
        i++;
    }
    return mult;
}

// Вывод: результат на консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}