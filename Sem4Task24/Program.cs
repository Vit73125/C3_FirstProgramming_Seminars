//===================================================================================
// # 24 Напишите программу, которая принимает на вход число A и выдаёт
// сумму от 1 до A.
//===================================================================================

using System;
using System.Diagnostics;

Stopwatch st = new Stopwatch();

int num = ReadData("Введите число: ");

st.Start();
int res = VariantSumSimple(num);
st.Stop();
PrintResult("Сумма чисел от 1 до " + num + " равна (простой метод): " + res);
Console.WriteLine(st.Elapsed);
st.Reset();


st.Start();
res = VariantSumGause(num);
st.Stop();
PrintResult("Сумма чисел от 1 до " + num + " равна (метод Гауса)  : " + res);
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

// Расчёт суммы целых чисел Вариант 1: цикл
int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 0; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

// Расчёт суммы целых чисел Вариант 2: формула Гауса
int VariantSumGause(int numA)
{
    int sumOfNumbers = ((1 + numA) * numA / 2);
    return sumOfNumbers;
}

// Вывод: результат на консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}