//===================================================================================
// # 18 Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
//===================================================================================

int num = ReadData("Введите  номер четверти: ");
string res = QuarterBorderAsk(num);

PrintResult("Диапозон координат в четверти " + num + ": " + res);

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

// Определяет диапозон координат
string QuarterBorderAsk(int numQuarter) {
    if (numQuarter == 1) return "x > 0 && y > 0";
    if (numQuarter == 2) return "x < 0 && y > 0";
    if (numQuarter == 3) return "x < 0 && y < 0";
    if (numQuarter == 4) return "x > 0 && y < 0";

    return "";
}

// Вывод: результат на консоль
void PrintResult(string line) {
    Console.WriteLine(line);
}