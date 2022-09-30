//===================================================================================
// # 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
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

// Сумма чисел в диапозоне [num1, num2] Вариант 1 - Цикл For
int IntervalSumCycle(int num1, int num2)
{
    if (num1 > num2) SwapNums(ref num1, ref num2);
    int sum = 0;
    for (int i = num1; i <= num2; i++) sum += i;
    return sum;
    
}

// Сумма чисел в диапозоне [num1, num2] Вариант 2-1 - Среднее арифметическое
int IntervalSumArithmetic(int num1, int num2)
{
    if (num1 > num2) SwapNums(ref num1, ref num2);
    return (int)((double)(num2 - num1 + 1) * (double)(num1 + num2) / 2);
}

// Сумма чисел в диапозоне [num1, num2] Вариант 2-2 - Среднее арифметическое, Math.Abs(), без смены границ
int IntervalSumArithmeticAbs(int num1, int num2)
{
    return (int)((double)Math.Abs((num2 - num1 + 1)) * (double)(num1 + num2) / 2);
}

// Сумма чисел в диапозоне [num1, num2] Вариант 3 - Рекурсия
int IntervalSumRec(int num1, int num2)
{
    if (num1 == num2) return num2;
    return num1 + IntervalSumRec(num1 + 1, num2);
}

// Поменять элементы местами
void SwapNums(ref int num1, ref int num2)
{
    int buf;
    buf = num1;
    num1 = num2;
    num2 = buf;
}

// Вывод: число с комментарием
void PrintData(string prefix, long data)
{
    Console.WriteLine(prefix + data);
}

int num1 = ReadData("Введите начало диапозона : ");
int num2 = ReadData("Введите конец диапозона  : ");

// Сумма чисел в диапозоне [num1, num2] Вариант 1 - Цикл For
Console.WriteLine("Сумма чисел от " + num1 + " до " + num2 + " = ");
st.Start();
PrintData("Цикл             : ", IntervalSumCycle(num1, num2));
st.Stop();
string t1 = st.Elapsed.ToString();
st.Reset();

// Сумма чисел в диапозоне [num1, num2] Вариант 2-1 - Среднее арифметическое
st.Start();
PrintData("Формула          : ", IntervalSumArithmetic(num1, num2));
st.Stop();
string t2 = st.Elapsed.ToString();
st.Reset();

// Сумма чисел в диапозоне [num1, num2] Вариант 2-2 - Среднее арифметическое, Math.Abs(), без смены границ
st.Start();
if (num1 > num2) SwapNums(ref num1, ref num2);
PrintData("Формула Math.Abs : ", IntervalSumArithmeticAbs(num1, num2));
st.Stop();
string t3 = st.Elapsed.ToString();
st.Reset();

// Сумма чисел в диапозоне [num1, num2] Вариант 3 - Рекурсия
st.Start();
PrintData("Рекурсия         : ", IntervalSumRec(num1, num2));
st.Stop();
string t4 = st.Elapsed.ToString();
st.Reset();

Console.WriteLine("Цикл             : " + t1);
Console.WriteLine("Формула          : " + t2);
Console.WriteLine("Формула Math.Abs : " + t3);
Console.WriteLine("Рекурсия         : " + t4);
