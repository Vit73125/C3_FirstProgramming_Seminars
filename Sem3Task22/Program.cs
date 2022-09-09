//===================================================================================
// # 20 Напишите программу, которая принимает на вход число N и выдаёт
// таблицу квадратов чисел от 1 до N.
//===================================================================================

int num = ReadData("Введите число: ");

PrintResult(HeadLine(num));
PrintResult(CalculateLine(num, 1));
PrintResult(CalculateLine(num, 2));

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

// Cтрока: Шапка таблицы
string HeadLine(int num) {
    String res = "";
    int i = 0;
    while(i <= num)
    {
        res = res + String.Format("{0,4:d}", i);
        i++;
    }
    return res;
}

// Строка: Квадраты чисел из шапки таблицы
string CalculateLine(int num, int pow)
{
    String res = "";
    int i = 0;
    while(i <= num)
    {
        res = res + String.Format("{0,4:d}", (int)Math.Pow(i, pow));
        i++;
    }
    return res;
}

// Вывод: результат на консоль
void PrintResult(string res)
{
    Console.WriteLine(res);
}