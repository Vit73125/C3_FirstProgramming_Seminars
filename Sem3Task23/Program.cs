//===================================================================================
// # 20 Напишите программу, которая принимает на вход число N и выдаёт
// таблицу кубов чисел от 1 до N.
//===================================================================================

int num = ReadData("Введите число: ");

Console.WriteLine("Печать таблицы Вариант 1");
PrintResult(HeadLine(num));
PrintResult(CalculateLine1(num, 3));
Console.WriteLine("Печать таблицы Вариант 2");
PrintResult(CalculateLine2(num, 1, 5));
PrintResult(CalculateLine2(num, 3, 5));

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

// Cтрока: Шапка таблицы. Вариант 1: String.Format()
string HeadLine(int num) {
    String res = "";
    int i = 0;
    while(i <= num)
    {
        res = res + String.Format("{0,5:d}", i);
        i++;
    }
    return res;
}

// Строка: Степени чисел в соответствии с указанными в шапке таблицы. Вариант 1: String.Format()
string CalculateLine1(int num, int pow)
{
    String res = "";
    int i = 0;
    while(i <= num)
    {
        res = res + String.Format("{0,5:d}", (int)Math.Pow(i, pow));
        i++;
    }
    return res;
}

// Строка: Степени чисел в соответствии с указанными в шапке таблицы. Вариант 2: Дополнение пробелов
string CalculateLine2(int num, int pow, int len)
{
    String res = "";
    int i = 0;
    while(i <= num)
    {
        res = res + ToFormatString((int)Math.Pow(i, pow), len);
        i++;
    }
    return res;
}

// Перевод числа в строку фиксированной длины
string ToFormatString(int num, int len)
{
    string numToString = num.ToString();
    int spacesLen = len - numToString.Length;
    if (spacesLen > 0)
        numToString = new String(' ', len - numToString.Length) + numToString;
    else
        Console.WriteLine("Ошибка: надостаточная ширина столбца. Требуется большая величина");
    return numToString;
}

// Вывод: результат на консоль
void PrintResult(string res)
{
    Console.WriteLine(res);
}