//===================================================================================
// # 17 Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
//===================================================================================

int num1 = ReadData("Введите число 1: ");
int num2 = ReadData("Введите число 2: ");
PrintResult(num1, num2);
PrintResult(num2, num1);

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

// Тест на квадрат
bool SqrTest(int firstNum, int secondNum)
{
    if (firstNum == Math.Pow(secondNum, 2))
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Вывод: результат на консоль
void PrintResult(int firstNUm, int secondNum)
{
    if (SqrTest(firstNUm, secondNum))
    {
        Console.WriteLine("Число " + firstNUm + " квадрат числа " + secondNum);
    }
    else
    {
        Console.WriteLine("Число " + firstNUm + " не квадрат числа " + secondNum);
    }
}