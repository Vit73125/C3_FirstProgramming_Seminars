//===================================================================================
// # 19 Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
//===================================================================================
Dictionary<long, string> PolDict = new Dictionary<long, string>();

long num = ReadData("Введите пятизначное число: ");
PrintResult("Число " + num + " - " + (CheckPolFiveDigit(num) ? "" : "не ") + "полиндром");
GeneratePolDict();
PrintResult("Число " + num + " - " + (CheckPolFiveDigitDict(num) ? "" : "не ") + "полиндром");

num = ReadData("Введите любое число: ");
PrintResult("Число " + num + " - " + (CheckPolAnyNum(num) ? "" : "не ") + "полиндром");

// Ввод: любое число
long ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    long number = long.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Проверка на полиндром 5-значное число. Метод 1

bool CheckPolFiveDigit(long num)
{
    return ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num / 10) % 10));
}

// Проверка на полиндром 5-значное число. Метод 2: Dictionary
bool CheckPolFiveDigitDict(long num)
{
    return PolDict.ContainsKey(num / 1000 * 100 + num % 100);
}

// Заполняем словарь 4-значными полиндромами
void GeneratePolDict()
{
    for (int i = 10; i < 100; i++)
    {
        PolDict.Add(i * 100 + i % 10 * 10 + i / 10, "");
    }
}

// Проверка на полиндром любое число. Метод 3
bool CheckPolAnyNum(long num)
{
    int digNum = (int)Math.Log10(num) + 1;
    int i = 0;
    while (i < digNum)
    {
        int dig1 = (int) (num % (long)Math.Pow(10, digNum - i) / (long)Math.Pow(10, digNum - 1 - i));
        int dig2 = (int) (num % (long)Math.Pow(10, i + 1) / (long)Math.Pow(10, i));
        if (dig1 != dig2) return false;
        i++;
    }
    return true;
}

// Вывод: результат на консоль
void PrintResult(string res)
{
    Console.WriteLine(res);
}