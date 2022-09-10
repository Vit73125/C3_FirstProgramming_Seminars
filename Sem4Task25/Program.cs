//===================================================================================
// # 25 Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
//===================================================================================

using System;
using System.Diagnostics;

Stopwatch st = new Stopwatch();

int numA = ReadData("Введите число              : ");
int numB = ReadData("Введите показатель степени : ");

// Вариант 1: цикл
st.Start();
long res = MyPow(numA, numB);
st.Stop();
PrintResult("Число " + numA + " в степени " + numB + " равно (Вариант 1 - цикл): " + res);
Console.WriteLine(st.Elapsed);
st.Reset();

// Вариант 2: Pow()
st.Start();
res = MyPow(numA, numB);
st.Stop();
PrintResult("Число " + numA + " в степени " + numB + " равно (Вариант 2 - Math.Pow()): " + res);
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

// Расчёт степени числа Вариант 1: цикл
long MyPow(int numA, int numB)
{
    int i = 1;
    long mult = 1;
    while (i <= numB)
    {
        mult *= numA;
        i++;
    }
    return mult;
}

// Расчёт степени числа Вариант 2: Pow()
long OriginPow(int numA, int numB)
{
    return (long)Math.Pow(numA, numB);
}

// Вывод: результат на консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}