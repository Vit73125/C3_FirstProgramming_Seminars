//===================================================================================
// # 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0
// ввёл пользователь.
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает
// сколько чисел больше 0 было введено. 
//===================================================================================

using System.Globalization;

double[] inputArr = ParseNums(ReadLine("Введите числа через пробел:"));
PrintResult("Количество чисел больше нуля: ", countPositiveNums(inputArr));

int keyCount = ReadData("Введите количество нажатий клавиш: ");
Console.Write($"Нажимайте разные клавиши {keyCount} раз\n");
int[] res = CountNumTypes(keyCount);
PrintResult("Количество чисел, равных нулю: ", res[0]);
PrintResult("Количество положительных чисел: ", res[1]);
PrintResult("Количество отрицательных чисел: ", res[2]);

// Подсчитывает количество отрицательных чисел по нажатиям клавиш - метод ReadKey()
int[] CountNumTypes(int keyCount)
{
    char[] header = new char[2]{' ', ' '};
    string bufString = String.Empty;
    double num;
    bool isFractPart = false;
    int[] countTypes = {0 , 0, 0};
    for (int i = 0; i < keyCount; i++)
    {
        ConsoleKeyInfo cki = Console.ReadKey();
        char sym = (cki.Key == ConsoleKey.Decimal) ? '.' : cki.KeyChar;

        bool isNumSym = (isDigit(sym) || (isDot(sym) && isDigit(header[1]) && !isFractPart));
        if (isNumSym)
        {
            if (isDot(header[1]))
            {
                isFractPart = true;
                if (isMinus(header[0]))
                    bufString = "-.";
                else if (!isDigit(header[0]))
                    bufString = ".";
            }
            else if (isMinus(header[1]))
                bufString = "-";
            bufString = bufString + sym;
        }
        if ((!isNumSym && (bufString != String.Empty)) ||
            (isNumSym && i == keyCount - 1))
        {
            NumberFormatInfo nfi = new NumberFormatInfo {NumberDecimalSeparator = "."};
            num = double.Parse(bufString, nfi);
            bufString = String.Empty;
            isFractPart = false;
            if (num > 0) countTypes[1]++;
            else if (num < 0) countTypes[2]++;
            else countTypes[0]++;
            Console.WriteLine($"\nЧисло: {num}");
        }
        header[0] = header[1];
        header[1] = sym;
    }
    Console.WriteLine();
    return countTypes;
}

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

// Ввод: любая строка
string ReadLine(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем строку
    string inputLine = Console.ReadLine() ?? string.Empty;
    // Возвращаем значение
    return inputLine;
}

// Получение чисел из строки (числа через пробел)
double[] ParseNums(string numsString)
{
    string[] buf = numsString.Split(' ');
    double[] nums = new double[buf.Length];
    for(int i = 0; i < nums.Length; i++)
    {
        nums[i] = double.Parse(buf[i]);
    }
    return nums;
}

// Подсчитывает в массиве количество чисел больше нуля
int countPositiveNums(double[] nums)
{
    int count = 0;
    foreach(double num in nums)
    {
        if (num > 0) count++;
    }
    return count;
}

// Проверка: символ 'число'
bool isDigit(char c)
{
    return c >= '0' && c <= '9';
}

// Проверка: символ '.'
bool isDot(char c)
{
    return c == '.';
}

// Проверка: символ '-'
bool isMinus(char c)
{
    return c == '-';
}

// Вывод: Число с комментарием
void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}
