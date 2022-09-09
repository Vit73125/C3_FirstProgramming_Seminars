//===================================================================================
// # 13 Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//===================================================================================
using System;
using System.Diagnostics;

Stopwatch st = new Stopwatch();
TimeSpan tt;

int inputNumber = 0;
int result = 0;

ReadData();
Console.WriteLine("Вариант 1: Цикл");
st.Start();
CalculateData1();
st.Stop();
tt = st.Elapsed;
PrintData();
Console.WriteLine(tt);

Console.WriteLine("Вариант 2: Логарифм");
st.Start();
CalculateData2();
st.Stop();
tt = st.Elapsed;
PrintData();
Console.WriteLine(tt);

// Ввод: любое число
void ReadData()
{
    Console.Write("Введите число: ");
    string? inputLine = Console.ReadLine();
    if (inputLine != null) inputNumber = int.Parse(inputLine);

}

// Вычисление: третья цифра, если есть. Вариант 1: цикл.
void CalculateData1()
{
    int temp = inputNumber;
    while (temp >= 1000) temp = temp / 10;
    result = inputNumber < 100 ? -1 : temp % 10;
}

// Вычисление: третья цифра, если есть. Вариант 2: логарифм.
void CalculateData2()
{
    int powNum = (int) Math.Log10(inputNumber);
    result = powNum > 1? inputNumber / (int) Math.Pow(10, powNum - 2) % 10 : -1;
}

// Вывод: результат на консоль
void PrintData() {
    Console.WriteLine(result != -1 ? result : "третьей цифры нет");
}