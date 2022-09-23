//===================================================================================
// # 44 Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1. 
//===================================================================================

int numFib = ReadData("Введите количество чисел Фибоначчи: ");
// Вывод: Вложенный метод
PrintResult("Числа Фибоначчи: ", FibNum(numFib));

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

// Числа Фибоначчи: num чисел (1-е число - 0, 2-е - 1)
string FibNum(int num)
{
    string res = String.Empty;
    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 0; i <= num; i++)
    {
        res = res + " " + first;
        buf = first + last;
        first = last;
        last = buf;
    }

    return res;
}

// Вывод: результат на консоль
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}