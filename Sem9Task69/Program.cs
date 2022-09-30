//===================================================================================
// # 69 Напишите программу, которая принимает на вход два числа A и B. Возведите
// число A в целую степень числа B с помощью рекурсии.
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

// Расчёт степени числа Вариант 1-1: цикл While
long WhileCyclePow(int numA, int numB)
{
    long mult = 1;
    int i = 2;
    while (i <= numB)
    {
        mult *= numA;
        i++;
    }
    return mult;
}

// Расчёт степени числа Вариант 1-2: цикл for
long ForCyclePow(int numA, int numB)
{
    long mult = 1;
    for (int i = 2; i <= numB; i++)
    {
        mult *= numA;
    }
    return mult;
}

// Расчёт степени числа Вариант 2: Pow()
long MathPow(int numA, int numB)
{
    return (long)Math.Pow(numA, numB);
}

// Расчёт степени числа Вариант 3: рекурсия
long RecPow(int numA, int numB)
{
    if (numB == 1) return numA;
    return numA * RecPow(numA, numB - 1);
}

// Вывод: Число с комментарием
void PrintData(string prefix, long data)
{
    Console.WriteLine(prefix + data);
}

int numA = ReadData("Введите число              : ");
int numB = ReadData("Введите показатель степени : ");
long res;

// Расчёт степени числа Вариант 1-1: цикл While
st.Start();
PrintData(numA + " в степени " + numB + " = ", WhileCyclePow(numA, numB));
st.Stop();
string t1 = st.Elapsed.ToString();
st.Reset();

// Расчёт степени числа Вариант 1: цикл For
st.Start();
PrintData(numA + " в степени " + numB + " = ", ForCyclePow(numA, numB));
st.Stop();
string t2 = st.Elapsed.ToString();
st.Reset();

// Расчёт степени числа Вариант 2: Pow()
st.Start();
PrintData(numA + " в степени " + numB + " = ", MathPow(numA, numB));
st.Stop();
string t3 = st.Elapsed.ToString();
st.Reset();

// Расчёт степени числа Вариант 3: Рекурсия
st.Start();
PrintData(numA + " в степени " + numB + " = ", RecPow(numA, numB));
st.Stop();
string t4 = st.Elapsed.ToString();
st.Reset();

Console.WriteLine("Цикл While : " + t1);
Console.WriteLine("Цикл For   : " + t2);
Console.WriteLine("Math       : " + t3);
Console.WriteLine("Рекурсия   : " + t4);
