//===================================================================================
// # 42 Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
//===================================================================================

int inputNumber = ReadData("Введите число: ");

PrintResult("Исходное число в бинарном формате Вариант 1: ", BinConvert(inputNumber));
PrintResult("Исходное число в бинарном формате Вариант 2: ", BinConvertToString(inputNumber));

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

// Переводит десятичное число в двоичное Вариант 1: 
string BinConvert(int num)
{
    string res = String.Empty;
    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }

    return res;
}

// Переводит десятичное число в двоичное Вариант 2: ToString
string BinConvertToString(int num)
{
    return Convert.ToString(num, 2);
}

// Вывод: результат на консоль
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}